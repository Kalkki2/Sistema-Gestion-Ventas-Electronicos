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

namespace CapaPresentacion.Administrador
{
    public partial class GestionClientesForm : Form
    {
        CNCliente objCNCliente = new CNCliente();
        int idClienteSeleccionado = 0; // Para saber qué cliente estamos editando
        public GestionClientesForm()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cmbEstado.SelectedIndex = 0;

            txtNombre.Focus(); // Regresa el cursor al primer campo
        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado un cliente de la grilla (idClienteSeleccionado debe ser mayor a 0)
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista haciendo clic en el icono de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que los TextBox no tengan errores de formato del ErrorProvider o estén vacíos
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtApellido)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtDni)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono)) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de actualizar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Confirmación previa del usuario
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios de este cliente?",
                "Confirmar actualización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            // 4. Creamos el objeto ECliente con los datos actualizados de los textbox
            ECliente objCliente = new ECliente()
            {
                cliente_id = idClienteSeleccionado,
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                dni = txtDni.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                email = txtCorreo.Text.Trim(),
                direccion = txtDireccion.Text.Trim(),
                estado = cmbEstado.SelectedIndex == 0 ? 1 : 0
            };

            // 5. Ejecutamos el método Editar de la capa de negocio
            string mensaje = string.Empty;
            bool resultado = objCNCliente.Editar(objCliente, out mensaje);

            if (resultado)
            {
                MessageBox.Show("El cliente se actualizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();     // Recargamos la grilla para reflejar los cambios
                LimpiarCampos();      // Limpiamos las cajas de texto y reseteamos el idClienteSeleccionado
            }
            else
            {
                // Aquí capturamos el mensaje de la base de datos si el DNI, Correo o Teléfono ya están repetidos
                MessageBox.Show(mensaje, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtApellido.Text) && string.IsNullOrWhiteSpace(txtDni.Text) &&
               string.IsNullOrWhiteSpace(txtTelefono.Text) && string.IsNullOrWhiteSpace(txtDireccion.Text)  && cmbEstado.SelectedIndex == -1)
            {
                // Si no hay nada escrito en los campos
                MessageBox.Show("No hay nada cargado para cancear/limpiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
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

        private void GestionClientesForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarClientes();
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

        private void txtApellido_Validating(object sender, CancelEventArgs e)
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
        }

        private void CargarClientes(string filtro = "")
        {
            dgvListaClientes.AutoGenerateColumns = false;

            // Mapeo de columnas del primer DataGridView (Lista de clientes)
            dgvListaClientes.Columns["colDni"].DataPropertyName = "dni";
            dgvListaClientes.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaClientes.Columns["colApellido"].DataPropertyName = "apellido";
            dgvListaClientes.Columns["colTelefono"].DataPropertyName = "telefono";
            dgvListaClientes.Columns["colCorreo"].DataPropertyName = "email";
            dgvListaClientes.Columns["colDireccion"].DataPropertyName = "direccion";
            dgvListaClientes.Columns["colEstado"].DataPropertyName = "EstadoTexto";
            dgvListaClientes.Columns["colFechaAlta"].DataPropertyName = "fecha_alta";
            dgvListaClientes.Columns["colFechaModificacion"].DataPropertyName = "fecha_ultima_modificacion";

            dgvListaClientes.DataSource = objCNCliente.Listar(filtro);
        }

        private void dgvListaClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvListaClientes.NewRowIndex) return;

            string colName = dg_GetColumnName(e.ColumnIndex); // Método seguro o lectura directa

            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "colEditar")
            {
                e.Value = Properties.Resources.icono_editar;
            }
            else if (dgvListaClientes.Columns[e.ColumnIndex].Name == "colEliminar" || dgvListaClientes.Columns[e.ColumnIndex].Name == "colCambiarEstado")
            {
                var clienteRow = dgvListaClientes.Rows[e.RowIndex].DataBoundItem as ECliente;
                if (clienteRow != null)
                {
                    e.Value = clienteRow.estado == 1 ? Properties.Resources.icono_eliminar : Properties.Resources.icono_reactivar;
                }
            }
            else if (dgvListaClientes.Columns[e.ColumnIndex].Name == "colVer")
            {
                e.Value = Properties.Resources.icono_lupa; // O tu recurso para ver compras
            }
        }

        private string dg_GetColumnName(int colIndex)
        {
            return dgvListaClientes.Columns[colIndex].Name;
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvListaClientes.Columns[e.ColumnIndex].Name;
            ECliente clienteSeleccionado = dgvListaClientes.Rows[e.RowIndex].DataBoundItem as ECliente;

            if (clienteSeleccionado == null) return;

            // EDITAR: Carga los datos arriba en los TextBox
            if (colName == "colEditar")
            {
                idClienteSeleccionado = clienteSeleccionado.cliente_id;
                txtNombre.Text = clienteSeleccionado.nombre;
                txtApellido.Text = clienteSeleccionado.apellido;
                txtDni.Text = clienteSeleccionado.dni;
                txtTelefono.Text = clienteSeleccionado.telefono;
                txtCorreo.Text = clienteSeleccionado.email;
                txtDireccion.Text = clienteSeleccionado.direccion;
                cmbEstado.SelectedIndex = clienteSeleccionado.estado == 1 ? 0 : 1;

                btnActualizarClientes.Text = "Guardar Cambios";
            }

            // CAMBIAR ESTADO (Activar / Desactivar)
            if (colName == "colEliminar")
            {
                int nuevoEstado = clienteSeleccionado.estado == 1 ? 0 : 1;
                string accion = clienteSeleccionado.estado == 1 ? "desactivar" : "reactivar";

                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de que desea {accion} al cliente {clienteSeleccionado.apellido}, {clienteSeleccionado.nombre}?",
                    $"Confirmar {accion}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    bool respuesta = objCNCliente.CambiarEstado(clienteSeleccionado.cliente_id, nuevoEstado, out mensaje);

                    if (respuesta)
                    {
                        MessageBox.Show($"Cliente {accion}do con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar el estado: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // VER COMPRAS: Abre el Modal con las compras de este cliente
            if (colName == "colVerCompras")
            {
                using (ListaCompraClientesForm modal = new ListaCompraClientesForm(clienteSeleccionado))
                {
                    modal.ShowDialog();
                }
            }
        }
    }
}
