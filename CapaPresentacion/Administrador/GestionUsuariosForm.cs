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
    public partial class GestionUsuariosForm : Form
    {
        public GestionUsuariosForm()
        {
            InitializeComponent();
        }

       

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtContrasenia.Clear();
            txtRepetirContrasenia.Clear();

            // Deseleccionar los ComboBoxes (vuelven a quedar en blanco)
            
            cmbPerfil.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            txtNombre.Focus(); // Regresa el cursor al primer campo
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text) || string.IsNullOrWhiteSpace(txtRepetirContrasenia.Text))
            {
                MessageBox.Show("Debe completar todos los campos de texto obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que se haya seleccionado una opción en los ComboBox
            if (cmbEstado.SelectedIndex == -1 || cmbPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opción en todas las listas desplegables (Estado, Perfil).", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea registrar este nuevo usuario?",
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
            MessageBox.Show("El usuario se registró con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Limpia los campos para un nuevo ingreso
            LimpiarCampos();
        }
    }
}
