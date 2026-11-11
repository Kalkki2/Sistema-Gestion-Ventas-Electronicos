using CapaEntidad;
using CapaNegocio;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
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
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;

                if (!string.IsNullOrEmpty(SesionActual.UsuarioLogueado.apellido) && !string.IsNullOrEmpty(SesionActual.UsuarioLogueado.nombre))
                {
                    char inicialApellido = char.ToUpper(SesionActual.UsuarioLogueado.apellido[0]);
                    char inicialNombre = char.ToUpper(SesionActual.UsuarioLogueado.nombre[0]);

                    lblIniciales.Text = $"{inicialApellido}{inicialNombre}";
                }
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

            // CONFIRMACIÓN SEGÚN LA ACCIÓN (REGISTRAR / EDITAR)
            string accionTexto = idUsuarioEdicion == 0 ? "registrar" : "modificar";
            string tituloTexto = idUsuarioEdicion == 0 ? "Confirmar registro" : "Confirmar modificación";

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea {accionTexto} este usuario?",
                tituloTexto,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return; // Se detiene la ejecución si el usuario elige "No"
            }

            bool resultado = false;

            if (idUsuarioEdicion == 0)
            {
                // Operación de Registro
                resultado = objCNUsuario.RegistrarUsuario(usuarioObj, out mensaje);
            }
            else
            {
                // Operación de Edición
                resultado = objCNUsuario.EditarUsuario(usuarioObj, out mensaje);
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

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            List<EUsuario> listaUsuarios = dgvListaUsuarios.DataSource as List<EUsuario>;

            if (listaUsuarios == null || listaUsuarios.Count == 0)
            {
                MessageBox.Show("No hay registros de usuarios para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Configurar el diálogo para guardar el archivo PDF
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = $"Reporte_Usuarios_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear documento PDF en orientación horizontal (A4 Landscape) con márgenes reducidos
                    Document doc = new Document(PageSize.A4.Rotate(), 25f, 25f, 30f, 30f);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Definición de fuentes corporativas
                    iTextSharp.text.Font fontEmpresa = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, new BaseColor(27, 38, 59));
                    iTextSharp.text.Font fontInfoEmpresa = FontFactory.GetFont(FontFactory.HELVETICA, 8.5f, new BaseColor(80, 90, 100));
                    iTextSharp.text.Font fontSubTituloGen = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.GRAY);
                    iTextSharp.text.Font fontCabeceraTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, BaseColor.WHITE);
                    iTextSharp.text.Font fontContenido = FontFactory.GetFont(FontFactory.HELVETICA, 7.5f, BaseColor.BLACK);
                    iTextSharp.text.Font fontContenidoNegrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7.5f, BaseColor.BLACK);

                    // CABECERA (MUSNOC)
                    PdfPTable tablaHeader = new PdfPTable(2);
                    tablaHeader.WidthPercentage = 100;
                    tablaHeader.SetWidths(new float[] { 50f, 50f });

                    PdfPCell cellLeft = new PdfPCell(new Phrase("MUSNOC", fontEmpresa));
                    cellLeft.Border = PdfPCell.NO_BORDER;
                    cellLeft.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tablaHeader.AddCell(cellLeft);

                    Paragraph pInfo = new Paragraph();
                    pInfo.Alignment = Element.ALIGN_RIGHT;
                    pInfo.Add(new Chunk("Dirección: Av. 3 Abril Corrientes - Corrientes - Argentina\n", fontInfoEmpresa));
                    pInfo.Add(new Chunk("Tel: +54 9 379 634-7610", fontInfoEmpresa));

                    PdfPCell cellRight = new PdfPCell(pInfo);
                    cellRight.Border = PdfPCell.NO_BORDER;
                    cellRight.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cellRight.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tablaHeader.AddCell(cellRight);

                    doc.Add(tablaHeader);

                    // Línea divisoria inferior de la cabecera
                    PdfPTable lineaDivisoria = new PdfPTable(1);
                    lineaDivisoria.WidthPercentage = 100;
                    PdfPCell cellLine = new PdfPCell(new Phrase(" "));
                    cellLine.Border = PdfPCell.BOTTOM_BORDER;
                    cellLine.BorderWidthBottom = 1.5f;
                    cellLine.BorderColorBottom = new BaseColor(27, 38, 59);
                    cellLine.FixedHeight = 6f;
                    lineaDivisoria.AddCell(cellLine);

                    doc.Add(lineaDivisoria);
                    doc.Add(new Paragraph(" "));

                    // Metadatos y fecha de generación
                    string usuarioNombre = SesionActual.UsuarioLogueado != null ? $"{SesionActual.UsuarioLogueado.nombre} {SesionActual.UsuarioLogueado.apellido}" : "Sistema";
                    Paragraph infoGen = new Paragraph($"Listado de Usuarios (Filtrado / General) — Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} por {usuarioNombre}", fontSubTituloGen);
                    doc.Add(infoGen);
                    doc.Add(new Paragraph(" "));

                    // TABLA PRINCIPAL DE USUARIOS 
                    PdfPTable tablaUsuarios = new PdfPTable(11);
                    tablaUsuarios.WidthPercentage = 100;
                    tablaUsuarios.SetWidths(new float[] { 8f, 10f, 10f, 14f, 9f, 14f, 9f, 7f, 8f, 8f, 8f });

                    // Cabeceras de la tabla
                    string[] cabeceras = { "DNI", "Nombre", "Apellido", "Correo", "Teléfono", "Dirección", "Perfil", "Estado", "Fecha Alta", "Últ. Modif.", "Últ. Ingreso" };
                    foreach (var cabecera in cabeceras)
                    {
                        PdfPCell celdaCabecera = new PdfPCell(new Phrase(cabecera, fontCabeceraTabla));
                        celdaCabecera.BackgroundColor = new BaseColor(41, 128, 185); // Azul institucional
                        celdaCabecera.HorizontalAlignment = Element.ALIGN_CENTER;
                        celdaCabecera.VerticalAlignment = Element.ALIGN_MIDDLE;
                        celdaCabecera.Padding = 4;
                        tablaUsuarios.AddCell(celdaCabecera);
                    }

                    // Rellenar filas con los datos de los usuarios
                    foreach (var usuario in listaUsuarios)
                    {
                        AgregarCeldaContenido(tablaUsuarios, usuario.dni, fontContenidoNegrita, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaUsuarios, usuario.nombre, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaUsuarios, usuario.apellido, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaUsuarios, usuario.email, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaUsuarios, usuario.telefono, fontContenido, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaUsuarios, usuario.direccion, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaUsuarios, usuario.NombrePerfil, fontContenido, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaUsuarios, usuario.EstadoTexto, fontContenido, Element.ALIGN_CENTER);

                        string fechaAltaStr = usuario.fecha_alta != null && usuario.fecha_alta != DateTime.MinValue ? Convert.ToDateTime(usuario.fecha_alta).ToString("dd/MM/yyyy") : "-";
                        string fechaModifStr = usuario.fecha_ultima_modificacion != null && usuario.fecha_ultima_modificacion != DateTime.MinValue ? Convert.ToDateTime(usuario.fecha_ultima_modificacion).ToString("dd/MM/yyyy") : "-";
                        string fechaIngresoStr = usuario.fecha_ultimo_ingreso != null && usuario.fecha_ultimo_ingreso != DateTime.MinValue ? Convert.ToDateTime(usuario.fecha_ultimo_ingreso).ToString("dd/MM/yyyy HH:mm:ss") : "-";

                        AgregarCeldaContenido(tablaUsuarios, fechaAltaStr, fontContenido, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaUsuarios, fechaModifStr, fontContenido, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaUsuarios, fechaIngresoStr, fontContenido, Element.ALIGN_CENTER);
                    }

                    doc.Add(tablaUsuarios);
                    doc.Close();

                    MessageBox.Show("Archivo PDF de usuarios exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método auxiliar privado para formatear y agregar celdas de datos limpiamente
        private void AgregarCeldaContenido(PdfPTable tabla, string texto, iTextSharp.text.Font fuente, int alineacion)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto ?? "", fuente));
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.HorizontalAlignment = alineacion;
            celda.Padding = 3.5f;
            tabla.AddCell(celda);
        }

        private void btnExportarEXCEL_Click(object sender, EventArgs e)
        {
            List<EUsuario> listaUsuarios = dgvListaUsuarios.DataSource as List<EUsuario>;

            if (listaUsuarios == null || listaUsuarios.Count == 0)
            {
                MessageBox.Show("No hay registros de usuarios para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Configurar el diálogo para guardar el archivo Excel
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Reporte_Usuarios_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            savefile.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Configuración de licencia requerida por EPPlus 8+
                    ExcelPackage.License.SetNonCommercialOrganization("MUSNOC");

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Lista de Usuarios");
                        ws.View.ShowGridLines = true;

                        int filaActual = 1;

                        // CABECERA (MUSNOC)
                        ws.Cells[filaActual, 1].Value = "MUSNOC";
                        ws.Cells[filaActual, 1].Style.Font.Size = 16;
                        ws.Cells[filaActual, 1].Style.Font.Bold = true;
                        ws.Cells[filaActual, 1].Style.Font.Color.SetColor(Color.FromArgb(27, 38, 59));
                        filaActual++;

                        ws.Cells[filaActual, 1].Value = "Dirección: Av. 3 Abril Corrientes - Corrientes - Argentina";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Color.SetColor(Color.Gray);
                        filaActual++;

                        ws.Cells[filaActual, 1].Value = "Tel: +54 9 379 634-7610";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Color.SetColor(Color.Gray);
                        filaActual++;

                        string usuarioNombre = SesionActual.UsuarioLogueado != null ? $"{SesionActual.UsuarioLogueado.nombre} {SesionActual.UsuarioLogueado.apellido}" : "Sistema";
                        ws.Cells[filaActual, 1].Value = $"Listado de Usuarios (Filtrado / General) — Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} por {usuarioNombre}";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Italic = true;
                        filaActual += 2;

                        // CABECERAS DE LA TABLA DE USUARIOS 
                        string[] cabeceras = { "DNI", "Nombre", "Apellido", "Correo", "Teléfono", "Dirección", "Perfil", "Estado", "Fecha Alta", "Últ. Modif.", "Últ. Ingreso" };
                        for (int i = 0; i < cabeceras.Length; i++)
                        {
                            var cell = ws.Cells[filaActual, i + 1];
                            cell.Value = cabeceras[i];
                            cell.Style.Font.Bold = true;
                            cell.Style.Font.Size = 10;
                            cell.Style.Font.Color.SetColor(Color.FromArgb(41, 128, 185)); // Azul institucional
                        }
                        filaActual++;

                        // RELLENAR DATOS DE USUARIOS
                        foreach (var usuario in listaUsuarios)
                        {
                            ws.Cells[filaActual, 1].Value = usuario.dni;
                            ws.Cells[filaActual, 1].Style.Font.Bold = true;
                            ws.Cells[filaActual, 2].Value = usuario.nombre;
                            ws.Cells[filaActual, 3].Value = usuario.apellido;
                            ws.Cells[filaActual, 4].Value = usuario.email;
                            ws.Cells[filaActual, 5].Value = usuario.telefono;
                            ws.Cells[filaActual, 6].Value = usuario.direccion;
                            ws.Cells[filaActual, 7].Value = usuario.NombrePerfil;
                            ws.Cells[filaActual, 8].Value = usuario.EstadoTexto;

                            string fechaAltaStr = usuario.fecha_alta != null && usuario.fecha_alta != DateTime.MinValue ? Convert.ToDateTime(usuario.fecha_alta).ToString("dd/MM/yyyy") : "-";
                            string fechaModifStr = usuario.fecha_ultima_modificacion != null && usuario.fecha_ultima_modificacion != DateTime.MinValue ? Convert.ToDateTime(usuario.fecha_ultima_modificacion).ToString("dd/MM/yyyy") : "-";
                            string fechaIngresoStr = usuario.fecha_ultimo_ingreso != null && usuario.fecha_ultimo_ingreso != DateTime.MinValue ? Convert.ToDateTime(usuario.fecha_ultimo_ingreso).ToString("dd/MM/yyyy HH:mm:ss") : "-";

                            ws.Cells[filaActual, 9].Value = fechaAltaStr;
                            ws.Cells[filaActual, 10].Value = fechaModifStr;
                            ws.Cells[filaActual, 11].Value = fechaIngresoStr;

                            ws.Cells[filaActual, 1, filaActual, 11].Style.Font.Size = 9.5f;
                            filaActual++;
                        }

                        // Ajustar automáticamente el ancho de las celdas
                        ws.Cells[ws.Dimension.Address].AutoFitColumns();

                        // Guardar y exportar el archivo físico
                        File.WriteAllBytes(savefile.FileName, package.GetAsByteArray());
                    }

                    MessageBox.Show("Reporte de Excel de usuarios generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savefile.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
 }

