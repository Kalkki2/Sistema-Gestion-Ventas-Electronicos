using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EDetalleVenta
    {
            public int producto_id { get; set; }
            public int venta_id { get; set; }
            public int cantidad { get; set; }
            public decimal precio_unitario { get; set; }

            // --- PROPIEDADES PLANAS PARA EL DATAGRIDVIEW ---
            public string CodigoProducto => oProducto != null ? oProducto.codigo : string.Empty;
            public string NombreProducto => oProducto != null ? oProducto.nombre : string.Empty;
            public decimal SubtotalFila => cantidad * precio_unitario;

            // Objeto de relación
            public EProducto oProducto { get; set; }
     }
}
