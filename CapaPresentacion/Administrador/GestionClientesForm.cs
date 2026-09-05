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
    public partial class GestionClientesForm : Form
    {
        public GestionClientesForm()
        {
            InitializeComponent();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) )
            {
                MessageBox.Show("Debe completar todos los campos de texto obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea actualizar este nuevo cliente?",
                "Confirmar actualizacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario responde 'No', cancelamos la operación
            if (respuesta == DialogResult.No)
            {
                return;
            }

            // Mensaje de éxito
            MessageBox.Show("El cliente se actualizo con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Limpia los campos para un nuevo ingreso
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();


            txtNombre.Focus(); // Regresa el cursor al primer campo
        }
    }
}
