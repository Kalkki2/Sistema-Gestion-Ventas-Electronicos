using CapaEntidad;
using CapaDatos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProducto
    {
        private CDProducto objCD_Producto = new CDProducto();

        // Listar Todos los Productos
        public List<EProducto> ListarProductos()
        {
            return objCD_Producto.ListarProductos();
        }

        // Listar Categorías
        public List<ECategoria> ListarCategorias()
        {
            return objCD_Producto.ListarCategorias();
        }

        // Listar Marca
        public List<EMarca> ListarMarcas()
        {
            return objCD_Producto.ListarMarcas();
        }

        // Listar Marcas por Categoría
        public List<EMarca> ListarMarcasPorCategoria(int categoriaId)
        {
            return objCD_Producto.ListarMarcasPorCategoria(categoriaId);
        }

        

        // 5. Registrar Producto con validaciones de negocio
        public bool Registrar(EProducto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.codigo) || string.IsNullOrWhiteSpace(obj.codigo))
            {
                Mensaje = "Es necesario ingresar el código del producto.";
                return false;
            }

            if (string.IsNullOrEmpty(obj.nombre) || string.IsNullOrWhiteSpace(obj.nombre))
            {
                Mensaje = "Es necesario ingresar el nombre del producto.";
                return false;
            }

            

            if (obj.marca_id == 0)
            {
                Mensaje = "Debe seleccionar una marca.";
                return false;
            }

            if (obj.categoria_id == 0)
            {
                Mensaje = "Debe seleccionar una categoría.";
                return false;
            }

            if (obj.proveedor_id == 0)
            {
                Mensaje = "Debe seleccionar un proveedor.";
                return false;
            }

            return objCD_Producto.Registrar(obj, out Mensaje);
        }

        // 6. Editar Producto con validaciones de negocio
        public bool Editar(EProducto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.codigo) || string.IsNullOrWhiteSpace(obj.codigo))
            {
                Mensaje = "Es necesario ingresar el código del producto.";
                return false;
            }

            if (string.IsNullOrEmpty(obj.nombre) || string.IsNullOrWhiteSpace(obj.nombre))
            {
                Mensaje = "Es necesario ingresar el nombre del producto.";
                return false;
            }

         

            if (obj.marca_id == 0)
            {
                Mensaje = "Debe seleccionar una marca.";
                return false;
            }

            if (obj.categoria_id == 0)
            {
                Mensaje = "Debe seleccionar una categoría.";
                return false;
            }

            if (obj.proveedor_id == 0)
            {
                Mensaje = "Debe seleccionar un proveedor.";
                return false;
            }

            return objCD_Producto.Editar(obj, out Mensaje);
        }

        // 7. Cambiar Estado del Producto
        public bool CambiarEstado(int idProducto, int nuevoEstado, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (idProducto == 0)
            {
                Mensaje = "ID de producto inválido.";
                return false;
            }

            return objCD_Producto.CambiarEstado(idProducto, nuevoEstado, out Mensaje);
        }

        // Puente de Negocio para listar productos del proveedor seleccionado
        public List<EProducto> ListarProductosPorProveedor(int proveedorId)
        {
            if (proveedorId == 0)
            {
                return new List<EProducto>(); // Retorna lista vacía si no hay proveedor válido
            }

            return objCD_Producto.ListarProductosPorProveedor(proveedorId);
        }

        public List<EProducto> BuscarProductosPorFiltro(int proveedorId, string busqueda, int marcaId)
        {
            return objCD_Producto.BuscarProductosPorProveedorPorFiltro(proveedorId, busqueda, marcaId);
        }

        public List<EProducto> BuscarProductosGeneral(int categoriaId, int marca_id, int proveedor_id, int estado, string busqueda)
        {
            return objCD_Producto.BuscarProductosGeneral(categoriaId, marca_id, proveedor_id, estado, busqueda);
        }

        //Lista productos activos (VENDEDOR: productos)
        public List<EProducto> ListarProductosActivos()
        {
            return objCD_Producto.ListarProductosActivos();
        }

        //Lista Filtada de  productos activos (VENDEDOR: productos)
        public List<EProducto> BuscarProductosActivosPorFiltro(int categoriaId, int marcaId, string busqueda)
        {
            return objCD_Producto.BuscarProductosActivosPorFiltro(categoriaId, marcaId, busqueda);
        }
    }


}
