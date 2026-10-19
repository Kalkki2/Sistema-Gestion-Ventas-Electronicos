using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ECliente
    {
        public int cliente_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime fecha_ultima_modificacion { get; set; }
        public int estado { get; set; }

        // --- PROPIEDADES PLANAS / FORMATOS AUXILIARES ---
        public string NombreCompleto => $"{apellido}, {nombre}";
        public string EstadoTexto => estado == 1 ? "Activo" : "Inactivo";
    }
}
