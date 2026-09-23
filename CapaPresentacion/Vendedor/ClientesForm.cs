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

namespace CapaPresentacion.Vendedor
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void dgvListaCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se hizo clic en una fila válida (evita errores si hacen clic en los encabezados)
            // y comprobar que la columna clickeada es la de nuestro botón ("btnAccion")
            if (e.RowIndex >= 0 && dgvListaCompras.Columns[e.ColumnIndex].Name == "colDetallesCompras")
            {
                // Instanciar y abrir el formulario modal
                using (DetalleCompra modal = new DetalleCompra())
                {
                    // Mostrar el formulario como modal (bloquea la ventana principal hasta que se cierre)
                    DialogResult resultado = modal.ShowDialog();
                }
            }
    }

        

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtApellido)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDni)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) ||  string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text) ||
               string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea registrar este nuevo cliente?",
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
            MessageBox.Show("El cliente se registro con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtCorreo.Clear();


            txtNombre.Focus(); // Regresa el cursor al primer campo
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras.");
            }
            else if (txtNombre.Text.Length < 3 || txtNombre.Text.Length > 15)
            {
                errorProvider1.SetError(txtNombre, "El nombre debe tener entre 3 y 15 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtApellido.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtApellido, "El apellido solo debe contener letras.");
            }
            else if (txtApellido.Text.Length < 3 || txtApellido.Text.Length > 20)
            {
                errorProvider1.SetError(txtApellido, "El apellido debe tener entre 3 y 15 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtDni.Text, out int stock))
            {
                errorProvider1.SetError(txtDni, "El DNI solo debe contener Numeros.");
            }
            else if (txtDni.Text.Length <= 11)
            {
                errorProvider1.SetError(txtDni, "El DNI debe tener 11 caracteres");
            }
            else
            {
                errorProvider1.SetError(txtDni, "");
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
            else if (txtApellido.Text.Length < 3 || txtDireccion.Text.Length > 30)
            {
                errorProvider1.SetError(txtDireccion, "La direccion debe tener entre 3 y 30 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtNombre.Focus(); 
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtCorreo.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtCorreo, "El correo solo debe contener letras.");
            }
            else if (txtCorreo.Text.Length < 3 || txtCorreo.Text.Length > 30)
            {
                errorProvider1.SetError(txtCorreo, "Correo debe tener entre 3 y 30 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}