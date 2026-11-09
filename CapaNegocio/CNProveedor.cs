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

        // LISTAR TODOS los  Proveedores(Gestion proveedor)
        public List<EProveedor> ListarProveedores()
        {
            return objCDProveedor.ListarProveedores();
        }

        // REGISTRAR proveedor (Gestion proveedor)
        public bool RegistrarProveedor(EProveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(oProveedor.cuit) ||
                string.IsNullOrWhiteSpace(oProveedor.nombre_comercial) ||
                string.IsNullOrWhiteSpace(oProveedor.razon_social) ||
                string.IsNullOrWhiteSpace(oProveedor.email) ||
                string.IsNullOrWhiteSpace(oProveedor.telefono) ||
                string.IsNullOrWhiteSpace(oProveedor.direccion))
            {
                mensaje = "Por favor, complete todos los campos obligatorios.";
                return false;
            }

            return objCDProveedor.RegistrarProveedor(oProveedor, out mensaje);
        }

        // EDITAR proveedor (Gestion proveedor)
        public bool EditarProveedor(EProveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;

            // Validación específica del ID
            if (oProveedor.proveedor_id <= 0)
            {
                mensaje = "ID de proveedor no válido para actualizar.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(oProveedor.cuit) ||
                string.IsNullOrWhiteSpace(oProveedor.nombre_comercial) ||
                string.IsNullOrWhiteSpace(oProveedor.razon_social) ||
                string.IsNullOrWhiteSpace(oProveedor.email) ||
                string.IsNullOrWhiteSpace(oProveedor.telefono) ||
                string.IsNullOrWhiteSpace(oProveedor.direccion))
            {
                mensaje = "Por favor, complete todos los campos obligatorios.";
                return false;
            }

            return objCDProveedor.EditarProveedor(oProveedor, out mensaje);
        }

        //  CAMBIAR ESTADO proveedor (Gestion proveedor)
        public bool CambiarEstadoProveedor(int idProveedor, int nuevoEstado, out string mensaje)
        {
            mensaje = string.Empty;

            if (idProveedor <= 0)
            {
                mensaje = "ID de proveedor no válido.";
                return false;
            }

            return objCDProveedor.CambiarEstadoProveedor(idProveedor, nuevoEstado, out mensaje);
        }

        // BUSCAR proveedor POR CUIT O CORREO
        public List<EProveedor> BuscarProveedorPorCuitOCorreo(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                return ListarProveedores();
            }
            return objCDProveedor.BuscarProveedoresPorCuitOCorreo(busqueda);
        }

        // FILTRAR proveedor por estado
        public List<EProveedor> FiltrarPorEstado(int? estado)
        {
            return objCDProveedor.FiltrarProveedorPoEstado(estado);
        }

        public List<EProveedor> ListarProveedoreActivos()
        {
            return objCDProveedor.ListarProveedoresActivos();
        }

        public List<EProveedor> ListarProveedorPorCategoria(int categoria_id)
        {
            if (categoria_id == 0)
            {
                return ListarProveedores(); 
            }
            else
            {
                return objCDProveedor.ListarProveedorPorCategoria(categoria_id);
            }
        }
    }
}

