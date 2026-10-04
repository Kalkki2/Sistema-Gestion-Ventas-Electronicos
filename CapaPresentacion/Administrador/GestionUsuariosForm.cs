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
    public partial class GestionUsuariosForm : Form
    {
        private CNUsuario objCNUsuario = new CNUsuario();
        private CNPerfil objCNPerfil = new CNPerfil();
        private int idUsuarioSeleccionado = 0;
        public GestionUsuariosForm()
        {
            InitializeComponent();
        }



        private void LimpiarCampos()
        {
            idUsuarioSeleccionado = 0; // Reinicia la selección
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtContrasenia.Clear();

            cmbPerfil.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            btnAgregarUsuario.Text = "Agregar"; // Vuelve a su estado inicial
            txtNombre.Focus();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // 1. Validaciones de campos
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtApellido)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDni)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono)) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de agregar.", "Campos vacíos o con error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEstado.SelectedIndex == -1 || cmbPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar Estado y Perfil.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Mapeo del objeto
            OpcionCombo estadoSeleccionado = (OpcionCombo)cmbEstado.SelectedItem;

            EUsuario oUsuario = new EUsuario()
            {
                usuario_id = idUsuarioSeleccionado,
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                dni = txtDni.Text.Trim(),
                email = txtCorreo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                direccion = txtDireccion.Text.Trim(),
                contrasenia = txtContrasenia.Text.Trim(),
                estado = Convert.ToInt32(estadoSeleccionado.Valor), // Cambiado a int (1 o 0)
                perfil_id = Convert.ToInt32(cmbPerfil.SelectedValue)
            };

            string mensaje = string.Empty;
            bool resultado = false;

            // 3. Evaluar si es Registro Nuevo o Actualización
            if (idUsuarioSeleccionado == 0)
            {
                // NUEVO
                DialogResult confirmacion = MessageBox.Show("¿Desea registrar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                resultado = objCNUsuario.Registrar(oUsuario, out mensaje);
            }
            else
            {
                // EDITAR / ACTUALIZAR
                DialogResult confirmacion = MessageBox.Show("¿Desea actualizar los datos de este usuario?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                resultado = objCNUsuario.Editar(oUsuario, out mensaje);
            }

            // 4. Respuesta
            if (resultado)
            {
                MessageBox.Show(idUsuarioSeleccionado == 0 ? "Usuario registrado con éxito." : "Usuario actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtApellido.Text) && string.IsNullOrWhiteSpace(txtDni.Text) && string.IsNullOrWhiteSpace(txtCorreo.Text) &&
                string.IsNullOrWhiteSpace(txtTelefono.Text) && string.IsNullOrWhiteSpace(txtDireccion.Text) && string.IsNullOrWhiteSpace(txtContrasenia.Text) && cmbEstado.SelectedIndex == -1 && cmbPerfil.SelectedIndex == -1)
            {
                // Si no hay nada escrito en los campos
                MessageBox.Show("No hay nada cargado para cancear/limpiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
            }

        }

        private void GestionUsuariosForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
            CargarUsuarios();
            CargarCmbPerfil();
            CargarCmbEstado();
            CargarFiltros();
        }
        private void CargarUsuarios()
        {
            // 1. Desactivar la generación automática de columnas
            dgvListaUsuarios.AutoGenerateColumns = false;

            // 2. Mapear las columnas creadas en el Diseñador con las propiedades de EUsuario
            dgvListaUsuarios.Columns["colDNI"].DataPropertyName = "dni";
            dgvListaUsuarios.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaUsuarios.Columns["colApellido"].DataPropertyName = "apellido";
            dgvListaUsuarios.Columns["colCorreo"].DataPropertyName = "email"; // Actualizado a email
            dgvListaUsuarios.Columns["colTelefono"].DataPropertyName = "telefono";
            dgvListaUsuarios.Columns["colDireccion"].DataPropertyName = "direccion";
            dgvListaUsuarios.Columns["colPerfil"].DataPropertyName = "NombrePerfil";
            dgvListaUsuarios.Columns["colEstado"].DataPropertyName = "EstadoTexto";
            dgvListaUsuarios.Columns["colFechaAlta"].DataPropertyName = "fecha_alta"; // Actualizado a fecha_alta

            // 3. Obtener la lista mapeada desde la Capa de Negocio
            var lista = objCNUsuario.Listar();

            // 4. Llenar el DataGridView y actualizar la tarjeta de total
            dgvListaUsuarios.DataSource = lista;
            lblCantTotalUsuarios.Text = lista.Count.ToString();
        }

        private void dgvListaUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvListaUsuarios.NewRowIndex) return;

            string colName = dgvListaUsuarios.Columns[e.ColumnIndex].Name;

            if (colName == "colEditar")
            {
                e.Value = Properties.Resources.icono_editar;
            }

            if (colName == "colEliminar")
            {
                var usuarioRow = dgvListaUsuarios.Rows[e.RowIndex].DataBoundItem as EUsuario;

                if (usuarioRow != null)
                {
                    // Evaluamos si estado == 1 (Activo)
                    if (usuarioRow.estado == 1)
                    {
                        e.Value = Properties.Resources.icono_eliminar;
                    }
                    else
                    {
                        e.Value = Properties.Resources.icono_reactivar;
                    }
                }
            }
        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvListaUsuarios.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "colEditar")
            {
                var usuario = dgvListaUsuarios.Rows[e.RowIndex].DataBoundItem as EUsuario;

                if (usuario != null)
                {
                    idUsuarioSeleccionado = usuario.usuario_id;

                    // 1. DESVINCULAR temporalmente los eventos Validating
                    txtNombre.Validating -= txtNombre_Validating;
                    txtApellido.Validating -= txtApellido_Validating;
                    txtDni.Validating -= txtDni_Validating;
                    txtCorreo.Validating -= txtCorreo_Validating;
                    txtTelefono.Validating -= txtTelefono_Validating;
                    txtDireccion.Validating -= txtDireccion_Validating;
                    txtContrasenia.Validating -= txtContrasenia_Validating;

                    // 2. Cargar datos en las cajas de texto
                    txtNombre.Text = usuario.nombre;
                    txtApellido.Text = usuario.apellido;
                    txtDni.Text = usuario.dni;
                    txtCorreo.Text = usuario.email; // Actualizado a email
                    txtTelefono.Text = usuario.telefono;
                    txtDireccion.Text = usuario.direccion;
                    txtContrasenia.Text = usuario.contrasenia;

                    // Seleccionar valor en ComboBox Perfil
                    cmbPerfil.SelectedValue = usuario.perfil_id;

                    // Seleccionar valor en ComboBox Estado (comparando con int)
                    foreach (OpcionCombo item in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(item.Valor) == usuario.estado)
                        {
                            cmbEstado.SelectedItem = item;
                            break;
                        }
                    }

                    // 3. VINCULAR NUEVAMENTE los eventos Validating
                    txtNombre.Validating += txtNombre_Validating;
                    txtApellido.Validating += txtApellido_Validating;
                    txtDni.Validating += txtDni_Validating;
                    txtCorreo.Validating += txtCorreo_Validating;
                    txtTelefono.Validating += txtTelefono_Validating;
                    txtDireccion.Validating += txtDireccion_Validating;
                    txtContrasenia.Validating += txtContrasenia_Validating;

                    errorProvider1.Clear();
                    btnAgregarUsuario.Text = "Actualizar";
                }
            }

            if (nombreColumna == "colEliminar")
            {
                var usuarioSeleccionado = dgvListaUsuarios.Rows[e.RowIndex].DataBoundItem as EUsuario;

                if (usuarioSeleccionado != null)
                {
                    int estadoActual = usuarioSeleccionado.estado; // 1 o 0
                    int nuevoEstado = (estadoActual == 1) ? 0 : 1;   // Invierte el estado

                    string accion = (estadoActual == 1) ? "desactivar" : "reactivar";
                    string titulo = (estadoActual == 1) ? "Desactivar Usuario" : "Reactivar Usuario";

                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} al usuario {usuarioSeleccionado.nombre} {usuarioSeleccionado.apellido}?",
                        titulo,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        bool respuesta = objCNUsuario.CambiarEstado(usuarioSeleccionado.usuario_id, nuevoEstado);

                        if (respuesta)
                        {
                            MessageBox.Show($"Usuario {accion}do con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cambiar el estado del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void CargarCmbPerfil()
        {
            List<EPerfil> listaPerfiles = objCNPerfil.Listar();
            cmbPerfil.ValueMember = "perfil_id";
            cmbPerfil.DisplayMember = "nombre";
            cmbPerfil.DataSource = listaPerfiles;
            cmbPerfil.SelectedIndex = -1;
        }

        private void CargarCmbEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });   // Valor int 1
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 }); // Valor int 0
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = -1;
        }

        public class OpcionCombo
        {
            public string Texto { get; set; }
            public object Valor { get; set; }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string busqueda = txtBuscarUsuario.Text.Trim();
            var resultados = objCNUsuario.Buscar(busqueda);

            dgvListaUsuarios.DataSource = resultados;
            lblCantTotalUsuarios.Text = resultados.Count.ToString();

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
        }

        private void btnFiltrarUsuario_Click(object sender, EventArgs e)
        {
            if (cmbFiltroEstado.SelectedIndex == -1 || cmbFiltroPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar Estado o Perfil para filtrar", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idPerfilSeleccionado = null;
            int? estadoSeleccionado = null; // Cambiado a int?

            if (cmbFiltroPerfil.SelectedValue != null)
            {
                int idPerfil = Convert.ToInt32(cmbFiltroPerfil.SelectedValue);
                if (idPerfil > 0)
                {
                    idPerfilSeleccionado = idPerfil;
                }
            }

            if (cmbFiltroEstado.SelectedItem != null)
            {
                OpcionCombo opcionEstado = (OpcionCombo)cmbFiltroEstado.SelectedItem;
                if (opcionEstado.Valor != null)
                {
                    estadoSeleccionado = Convert.ToInt32(opcionEstado.Valor);
                }
            }

            var usuariosFiltrados = objCNUsuario.Filtrar(idPerfilSeleccionado, estadoSeleccionado);

            dgvListaUsuarios.DataSource = usuariosFiltrados;
            lblCantTotalUsuarios.Text = usuariosFiltrados.Count.ToString();

            if (usuariosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios con los criterios de búsqueda seleccionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CargarFiltros()
        {
            List<EPerfil> listaPerfiles = objCNPerfil.Listar();
            listaPerfiles.Insert(0, new EPerfil { perfil_id = 0, nombre = "Todos" });

            cmbFiltroPerfil.DataSource = listaPerfiles;
            cmbFiltroPerfil.DisplayMember = "nombre";
            cmbFiltroPerfil.ValueMember = "perfil_id";
            cmbFiltroPerfil.SelectedIndex = 0;

            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = null });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });   // int 1
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 }); // int 0

            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0;
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

        private void txtContrasenia_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtContrasenia.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9\\s]+$"))
            {
                errorProvider1.SetError(txtContrasenia, "La contraseña solo debe contener letras y números.");
            }
            else if (txtContrasenia.Text.Length < 3 || txtContrasenia.Text.Length > 40)
            {
                errorProvider1.SetError(txtContrasenia, "La contraseña debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtContrasenia, "");
            }
        }
    }
    }

