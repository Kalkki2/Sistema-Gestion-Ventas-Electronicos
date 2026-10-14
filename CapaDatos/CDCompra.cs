using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDatos
{
    public class CDCompra
    {
            public bool Registrar(ECompra objCompra, List<EDetalleCompra> listaDetalles, out string Mensaje)
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
                            // 1. Validar si la factura ya existe
                            bool facturaExiste = db.compra.Any(c => c.nro_factura == objCompra.nro_factura);
                            if (facturaExiste)
                            {
                                Mensaje = "El número de factura ya se encuentra registrado.";
                                return false;
                            }

                            // 2. Registrar la Cabecera de la Compra
                            compra nuevaCompra = new compra
                            {
                                nro_factura = objCompra.nro_factura,
                                fecha_compra = DateTime.Now, 
                                estado = objCompra.estado,
                                usuario_id = objCompra.usuario_id,
                                proveedor_id = objCompra.proveedor_id
                            };

                            db.compra.Add(nuevaCompra);
                            db.SaveChanges(); // Guarda para generar el ID de la compra

                            // 3. Registrar los Detalles, Actualizar Stock y el Nuevo Precio de Venta
                            foreach (var item in listaDetalles)
                            {
                                // Insertar detalle con su margen
                                detalle_compra nuevoDetalle = new detalle_compra
                                {
                                    compra_id = nuevaCompra.compra_id,
                                    producto_id = item.producto_id,
                                    cantidad = item.cantidad,
                                    costo_unitario = item.costo_unitario,
                                    porcentaje_margen = item.porcentaje_margen //  Guardamos el margen histórico
                                };
                                db.detalle_compra.Add(nuevoDetalle);

                                // Actualizar el stock y el precio de venta del producto
                                var productoTemp = db.producto.FirstOrDefault(p => p.producto_id == item.producto_id);
                                if (productoTemp != null)
                                {
                                    productoTemp.stock += item.cantidad; // Suma la cantidad comprada al stock actual

                                    // Calculamos el nuevo precio de venta en base al costo unitario y el margen ingresados
                                    decimal precioVentaCalculado = item.costo_unitario + (item.costo_unitario * (item.porcentaje_margen / 100));
                                    productoTemp.precio_venta = precioVentaCalculado; // Actualiza el precio de venta oficial del producto

                                    productoTemp.fecha_ultima_modificacion = DateTime.Now;
                                }
                            }

                            db.SaveChanges(); // Guarda todos los detalles y las actualizaciones

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

        public List<ECompra> ListarHistorialCompras()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from c in db.compra
                            join u in db.usuario on c.usuario_id equals u.usuario_id
                            join p in db.proveedor on c.proveedor_id equals p.proveedor_id
                            orderby c.fecha_compra descending // Las más recientes primero
                            select new ECompra()
                            {
                                compra_id = c.compra_id,
                                nro_factura = c.nro_factura,
                                fecha_compra = c.fecha_compra,
                                estado = c.estado,
                                usuario_id = c.usuario_id,
                                proveedor_id = c.proveedor_id,

                                // Mapeo de objetos relacionados
                                oUsuario = new EUsuario()
                                {
                                    usuario_id = u.usuario_id,
                                    nombre = u.nombre,
                                    apellido = u.apellido,
                                    dni = u.dni // Asegúrate de que tu entidad EUsuario tenga esta propiedad
                                },
                                oProveedor = new EProveedor()
                                {
                                    proveedor_id = p.proveedor_id,
                                    cuit = p.cuit,
                                    razon_social = p.razon_social
                                },
                                // Mapeo de los detalles para poder calcular el total
                                oDetalleCompra = db.detalle_compra
                                    .Where(d => d.compra_id == c.compra_id)
                                    .Select(d => new EDetalleCompra()
                                    {
                                        producto_id = d.producto_id,
                                        cantidad = d.cantidad,
                                        costo_unitario = d.costo_unitario
                                    }).ToList()
                            };

                return query.ToList();
            }
        }

        public List<EDetalleCompra> ObtenerDetalleCompra(int compraId)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from d in db.detalle_compra
                            join p in db.producto on d.producto_id equals p.producto_id
                            where d.compra_id == compraId
                            select new EDetalleCompra()
                            {
                                producto_id = d.producto_id,
                                compra_id = d.compra_id,
                                cantidad = d.cantidad,
                                costo_unitario = d.costo_unitario,
                                // Mapeamos explícitamente el objeto producto
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
