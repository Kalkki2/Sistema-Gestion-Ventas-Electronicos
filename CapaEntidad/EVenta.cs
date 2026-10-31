using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EVenta
    {
        public int venta_id { get; set; }
        public string nro_venta { get; set; }
        public DateTime fecha_venta { get; set; }
        public decimal porcentaje_aplicado { get; set; }
        public int estado { get; set; }

        public int usuario_id { get; set; }
        public int metodo_pago_id { get; set; }
        public int cliente_id { get; set; }

        // Propiedades planas
        public string DniUsuario => oUsuario != null ? oUsuario.dni : string.Empty;
        public string NombreComprador => oUsuario != null ? $"{oUsuario.apellido}, {oUsuario.nombre}" : string.Empty;

        public string NombreCliente => oCliente != null ? $"{oCliente.apellido}, {oCliente.nombre}" : string.Empty;
        public string DniCliente => oCliente != null ? oCliente.dni : string.Empty;

        public string NombreMetodoPago => oMetodoPago != null ? oMetodoPago.nombre : string.Empty;

        // El tipo de ajuste se obtiene a través del método de pago:
        public string NombreTipoAjuste => (oMetodoPago != null && oMetodoPago.oTipoAjuste != null) ? oMetodoPago.oTipoAjuste.nombre : string.Empty;

        public string EstadoTexto => estado == 1 ? "Completada" : "Anulada";

        public decimal SubtotalVenta => oDetalleVenta != null ? oDetalleVenta.Sum(d => d.SubtotalFila) : 0;

        public decimal TotalVenta
        {
            get
            {
                decimal subtotal = SubtotalVenta;
                decimal montoAjuste = (subtotal * porcentaje_aplicado) / 100; 
                decimal totalReal = subtotal;

                if (NombreTipoAjuste == "Descuento")
                {
                    totalReal = subtotal - montoAjuste; 
                }
                else if (NombreTipoAjuste == "Recargo")
                {
                    totalReal = subtotal + montoAjuste;
                }

                return totalReal;
            }
        }

        public EUsuario oUsuario { get; set; }
        public ECliente oCliente { get; set; }
        public EMetodoPago oMetodoPago { get; set; }
        public List<EDetalleVenta> oDetalleVenta { get; set; }
    }
}
