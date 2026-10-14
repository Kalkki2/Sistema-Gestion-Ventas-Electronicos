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

        public bool Registrar(ECompra objCompra, List<EDetalleCompra> listaDetalles, out string Mensaje)
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

            return objCD_Compra.Registrar(objCompra, listaDetalles, out Mensaje);
        }

        public List<ECompra> ListarHistorialCompras()
        {
            return objCD_Compra.ListarHistorialCompras();
        }

        public List<EDetalleCompra> ObtenerDetalleCompra(int compraId)
        {
            return objCD_Compra.ObtenerDetalleCompra(compraId);
        }
    }
}

