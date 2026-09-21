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
    public partial class GestionProveedoresForm : Form
    {
        public GestionProveedoresForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreComercial.Text) && string.IsNullOrWhiteSpace(txtRazonSocial.Text) && string.IsNullOrWhiteSpace(txtCuit.Text) &&
               string.IsNullOrWhiteSpace(txtTelefono.Text) && string.IsNullOrWhiteSpace(txtDireccion.Text) && string.IsNullOrWhiteSpace(txtCorreo.Text) && cmbEstado.SelectedIndex == -1)
            {
                // Si no hay nada escrito en los campos
                MessageBox.Show("No hay nada cargado para cancear/limpiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreComercial.Text) || string.IsNullOrWhiteSpace(txtRazonSocial.Text) || string.IsNullOrWhiteSpace(txtCuit.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Debe completar todos los campos de texto obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea registrar este nuevo proveedor?",
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
            MessageBox.Show("El proveedor se registró con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Limpia los campos para un nuevo ingreso
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreComercial.Clear();
            txtRazonSocial.Clear();
            txtCuit.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            // Deseleccionar los ComboBoxes (vuelven a quedar en blanco)
            cmbEstado.SelectedIndex = 0;

            txtNombreComercial.Focus(); // Regresa el cursor al primer campo
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProveedor.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
