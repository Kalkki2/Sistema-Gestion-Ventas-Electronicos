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
        // 1. Listar Categorías
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

        // 2. Listar Proveedores Activos
        public List<EProveedor> ListarProveedores()
        {
            using (var db = new db_sistema_gestion_ventas_electronicosEntities())
            {
                return db.proveedor.Where(p => p.estado == 1).Select(p => new EProveedor
                {
                    proveedor_id = p.proveedor_id,
                    razon_social = p.razon_social
                }).ToList();
            }
        }

        // 3. Listar Marcas filtradas por Categoría
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

        // 4. Listar todos los Productos con Joins explícitos
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

        // 5. Registrar Producto
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

        // 6. Editar Producto
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
    }
}
