using CapaEntidad;
using CapaNegocio;
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
using static ClosedXML.Excel.XLPredefinedFormat;

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

                if (!string.IsNullOrEmpty(SesionActual.UsuarioLogueado.apellido) && !string.IsNullOrEmpty(SesionActual.UsuarioLogueado.nombre))
                {
                    char inicialApellido = char.ToUpper(SesionActual.UsuarioLogueado.apellido[0]);
                    char inicialNombre = char.ToUpper(SesionActual.UsuarioLogueado.nombre[0]);

                    lblIniciales.Text = $"{inicialApellido}{inicialNombre}";
                }
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = System.DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

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

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            List<ECliente> listaClientes = dgvListaClientes.DataSource as List<ECliente>;

            if (listaClientes == null || listaClientes.Count == 0)
            {
                MessageBox.Show("No hay registros de clientes para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Configurar el diálogo para guardar el archivo PDF
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Reporte_Clientes_{System.DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            savefile.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear documento PDF en orientación horizontal (A4 Landscape)
                    Document doc = new Document(PageSize.A4.Rotate(), 36, 36, 36, 36);
                    PdfWriter.GetInstance(doc, new FileStream(savefile.FileName, FileMode.Create));
                    doc.Open();

                    // Definición de fuentes corporativas
                    iTextSharp.text.Font fontEmpresa = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, new BaseColor(27, 38, 59));
                    iTextSharp.text.Font fontInfoEmpresa = FontFactory.GetFont(FontFactory.HELVETICA, 8.5f, new BaseColor(80, 90, 100));
                    iTextSharp.text.Font fontSubTituloGen = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.GRAY);
                    iTextSharp.text.Font fontCabeceraTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8.5f, BaseColor.WHITE);
                    iTextSharp.text.Font fontContenido = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.BLACK);
                    iTextSharp.text.Font fontContenidoNegrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, BaseColor.BLACK);

                    // CABECERA  (MUSNOC)
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
                    Paragraph infoGen = new Paragraph($"Listado de Clientes (Filtrado / General) — Generado el: {System.DateTime.Now:dd/MM/yyyy HH:mm} por {usuarioNombre}", fontSubTituloGen);
                    doc.Add(infoGen);
                    doc.Add(new Paragraph(" "));

                    // TABLA PRINCIPAL DE CLIENTES (9 Columnas)
                    PdfPTable tablaClientes = new PdfPTable(9);
                    tablaClientes.WidthPercentage = 100;
                    tablaClientes.SetWidths(new float[] { 10f, 13f, 13f, 11f, 16f, 17f, 8f, 11f, 11f });

                    // Cabeceras de la tabla
                    string[] cabeceras = { "DNI", "Nombre", "Apellido", "Teléfono", "Correo", "Dirección", "Estado", "Fecha Alta", "Últ. Modif." };
                    foreach (var cabecera in cabeceras)
                    {
                        PdfPCell celdaCabecera = new PdfPCell(new Phrase(cabecera, fontCabeceraTabla));
                        celdaCabecera.BackgroundColor = new BaseColor(41, 128, 185); // Azul institucional
                        celdaCabecera.HorizontalAlignment = Element.ALIGN_CENTER;
                        celdaCabecera.VerticalAlignment = Element.ALIGN_MIDDLE;
                        celdaCabecera.Padding = 5;
                        tablaClientes.AddCell(celdaCabecera);
                    }

                    // Rellenar filas con los datos de los clientes
                    foreach (var cliente in listaClientes)
                    {
                        AgregarCeldaContenido(tablaClientes, cliente.dni, fontContenidoNegrita, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaClientes, cliente.nombre, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaClientes, cliente.apellido, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaClientes, cliente.telefono, fontContenido, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaClientes, cliente.email, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaClientes, cliente.direccion, fontContenido, Element.ALIGN_LEFT);
                        AgregarCeldaContenido(tablaClientes, cliente.EstadoTexto, fontContenido, Element.ALIGN_CENTER);

                        string fechaAltaStr = cliente.fecha_alta != null ? Convert.ToDateTime(cliente.fecha_alta).ToString("dd/MM/yyyy") : "-";
                        string fechaModifStr = cliente.fecha_ultima_modificacion != null ? Convert.ToDateTime(cliente.fecha_ultima_modificacion).ToString("dd/MM/yyyy") : "-";

                        AgregarCeldaContenido(tablaClientes, fechaAltaStr, fontContenido, Element.ALIGN_CENTER);
                        AgregarCeldaContenido(tablaClientes, fechaModifStr, fontContenido, Element.ALIGN_CENTER);
                    }

                    doc.Add(tablaClientes);
                    doc.Close();

                    MessageBox.Show("Reporte PDF de clientes generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savefile.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método auxiliar para rellenar el contenido de las celdas ordenadamente
        private void AgregarCeldaContenido(PdfPTable tabla, string texto, iTextSharp.text.Font fuente, int alineacion)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto ?? "", fuente));
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.HorizontalAlignment = alineacion;
            celda.Padding = 4;
            tabla.AddCell(celda);
        }

        private void btnExportarEXCEL_Click(object sender, EventArgs e)
        {
            List<ECliente> listaClientes = dgvListaClientes.DataSource as List<ECliente>;

            if (listaClientes == null || listaClientes.Count == 0)
            {
                MessageBox.Show("No hay registros de clientes para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Configurar diálogo para guardar archivo Excel
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Reporte_Clientes_{System.DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            savefile.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Configuración de licencia requerida por EPPlus 8+
                    ExcelPackage.License.SetNonCommercialOrganization("MUSNOC");

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Lista de Clientes");
                        ws.View.ShowGridLines = true;

                        int filaActual = 1;

                        // CABECERA  (MUSNOC)
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
                        ws.Cells[filaActual, 1].Value = $"Listado de Clientes (Filtrado / General) — Generado el: {System.DateTime.Now:dd/MM/yyyy HH:mm} por {usuarioNombre}";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Italic = true;
                        filaActual += 2;

                        // CABECERAS DE LA TABLA DE CLIENTES
                        string[] cabeceras = { "DNI", "Nombre", "Apellido", "Teléfono", "Correo", "Dirección", "Estado", "Fecha Alta", "Últ. Modif." };
                        for (int i = 0; i < cabeceras.Length; i++)
                        {
                            var cell = ws.Cells[filaActual, i + 1];
                            cell.Value = cabeceras[i];
                            cell.Style.Font.Bold = true;
                            cell.Style.Font.Size = 10;
                            cell.Style.Font.Color.SetColor(Color.FromArgb(41, 128, 185)); // Azul institucional
                        }
                        filaActual++;

                        // RELLENAR DATOS DE CLIENTES
                        foreach (var cliente in listaClientes)
                        {
                            ws.Cells[filaActual, 1].Value = cliente.dni;
                            ws.Cells[filaActual, 1].Style.Font.Bold = true;
                            ws.Cells[filaActual, 2].Value = cliente.nombre;
                            ws.Cells[filaActual, 3].Value = cliente.apellido;
                            ws.Cells[filaActual, 4].Value = cliente.telefono;
                            ws.Cells[filaActual, 5].Value = cliente.email;
                            ws.Cells[filaActual, 6].Value = cliente.direccion;
                            ws.Cells[filaActual, 7].Value = cliente.EstadoTexto;

                            string fechaAltaStr = cliente.fecha_alta != null ? Convert.ToDateTime(cliente.fecha_alta).ToString("dd/MM/yyyy") : "-";
                            string fechaModifStr = cliente.fecha_ultima_modificacion != null ? Convert.ToDateTime(cliente.fecha_ultima_modificacion).ToString("dd/MM/yyyy") : "-";

                            ws.Cells[filaActual, 8].Value = fechaAltaStr;
                            ws.Cells[filaActual, 9].Value = fechaModifStr;

                            ws.Cells[filaActual, 1, filaActual, 9].Style.Font.Size = 9.5f;
                            filaActual++;
                        }

                        // Ajustar automáticamente el ancho de las celdas para que no se corten los textos
                        ws.Cells[ws.Dimension.Address].AutoFitColumns();

                        // Guardar y exportar el archivo físico
                        File.WriteAllBytes(savefile.FileName, package.GetAsByteArray());
                    }

                    MessageBox.Show("Reporte de Excel de clientes generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
