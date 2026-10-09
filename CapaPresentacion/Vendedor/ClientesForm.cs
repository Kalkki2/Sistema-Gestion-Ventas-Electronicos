using CapaEntidad;
using CapaNegocio;
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
        private readonly CNUsuario objCNUsuario = new CNUsuario();

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
           
        }



        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) ||
        !string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) ||
        !string.IsNullOrEmpty(errorProvider1.GetError(txtApellido)) ||
        !string.IsNullOrEmpty(errorProvider1.GetError(txtDni)) ||
        !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono)) ||
        !string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) ||
        string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtDni.Text) ||
        string.IsNullOrWhiteSpace(txtTelefono.Text) ||
        string.IsNullOrWhiteSpace(txtDireccion.Text) ||
        string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmación
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea registrar este nuevo cliente?",
                "Confirmar registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                // 3. Crear el objeto usuario/cliente con los datos de los TextBox
                EUsuario objCliente = new EUsuario();
                objCliente.nombre = txtNombre.Text.Trim();
                objCliente.apellido = txtApellido.Text.Trim();
                objCliente.dni = txtDni.Text.Trim();
                objCliente.telefono = txtTelefono.Text.Trim();
                objCliente.direccion = txtDireccion.Text.Trim();
                objCliente.email = txtCorreo.Text.Trim();

                // NUEVO: Asignar los campos obligatorios que CNUsuario exige por validación
                objCliente.contrasenia = "123456"; // Contraseña temporal por defecto
                objCliente.perfil_id = 2;          // ID de perfil correspondiente a clientes (ajústalo si tu BD usa otro número)

                // 4. Guardar usando la clase de negocio de usuarios
                string mensaje;
                bool operacionExitosa = objCNUsuario.Registrar(objCliente, out mensaje);

                if (operacionExitosa)
                {
                    MessageBox.Show("El cliente se registró con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaClientes(); // Refresca la grilla de la izquierda
                }
                else
                {
                    MessageBox.Show("No se pudo registrar: " + mensaje, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LimpiarCampos();
            }
        }
        
        
        
        

        //  Limpia los campos para un nuevo ingreso
       

        private void CargarGrillaClientes()
        {
            dgvListaClientes.AutoGenerateColumns = false;

            colNroCliente.DataPropertyName = "usuario_id";
            colDni.DataPropertyName = "dni";
            colNombre.DataPropertyName = "nombre";
            colApellido.DataPropertyName = "apellido";
            colCorreo.DataPropertyName = "email";
            colTelefono.DataPropertyName = "telefono";
            colDireccion.DataPropertyName = "direccion";

            dgvListaClientes.DataSource = objCNUsuario.Listar();
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
                errorProvider1.SetError(txtNombre, "El nombre  solo debe contener letras.");
            }
            else if (txtNombre.Text.Length < 3 || txtNombre.Text.Length > 40)
            {
                errorProvider1.SetError(txtNombre, "El nombre  debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

       /* private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtApellido.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtApellido, "El apellido solo debe contener letras.");
            }
            else if (txtApellido.Text.Length < 3 || txtApellido.Text.Length > 40)
            {
                errorProvider1.SetError(txtApellido, "El apellido  debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            string cuit = txtDni.Text.Trim();

            if (!ulong.TryParse(cuit, out _))
            {
                errorProvider1.SetError(txtDni, "El DNI solo debe contener números.");
            }
            else if (cuit.Length != 8)
            {
                errorProvider1.SetError(txtDni, "El DNI debe tener exactamente 8 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtDni, "");
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();

            if (!ulong.TryParse(telefono, out _))
            {
                errorProvider1.SetError(txtTelefono, "El TELEFONO solo debe contener números.");
            }
            else if (telefono.Length != 10)
            {
                errorProvider1.SetError(txtTelefono, "El TELEFONO debe tener exactamente 10 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDireccion.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9\\s]+$"))
            {
                errorProvider1.SetError(txtDireccion, "La dirección solo debe contener letras y números.");
            }
            else if (txtDireccion.Text.Length < 3 || txtDireccion.Text.Length > 40)
            {
                errorProvider1.SetError(txtDireccion, "La dirección debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
        }*/

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
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo electrónico válido (ej: usuario@dominio.com).");
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtApellido)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDni)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono))
                || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Permite letras, espacios y la tecla de borrar(BackSpace)*/
             if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Permite letras, espacios y la tecla de borrar(BackSpace)*/
             if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y la tecla de borrar (BackSpace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla si no es un número
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y la tecla de borrar (BackSpace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla si no es un número
            }
        }
    }
}