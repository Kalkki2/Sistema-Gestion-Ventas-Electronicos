using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDVenta
    {
        public bool Registrar(EVenta objVenta, List<EDetalleVenta> listaDetalles, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Abrimos una transacción explícita de Entity Framework
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            // 1. Validar si el número de venta ya existe
                            bool ventaExiste = db.venta.Any(v => v.nro_venta == objVenta.nro_venta);
                            if (ventaExiste)
                            {
                                Mensaje = "El número de venta ya se encuentra registrado.";
                                return false;
                            }

                            // 2. Registrar la Cabecera de la Venta (con los datos congelados del pago y ajuste)
                            venta nuevaVenta = new venta
                            {
                                nro_venta = objVenta.nro_venta,
                                fecha_venta = DateTime.Now,
                                porcentaje_aplicado = objVenta.porcentaje_aplicado,
                                estado = objVenta.estado,
                                usuario_id = objVenta.usuario_id,
                                metodo_pago_id = objVenta.metodo_pago_id,
                                cliente_id = objVenta.cliente_id,
                                tipo_ajuste_id = objVenta.tipo_ajuste_id
                            };

                            db.venta.Add(nuevaVenta);
                            db.SaveChanges(); // Guarda para generar el ID de la venta

                            // 3. Registrar los Detalles y Descontar el Stock de cada Producto
                            foreach (var item in listaDetalles)
                            {
                                // Verificar si el producto existe
                                var productoTemp = db.producto.FirstOrDefault(p => p.producto_id == item.producto_id);
                                if (productoTemp == null)
                                {
                                    Mensaje = $"El producto con ID {item.producto_id} no existe.";
                                    transaction.Rollback();
                                    return false;
                                }

                                // Validar si hay stock suficiente
                                if (productoTemp.stock < item.cantidad)
                                {
                                    Mensaje = $"Stock insuficiente para el producto: {productoTemp.nombre}. Stock actual: {productoTemp.stock}";
                                    transaction.Rollback();
                                    return false;
                                }

                                // Insertar el detalle de la venta
                                detalle_venta nuevoDetalle = new detalle_venta
                                {
                                    venta_id = nuevaVenta.venta_id,
                                    producto_id = item.producto_id,
                                    cantidad = item.cantidad,
                                    precio_unitario = item.precio_unitario
                                };
                                db.detalle_venta.Add(nuevoDetalle);

                                // Descontar la cantidad vendida del stock actual del producto
                                productoTemp.stock -= item.cantidad;
                                productoTemp.fecha_ultima_modificacion = DateTime.Now;
                            }

                            db.SaveChanges(); // Guarda todos los detalles y las actualizaciones de stock

                            // Si todo salió bien, confirmamos los cambios en la base de datos
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            // Si algo falla, deshacemos todo
                            transaction.Rollback();
                            Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }

        public List<EVenta> ListarHistorialVentas()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from v in db.venta
                            join u in db.usuario on v.usuario_id equals u.usuario_id
                            join c in db.cliente on v.cliente_id equals c.cliente_id
                            join mp in db.metodo_pago on v.metodo_pago_id equals mp.metodo_pago_id
                            join ta in db.tipo_ajuste on v.tipo_ajuste_id equals ta.tipo_ajuste_id
                            orderby v.fecha_venta descending // Las ventas más recientes primero
                            select new EVenta()
                            {
                                venta_id = v.venta_id,
                                nro_venta = v.nro_venta,
                                fecha_venta = v.fecha_venta,
                                porcentaje_aplicado = v.porcentaje_aplicado,
                                estado = v.estado,
                                usuario_id = v.usuario_id,
                                metodo_pago_id = v.metodo_pago_id,
                                cliente_id = v.cliente_id,
                                tipo_ajuste_id = v.tipo_ajuste_id,

                                // Mapeo de objetos relacionados
                                oUsuario = new EUsuario()
                                {
                                    usuario_id = u.usuario_id,
                                    nombre = u.nombre,
                                    apellido = u.apellido,
                                    dni = u.dni
                                },
                                oCliente = new ECliente()
                                {
                                    cliente_id = c.cliente_id,
                                    nombre = c.nombre,
                                    apellido = c.apellido,
                                    dni = c.dni
                                },
                                oMetodoPago = new EMetodoPago()
                                {
                                    metodo_pago_id = mp.metodo_pago_id,
                                    nombre = mp.nombre
                                },
                                oTipoAjuste = new ETipoAjuste()
                                {
                                    tipo_ajuste_id = ta.tipo_ajuste_id,
                                    nombre = ta.nombre
                                },
                                // Mapeo de los detalles para poder calcular el subtotal/total en la grilla
                                oDetalleVenta = db.detalle_venta
                                    .Where(d => d.venta_id == v.venta_id)
                                    .Select(d => new EDetalleVenta()
                                    {
                                        producto_id = d.producto_id,
                                        cantidad = d.cantidad,
                                        precio_unitario = d.precio_unitario
                                    }).ToList()
                            };

                return query.ToList();
            }
        }

        public List<EDetalleVenta> ObtenerDetalleVenta(int ventaId)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from d in db.detalle_venta
                            join p in db.producto on d.producto_id equals p.producto_id
                            where d.venta_id == ventaId
                            select new EDetalleVenta()
                            {
                                producto_id = d.producto_id,
                                venta_id = d.venta_id,
                                cantidad = d.cantidad,
                                precio_unitario = d.precio_unitario,
                                // Mapeamos el objeto producto para mostrar código y nombre en la grilla del detalle
                                oProducto = new EProducto()
                                {
                                    producto_id = p.producto_id,
                                    codigo = p.codigo,
                                    nombre = p.nombre
                                }
                            };

                return query.ToList();
            }
        }
    }
}
