using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNProveedor
    {
        private CDProveedor objCDProveedor = new CDProveedor();

        // LISTAR Proveedores
        public List<EProveedor> Listar()
        {
            return objCDProveedor.ListarProveedores();
        }

        // REGISTRAR proveedores
        public bool Registrar(EProveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            // Validaciones lógicas básicas antes de llegar a la base de datos
            if (string.IsNullOrWhiteSpace(oProveedor.cuit))
            {
                mensaje = "Es necesario ingresar el CUIT del proveedor.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.nombre_comercial))
            {
                mensaje = "Es necesario ingresar el Nombre Comercial del proveedor.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.razon_social))
            {
                mensaje = "Es necesario ingresar la Razón Social del proveedor.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.email))
            {
                mensaje = "Es necesario ingresar el correo electrónico del proveedor.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.telefono))
            {
                mensaje = "Es necesario ingresar el teléfono del proveedor.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.direccion))
            {
                mensaje = "Es necesario ingresar la dirección del proveedor.";
                return false;
            }

            return objCDProveedor.RegistrarProveedor(oProveedor, out mensaje);
        }

        // EDITAR proveedor
        public bool EditarProveedor(EProveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (oProveedor.proveedor_id <= 0)
            {
                mensaje = "ID de proveedor no válido para actualizar.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.cuit))
            {
                mensaje = "El CUIT no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.nombre_comercial))
            {
                mensaje = "El Nombre Comercial no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.razon_social))
            {
                mensaje = "La Razón Social no puede estar vacía.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.email))
            {
                mensaje = "El correo electrónico no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.telefono))
            {
                mensaje = "El teléfono no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.direccion))
            {
                mensaje = "La dirección no puede estar vacía.";
                return false;
            }

            return objCDProveedor.EditarProveedor(oProveedor, out mensaje);
        }

        // CAMBIAR ESTADO proveedor (Actualizado para recibir el out mensaje)
        public bool CambiarEstado(int idProveedor, int nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idProveedor <= 0)
            {
                mensaje = "ID de proveedor no válido.";
                return false;
            }

            return objCDProveedor.CambiarEstado(idProveedor, nuevoEstado, out mensaje);
        }

        // BUSCAR proveedor (Llama al método unificado 'Buscar' de la Capa de Datos)
        public List<EProveedor> Buscar(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                return Listar();
            }
            return objCDProveedor.BuscarProveedoresPorCuitOCorreo(busqueda);
        }

        // FILTRAR proveedor por estado
        public List<EProveedor> FiltrarPorEstado(int? estado)
        {
            return objCDProveedor.Filtrar(estado);
        }

        public List<EProveedor> ListarProveedoreActivos()
        {
            return objCDProveedor.ListarProveedoresActivos();
        }

        public List<EProveedor> ListarProveedorPorCategoria(int categoria_id)
        {
            if (categoria_id == 0)
            {
                return Listar(); 
            }
            else
            {
                return objCDProveedor.ListarProveedorPorCategoria(categoria_id);
            }
        }
    }
}

