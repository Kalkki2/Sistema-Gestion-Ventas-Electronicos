using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProveedor
    {
        public int proveedor_id { get; set; }
        public string cuit { get; set; }
        public string nombre_comercial { get; set; }
        public string razon_social { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }

        public int estado { get; set; } // 1 para Activo, 0 para Inactivo

        // Propiedad de apoyo para mostrar "Activo" o "Inactivo" en el DataGridView
        public string EstadoTexto
        {
            get { return estado == 1 ? "Activo" : "Inactivo"; }
        }

        public DateTime fecha_alta{ get; set; }
        public DateTime fecha_ultima_modificacion { get; set; }
    }
}
