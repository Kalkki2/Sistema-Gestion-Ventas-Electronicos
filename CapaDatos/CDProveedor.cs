using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDatos
{
    public class CDProveedor
    {
        // 1. LISTAR PROVEEDORES
        public List<EProveedor> Listar()
        {
            List<EProveedor> lista = new List<EProveedor>();

            try
            {
                // Reemplaza 'db_sistema_gestion_ventas_electronicosEntities' por el nombre de tu contexto de BD
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Asumiendo que tu entidad de EF se llama 'proveedor' y la de negocio 'EProveedor'
                    var query = from p in contexto.proveedor
                                select new EProveedor
                                {
                                    proveedor_id = p.proveedor_id,
                                    cuit = p.cuit,
                                    nombre_comercial = p.nombre_comercial,
                                    razon_social = p.razon_social,
                                    email = p.email,
                                    telefono = p.telefono,
                                    direccion = p.direccion,
                                    estado = p.estado,
                                    fecha_alta = p.fecha_alta,
                                    fecha_ultima_modificacion = p.fecha_ultima_modificacion
                                };

                    lista = query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        // 2. REGISTRAR PROVEEDOR
        public bool Registrar(EProveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Validar si el CUIT ya existe
                    int cuitExistente = contexto.proveedor.Where(p => p.cuit == oProveedor.cuit).Count();
                    if (cuitExistente > 0)
                    {
                        mensaje = "El CUIT ingresado ya se encuentra registrado.";
                        return false;
                    }

                    // Validar si el correo ya existe
                    int correoExistente = contexto.proveedor.Where(p => p.email == oProveedor.email).Count();
                    if (correoExistente > 0)
                    {
                        mensaje = "El correo electrónico ya se encuentra registrado.";
                        return false;
                    }

                    // Crear la entidad de base de datos a partir de EProveedor
                    // (Asegúrate de que el nombre de la clase de la tabla en EF sea el correcto, ej: proveedor)
                    var nuevoProveedor = new proveedor()
                    {
                        cuit = oProveedor.cuit,
                        nombre_comercial = oProveedor.nombre_comercial,
                        razon_social = oProveedor.razon_social,
                        email = oProveedor.email,
                        telefono = oProveedor.telefono,
                        direccion = oProveedor.direccion,
                        estado = oProveedor.estado,
                        fecha_alta = DateTime.Now,
                        fecha_ultima_modificacion = DateTime.Now
                    };

                    contexto.proveedor.Add(nuevoProveedor);
                    contexto.SaveChanges();
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        // 3. EDITAR PROVEEDOR
        public bool Editar(EProveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Validar CUIT duplicado en otro proveedor
                    int cuitExistente = contexto.proveedor
                        .Where(p => p.cuit == oProveedor.cuit && p.proveedor_id != oProveedor.proveedor_id)
                        .Count();

                    if (cuitExistente > 0)
                    {
                        mensaje = "El CUIT ya pertenece a otro proveedor.";
                        return false;
                    }

                    // Validar Correo duplicado en otro proveedor
                    int correoExistente = contexto.proveedor
                        .Where(p => p.email == oProveedor.email && p.proveedor_id != oProveedor.proveedor_id)
                        .Count();

                    if (correoExistente > 0)
                    {
                        mensaje = "El correo electrónico ya pertenece a otro proveedor.";
                        return false;
                    }

                    var proveedorModificar = contexto.proveedor.Where(p => p.proveedor_id == oProveedor.proveedor_id).FirstOrDefault();

                    if (proveedorModificar != null)
                    {
                        proveedorModificar.cuit = oProveedor.cuit;
                        proveedorModificar.nombre_comercial = oProveedor.nombre_comercial;
                        proveedorModificar.razon_social = oProveedor.razon_social;
                        proveedorModificar.email = oProveedor.email;
                        proveedorModificar.telefono = oProveedor.telefono;
                        proveedorModificar.direccion = oProveedor.direccion;
                        proveedorModificar.estado = oProveedor.estado;
                        proveedorModificar.fecha_ultima_modificacion = DateTime.Now;

                        contexto.SaveChanges();
                        respuesta = true;
                    }
                    else
                    {
                        mensaje = "No se encontró el proveedor a modificar.";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        // 4. CAMBIAR ESTADO (Activar / Desactivar)
        public bool CambiarEstado(int idProveedor, int nuevoEstado)
        {
            bool respuesta = false;

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var proveedorModificar = contexto.proveedor.Where(p => p.proveedor_id == idProveedor).FirstOrDefault();

                    if (proveedorModificar != null)
                    {
                        proveedorModificar.estado = nuevoEstado;
                        proveedorModificar.fecha_ultima_modificacion = DateTime.Now;
                        contexto.SaveChanges();
                        respuesta = true;
                    }
                }
            }
            catch (Exception)
            {
                respuesta = false;
            }

            return respuesta;
        }

        // 5. BUSCAR PROVEEDOR (Por CUIT o Correo, tal como indica la interfaz)
        public List<EProveedor> Buscar(string busqueda)
        {
            List<EProveedor> lista = new List<EProveedor>();
            busqueda = busqueda.ToLower();

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var query = from p in contexto.proveedor
                                where p.cuit.ToLower().Contains(busqueda) || p.email.ToLower().Contains(busqueda)
                                select new EProveedor
                                {
                                    proveedor_id = p.proveedor_id,
                                    cuit = p.cuit,
                                    nombre_comercial = p.nombre_comercial,
                                    razon_social = p.razon_social,
                                    email = p.email,
                                    telefono = p.telefono,
                                    direccion = p.direccion,
                                    estado = p.estado,
                                    fecha_alta = p.fecha_alta,
                                    fecha_ultima_modificacion = p.fecha_ultima_modificacion
                                };

                    lista = query.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        // 6. FILTRAR POR ESTADO (Tal como muestra el combo de filtrado de la interfaz)
        public List<EProveedor> Filtrar(int? estado)
        {
            List<EProveedor> lista = new List<EProveedor>();

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var query = contexto.proveedor.AsQueryable();

                    if (estado.HasValue)
                    {
                        query = query.Where(p => p.estado == estado.Value);
                    }

                    lista = query.Select(p => new EProveedor
                    {
                        proveedor_id = p.proveedor_id,
                        cuit = p.cuit,
                        nombre_comercial = p.nombre_comercial,
                        razon_social = p.razon_social,
                        email = p.email,
                        telefono = p.telefono,
                        direccion = p.direccion,
                        estado = p.estado,
                        fecha_alta = p.fecha_alta,
                        fecha_ultima_modificacion = p.fecha_ultima_modificacion
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }
    }
}
