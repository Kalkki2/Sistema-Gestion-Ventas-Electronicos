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
        private readonly CNCliente objCNCliente = new CNCliente();

        // Id del cliente que se está editando (0 = no se está editando ninguno)
        private int clienteSeleccionadoId = 0;

        public ClientesForm()
        {
            InitializeComponent();
            dgvListaClientes.CellContentClick += dgvListaClientes_CellContentClick;
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

        // Botón Editar de la grilla de clientes: pasa los datos del cliente al formulario
        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvListaClientes.Columns[e.ColumnIndex].Name != "colEditar") return;

            ECliente cliente = dgvListaClientes.Rows[e.RowIndex].DataBoundItem as ECliente;
            if (cliente == null) return;

            clienteSeleccionadoId = cliente.cliente_id;
            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            txtDni.Text = cliente.dni;
            txtTelefono.Text = cliente.telefono;
            txtDireccion.Text = cliente.direccion;
            txtCorreo.Text = cliente.email;

            // Se limpian los avisos de error que pudieran haber quedado de antes
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDni, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtCorreo, "");

            txtNombre.Focus();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            CargarGrillaClientes(txtBuscarCliente.Text.Trim());
        }

        // Busca mientras se escribe
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaClientes(txtBuscarCliente.Text.Trim());
        }



        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId != 0)
            {
                MessageBox.Show("Está editando un cliente. Use el botón Actualizar para guardar los cambios o Cancelar para salir de la edición.", "Edición en curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                // 3. Crear el objeto cliente con los datos de los TextBox
                ECliente objCliente = new ECliente();
                objCliente.nombre = txtNombre.Text.Trim();
                objCliente.apellido = txtApellido.Text.Trim();
                objCliente.dni = txtDni.Text.Trim();
                objCliente.telefono = txtTelefono.Text.Trim();
                objCliente.direccion = txtDireccion.Text.Trim();
                objCliente.email = txtCorreo.Text.Trim();

                // 4. Guardar usando la clase de negocio de clientes (tabla cliente)
                string mensaje;
                bool operacionExitosa = objCNCliente.Registrar(objCliente, out mensaje);

                if (operacionExitosa)
                {
                    MessageBox.Show("El cliente se registró con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaClientes(txtBuscarCliente.Text.Trim()); // Refresca la grilla de la izquierda
                    LimpiarCampos();                                    // Solo se limpia si se guardó bien
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
        }





        //  Limpia los campos para un nuevo ingreso


        private void CargarGrillaClientes(string filtro = "")
        {
            dgvListaClientes.AutoGenerateColumns = false;

            colNroCliente.DataPropertyName = "cliente_id";
            colDni.DataPropertyName = "dni";
            colNombre.DataPropertyName = "nombre";
            colApellido.DataPropertyName = "apellido";
            colCorreo.DataPropertyName = "email";
            colTelefono.DataPropertyName = "telefono";
            colDireccion.DataPropertyName = "direccion";

            dgvListaClientes.DataSource = null;
            dgvListaClientes.DataSource = objCNCliente.Listar(filtro);
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();

            clienteSeleccionadoId = 0; // Sale del modo edición

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
            CargarGrillaClientes();
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

        // Guarda los cambios del cliente elegido con el botón Editar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionadoId == 0)
            {
                MessageBox.Show("Primero elija un cliente con el botón Editar de la lista.", "Sin cliente elegido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Valida que los TextBox no estén vacíos
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtApellido)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDni)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono))
                || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de actualizar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea actualizar los datos de este cliente?",
                "Confirmar actualizacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario responde 'No', cancelamos la operación
            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                ECliente objCliente = new ECliente
                {
                    cliente_id = clienteSeleccionadoId,
                    nombre = txtNombre.Text.Trim(),
                    apellido = txtApellido.Text.Trim(),
                    dni = txtDni.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    direccion = txtDireccion.Text.Trim(),
                    email = txtCorreo.Text.Trim()
                };

                string mensaje;
                bool operacionExitosa = objCNCliente.Editar(objCliente, out mensaje);

                if (operacionExitosa)
                {
                    MessageBox.Show("El cliente se actualizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaClientes(txtBuscarCliente.Text.Trim());
                    LimpiarCampos(); // Limpia los campos y sale del modo edición
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar: " + mensaje, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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