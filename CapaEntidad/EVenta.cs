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
        public int tipo_ajuste_id { get; set; }

        // --- PROPIEDADES PLANAS PARA MOSTRAR EN EL DATAGRIDVIEW ---
        public string DniUsuario => oUsuario != null ? oUsuario.dni : string.Empty;
        public string NombreComprador => oUsuario != null ? $"{oUsuario.apellido}, {oUsuario.nombre}" : string.Empty;

        public string NombreCliente => oCliente != null ? $"{oCliente.apellido}, {oCliente.nombre}" : string.Empty;
        public string DniCliente => oCliente != null ? oCliente.dni : string.Empty;

        public string NombreMetodoPago => oMetodoPago != null ? oMetodoPago.nombre : string.Empty;
        public string NombreTipoAjuste => oTipoAjuste != null ? oTipoAjuste.nombre : string.Empty;

        public string EstadoTexto => estado == 1 ? "Completada" : "Anulada";

        // Cálculo automático del Total de la venta basado en sus detalles
        public decimal SubtotalVenta => oDetalleVenta != null ? oDetalleVenta.Sum(d => d.SubtotalFila) : 0;

        // Si quisieras calcular el total aplicando el recargo o descuento del método de pago de forma automática:
        // (O puedes calcularlo en la lógica de negocio/interfaz)

        // Objetos de relación
        public EUsuario oUsuario { get; set; }
        public ECliente oCliente { get; set; }
        public EMetodoPago oMetodoPago { get; set; }
        public ETipoAjuste oTipoAjuste { get; set; }
        public List<EDetalleVenta> oDetalleVenta { get; set; }
    }
}
