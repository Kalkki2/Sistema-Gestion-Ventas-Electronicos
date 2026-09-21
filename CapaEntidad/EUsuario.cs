using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EUsuario
    {
        public int usuario_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public DateTime fecha_registro { get; set; }
        public string direccion { get; set; }
        public string contrasenia { get; set; }

        public int perfil_id { get; set; }
        public EPerfil oPerfil { get; set; } // Objeto anidado de tipo EPerfil

        // Propiedades de lectura directa para la grilla
        public string NombrePerfil => oPerfil != null ? oPerfil.nombre : string.Empty;
        public string EstadoTexto => estado ? "Activo" : "Inactivo";
    }
}
