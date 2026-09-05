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

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreComercial.Text) || string.IsNullOrWhiteSpace(txtRazonSocial.Text) || string.IsNullOrWhiteSpace(txtCuit.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Debe completar todos los campos de texto obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que se haya seleccionado una opción en los ComboBox
            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opción en todas las listas desplegables (Estado).", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            cmbEstado.SelectedIndex = -1;

            txtNombreComercial.Focus(); // Regresa el cursor al primer campo
        }
    }
}
