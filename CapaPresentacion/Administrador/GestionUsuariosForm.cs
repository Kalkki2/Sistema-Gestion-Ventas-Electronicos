using CapaEntidad;
using CapaNegocio;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int idUsuarioEdicion = 0;
        private bool cargandoFormulario = true;
        public GestionUsuariosForm()
        {
            InitializeComponent();
        }


        private void GestionUsuariosForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null){
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre; 
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarUsuarios();
            CargarCombosFormulario();
            CargarFiltros();
            cargandoFormulario = false;
        }
        private void CargarUsuarios()
        {
            dgvListaUsuarios.AutoGenerateColumns = false;

            dgvListaUsuarios.Columns["colDNI"].DataPropertyName = "dni";
            dgvListaUsuarios.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaUsuarios.Columns["colApellido"].DataPropertyName = "apellido";
            dgvListaUsuarios.Columns["colCorreo"].DataPropertyName = "email"; 
            dgvListaUsuarios.Columns["colTelefono"].DataPropertyName = "telefono";
            dgvListaUsuarios.Columns["colDireccion"].DataPropertyName = "direccion";
            dgvListaUsuarios.Columns["colPerfil"].DataPropertyName = "NombrePerfil";
            dgvListaUsuarios.Columns["colEstado"].DataPropertyName = "EstadoTexto";
            dgvListaUsuarios.Columns["colFechaAlta"].DataPropertyName = "fecha_alta";
            dgvListaUsuarios.Columns["colFechaUltModificacion"].DataPropertyName = "fecha_ultima_modificacion";
            dgvListaUsuarios.Columns["colFechaUltIngreso"].DataPropertyName = "fecha_ultimo_ingreso";

            var lista = objCNUsuario.ListarUsuarios();

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
                var usuarioSeleccionado = dgvListaUsuarios.Rows[e.RowIndex].DataBoundItem as EUsuario;

                if (usuarioSeleccionado != null)
                {
                    // Guardamos el ID para saber qué usuario estamos modificando
                    idUsuarioEdicion = usuarioSeleccionado.usuario_id;

                    // Rellenamos los TextBox
                    txtNombre.Text = usuarioSeleccionado.nombre;
                    txtApellido.Text = usuarioSeleccionado.apellido;
                    txtDni.Text = usuarioSeleccionado.dni;
                    txtCorreo.Text = usuarioSeleccionado.email;
                    txtTelefono.Text = usuarioSeleccionado.telefono;
                    txtDireccion.Text = usuarioSeleccionado.direccion;
                    txtContrasenia.Text = ""; // Se deja vacío por seguridad (si no se escribe nada, la capa de negocio puede mantener la anterior o manejarlo)

                    // Seleccionar el Estado en el ComboBox cmbEstado
                    foreach (OpcionCombo item in cmbEstado.Items)
                    {
                        if (item.Valor != null && Convert.ToInt32(item.Valor) == usuarioSeleccionado.estado)
                        {
                            cmbEstado.SelectedItem = item;
                            break;
                        }
                    }

                    cmbPerfil.SelectedValue = usuarioSeleccionado.perfil_id;
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

        private void AplicarFiltrosAutomaticos()
        {
            if (cargandoFormulario) return; // Si se está iniciando, no ejecutamos todavía

            string textoBusqueda = txtBuscarUsuario.Text.Trim();

            int? idPerfilSeleccionado = null;
            if (cmbFiltroPerfil.SelectedValue != null)
            {
                int idPerfil = Convert.ToInt32(cmbFiltroPerfil.SelectedValue);
                if (idPerfil > 0) idPerfilSeleccionado = idPerfil;
            }

            int? estadoSeleccionado = null;
            if (cmbFiltroEstado.SelectedItem != null)
            {
                OpcionCombo opcionEstado = cmbFiltroEstado.SelectedItem as OpcionCombo;
                if (opcionEstado != null && opcionEstado.Valor != null)
                {
                    estadoSeleccionado = Convert.ToInt32(opcionEstado.Valor);
                }
            }

            // Llamamos a la capa de negocio con los tres parámetros combinados
            var resultados = objCNUsuario.BuscarYFiltrarUsuario(textoBusqueda, idPerfilSeleccionado, estadoSeleccionado);

            dgvListaUsuarios.DataSource = resultados;
            lblCantTotalUsuarios.Text = resultados.Count.ToString();
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

        

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (dgvListaUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.FileName = "Reporte_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Crear documento PDF (en formato Horizontal o Vertical, aquí usaremos PageSize.A4 en orientación horizontal para que quepan más columnas)
                        Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 20f);
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        // Título del reporte
                        Paragraph titulo = new Paragraph("Lista de usuarios", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);
                        doc.Add(new Paragraph(" ")); // Espacio en blanco

                        // Contar cuántas columnas de texto/datos hay (excluyendo imágenes)
                        int totalColumnasValidas = 0;
                        foreach (DataGridViewColumn col in dgvListaUsuarios.Columns)
                        {
                            if (!(col is DataGridViewImageColumn)) totalColumnasValidas++;
                        }

                        // Crear tabla PDF
                        PdfPTable pdfTable = new PdfPTable(totalColumnasValidas);
                        pdfTable.WidthPercentage = 100;

                        // Agregar Encabezados
                        foreach (DataGridViewColumn col in dgvListaUsuarios.Columns)
                        {
                            if (col is DataGridViewImageColumn) continue;

                            PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 230);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdfTable.AddCell(cell);
                        }

                        // Agregar Filas de Datos
                        foreach (DataGridViewRow row in dgvListaUsuarios.Rows)
                        {
                            if (row.IsNewRow) continue;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.OwningColumn is DataGridViewImageColumn) continue;

                                string valor = cell.Value != null ? cell.Value.ToString() : "";
                                PdfPCell pdfCell = new PdfPCell(new Phrase(valor, FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                                pdfTable.AddCell(pdfCell);
                            }
                        }

                        // Agregar la tabla al documento y cerrar
                        doc.Add(pdfTable);
                        doc.Close();

                        MessageBox.Show("Archivo PDF exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void CargarCombosFormulario()
        {
            // Cargar el ComboBox de Estado
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 });

            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0; // Selecciona "Activo" por defecto

            // Cargar el ComboBox de Perfil
            List<EPerfil> listaPerfiles = objCNPerfil.Listar();

            cmbPerfil.DataSource = listaPerfiles;
            cmbPerfil.DisplayMember = "nombre";
            cmbPerfil.ValueMember = "perfil_id";

            if (listaPerfiles.Count > 0)
            {
                cmbPerfil.SelectedIndex = 0; // Selecciona el primer perfil por defecto
            }
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposUsuario())
            {
                MessageBox.Show("Por favor, corrija los errores marcados en el formulario antes de continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            string mensaje = string.Empty;

            // Obtenemos los valores de los controles
            EUsuario usuarioObj = new EUsuario()
            {
                usuario_id = idUsuarioEdicion, // Si es 0 se ignorará en el registro, si tiene ID servirá para identificarlo al editar
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                dni = txtDni.Text.Trim(),
                contrasenia = txtContrasenia.Text.Trim(),
                email = txtCorreo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                direccion = txtDireccion.Text.Trim(),
                estado = Convert.ToInt32(((OpcionCombo)cmbEstado.SelectedItem).Valor),
                perfil_id = Convert.ToInt32(cmbPerfil.SelectedValue)
            };

            bool resultado = false;

            if (idUsuarioEdicion == 0)
            {
                // Operación de Registro
                resultado = objCNUsuario.RegistrarUsuario(usuarioObj, out mensaje);
            }
            else
            {
                // Operación de Edición
                resultado = objCNUsuario.EditarUsuario(usuarioObj, out mensaje); // Asegúrate de tener este método en tu Capa de Negocio
            }

            if (resultado)
            {
                string accion = idUsuarioEdicion == 0 ? "registrado" : "modificado";
                MessageBox.Show($"Usuario {accion} correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarFormulario()
        {
            idUsuarioEdicion = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtContrasenia.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbEstado.SelectedIndex = 0;
            if (cmbPerfil.Items.Count > 0) cmbPerfil.SelectedIndex = 0;

            btnAgregarUsuario.Text = "Agregar Usuario"; // Restablece el texto del botón
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosAutomaticos();
        }

        private void cmbFiltroPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosAutomaticos();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosAutomaticos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea cancelar la operación y limpiar los campos?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                LimpiarFormulario();
            }
        }

        private bool ValidarCamposUsuario()
        {
            bool esValido = true;
            errorProvider1.Clear(); // Limpia errores anteriores

            // Validar Nombre (Solo letras y más de 5 caracteres)
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
            else if (nombre.Length < 4)
            {
                errorProvider1.SetError(txtNombre, "El nombre debe tener más de 4 caracteres.");
                esValido = false;
            }

            // Validar Apellido (Solo letras y más de 5 caracteres)
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

            // Validar DNI (Numérico y exactamente 8 caracteres)
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

            //  Validar Contraseña (Alfanumérico y más de 5 caracteres)
            string password = txtContrasenia.Text.Trim(); // Cambia txtContrasena por el nombre real de tu caja de texto de clave
            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(txtContrasenia, "La contraseña es obligatoria.");
                esValido = false;
            }
            else if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                errorProvider1.SetError(txtContrasenia, "La contraseña debe ser alfanumérica (letras y números).");
                esValido = false;
            }
            else if (password.Length <= 5)
            {
                errorProvider1.SetError(txtContrasenia, "La contraseña debe tener más de 5 caracteres.");
                esValido = false;
            }

            //  Validar Correo (Más de 10 caracteres y formato válido con @ y .com)
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
                errorProvider1.SetError(txtCorreo, "Correo inválido. Ejemplo de formato correcto: usuario@dominio.com");
                esValido = false;
            }

            //  Validar Teléfono (Numérico y exactamente 10 caracteres)
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

            // Validar Dirección (Alfanumérico y más de 10 caracteres)
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

            //Validar ComboBox de Perfil (Obligatorio)
            if (cmbPerfil.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbPerfil, "Debe seleccionar un perfil.");
                esValido = false;
            }

            return esValido;
        }
    }
    }

