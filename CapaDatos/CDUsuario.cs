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
        //Metodo Listar Usuario (Gestion Usuario)   
        public List<EUsuario> ListarUsuarios()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.usuario.Select(u => new EUsuario()
                {
                    usuario_id = u.usuario_id,
                    nombre = u.nombre,
                    apellido = u.apellido,
                    dni = u.dni,
                    email = u.email,
                    telefono = u.telefono,
                    estado = u.estado,
                    fecha_alta = u.fecha_alta,
                    fecha_ultima_modificacion = u.fecha_ultima_modificacion,
                    fecha_ultimo_ingreso = u.fecha_ultimo_ingreso, // Incluye la última fecha/hora de login
                    direccion = u.direccion,
                    contrasenia = u.contrasenia,
                    perfil_id = u.perfil_id,

                    // Mapeo manual del objeto EPerfil anidado
                    oPerfil = new EPerfil()
                    {
                        perfil_id = u.perfil.perfil_id,
                        nombre = u.perfil.nombre
                    }
                }).ToList();
            }
        }

        // Método para cambiar el estado (1: Activo, 0: Inactivo)
        public bool CambiarEstado(int idUsuario, int nuevoEstado)
        {
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var oUsuario = db.usuario.FirstOrDefault(u => u.usuario_id == idUsuario);
                    if (oUsuario != null)
                    {
                        oUsuario.estado = nuevoEstado;
                        oUsuario.fecha_ultima_modificacion = DateTime.Now;
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

        //Metodo Registrar Usuario (Gestion Usuario)  
        public bool Registrar(EUsuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Validar si ya existe un usuario con el mismo DNI
                    if (db.usuario.Any(u => u.dni == obj.dni))
                    {
                        Mensaje = "Ya existe un usuario registrado con el DNI ingresado.";
                        return false;
                    }

                    // Validar si ya existe un usuario con el mismo Email
                    if (db.usuario.Any(u => u.email == obj.email))
                    {
                        Mensaje = "El correo electrónico ingresado ya se encuentra registrado.";
                        return false;
                    }

                    //  Validar si ya existe un usuario con el mismo Teléfono
                    if (db.usuario.Any(u => u.telefono == obj.telefono))
                    {
                        Mensaje = "El número de teléfono ingresado ya pertenece a otro usuario.";
                        return false;
                    }

                    // Si pasa las validaciones, procedemos a crear el registro
                    usuario nuevoUsuario = new usuario
                    {
                        nombre = obj.nombre,
                        apellido = obj.apellido,
                        dni = obj.dni,
                        email = obj.email,
                        telefono = obj.telefono,
                        direccion = obj.direccion,
                        contrasenia = obj.contrasenia,
                        estado = obj.estado,
                        perfil_id = obj.perfil_id,
                        fecha_alta = DateTime.Now,
                        fecha_ultima_modificacion = DateTime.Now,
                        fecha_ultimo_ingreso = null // Inicia en nulo hasta su primer inicio de sesión
                    };

                    db.usuario.Add(nuevoUsuario);
                    int filasAfectadas = db.SaveChanges();

                    if (filasAfectadas == 0)
                    {
                        Mensaje = "No se pudo insertar el registro en la base de datos.";
                        return false;
                    }

                    obj.usuario_id = nuevoUsuario.usuario_id;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }

        //Metodo Editar Usuario (Gestion Usuario)  
        public bool EditarUsuario(EUsuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Validar que el DNI no pertenezca a OTRO usuario distinto
                    if (db.usuario.Any(u => u.dni == obj.dni && u.usuario_id != obj.usuario_id))
                    {
                        Mensaje = "Ya existe otro usuario registrado con el DNI ingresado.";
                        return false;
                    }

                    // Validar que el Email no pertenezca a OTRO usuario distinto
                    if (db.usuario.Any(u => u.email == obj.email && u.usuario_id != obj.usuario_id))
                    {
                        Mensaje = "El correo electrónico ingresado ya pertenece a otro usuario.";
                        return false;
                    }

                    // Validar que el Teléfono no pertenezca a OTRO usuario distinto
                    if (db.usuario.Any(u => u.telefono == obj.telefono && u.usuario_id != obj.usuario_id))
                    {
                        Mensaje = "El número de teléfono ingresado ya pertenece a otro usuario.";
                        return false;
                    }

                    // Buscar el usuario existente por su ID
                    var oUsuario = db.usuario.FirstOrDefault(u => u.usuario_id == obj.usuario_id);

                    if (oUsuario != null)
                    {
                        // Actualizar los campos correspondientes
                        oUsuario.nombre = obj.nombre;
                        oUsuario.apellido = obj.apellido;
                        oUsuario.dni = obj.dni;
                        oUsuario.email = obj.email;
                        oUsuario.telefono = obj.telefono;
                        oUsuario.direccion = obj.direccion;
                        oUsuario.estado = obj.estado;
                        oUsuario.perfil_id = obj.perfil_id;
                        oUsuario.fecha_ultima_modificacion = DateTime.Now; // Registra el momento exacto de la modificación

                        // Actualizar la contraseña solo si el usuario escribió una nueva
                        if (!string.IsNullOrEmpty(obj.contrasenia))
                        {
                            oUsuario.contrasenia = obj.contrasenia;
                        }

                        // Guardar los cambios en la base de datos
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

        public List<EUsuario> BuscarYFiltrar(string busqueda, int? idPerfil, int? estado)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = db.usuario.AsQueryable();

                //  Filtro por texto (DNI, Nombre, Apellido o Email)
                if (!string.IsNullOrWhiteSpace(busqueda))
                {
                    string filtro = busqueda.Trim().ToLower();
                    query = query.Where(u => u.dni.ToLower().Contains(filtro) ||
                                            u.apellido.ToLower().Contains(filtro) ||
                                            u.email.ToLower().Contains(filtro));
                }

                // Filtro por Perfil
                if (idPerfil.HasValue && idPerfil.Value > 0)
                {
                    query = query.Where(u => u.perfil_id == idPerfil.Value);
                }

                //  Filtro por Estado
                if (estado.HasValue)
                {
                    query = query.Where(u => u.estado == estado.Value);
                }

                // Mapeo a la entidad de negocio
                return query.Select(u => new EUsuario()
                {
                    usuario_id = u.usuario_id,
                    nombre = u.nombre,
                    apellido = u.apellido,
                    dni = u.dni,
                    email = u.email,
                    telefono = u.telefono,
                    estado = u.estado,
                    fecha_alta = u.fecha_alta,
                    fecha_ultima_modificacion = u.fecha_ultima_modificacion,
                    fecha_ultimo_ingreso = u.fecha_ultimo_ingreso,
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


        public EUsuario Login(string dni, string contrasenia)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                // Buscamos al usuario activo
                var u = db.usuario
                          .Include("perfil")
                          .FirstOrDefault(x => x.dni == dni && x.contrasenia == contrasenia && x.estado == 1);

                if (u != null)
                {
                    u.fecha_ultimo_ingreso = DateTime.Now;

                    db.SaveChanges();

                    return new EUsuario()
                    {
                        usuario_id = u.usuario_id,
                        nombre = u.nombre,
                        apellido = u.apellido,
                        dni = u.dni,
                        email = u.email,
                        telefono = u.telefono,
                        estado = u.estado,
                        fecha_alta = u.fecha_alta,
                        fecha_ultima_modificacion = u.fecha_ultima_modificacion,
                        fecha_ultimo_ingreso = u.fecha_ultimo_ingreso, 
                        direccion = u.direccion,
                        contrasenia = u.contrasenia,
                        perfil_id = u.perfil_id,
                        oPerfil = new EPerfil()
                        {
                            perfil_id = u.perfil.perfil_id,
                            nombre = u.perfil.nombre
                        }
                    };
                }
                return null;
            }
        }

    }
}

