using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCompra
    {
        private CDCompra objCD_Compra = new CDCompra();

        public bool RegistrarcCompra(ECompra objCompra, List<EDetalleCompra> listaDetalles, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(objCompra.nro_factura))
            {
                Mensaje = "Es necesario ingresar el número de factura.";
                return false;
            }

            if (objCompra.proveedor_id == 0)
            {
                Mensaje = "Debe seleccionar un proveedor.";
                return false;
            }

            if (listaDetalles == null || listaDetalles.Count == 0)
            {
                Mensaje = "Debe agregar al menos un producto al detalle de la compra.";
                return false;
            }

            return objCD_Compra.RegistrarCompra(objCompra, listaDetalles, out Mensaje);
        }

        public List<ECompra> ListarHistorialCompras()
        {
            return objCD_Compra.ListarHistorialCompras();
        }

        public List<EDetalleCompra> ObtenerDetalleCompra(int compraId)
        {
            return objCD_Compra.ObtenerDetalleCompra(compraId);
        }

        public List<ECompra> Buscar(string nroFactura, string cuitProveedor, string dniUsuario, DateTime? fechaDesde, DateTime? fechaHasta, int? estadoFiltro)
        {
            return objCD_Compra.Buscar(nroFactura, cuitProveedor, dniUsuario, fechaDesde, fechaHasta, estadoFiltro);
        }

        public bool CambiarEstado(int idCompra, int nuevoEstado, out string mensaje)
        {
            return objCD_Compra.CambiarEstado(idCompra, nuevoEstado, out mensaje);
        }
    }
}

