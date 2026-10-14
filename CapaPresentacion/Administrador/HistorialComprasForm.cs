using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class HistorialCompras : Form
    {
        public HistorialCompras()
        {
            InitializeComponent();
        }

        private void HistorialComprasForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            CargarHistorialCompras();
        }

        private void CargarHistorialCompras()
        {
            dgvHistorialCompras.AutoGenerateColumns = false;

            // Mapeamos los nombres de las columnas del DataGridView con las propiedades de ECompra
            dgvHistorialCompras.Columns["colNroFactura"].DataPropertyName = "nro_factura";
            dgvHistorialCompras.Columns["colCuitProveedor"].DataPropertyName = "CuitProveedor";
            dgvHistorialCompras.Columns["colProveedor"].DataPropertyName = "NombreProveedor";
            dgvHistorialCompras.Columns["colDniUsuario"].DataPropertyName = "DniUsuario";
            dgvHistorialCompras.Columns["colComprador"].DataPropertyName = "NombreComprador";
            dgvHistorialCompras.Columns["colFechaCompra"].DataPropertyName = "fecha_compra";
            dgvHistorialCompras.Columns["colTotal"].DataPropertyName = "TotalCompra";
            dgvHistorialCompras.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            CNCompra objCNCompra = new CNCompra();
            dgvHistorialCompras.DataSource = objCNCompra.ListarHistorialCompras();
        }

        private void dgvHistorialCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvHistorialCompras.Columns[e.ColumnIndex].Name;

            // Si hace clic en la columna del botón "Ver Detalle"
            if (nombreColumna == "colVerDetalle")
            {
                // Obtenemos el objeto ECompra ligado a esa fila de la grilla
                ECompra compraSeleccionada = (ECompra)dgvHistorialCompras.Rows[e.RowIndex].DataBoundItem;

                if (compraSeleccionada != null)
                {
                    // Abrimos el formulario modal pasándole el objeto por el constructor
                    using (DetalleCompraProducto modal = new DetalleCompraProducto(compraSeleccionada))
                    {
                        modal.ShowDialog();
                    }
                }
            }
        }
    }
}
