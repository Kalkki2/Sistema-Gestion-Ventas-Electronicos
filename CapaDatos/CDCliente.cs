using System;
using System.Collections.Generic;
using System.Linq;
using CapaEntidad;

namespace CapaDatos
{
    public class CDCliente
    {
        // Lista los clientes de la tabla cliente, con filtro opcional por DNI, nombre, apellido o teléfono
        public List<ECliente> Listar(string filtro = "")
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var consulta = db.cliente.AsQueryable();

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    filtro = filtro.Trim();
                    consulta = consulta.Where(c =>
                        c.dni.Contains(filtro) ||
                        c.nombre.Contains(filtro) ||
                        c.apellido.Contains(filtro) ||
                        c.telefono.Contains(filtro));
                }

                return consulta
                    .OrderBy(c => c.apellido)
                    .ThenBy(c => c.nombre)
                    .ToList()
                    .Select(c => Mapear(c))
                    .ToList();
            }
        }

        public bool Registrar(ECliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    if (db.cliente.Any(c => c.dni == obj.dni))
                    {
                        Mensaje = "El DNI ingresado ya se encuentra registrado.";
                        return false;
                    }

                    if (db.cliente.Any(c => c.email == obj.email))
                    {
                        Mensaje = "El correo ingresado ya pertenece a otro cliente.";
                        return false;
                    }

                    if (db.cliente.Any(c => c.telefono == obj.telefono))
                    {
                        Mensaje = "El teléfono ingresado ya pertenece a otro cliente.";
                        return false;
                    }

                    cliente nuevo = new cliente
                    {
                        dni = obj.dni,
                        nombre = obj.nombre,
                        apellido = obj.apellido,
                        telefono = obj.telefono,
                        email = obj.email,
                        direccion = obj.direccion,
                        fecha_alta = DateTime.Now,
                        fecha_ultima_modificacion = DateTime.Now,
                        estado = 1
                    };

                    db.cliente.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }

        public bool EditarCliente(ECliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Validar si el DNI ya pertenece a otro cliente
                    if (db.cliente.Any(c => c.dni == obj.dni && c.cliente_id != obj.cliente_id))
                    {
                        Mensaje = "El DNI ingresado ya pertenece a otro cliente.";
                        return false;
                    }

                    // Validar si el correo ya pertenece a otro cliente
                    if (db.cliente.Any(c => c.email == obj.email && c.cliente_id != obj.cliente_id))
                    {
                        Mensaje = "El correo ingresado ya pertenece a otro cliente.";
                        return false;
                    }

                    // Validar si el teléfono ya pertenece a otro cliente
                    if (db.cliente.Any(c => c.telefono == obj.telefono && c.cliente_id != obj.cliente_id))
                    {
                        Mensaje = "El teléfono ingresado ya pertenece a otro cliente.";
                        return false;
                    }

                    cliente existente = db.cliente.FirstOrDefault(c => c.cliente_id == obj.cliente_id);
                    if (existente == null)
                    {
                        Mensaje = "No se encontró el cliente a modificar.";
                        return false;
                    }

                    existente.dni = obj.dni;
                    existente.nombre = obj.nombre;
                    existente.apellido = obj.apellido;
                    existente.telefono = obj.telefono;
                    existente.email = obj.email;
                    existente.direccion = obj.direccion;
                    existente.estado = obj.estado;
                    existente.fecha_ultima_modificacion = DateTime.Now;

                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }

        // Convierte la entidad de EF en el objeto ECliente que viaja entre capas
        private ECliente Mapear(cliente c)
        {
            return new ECliente
            {
                cliente_id = c.cliente_id,
                dni = c.dni,
                nombre = c.nombre,
                apellido = c.apellido,
                telefono = c.telefono,
                email = c.email,
                direccion = c.direccion,
                fecha_alta = c.fecha_alta,
                fecha_ultima_modificacion = c.fecha_ultima_modificacion,
                estado = c.estado
            };
        }

        // Método para cambiar el estado del cliente (1 a 0 y viceversa)
        public bool CambiarEstado(int clienteId, int nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var clienteTemp = db.cliente.FirstOrDefault(c => c.cliente_id == clienteId);
                    if (clienteTemp != null)
                    {
                        clienteTemp.estado = nuevoEstado;
                        clienteTemp.fecha_ultima_modificacion = DateTime.Now;
                        db.SaveChanges();
                        respuesta = true;
                    }
                    else
                    {
                        mensaje = "No se encontró el cliente especificado.";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        // Método para listar las vecompras hechas por un cliente en específico 
        public List<EVenta> ListarVentasPorCliente(int clienteId)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from v in db.venta
                            join u in db.usuario on v.usuario_id equals u.usuario_id
                            join c in db.cliente on v.cliente_id equals c.cliente_id
                            join mp in db.metodo_pago on v.metodo_pago_id equals mp.metodo_pago_id
                            where v.cliente_id == clienteId // Filtramos solo las compras de este cliente
                            orderby v.fecha_venta descending
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
                                    nombre = mp.nombre,
                                    porcentaje = mp.porcentaje,
                                    tipo_ajuste_id = mp.tipo_ajuste_id,
                                    // Mapeamos el tipo de ajuste para que el cálculo del total reconozca Recargo o Descuento
                                    oTipoAjuste = new ETipoAjuste()
                                    {
                                        tipo_ajuste_id = mp.tipo_ajuste.tipo_ajuste_id,
                                        nombre = mp.tipo_ajuste.nombre
                                    }
                                },
                                // Mapeamos los detalles de la venta para calcular correctamente SubtotalVenta y TotalVenta
                                oDetalleVenta = db.detalle_venta
                                    .Where(d => d.venta_id == v.venta_id)
                                    .Select(d => new EDetalleVenta()
                                    {
                                        producto_id = d.producto_id,
                                        venta_id = d.venta_id,
                                        cantidad = d.cantidad,
                                        precio_unitario = d.precio_unitario
                                    }).ToList()
                            };

                return query.ToList();
            }
        }




    }
}