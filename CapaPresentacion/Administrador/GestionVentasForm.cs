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
    public partial class GestionVentasForm : Form
    {
        public GestionVentasForm()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarVendedorDni.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void GestionVentasForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarHistorialVentas();
        }

        private void txtBuscarVendedor_Validating(object sender, CancelEventArgs e)
        {
            string codigo = txtBuscarVendedorDni.Text.Trim();

            if (!ulong.TryParse(codigo, out _))
            {
                errorProvider1.SetError(txtBuscarVendedorDni, "El DNI solo debe contener números.");
            }
            else if (codigo.Length != 8)
            {
                errorProvider1.SetError(txtBuscarVendedorDni, "El DNI debe tener exactamente 8 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtBuscarVendedorDni, "");
            }
        }

        private void btnAplicarAjusteFormaPago_Click(object sender, EventArgs e)
        {
           
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea aplicar ajuste a la forma de pago?",
                "Confirmar ajuste",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario responde 'No', cancelamos la operación
            if (respuesta == DialogResult.No)
            {
                return;
            }
            // Mensaje de éxito
            MessageBox.Show("Se aplico ajuste  con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPorcentajeAjuste.Value = 0;
        }

        private void CargarHistorialVentas()
        {
            dgvHistorialVentas.AutoGenerateColumns = false;

            // Mapeamos las columnas del DataGridView con las propiedades planas de EVenta
            dgvHistorialVentas.Columns["colNroVenta"].DataPropertyName = "nro_venta";
            dgvHistorialVentas.Columns["colDniCliente"].DataPropertyName = "DniCliente";
            dgvHistorialVentas.Columns["colCliente"].DataPropertyName = "NombreCliente";
            dgvHistorialVentas.Columns["colDniVendedor"].DataPropertyName = "DniUsuario";
            dgvHistorialVentas.Columns["colVendedor"].DataPropertyName = "NombreComprador";
            dgvHistorialVentas.Columns["colMetodoPago"].DataPropertyName = "NombreMetodoPago";
            dgvHistorialVentas.Columns["colTipoAjuste"].DataPropertyName = "NombreTipoAjuste";
            dgvHistorialVentas.Columns["colFechaVenta"].DataPropertyName = "fecha_venta";
            dgvHistorialVentas.Columns["colTotal"].DataPropertyName = "SubtotalVenta";
            dgvHistorialVentas.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            // Instanciamos la capa de negocio y cargamos la grilla
            CNVenta objCNVenta = new CNVenta();
            dgvHistorialVentas.DataSource = objCNVenta.ListarHistorialVentas();
        }

        private void dgvHistorialVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no se haga clic en los encabezados (fila -1)
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvHistorialVentas.Columns[e.ColumnIndex].Name;

            // Si hace clic en la columna configurada como botón "Ver Detalle"
            if (nombreColumna == "colVerDetalle")
            {
                // 1. Extraemos el objeto EVenta de la fila seleccionada en la grilla
                EVenta ventaSeleccionada = (EVenta)dgvHistorialVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada != null)
                {
                    // 2. Abrimos el formulario modal pasándole el objeto por el constructor
                    using (DetalleVenta modal = new DetalleVenta(ventaSeleccionada))
                    {
                        modal.ShowDialog(); // Esto abre la ventana que diseñaste con los datos de la venta y productos
                    }
                }
            }
        }
    }
}
