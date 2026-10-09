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

        // 1. Listar Categorías
        public List<ECategoria> ListarCategorias()
        {
            return objCD_Producto.ListarCategorias();
        }

        // 2. Listar Proveedores
        public List<EProveedor> ListarProveedores()
        {
            return objCD_Producto.ListarProveedores();
        }

        // 3. Listar Marcas por Categoría
        public List<EMarca> ListarMarcasPorCategoria(int categoriaId)
        {
            return objCD_Producto.ListarMarcasPorCategoria(categoriaId);
        }

        // 4. Listar Productos
        public List<EProducto> ListarProductos()
        {
            return objCD_Producto.ListarProductos();
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
    }
}
