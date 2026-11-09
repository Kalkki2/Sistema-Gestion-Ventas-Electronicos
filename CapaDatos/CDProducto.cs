using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDProducto
    {
        // Listar todos los Productos con sus marcas y categorias ( Joins explícitos)
        public List<EProducto> ListarProductos()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from p in db.producto
                            join m in db.marca on p.marca_id equals m.marca_id
                            join c in db.categoria on p.categoria_id equals c.categoria_id
                            join pr in db.proveedor on p.proveedor_id equals pr.proveedor_id
                            select new EProducto()
                            {
                                producto_id = p.producto_id,
                                codigo = p.codigo,
                                nombre = p.nombre,
                                descripcion = p.descripcion,
                                precio_venta = p.precio_venta,
                                stock = p.stock,
                                stock_minimo = p.stock_minimo,
                                estado = p.estado,
                                fecha_alta = p.fecha_alta,
                                fecha_ultima_modificacion = p.fecha_ultima_modificacion,

                                marca_id = p.marca_id,
                                categoria_id = p.categoria_id,
                                proveedor_id = p.proveedor_id,

                                oMarca = new EMarca { marca_id = m.marca_id, nombre = m.nombre },
                                oCategoria = new ECategoria { categoria_id = c.categoria_id, nombre = c.nombre },
                                oProveedor = new EProveedor { proveedor_id = pr.proveedor_id, razon_social = pr.razon_social }
                            };

                return query.ToList();
            }
        }

        // Listar Categorías
        public List<ECategoria> ListarCategorias()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.categoria.Select(c => new ECategoria
                {
                    categoria_id = c.categoria_id,
                    nombre = c.nombre
                }).ToList();
            }
        }

        // Listar Categorías
        public List<EMarca> ListarMarcas()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.marca.Select(c => new EMarca
                {
                    marca_id = c.marca_id,
                    nombre = c.nombre
                }).ToList();
            }
        }

        // Listar Marcas filtradas por Categoría
        public List<EMarca> ListarMarcasPorCategoria(int categoriaId)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.categoria_marca
                    .Where(cm => cm.categoria_id == categoriaId)
                    .Select(cm => new EMarca
                    {
                        marca_id = cm.marca.marca_id,
                        nombre = cm.marca.nombre
                    }).ToList();
            }
        }

        

        // Registrar Producto
        public bool Registrar(EProducto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    bool codigoExiste = db.producto.Any(p => p.codigo == obj.codigo);
                    if (codigoExiste)
                    {
                        Mensaje = "El código de producto ya se encuentra registrado.";
                        return false;
                    }

                    producto nuevoProducto = new producto
                    {
                        codigo = obj.codigo,
                        nombre = obj.nombre,
                        descripcion = obj.descripcion,
                        precio_venta = obj.precio_venta,
                        stock = obj.stock,
                        stock_minimo = obj.stock_minimo,
                        estado = obj.estado,
                        marca_id = obj.marca_id,
                        categoria_id = obj.categoria_id,
                        proveedor_id = obj.proveedor_id,
                        fecha_alta = DateTime.Now,
                        fecha_ultima_modificacion = DateTime.Now
                    };

                    db.producto.Add(nuevoProducto);
                    db.SaveChanges();
                    obj.producto_id = nuevoProducto.producto_id;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return false;
            }
        }

        // Editar Producto
        public bool Editar(EProducto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    // Validar si el código ya existe en OTRO producto
                    bool codigoExiste = db.producto.Any(p => p.codigo == obj.codigo && p.producto_id != obj.producto_id);
                    if (codigoExiste)
                    {
                        Mensaje = "El código de producto ya se encuentra registrado por otro artículo.";
                        return false;
                    }

                    var productoTemp = db.producto.FirstOrDefault(p => p.producto_id == obj.producto_id);
                    if (productoTemp == null)
                    {
                        Mensaje = "No se encontró el producto a modificar.";
                        return false;
                    }

                    productoTemp.codigo = obj.codigo;
                    productoTemp.nombre = obj.nombre;
                    productoTemp.descripcion = obj.descripcion;
                    productoTemp.precio_venta = obj.precio_venta;
                    productoTemp.stock = obj.stock;
                    productoTemp.stock_minimo = obj.stock_minimo;
                    productoTemp.estado = obj.estado;
                    productoTemp.marca_id = obj.marca_id;
                    productoTemp.categoria_id = obj.categoria_id;
                    productoTemp.proveedor_id = obj.proveedor_id;
                    productoTemp.fecha_ultima_modificacion = DateTime.Now; // Actualiza la fecha de modificación

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

        // 7. Cambiar Estado (Activar / Desactivar producto)
        public bool CambiarEstado(int idProducto, int nuevoEstado, out string Mensaje)
        {
            Mensaje = string.Empty;
            try
            {
                using (var db = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var productoTemp = db.producto.FirstOrDefault(p => p.producto_id == idProducto);
                    if (productoTemp == null)
                    {
                        Mensaje = "No se encontró el producto.";
                        return false;
                    }

                    productoTemp.estado = nuevoEstado;
                    productoTemp.fecha_ultima_modificacion = DateTime.Now; // Actualizamos la fecha de modificación

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

        // Método para listar productos filtrados por el Proveedor seleccionado en la compra
        public List<EProducto> ListarProductosPorProveedor(int proveedorId)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from p in db.producto
                            join m in db.marca on p.marca_id equals m.marca_id
                            join c in db.categoria on p.categoria_id equals c.categoria_id
                            join pr in db.proveedor on p.proveedor_id equals pr.proveedor_id
                            where p.proveedor_id == proveedorId && p.estado == 1 // Filtramos estrictamente por el proveedor de la compra y que estén activos
                            select new EProducto()
                            {
                                producto_id = p.producto_id,
                                codigo = p.codigo,
                                nombre = p.nombre,
                                descripcion = p.descripcion,
                                precio_venta = p.precio_venta,
                                stock = p.stock,
                                stock_minimo = p.stock_minimo,
                                estado = p.estado,
                                fecha_alta = p.fecha_alta,
                                fecha_ultima_modificacion = p.fecha_ultima_modificacion,

                                marca_id = p.marca_id,
                                categoria_id = p.categoria_id,
                                proveedor_id = p.proveedor_id,

                                oMarca = new EMarca { marca_id = m.marca_id, nombre = m.nombre },
                                oCategoria = new ECategoria { categoria_id = c.categoria_id, nombre = c.nombre },
                                oProveedor = new EProveedor { proveedor_id = pr.proveedor_id, razon_social = pr.razon_social }
                            };

                return query.ToList();
            }
        }



        // Método para buscar y filtrar productos por proveedor, texto (código o nombre) y marca
        public List<EProducto> BuscarProductosPorProveedorPorFiltro(int proveedorId, string busqueda, int marcaId)
        {
            List<EProducto> listaProductos = new List<EProducto>();

            try
            {
                using (var contexto = new db_sistema_gestion_ventas_electronicosEntities())
                {
                    var query = from p in contexto.producto
                                join m in contexto.marca on p.marca_id equals m.marca_id
                                join c in contexto.categoria on p.categoria_id equals c.categoria_id
                                join pr in contexto.proveedor on p.proveedor_id equals pr.proveedor_id
                                where p.proveedor_id == proveedorId && p.estado == 1 // Filtrado estricto por proveedor y activos
                                select new
                                {
                                    Producto = p,
                                    NombreMarca = m.nombre,
                                    NombreCategoria = c.nombre,
                                    RazonSocialProveedor = pr.razon_social
                                };

                    // Filtro por Código o Nombre si se escribe algo en el buscador
                    if (!string.IsNullOrWhiteSpace(busqueda))
                     {
                        busqueda = busqueda.Trim().ToLower();
                        query = query.Where(x => x.Producto.codigo.ToLower().Contains(busqueda) ||
                                                  x.Producto.nombre.ToLower().Contains(busqueda));
                    }

                    // Filtro por Marca si se selecciona una diferente de "Todos" (ej. ID > 0)
                    if (marcaId > 0)
                    {
                        query = query.Where(x => x.Producto.marca_id == marcaId);
                    }

                    var resultado = query.ToList();

                    listaProductos = resultado.Select(item => new EProducto()
                    {
                        producto_id = item.Producto.producto_id,
                        codigo = item.Producto.codigo,
                        nombre = item.Producto.nombre,
                        descripcion = item.Producto.descripcion,
                        precio_venta = item.Producto.precio_venta,
                        stock = item.Producto.stock,
                        stock_minimo = item.Producto.stock_minimo,
                        estado = item.Producto.estado,
                        fecha_alta = item.Producto.fecha_alta,
                        fecha_ultima_modificacion = item.Producto.fecha_ultima_modificacion,
                        marca_id = item.Producto.marca_id,
                        categoria_id = item.Producto.categoria_id,
                        proveedor_id = item.Producto.proveedor_id,

                        oMarca = new EMarca { marca_id = item.Producto.marca_id, nombre = item.NombreMarca },
                        oCategoria = new ECategoria { categoria_id = item.Producto.categoria_id, nombre = item.NombreCategoria },
                        oProveedor = new EProveedor { proveedor_id = item.Producto.proveedor_id, razon_social = item.RazonSocialProveedor }
                    }).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return listaProductos;
        }


        // Listar Productos Activos con su Marca y Categoría (sin proveedor) usando Lambda
        public List<EProducto> ListarProductosActivos()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.producto
                    .Where(p => p.estado == 1) // Filtramos solo los productos activos
                    .Join(db.marca,
                          p => p.marca_id,
                          m => m.marca_id,
                          (p, m) => new { p, m })
                    .Join(db.categoria,
                          x => x.p.categoria_id,
                          c => c.categoria_id,
                          (x, c) => new EProducto
                          {
                              producto_id = x.p.producto_id,
                              codigo = x.p.codigo,
                              nombre = x.p.nombre,
                              descripcion = x.p.descripcion,
                              precio_venta = x.p.precio_venta,
                              stock = x.p.stock,
                              stock_minimo = x.p.stock_minimo,
                              estado = x.p.estado,
                              fecha_alta = x.p.fecha_alta,
                              fecha_ultima_modificacion = x.p.fecha_ultima_modificacion,

                              marca_id = x.p.marca_id,
                              categoria_id = x.p.categoria_id,

                              // Asignamos únicamente Marca y Categoría
                              oMarca = new EMarca { marca_id = x.m.marca_id, nombre = x.m.nombre },
                              oCategoria = new ECategoria { categoria_id = c.categoria_id, nombre = c.nombre },
                          })
                    .ToList();
            }
        }

        // Método para buscar y filtrar productos activos por Categoría, Marca y Texto (Código o Nombre)
        public List<EProducto> BuscarProductosActivosPorFiltro(int categoriaId, int marcaId, string busqueda)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from p in db.producto
                            join m in db.marca on p.marca_id equals m.marca_id
                            join c in db.categoria on p.categoria_id equals c.categoria_id
                            where p.estado == 1 // Estrictamente activos
                            select new EProducto
                            {
                                producto_id = p.producto_id,
                                codigo = p.codigo,
                                nombre = p.nombre,
                                descripcion = p.descripcion,
                                precio_venta = p.precio_venta,
                                stock = p.stock,
                                stock_minimo = p.stock_minimo,
                                estado = p.estado,
                                fecha_alta = p.fecha_alta,
                                fecha_ultima_modificacion = p.fecha_ultima_modificacion,
                                marca_id = p.marca_id,
                                categoria_id = p.categoria_id,

                                oMarca = new EMarca { marca_id = m.marca_id, nombre = m.nombre },
                                oCategoria = new ECategoria { categoria_id = c.categoria_id, nombre = c.nombre }
                            };

                // Filtrar por Categoría si se seleccionó una distinta de "Todos" (ID > 0)
                if (categoriaId > 0)
                {
                    query = query.Where(p => p.categoria_id == categoriaId);
                }

                // Filtrar por Marca si se seleccionó una distinta de "Todos" (ID > 0)
                if (marcaId > 0)
                {
                    query = query.Where(p => p.marca_id == marcaId);
                }

                //  Filtrar por Texto (Código o Nombre) si se escribió algo en el buscador
                if (!string.IsNullOrWhiteSpace(busqueda))
                {
                    busqueda = busqueda.Trim().ToLower();
                    query = query.Where(p => p.codigo.ToLower().Contains(busqueda) ||
                                              p.nombre.ToLower().Contains(busqueda));
                }

                return query.ToList();
            }
        }

        // Buscar Producto 
        public List<EProducto> BuscarProductosGeneral(int categoriaId, int marcaId, int proveedorId, int estado, string busqueda)
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                var query = from p in db.producto
                            join m in db.marca on p.marca_id equals m.marca_id
                            join c in db.categoria on p.categoria_id equals c.categoria_id
                            join pr in db.proveedor on p.proveedor_id equals pr.proveedor_id
                            select new EProducto
                            {
                                producto_id = p.producto_id,
                                codigo = p.codigo,
                                nombre = p.nombre,
                                descripcion = p.descripcion,
                                precio_venta = p.precio_venta,
                                stock = p.stock,
                                stock_minimo = p.stock_minimo,
                                estado = p.estado,
                                fecha_alta = p.fecha_alta,
                                fecha_ultima_modificacion = p.fecha_ultima_modificacion,
                                marca_id = p.marca_id,
                                categoria_id = p.categoria_id,
                                proveedor_id = p.proveedor_id,
                                oMarca = new EMarca { marca_id = m.marca_id, nombre = m.nombre },
                                oCategoria = new ECategoria { categoria_id = c.categoria_id, nombre = c.nombre },
                                oProveedor = new EProveedor { proveedor_id = pr.proveedor_id, razon_social = pr.razon_social }
                            };

                // Filtro por Categoría (> 0 significa que se seleccionó una categoría específica)
                if (categoriaId > 0)
                {
                    query = query.Where(p => p.categoria_id == categoriaId);
                }

                // Filtro por Marca
                if (marcaId > 0)
                {
                    query = query.Where(p => p.marca_id == marcaId);
                }

                // Filtro por Proveedor
                if (proveedorId > 0)
                {
                    query = query.Where(p => p.proveedor_id == proveedorId);
                }

                // Filtro por Estado (-1 es "Todos", 1 es "Activo", 0 es "Inactivo")
                if (estado != -1)
                {
                    query = query.Where(p => p.estado == estado);
                }

                // Filtro por Texto (Código o Nombre)
                if (!string.IsNullOrWhiteSpace(busqueda))
                {
                    busqueda = busqueda.Trim().ToLower();
                    query = query.Where(p => p.codigo.ToLower().Contains(busqueda) ||
                                            p.nombre.ToLower().Contains(busqueda));
                }

                return query.ToList();
            }
        }
    }
}
