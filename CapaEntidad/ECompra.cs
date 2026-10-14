using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class ECompra
    {
        public int compra_id { get; set; }
        public string nro_factura { get; set; }
        public DateTime fecha_compra { get; set; }
        public int estado { get; set; }
        public int usuario_id { get; set; }
        public int proveedor_id { get; set; }

        // --- PROPIEDADES PLANAS PARA MOSTRAR EN EL DATAGRIDVIEW ---
        public string CuitProveedor => oProveedor != null ? oProveedor.cuit : string.Empty;
        public string NombreProveedor => oProveedor != null ? oProveedor.razon_social : string.Empty;

        public string DniUsuario => oUsuario != null ? oUsuario.dni : string.Empty; // Ajusta según el campo DNI de tu entidad usuario
        public string NombreComprador => oUsuario != null ? $"{oUsuario.apellido}, {oUsuario.nombre}" : string.Empty;

        public string EstadoTexto => estado == 1 ? "Activo" : "Anulado";

        // Cálculo automático del Total de la compra basado en sus detalles
        public decimal TotalCompra => oDetalleCompra != null ? oDetalleCompra.Sum(d => d.cantidad * d.costo_unitario) : 0;

        // Objetos de relación
        public EUsuario oUsuario { get; set; }
        public EProveedor oProveedor { get; set; }
        public List<EDetalleCompra> oDetalleCompra { get; set; }
    }
}
