using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNVenta
    {
        private CDVenta objCD_Venta = new CDVenta();

        public bool Registrar(EVenta objVenta, List<EDetalleVenta> listaDetalles, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Validar que se haya ingresado o generado el número de venta
            if (string.IsNullOrWhiteSpace(objVenta.nro_venta))
            {
                Mensaje = "Es necesario ingresar o generar el número de venta.";
                return false;
            }

            // Validar que se haya seleccionado un cliente
            if (objVenta.cliente_id == 0)
            {
                Mensaje = "Debe seleccionar un cliente para realizar la venta.";
                return false;
            }

            // Validar que se haya seleccionado un método de pago
            if (objVenta.metodo_pago_id == 0)
            {
                Mensaje = "Debe seleccionar un método de pago.";
                return false;
            }

            // Validar que se haya asignado un tipo de ajuste
            if (objVenta.tipo_ajuste_id == 0)
            {
                Mensaje = "Debe especificar el tipo de ajuste del método de pago.";
                return false;
            }

            // Validar que la lista de productos no esté vacía
            if (listaDetalles == null || listaDetalles.Count == 0)
            {
                Mensaje = "Debe agregar al menos un producto al detalle de la venta.";
                return false;
            }

            // Validar datos individuales dentro de cada producto del detalle
            foreach (var detalle in listaDetalles)
            {
                if (detalle.cantidad <= 0)
                {
                    Mensaje = "La cantidad para cada producto debe ser mayor a 0.";
                    return false;
                }

                if (detalle.precio_unitario <= 0)
                {
                    Mensaje = "El precio unitario de los productos debe ser mayor a 0.";
                    return false;
                }
            }

            // Si todas las validaciones pasan, envía los datos a la Capa de Datos
            return objCD_Venta.Registrar(objVenta, listaDetalles, out Mensaje);
        }

        public List<EVenta> ListarHistorialVentas()
        {
            return objCD_Venta.ListarHistorialVentas();
        }

        public List<EDetalleVenta> ObtenerDetalleVenta(int ventaId)
        {
            return objCD_Venta.ObtenerDetalleVenta(ventaId);
        }
    }
}
