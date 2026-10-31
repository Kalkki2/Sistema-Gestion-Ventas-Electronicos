using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.CDVenta;

namespace CapaNegocio
{
    public class CNVenta
    {
        private CDVenta objCD_Venta = new CDVenta();

        public bool Registrar(EVenta objVenta, List<EDetalleVenta> listaDetalles, out string Mensaje)
        {
            Mensaje = string.Empty;

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

            // Enviar a la Capa de Datos (donde se generará automáticamente el nro_venta)
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

        public List<EVenta> ListarHistorialVentasPorUsuario(int usuarioId)
        {
            return objCD_Venta.ListarHistorialVentasPorUsuario(usuarioId);
        }

        public List<EMarcaVenta> ObtenerVentasPorMarca(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.ObtenerVentasPorMarca(fechaDesde, fechaHasta);
        }

        public List<ETendenciaVenta> ObtenerTendenciaVentasDiarias()
        {
            return objCD_Venta.ObtenerTendenciaVentasDiarias();
        }

        public decimal CalcularTotalVentasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.CalcularTotalVentasPorFecha(fechaDesde, fechaHasta);
        }

        public int CalcularTotalArticulosVendidosPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.CalcularTotalArticulosVendidosPorFecha(fechaDesde, fechaHasta);
        }

        public int CalcularTotalClientesUnicosPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.CalcularTotalClientesUnicosPorFecha(fechaDesde, fechaHasta);
        }

        public List<EReporteTopProducto> ListarTop10ProductosMasVendidos(DateTime fechaDesde, DateTime fechaHasta)
        {
            CDVenta objCDVenta = new CDVenta();
            return objCDVenta.ObtenerTop10ProductosMasVendidos(fechaDesde, fechaHasta);
        }

        public List<EVenta> Buscar(string dniVendedor, string dniCliente, int? metodoPagoId, DateTime? fechaDesde, DateTime? fechaHasta)
        {
            return objCD_Venta.Buscar(dniVendedor, dniCliente, metodoPagoId, fechaDesde, fechaHasta);
        }

        public List<ECategoriaVenta> ObtenerVentasMonetariasPorCategoria(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.ObtenerVentasMonetariasPorCategoria(fechaDesde, fechaHasta);
        }

        public List<ETopVendedor> ObtenerTop5PersonalVentas(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.ObtenerTop5PersonalVentas(fechaDesde, fechaHasta);
        }

        //
        public List<EMetodoPagoVenta> ObtenerVentasPorMetodoPago(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.ObtenerVentasPorMetodoPago(fechaDesde, fechaHasta);
        }
    }
}
