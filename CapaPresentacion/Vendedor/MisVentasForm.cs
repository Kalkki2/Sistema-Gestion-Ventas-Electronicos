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

namespace CapaPresentacion.Vendedor
{
    public partial class MisVentasForm : Form
    {
        public MisVentasForm()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarClienteDni.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void MisVentasForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
            CargarMisVentas();
        }

        private void txtBuscarCliente_Validating(object sender, CancelEventArgs e)
        {
            string codigo = txtBuscarClienteDni.Text.Trim();

            if (!ulong.TryParse(codigo, out _))
            {
                errorProvider1.SetError(txtBuscarClienteDni, "El DNI solo debe contener números.");
            }
            else if (codigo.Length != 8)
            {
                errorProvider1.SetError(txtBuscarClienteDni, "El DNI debe tener exactamente 8 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtBuscarClienteDni, "");
            }
        }

        private void CargarMisVentas()
        {
            dgvMisVentas.AutoGenerateColumns = false;

            // Mapeamos las columnas del DataGridView con las propiedades de EVenta
            // (Nota: Como este formulario es solo para el vendedor, no hace falta mostrar su propio DNI/nombre en cada fila, 
            // pero sí el cliente, método de pago, fecha y total)
            dgvMisVentas.Columns["colNroVenta"].DataPropertyName = "nro_venta";
            dgvMisVentas.Columns["colDniCliente"].DataPropertyName = "DniCliente";
            dgvMisVentas.Columns["colCliente"].DataPropertyName = "NombreCliente";
            dgvMisVentas.Columns["colMetodoPago"].DataPropertyName = "NombreMetodoPago";
            dgvMisVentas.Columns["colTipoAjuste"].DataPropertyName = "NombreTipoAjuste";
            dgvMisVentas.Columns["colFechaVenta"].DataPropertyName = "fecha_venta";
            dgvMisVentas.Columns["colTotal"].DataPropertyName = "SubtotalVenta";

            CNVenta objCNVenta = new CNVenta();

            // Validamos que haya un usuario logueado y filtramos por su ID
            if (SesionActual.UsuarioLogueado != null)
            {
                int idVendedorActual = SesionActual.UsuarioLogueado.usuario_id;

                // Llamamos al método
                var lista = objCNVenta.ListarHistorialVentasPorUsuario(idVendedorActual);



                // Asignamos los datos a la grilla
                dgvMisVentas.DataSource = objCNVenta.ListarHistorialVentasPorUsuario(idVendedorActual);
            }
        }
    }
}
