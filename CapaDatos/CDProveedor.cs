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
        // Método para LISTAR PROVEEDORES
        public List<EProveedor> ListarProveedores()
        {
            List<EProveedor> lista = new List<EProveedor>();
            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    lista = contexto.proveedor
                        .AsEnumerable()
                        .Select(p => new EProveedor()
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
                            fecha_ultima_modificacion = p.fecha_ultima_modificacion,
                            CategoriasTexto = string.Join(", ", contexto.producto
                                .Where(prod => prod.proveedor_id == p.proveedor_id)
                                .Select(prod => prod.categoria_marca.categoria.nombre) 
                                .Distinct()
                                .ToList())
                        })
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

        // Método para REGISTRAR PROVEEDOR
        public bool RegistrarProveedor(EProveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Validar usando Any() en lugar de Count() por rendimiento
                    if (contexto.proveedor.Any(p => p.cuit == oProveedor.cuit))
                    {
                        mensaje = "El CUIT ingresado ya se encuentra registrado.";
                        return false;
                    }

                    if (contexto.proveedor.Any(p => p.email == oProveedor.email))
                    {
                        mensaje = "El correo electrónico ya se encuentra registrado.";
                        return false;
                    }

                    if (contexto.proveedor.Any(p => p.telefono == oProveedor.telefono))
                    {
                        mensaje = "El teléfono ya se encuentra registrado.";
                        return false;
                    }

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

        // Método para EDITAR PROVEEDOR
        public bool EditarProveedor(EProveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    if (contexto.proveedor.Any(p => p.cuit == oProveedor.cuit && p.proveedor_id != oProveedor.proveedor_id))
                    {
                        mensaje = "El CUIT ya pertenece a otro proveedor.";
                        return false;
                    }

                    if (contexto.proveedor.Any(p => p.email == oProveedor.email && p.proveedor_id != oProveedor.proveedor_id))
                    {
                        mensaje = "El correo electrónico ya pertenece a otro proveedor.";
                        return false;
                    }

                    if (contexto.proveedor.Any(p => p.telefono == oProveedor.telefono && p.proveedor_id != oProveedor.proveedor_id))
                    {
                        mensaje = "El teléfono ya pertenece a otro proveedor.";
                        return false;
                    }

                    var proveedorModificar = contexto.proveedor
                        .FirstOrDefault(p => p.proveedor_id == oProveedor.proveedor_id);

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

        // Método para CAMBIAR ESTADO
        public bool CambiarEstado(int idProveedor, int nuevoEstado, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var proveedorModificar = contexto.proveedor
                        .FirstOrDefault(p => p.proveedor_id == idProveedor);

                    if (proveedorModificar != null)
                    {
                        proveedorModificar.estado = nuevoEstado;
                        proveedorModificar.fecha_ultima_modificacion = DateTime.Now;
                        contexto.SaveChanges();
                        respuesta = true;
                    }
                    else
                    {
                        mensaje = "No se encontró el proveedor.";
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

        // Método para BUSCAR PROVEEDOR
        public List<EProveedor> BuscarProveedoresPorCuitOCorreo(string busqueda)
        {
            List<EProveedor> lista = new List<EProveedor>();
            busqueda = busqueda.ToLower();

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    lista = contexto.proveedor
                        .Where(p => p.cuit.Contains(busqueda) || p.email.ToLower().Contains(busqueda))
                        .Select(p => new EProveedor()
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
                        })
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

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

                    lista = query.Select(p => new EProveedor()
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
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public List<EProveedor> ListarProveedoresActivos()
        {
            List<EProveedor> lista = new List<EProveedor>();
            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    lista = contexto.proveedor
                        .Where(p => p.estado == 1) // traer solo activos
                        .Select(p => new EProveedor()
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
                        })
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public List<EProveedor> ListarProveedorPorCategoria(int categoriaId)
        {
            using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
            {
                // Unimos los productos con los proveedores filtrando por la categoría seleccionada
                var query = from p in contexto.producto
                            where p.categoria_id == categoriaId && p.estado == 1
                            select p.proveedor;

                return query.Distinct().AsEnumerable().Select(p => new EProveedor()
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
                    fecha_ultima_modificacion = p.fecha_ultima_modificacion,

                    CategoriasTexto = string.Join(", ", contexto.producto
                        .Where(prod => prod.proveedor_id == p.proveedor_id)
                        .Select(prod => prod.categoria_marca.categoria.nombre)
                        .Distinct())
                }).ToList();
            }
        }
    }
}
