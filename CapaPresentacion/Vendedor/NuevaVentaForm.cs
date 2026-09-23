using CapaPresentacion.Administrador;
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
    public partial class NuevaVentaForm : Form
    {
        public NuevaVentaForm()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoForm frm = new BuscarProductoForm();
            frm.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClienteForm frm = new BuscarClienteForm();
            frm.ShowDialog();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            ConfirmacionVentaForm frm = new ConfirmacionVentaForm();
            frm.ShowDialog();
        }

        private void btnAgregarItemVenta_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNomYApeCliente.Text) || string.IsNullOrWhiteSpace(txtDniCliente.Text) || string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidadCompra.Text))
            {
                MessageBox.Show("Debe completar todos los campos de texto obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea agregar este nuevo item?",
                "Confirmar registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario responde 'No', cancelamos la operación
            if (respuesta == DialogResult.No)
            {
                return;
            }

            // Mensaje de éxito
            MessageBox.Show("El item  se cargo con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Limpia los campos para un nuevo ingreso
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNomYApeCliente.Clear();
            txtDniCliente.Clear();
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            
        }

        private void txtCantidadCompra_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidadCompra.Value <= 0)
            {
                errorProvider1.SetError(txtCantidadCompra, "El valor debe ser mayor a 0.");
            }
            else
            {
                errorProvider1.SetError(txtCantidadCompra, "");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidadCompra.Value = 0;
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea Cancelar la venta?",
                "Confirmar cancelaciion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario responde 'No', cancelamos la operación
            if (respuesta == DialogResult.No)
            {
                return;
            }

            // Mensaje de éxito
            MessageBox.Show("La venta se cancelo con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Limpia los campos para un nuevo ingreso
            LimpiarCampos();
        }

        private void NuevaVentaForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
        }
    }
}
