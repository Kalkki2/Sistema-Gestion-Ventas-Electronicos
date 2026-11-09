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
        private bool cargandoFormulario = true;
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
            txtCorreo.Clear();
            txtDireccion.Clear();
            cmbEstado.SelectedIndex = 0;

            errorProvider1.Clear(); 
            idClienteSeleccionado = 0; 
            btnActualizarClientes.Text = "Actualizar"; 

            txtNombre.Focus(); 
        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            //  Validar que se haya seleccionado un cliente de la grilla
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista haciendo clic en el icono de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ejecutar las validaciones de formato y longitud
            if (!ValidarCamposCliente())
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de actualizar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Confirmación previa del usuario
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios de este cliente?",
                "Confirmar actualización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            // Creamos el objeto ECliente con los datos actualizados de los textbox
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

            // Ejecutamos el método Editar de la capa de negocio
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

        private void GestionClientesForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarFiltroEstado(); 

            cargandoFormulario = false; 
            FiltrarClientes();
        }

      
        private void CargarClientes(string filtro = "")
        {
            if (!string.IsNullOrEmpty(filtro))
            {
                txtBuscarCliente.Text = filtro;
            }
            FiltrarClientes();
        }

        private void FiltrarClientes()
        {
            if (cargandoFormulario) return;

            string valorBusqueda = txtBuscarCliente.Text.Trim();

            int estadoId = -1;
            if (cmbFiltroEstado.SelectedItem is OpcionCombo opcionSeleccionada)
            {
                estadoId = Convert.ToInt32(opcionSeleccionada.Valor);
            }

            dgvListaClientes.AutoGenerateColumns = false;

            // Mapeo de columnas
            dgvListaClientes.Columns["colDni"].DataPropertyName = "dni";
            dgvListaClientes.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaClientes.Columns["colApellido"].DataPropertyName = "apellido";
            dgvListaClientes.Columns["colTelefono"].DataPropertyName = "telefono";
            dgvListaClientes.Columns["colCorreo"].DataPropertyName = "email";
            dgvListaClientes.Columns["colDireccion"].DataPropertyName = "direccion";
            dgvListaClientes.Columns["colEstado"].DataPropertyName = "EstadoTexto";
            dgvListaClientes.Columns["colFechaAlta"].DataPropertyName = "fecha_alta";
            dgvListaClientes.Columns["colFechaModificacion"].DataPropertyName = "fecha_ultima_modificacion";

            var listaFiltrada = objCNCliente.Buscar(valorBusqueda, estadoId);

            dgvListaClientes.DataSource = listaFiltrada;
            lblCantTotalClientes.Text = listaFiltrada.Count.ToString();

        }

        private void CargarFiltroEstado()
        {
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = -1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Activos", Valor = 1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Inactivos", Valor = 0 });
            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0;
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
            else if (dgvListaClientes.Columns[e.ColumnIndex].Name == "colVerCompras")
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

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private bool ValidarCamposCliente()
        {
            bool esValido = true;
            errorProvider1.Clear(); // Limpia errores anteriores

            // Validar Nombre (Obligatorio, solo letras, más de 5 caracteres)
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras.");
                esValido = false;
            }
            else if (nombre.Length <= 5)
            {
                errorProvider1.SetError(txtNombre, "El nombre debe tener más de 5 caracteres.");
                esValido = false;
            }

            // Validar Apellido (Obligatorio, solo letras, más de 5 caracteres)
            string apellido = txtApellido.Text.Trim();
            if (string.IsNullOrWhiteSpace(apellido))
            {
                errorProvider1.SetError(txtApellido, "El apellido es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtApellido, "El apellido solo debe contener letras.");
                esValido = false;
            }
            else if (apellido.Length <= 5)
            {
                errorProvider1.SetError(txtApellido, "El apellido debe tener más de 5 caracteres.");
                esValido = false;
            }

            //  Validar DNI (Obligatorio, numérico, exactamente 8 caracteres)
            string dni = txtDni.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                errorProvider1.SetError(txtDni, "El DNI es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(dni, @"^\d{8}$"))
            {
                errorProvider1.SetError(txtDni, "El DNI debe ser numérico y tener exactamente 8 caracteres.");
                esValido = false;
            }

            // Validar Teléfono (Obligatorio, numérico, exactamente 10 dígitos)
            string telefono = txtTelefono.Text.Trim();
            if (string.IsNullOrWhiteSpace(telefono))
            {
                errorProvider1.SetError(txtTelefono, "El teléfono es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(telefono, @"^\d{10}$"))
            {
                errorProvider1.SetError(txtTelefono, "El teléfono debe ser numérico y tener exactamente 10 dígitos.");
                esValido = false;
            }

            //  Validar Correo (Obligatorio, más de 10 caracteres, formato válido)
            string correo = txtCorreo.Text.Trim();
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(correo))
            {
                errorProvider1.SetError(txtCorreo, "El correo electrónico es obligatorio.");
                esValido = false;
            }
            else if (correo.Length <= 10)
            {
                errorProvider1.SetError(txtCorreo, "El correo debe tener más de 10 caracteres.");
                esValido = false;
            }
            else if (!Regex.IsMatch(correo, patronCorreo))
            {
                errorProvider1.SetError(txtCorreo, "Correo inválido. Ejemplo: usuario@dominio.com");
                esValido = false;
            }

            //  Validar Dirección (Obligatorio, más de 10 caracteres)
            string direccion = txtDireccion.Text.Trim();
            if (string.IsNullOrWhiteSpace(direccion))
            {
                errorProvider1.SetError(txtDireccion, "La dirección es obligatoria.");
                esValido = false;
            }
            else if (direccion.Length <= 10)
            {
                errorProvider1.SetError(txtDireccion, "La dirección debe tener más de 10 caracteres.");
                esValido = false;
            }

            //  Validar ComboBox de Estado (Obligatorio)
            if (cmbEstado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;
        }
    }
}
