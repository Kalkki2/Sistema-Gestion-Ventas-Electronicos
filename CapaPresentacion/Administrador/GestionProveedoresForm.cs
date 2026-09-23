using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtRazonSocial)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtCuit)) || string.IsNullOrWhiteSpace(txtNombreComercial.Text) || string.IsNullOrWhiteSpace(txtRazonSocial.Text) || string.IsNullOrWhiteSpace(txtCuit.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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



        private void txtNombreComercial_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNombreComercial.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtNombreComercial, "El nombre comercial solo debe contener letras.");
            }
            else if (txtNombreComercial.Text.Length < 3 || txtNombreComercial.Text.Length > 50)
            {
                errorProvider1.SetError(txtNombreComercial, "El nombre debe tener entre 3 y 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtNombreComercial, "");
            }
        }

        private void txtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtRazonSocial.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtRazonSocial, "La razon social solo debe contener letras.");
            }
            else if (txtRazonSocial.Text.Length < 3 || txtRazonSocial.Text.Length > 50)
            {
                errorProvider1.SetError(txtRazonSocial, "La razon social debe tener entre 3 y 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtRazonSocial, "");
            }
        }

        private void txtCuit_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtCuit.Text, out int stock))
            {
                errorProvider1.SetError(txtCuit, "El CUIT solo debe contener Numeros.");
            }
            else if (txtCuit.Text.Length <= 11)
            {
                errorProvider1.SetError(txtCuit, "El CUIT debe tener 11 caracteres");
            }
            else
            {
                errorProvider1.SetError(txtCuit, "");
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
             if (txtCorreo.Text.Length < 10 || txtCorreo.Text.Length > 30)
            {
                errorProvider1.SetError(txtCorreo, "El correo debe tener entre 10 y 30 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtTelefono.Text, out int stock))
            {
                errorProvider1.SetError(txtTelefono, "El Telefono solo debe contener Numeros.");
            }
            else if (txtTelefono.Text.Length <= 11)
            {
                errorProvider1.SetError(txtTelefono, "El Telefono debe tener 11 caracteres");
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDireccion.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtDireccion, "La direccion solo debe contener letras.");
            }
            else if (txtDireccion.Text.Length < 3 || txtDireccion.Text.Length > 50)
            {
                errorProvider1.SetError(txtDireccion, "La direcion debe tener entre 3 y 50 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
        }

        private void GestionProveedoresForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
        }
    }
}
