using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDUsuario
    {
        public List<EUsuario> ListarUsuarios()
        {
            using (var db = new BD_SISTEMA_GESTION_VENTAS_ELECTRONICOSEntities()) // DbContext generado por el .edmx
            {
                return db.usuario.Select(u => new EUsuario()
                {
                    usuario_id = u.usuario_id,
                    nombre = u.nombre,
                    apellido = u.apellido,
                    dni = u.dni,
                    correo = u.correo,
                    telefono = u.telefono,
                    estado = u.estado,
                    fecha_registro = u.fecha_registro,
                    direccion = u.direccion,
                    contrasenia = u.contrasenia,
                    perfil_id = u.perfil_id,

                    // Mapeo manual del objeto EPerfil
                    oPerfil = new EPerfil()
                    {
                        perfil_id = u.perfil.perfil_id,
                        nombre = u.perfil.nombre
                    }
                }).ToList();
            }
        }


        // Método para cambiar el estado (Activo <-> Inactivo)
        public bool CambiarEstado(int idUsuario, bool nuevoEstado)
        {
            try
            {
                using (var db = new BD_SISTEMA_GESTION_VENTAS_ELECTRONICOSEntities())
                {
                    var oUsuario = db.usuario.FirstOrDefault(u => u.usuario_id == idUsuario);
                    if (oUsuario != null)
                    {
                        oUsuario.estado = nuevoEstado;
                        db.SaveChanges(); // Guarda el cambio en la BD
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar el estado: " + ex.Message);
            }
        }

        public bool Registrar(EUsuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new BD_SISTEMA_GESTION_VENTAS_ELECTRONICOSEntities())
                {
                    usuario nuevoUsuario = new usuario
                    {
                        nombre = obj.nombre,
                        apellido = obj.apellido,
                        dni = obj.dni,
                        correo = obj.correo,
                        telefono = obj.telefono,
                        direccion = obj.direccion,
                        contrasenia = obj.contrasenia,
                        estado = obj.estado,
                        perfil_id = obj.perfil_id,
                        fecha_registro = DateTime.Now
                    };

                    db.usuario.Add(nuevoUsuario);
                    int filasAfectadas = db.SaveChanges();

                    if (filasAfectadas == 0)
                    {
                        Mensaje = "No se pudo insertar el registro en la base de datos.";
                        return false;
                    }

                    // Se asigna el id generado automáticamente
                    obj.usuario_id = nuevoUsuario.usuario_id;
                    return true;
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Mensaje += $"Campo: {validationError.PropertyName} - Error: {validationError.ErrorMessage}\n";
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }


        public bool Editar(EUsuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new BD_SISTEMA_GESTION_VENTAS_ELECTRONICOSEntities())
                {
                    var oUsuario = db.usuario.FirstOrDefault(u => u.usuario_id == obj.usuario_id);

                    if (oUsuario != null)
                    {
                        oUsuario.nombre = obj.nombre;
                        oUsuario.apellido = obj.apellido;
                        oUsuario.dni = obj.dni;
                        oUsuario.correo = obj.correo;
                        oUsuario.telefono = obj.telefono;
                        oUsuario.direccion = obj.direccion;
                        oUsuario.estado = obj.estado;
                        oUsuario.perfil_id = obj.perfil_id;

                        // Actualiza la contraseña solo si se ingresó una nueva
                        if (!string.IsNullOrEmpty(obj.contrasenia))
                        {
                            oUsuario.contrasenia = obj.contrasenia;
                        }

                        db.SaveChanges();
                        return true;
                    }

                    Mensaje = "Usuario no encontrado.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }


        public List<EUsuario> BuscarUsuarios(string busqueda)
        {
            using (var db = new BD_SISTEMA_GESTION_VENTAS_ELECTRONICOSEntities())
            {
                string filtro = busqueda.Trim().ToLower();

                return db.usuario
                    .Where(u => u.dni.ToLower().Contains(filtro) ||
                                u.nombre.ToLower().Contains(filtro) ||
                                u.correo.ToLower().Contains(filtro))
                    .Select(u => new EUsuario()
                    {
                        usuario_id = u.usuario_id,
                        nombre = u.nombre,
                        apellido = u.apellido,
                        dni = u.dni,
                        correo = u.correo,
                        telefono = u.telefono,
                        estado = u.estado,
                        fecha_registro = u.fecha_registro,
                        direccion = u.direccion,
                        contrasenia = u.contrasenia,
                        perfil_id = u.perfil_id,

                        oPerfil = new EPerfil()
                        {
                            perfil_id = u.perfil.perfil_id,
                            nombre = u.perfil.nombre
                        }
                    }).ToList();
            }
        }

        public List<EUsuario> FiltrarUsuarios(int? idPerfil, bool? estado)
        {
            using (var db = new BD_SISTEMA_GESTION_VENTAS_ELECTRONICOSEntities())
            {
                // Iniciamos la consulta base
                var query = db.usuario.AsQueryable();

                // Aplicamos los filtros de manera condicional
                if (idPerfil.HasValue && idPerfil.Value > 0)
                {
                    query = query.Where(u => u.perfil_id == idPerfil.Value);
                }

                if (estado.HasValue)
                {
                    query = query.Where(u => u.estado == estado.Value);
                }

                // Mapeamos el resultado a la entidad de la capa de dominio
                return query.Select(u => new EUsuario()
                {
                    usuario_id = u.usuario_id,
                    nombre = u.nombre,
                    apellido = u.apellido,
                    dni = u.dni,
                    correo = u.correo,
                    telefono = u.telefono,
                    estado = u.estado,
                    fecha_registro = u.fecha_registro,
                    direccion = u.direccion,
                    contrasenia = u.contrasenia,
                    perfil_id = u.perfil_id,

                    oPerfil = new EPerfil()
                    {
                        perfil_id = u.perfil.perfil_id,
                        nombre = u.perfil.nombre
                    }
                }).ToList();
            }
        }

    }
}

