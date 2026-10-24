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

        public bool Editar(ECliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    if (db.cliente.Any(c => c.dni == obj.dni && c.cliente_id != obj.cliente_id))
                    {
                        Mensaje = "El DNI ingresado ya pertenece a otro cliente.";
                        return false;
                    }

                    if (db.cliente.Any(c => c.email == obj.email && c.cliente_id != obj.cliente_id))
                    {
                        Mensaje = "El correo ingresado ya pertenece a otro cliente.";
                        return false;
                    }

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
    }
}