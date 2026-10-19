using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EMetodoPago
    {
        public int metodo_pago_id { get; set; }
        public string nombre { get; set; }
        public decimal porcentaje { get; set; }
        public int tipo_ajuste_id { get; set; }

        // Objeto de relación
        public ETipoAjuste oTipoAjuste { get; set; }
    }
}
