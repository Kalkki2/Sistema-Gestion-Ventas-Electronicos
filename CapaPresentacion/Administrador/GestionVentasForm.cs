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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class GestionVentasForm : Form
    {
        private CNMetodoPago objCNMetodoPago = new CNMetodoPago();
        private bool cargandoFormulario = true;
        public GestionVentasForm()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: true);
        }

        private void GestionVentasForm_Load(object sender, EventArgs e)
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

            CargarHistorialVentas();
            CargarConfiguracionPagos();
            CargarFiltroMetodoPago();
            CargarFiltroEstado();

            cargandoFormulario = false; 
            FiltrarHistorial(aplicarFechas: false);
        }

        

        private void btnAplicarAjusteFormaPago_Click(object sender, EventArgs e)
        {
            if (cmbMetodoPago.SelectedValue == null || cmbTipoAjuste.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un método de pago y un tipo de ajuste.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea aplicar este ajuste a la forma de pago?",
                "Confirmar ajuste",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            int metodoPagoId = Convert.ToInt32(cmbMetodoPago.SelectedValue);
            int tipoAjusteId = Convert.ToInt32(cmbTipoAjuste.SelectedValue);
            decimal porcentaje = Convert.ToDecimal(txtPorcentajeAjuste.Value);

            string mensaje = string.Empty;
            bool resultado = objCNMetodoPago.Actualizar(metodoPagoId, porcentaje, tipoAjusteId, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Se aplicó el ajuste con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarConfiguracionPagos(); // Recargamos para refrescar
            }
            else
            {
                MessageBox.Show("Error al actualizar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SincronizarDatosMetodoPago();
        }

        private void CargarHistorialVentas()
        {
            dgvHistorialVentas.AutoGenerateColumns = false;

            dgvHistorialVentas.Columns["colNroVenta"].DataPropertyName = "nro_venta";
            dgvHistorialVentas.Columns["colDniCliente"].DataPropertyName = "DniCliente";
            dgvHistorialVentas.Columns["colCliente"].DataPropertyName = "NombreCliente";
            dgvHistorialVentas.Columns["colDniVendedor"].DataPropertyName = "DniUsuario";
            dgvHistorialVentas.Columns["colVendedor"].DataPropertyName = "NombreComprador";
            dgvHistorialVentas.Columns["colMetodoPago"].DataPropertyName = "NombreMetodoPago";
            dgvHistorialVentas.Columns["colTipoAjuste"].DataPropertyName = "NombreTipoAjuste";
            dgvHistorialVentas.Columns["colFechaVenta"].DataPropertyName = "fecha_venta";
            dgvHistorialVentas.Columns["colTotal"].DataPropertyName = "TotalVenta";
            dgvHistorialVentas.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            CNVenta objCNVenta = new CNVenta();
            dgvHistorialVentas.DataSource = objCNVenta.ListarHistorialVentas();
        }

        private void dgvHistorialVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no se haga clic en los encabezados (fila -1)
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvHistorialVentas.Columns[e.ColumnIndex].Name;

            // Si hace clic en la columna configurada como botón "Ver Detalle"
            if (nombreColumna == "colVerDetalle")
            {
                // Extraemos el objeto EVenta de la fila seleccionada en la grilla
                EVenta ventaSeleccionada = (EVenta)dgvHistorialVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada != null)
                {
                    // Abrimos el formulario modal pasándole el objeto por el constructor
                    using (DetalleVenta modal = new DetalleVenta(ventaSeleccionada))
                    {
                        modal.ShowDialog(); // Esto abre la ventana que diseñaste con los datos de la venta y productos
                    }
                }
            }
        }

        private void CargarConfiguracionPagos()
        {
            // Cargar Tipos de Ajuste
            cmbTipoAjuste.DataSource = objCNMetodoPago.ListarTiposAjuste();
            cmbTipoAjuste.DisplayMember = "nombre";
            cmbTipoAjuste.ValueMember = "tipo_ajuste_id";

            // Cargar Métodos de Pago
            cmbMetodoPago.DataSource = objCNMetodoPago.Listar();
            cmbMetodoPago.DisplayMember = "nombre";
            cmbMetodoPago.ValueMember = "metodo_pago_id";

            // Si hay elementos, seleccionamos el primero y cargamos sus datos en los controles
            if (cmbMetodoPago.Items.Count > 0)
            {
                cmbMetodoPago.SelectedIndex = 0;
                SincronizarDatosMetodoPago();
            }
        }

        private void SincronizarDatosMetodoPago()
        {
            if (cmbMetodoPago.SelectedItem != null)
            {
                EMetodoPago metodoSeleccionado = (EMetodoPago)cmbMetodoPago.SelectedItem;

                // Rellenamos el porcentaje actual para que pueda modificarlo
                txtPorcentajeAjuste.Value = metodoSeleccionado.porcentaje;

                // Seleccionamos el tipo de ajuste fijo que le pertenece
                cmbTipoAjuste.SelectedValue = metodoSeleccionado.tipo_ajuste_id;
            }
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            SincronizarDatosMetodoPago();
        }

        private void FiltrarHistorial(bool aplicarFechas = true)
        {
            CNVenta objCNVenta = new CNVenta();
            if (cargandoFormulario) return;

            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            if (aplicarFechas)
            {
                if (dtpDesde.Value.Date > dtpHasta.Value.Date)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                fechaDesde = dtpDesde.Value.Date;
                fechaHasta = dtpHasta.Value.Date;
            }

            try
            {
                string dniVendedor = txtBuscarVendedorDni.Text.Trim();
                string dniCliente = txtBuscarClienteDni.Text.Trim();

                int metodoPagoId = 0;
                if (cmbFiltroMetodoPago.SelectedValue != null)
                {
                    int.TryParse(cmbFiltroMetodoPago.SelectedValue.ToString(), out metodoPagoId);
                }

                int estadoId = -1; // Por defecto "Todos"
                if (cmbFiltroEstado.SelectedItem is OpcionCombo opcionSeleccionada)
                {
                    estadoId = Convert.ToInt32(opcionSeleccionada.Valor);
                }

                // Llamada a la capa de negocio
                var listaFiltrada = objCNVenta.Buscar(null, dniVendedor, dniCliente, metodoPagoId, estadoId, fechaDesde, fechaHasta);

                dgvHistorialVentas.DataSource = listaFiltrada;
                lblCantTotalVentas.Text = listaFiltrada.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarVendedorDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void txtBuscarClienteDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void cmbFiltroMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void CargarFiltroMetodoPago()
        {
            CNMetodoPago objCNMetodoPagoFiltro = new CNMetodoPago();
            var listaMetodos = objCNMetodoPagoFiltro.Listar();

            listaMetodos.Insert(0, new EMetodoPago { metodo_pago_id = 0, nombre = "Todos" });

            cmbFiltroMetodoPago.DataSource = listaMetodos;
            cmbFiltroMetodoPago.DisplayMember = "nombre";
            cmbFiltroMetodoPago.ValueMember = "metodo_pago_id";
            cmbFiltroMetodoPago.SelectedIndex = 0;
        }

        private void CargarFiltroEstado()
        {
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = -1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Completados", Valor = 1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Anulados", Valor = 0 });

            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0; // Selecciona "Todos" por defecto
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void dgvHistorialVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvHistorialVentas.NewRowIndex) return;

            string colName = dgvHistorialVentas.Columns[e.ColumnIndex].Name;

            if (colName == "colVerDetalle")
            {
                e.Value = Properties.Resources.icono_editar;
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            List<EVenta> listaVentas = dgvHistorialVentas.DataSource as List<EVenta>;

            if (listaVentas == null || listaVentas.Count == 0)
            {
                MessageBox.Show("No hay registros de ventas para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Reporte_Ventas_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            savefile.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Configurar documento en orientación horizontal (Landscape)
                    Document doc = new Document(PageSize.A4.Rotate(), 36, 36, 36, 36);
                    PdfWriter.GetInstance(doc, new FileStream(savefile.FileName, FileMode.Create));
                    doc.Open();

                    // Definición de fuentes
                    iTextSharp.text.Font fontEmpresa = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, new BaseColor(27, 38, 59));
                    iTextSharp.text.Font fontInfoEmpresa = FontFactory.GetFont(FontFactory.HELVETICA, 8.5f, new BaseColor(80, 90, 100));
                    iTextSharp.text.Font fontSubTituloGen = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.GRAY);
                    iTextSharp.text.Font fontCabeceraTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8.5f, BaseColor.WHITE);
                    iTextSharp.text.Font fontContenido = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.BLACK);
                    iTextSharp.text.Font fontContenidoNegrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8, BaseColor.BLACK);

                    // CABECERA INSTITUCIONAL (MUSNOC)
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

                    // Línea divisoria inferior
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

                    Paragraph infoGen = new Paragraph($"Historial de Ventas (Filtrado / General) — Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} por {SesionActual.UsuarioLogueado.nombre} {SesionActual.UsuarioLogueado.apellido}", fontSubTituloGen);
                    doc.Add(infoGen);
                    doc.Add(new Paragraph(" "));

                    CNVenta objCNVenta = new CNVenta();

                    // RECORRIDO DE CADA VENTA Y SUS DETALLES
                    foreach (var venta in listaVentas)
                    {
                        // Contenedor principal que agrupa la venta y sus detalles para mantenerlos juntos por página
                        PdfPTable bloqueVenta = new PdfPTable(1);
                        bloqueVenta.WidthPercentage = 100;
                        bloqueVenta.KeepTogether = true;
                        bloqueVenta.DefaultCell.Border = PdfPCell.NO_BORDER;
                        bloqueVenta.DefaultCell.Padding = 0;

                        // Tabla de Cabecera de la Venta 
                        PdfPTable tablaVenta = new PdfPTable(9);
                        tablaVenta.WidthPercentage = 100;
                        tablaVenta.SetWidths(new float[] { 9f, 13f, 13f, 10f, 12f, 11f, 11f, 11f, 10f });

                        AgregarCeldaCabecera(tablaVenta, "Nro Venta", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Cliente", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Vendedor", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Método Pago", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Tipo Ajuste", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Porcentaje", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Fecha", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Total ($)", fontCabeceraTabla);
                        AgregarCeldaCabecera(tablaVenta, "Estado", fontCabeceraTabla);

                        AgregarCeldaContenido(tablaVenta, venta.nro_venta, fontContenidoNegrita);
                        AgregarCeldaContenido(tablaVenta, venta.NombreCliente, fontContenido);
                        AgregarCeldaContenido(tablaVenta, venta.NombreComprador, fontContenido);
                        AgregarCeldaContenido(tablaVenta, venta.NombreMetodoPago, fontContenido);
                        AgregarCeldaContenido(tablaVenta, venta.NombreTipoAjuste, fontContenido); 
                        AgregarCeldaContenido(tablaVenta, $"{venta.porcentaje_aplicado:N2}%", fontContenido); 
                        AgregarCeldaContenido(tablaVenta, Convert.ToDateTime(venta.fecha_venta).ToString("dd/MM/yyyy HH:mm"), fontContenido);
                        AgregarCeldaContenido(tablaVenta, $"$ {venta.TotalVenta:N2}", fontContenidoNegrita);
                        AgregarCeldaContenido(tablaVenta, venta.EstadoTexto, fontContenido);

                        PdfPCell cellVenta = new PdfPCell(tablaVenta);
                        cellVenta.Border = PdfPCell.NO_BORDER;
                        cellVenta.PaddingBottom = 3;
                        bloqueVenta.AddCell(cellVenta);

                        // Tabla de Detalle de Productos (Debajo de la venta)
                        var listaDetalles = objCNVenta.ObtenerDetalleVenta(venta.venta_id);

                        if (listaDetalles != null && listaDetalles.Count > 0)
                        {
                            PdfPTable tablaDetalle = new PdfPTable(4);
                            tablaDetalle.WidthPercentage = 90;
                            tablaDetalle.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tablaDetalle.SetWidths(new float[] { 40f, 15f, 20f, 25f });

                            AgregarCeldaSubCabecera(tablaDetalle, "Producto / Artículo", fontCabeceraTabla);
                            AgregarCeldaSubCabecera(tablaDetalle, "Cantidad", fontCabeceraTabla);
                            AgregarCeldaSubCabecera(tablaDetalle, "Precio Unit.", fontCabeceraTabla);
                            AgregarCeldaSubCabecera(tablaDetalle, "Subtotal", fontCabeceraTabla);

                            foreach (var detalle in listaDetalles)
                            {
                                AgregarCeldaContenido(tablaDetalle, detalle.NombreProducto, fontContenido);
                                AgregarCeldaContenido(tablaDetalle, detalle.cantidad.ToString(), fontContenido);
                                AgregarCeldaContenido(tablaDetalle, $"$ {detalle.precio_unitario:N2}", fontContenido);
                                AgregarCeldaContenido(tablaDetalle, $"$ {detalle.SubtotalFila:N2}", fontContenido);
                            }

                            PdfPCell cellDetalle = new PdfPCell(tablaDetalle);
                            cellDetalle.Border = PdfPCell.NO_BORDER;
                            cellDetalle.HorizontalAlignment = Element.ALIGN_RIGHT;
                            cellDetalle.PaddingBottom = 6;
                            bloqueVenta.AddCell(cellDetalle);
                        }

                        // Separador visual limpio entre cada venta completa
                        Paragraph separador = new Paragraph("----------------------------------------------------------------------------------------------------------------------------------------------------------------", fontSubTituloGen);
                        separador.Alignment = Element.ALIGN_CENTER;

                        PdfPCell cellSeparador = new PdfPCell(separador);
                        cellSeparador.Border = PdfPCell.NO_BORDER;
                        cellSeparador.PaddingBottom = 8;
                        bloqueVenta.AddCell(cellSeparador);

                        doc.Add(bloqueVenta);
                    }

                    doc.Close();

                    MessageBox.Show("Reporte PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savefile.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Métodos auxiliares de formato
        private void AgregarCeldaCabecera(PdfPTable tabla, string texto, iTextSharp.text.Font fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.BackgroundColor = new BaseColor(41, 128, 185);
            celda.HorizontalAlignment = Element.ALIGN_CENTER;
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.Padding = 4;
            tabla.AddCell(celda);
        }

        private void AgregarCeldaSubCabecera(PdfPTable tabla, string texto, iTextSharp.text.Font fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
            celda.BackgroundColor = new BaseColor(127, 140, 141);
            celda.HorizontalAlignment = Element.ALIGN_CENTER;
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.Padding = 3;
            tabla.AddCell(celda);
        }

        private void AgregarCeldaContenido(PdfPTable tabla, string texto, iTextSharp.text.Font fuente)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto ?? "", fuente));
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.Padding = 3;
            tabla.AddCell(celda);
        }

        private void btnExportarEXCEL_Click(object sender, EventArgs e)
        {
            List<EVenta> listaVentas = dgvHistorialVentas.DataSource as List<EVenta>;

            if (listaVentas == null || listaVentas.Count == 0)
            {
                MessageBox.Show("No hay registros de ventas para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Reporte_Ventas_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            savefile.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Corrección obligatoria para EPPlus 8+ en entornos organizacionales
                    ExcelPackage.License.SetNonCommercialOrganization("MUSNOC");

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Historial de Ventas");
                        ws.View.ShowGridLines = true;

                        int filaActual = 1;

                        //  CABECERA INSTITUCIONAL (MUSNOC)
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

                        ws.Cells[filaActual, 1].Value = $"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} por {SesionActual.UsuarioLogueado.nombre} {SesionActual.UsuarioLogueado.apellido}";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Italic = true;
                        filaActual += 2;

                        CNVenta objCNVenta = new CNVenta();

                        //  RECORRIDO DE CADA VENTA Y SUS DETALLES
                        foreach (var venta in listaVentas)
                        {
                            // A. Cabecera principal de la Venta (9 Columnas)
                            string[] cabecerasVenta = { "Nro Venta", "Cliente", "Vendedor", "Método Pago", "Tipo Ajuste", "Porcentaje", "Fecha Venta", "Total ($)", "Estado" };
                            for (int i = 0; i < cabecerasVenta.Length; i++)
                            {
                                var cell = ws.Cells[filaActual, i + 1];
                                cell.Value = cabecerasVenta[i];
                                cell.Style.Font.Bold = true;
                                cell.Style.Font.Size = 10;
                                cell.Style.Font.Color.SetColor(Color.FromArgb(41, 128, 185));
                            }
                            filaActual++;

                            // B. Datos de la Venta
                            ws.Cells[filaActual, 1].Value = venta.nro_venta;
                            ws.Cells[filaActual, 1].Style.Font.Bold = true;
                            ws.Cells[filaActual, 2].Value = venta.NombreCliente;
                            ws.Cells[filaActual, 3].Value = venta.NombreComprador;
                            ws.Cells[filaActual, 4].Value = venta.NombreMetodoPago;
                            ws.Cells[filaActual, 5].Value = venta.NombreTipoAjuste;
                            ws.Cells[filaActual, 6].Value = $"{venta.porcentaje_aplicado:N2}%";
                            ws.Cells[filaActual, 7].Value = Convert.ToDateTime(venta.fecha_venta).ToString("dd/MM/yyyy HH:mm");

                            var celdaTotal = ws.Cells[filaActual, 8];
                            celdaTotal.Value = venta.TotalVenta;
                            celdaTotal.Style.Numberformat.Format = "$ #,##0.00";
                            celdaTotal.Style.Font.Bold = true;

                            ws.Cells[filaActual, 9].Value = venta.EstadoTexto;
                            filaActual++;

                            // C. Sub-tabla con el Detalle de Productos de la venta
                            var listaDetalles = objCNVenta.ObtenerDetalleVenta(venta.venta_id);

                            if (listaDetalles != null && listaDetalles.Count > 0)
                            {
                                filaActual++;

                                string[] cabecerasDetalle = { "Producto / Artículo", "Cantidad", "Precio Unitario", "Subtotal" };
                                int colInicioDetalle = 2;

                                for (int i = 0; i < cabecerasDetalle.Length; i++)
                                {
                                    var cell = ws.Cells[filaActual, colInicioDetalle + i];
                                    cell.Value = cabecerasDetalle[i];
                                    cell.Style.Font.Bold = true;
                                    cell.Style.Font.Size = 9;
                                    cell.Style.Font.Color.SetColor(Color.FromArgb(100, 110, 120));
                                }
                                filaActual++;

                                foreach (var detalle in listaDetalles)
                                {
                                    ws.Cells[filaActual, 2].Value = detalle.NombreProducto;
                                    ws.Cells[filaActual, 3].Value = detalle.cantidad;

                                    var celdaPUnit = ws.Cells[filaActual, 4];
                                    celdaPUnit.Value = detalle.precio_unitario;
                                    celdaPUnit.Style.Numberformat.Format = "$ #,##0.00";

                                    var celdaSub = ws.Cells[filaActual, 5];
                                    celdaSub.Value = detalle.SubtotalFila;
                                    celdaSub.Style.Numberformat.Format = "$ #,##0.00";

                                    ws.Cells[filaActual, 2, filaActual, 5].Style.Font.Size = 9;
                                    filaActual++;
                                }
                            }

                            filaActual += 2;
                        }

                        ws.Cells[ws.Dimension.Address].AutoFitColumns();
                        File.WriteAllBytes(savefile.FileName, package.GetAsByteArray());
                    }

                    MessageBox.Show("Reporte de Excel generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
