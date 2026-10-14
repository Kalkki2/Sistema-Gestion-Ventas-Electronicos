using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EDetalleCompra
    {
        
            public int producto_id { get; set; }
            public int compra_id { get; set; }
            public int cantidad { get; set; }
            public decimal costo_unitario { get; set; }
            public decimal porcentaje_margen { get; set; }

            // --- PROPIEDADES PLANAS QUE NECESITA TU DATAGRIDVIEW PARA MOSTRAR LOS TEXTOS ---
            public string CodigoProducto => oProducto != null ? oProducto.codigo : string.Empty;
            public string NombreProducto => oProducto != null ? oProducto.nombre : string.Empty;
            public decimal SubtotalFila => cantidad * costo_unitario;

            // Objeto de relación
            public EProducto oProducto { get; set; }
      }
    
}
