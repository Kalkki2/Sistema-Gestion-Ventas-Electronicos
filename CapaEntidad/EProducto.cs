using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProducto
    {
        public int producto_id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio_venta { get; set; }
        public int stock { get; set; }
        public int stock_minimo { get; set; }
        public int estado { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime? fecha_ultima_modificacion { get; set; } // Puede ser nula

        // IDs para los ComboBox al registrar/editar
        public int marca_id { get; set; }
        public int categoria_id { get; set; }
        public int proveedor_id { get; set; }

        // --- PROPIEDADES PLANAS PARA MOSTRAR EN EL DATAGRIDVIEW ---
        public string NombreCategoria => oCategoria != null ? oCategoria.nombre : string.Empty;
        public string NombreMarca => oMarca != null ? oMarca.nombre : string.Empty;
        public string NombreProveedor => oProveedor != null ? oProveedor.razon_social : string.Empty;

        public string EstadoTexto => estado == 1 ? "Activo" : "Inactivo";

        // Objetos de relación
        public EMarca oMarca { get; set; }
        public ECategoria oCategoria { get; set; }
        public EProveedor oProveedor { get; set; }
    }
}
