using CapaEntidad;
using CapaNegocio;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class DetalleCompraProducto : Form
    {
        private ECompra _compraActual;
        public DetalleCompraProducto(ECompra compraSeleccionada)
        {
            InitializeComponent();
            _compraActual = compraSeleccionada;
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar el cuadro de diálogo para guardar el archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"ComprobanteCompra_{_compraActual.nro_factura}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Definir el documento con márgenes limpios
                    Document doc = new Document(PageSize.A4, 36, 36, 36, 36);
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    //  Colores institucionales
                    BaseColor colorPrimario = new BaseColor(15, 23, 42);   // #0f172a
                    BaseColor colorGrisClaro = new BaseColor(241, 245, 249); // #f1f5f9
                    BaseColor colorTexto = new BaseColor(51, 65, 85);      // #334155

                    // Fuentes tipográficas de iTextSharp
                    iTextSharp.text.Font fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, colorPrimario);
                    iTextSharp.text.Font fuenteSubTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, colorPrimario);
                    iTextSharp.text.Font fuenteTexto = FontFactory.GetFont(FontFactory.HELVETICA, 9, colorTexto);
                    iTextSharp.text.Font fuenteTextoBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, colorTexto);
                    iTextSharp.text.Font fuenteTh = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.WHITE);

                    // ENCABEZADO: TÍTULO Y DATOS DE LA EMPRESA
                    PdfPTable tablaHeader = new PdfPTable(2);
                    tablaHeader.WidthPercentage = 100;
                    tablaHeader.SetWidths(new float[] { 50f, 50f });

                    PdfPCell celdaLogo = new PdfPCell(new Phrase("MUSNOC - COMPRA", fuenteTitulo));
                    celdaLogo.Border = PdfPCell.NO_BORDER;
                    celdaLogo.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tablaHeader.AddCell(celdaLogo);

                    PdfPCell celdaEmpresa = new PdfPCell(new Phrase(
                        "Dirección: Av. 3 Abril Corrientes - Corrientes - Argentina\nTel: +54 9 379 634-7610",
                        FontFactory.GetFont(FontFactory.HELVETICA, 8, colorTexto)));
                    celdaEmpresa.Border = PdfPCell.NO_BORDER;
                    celdaEmpresa.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celdaEmpresa.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tablaHeader.AddCell(celdaEmpresa);

                    doc.Add(tablaHeader);
                    doc.Add(new Paragraph(" "));

                    // Línea divisoria
                    PdfPTable linea = new PdfPTable(1);
                    linea.WidthPercentage = 100;
                    PdfPCell celdaLinea = new PdfPCell();
                    celdaLinea.BackgroundColor = colorPrimario;
                    celdaLinea.FixedHeight = 2f;
                    celdaLinea.Border = PdfPCell.NO_BORDER;
                    linea.AddCell(celdaLinea);
                    doc.Add(linea);
                    doc.Add(new Paragraph(" "));

                    // INFORMACIÓN DE LA COMPRA, RESPONSABLE Y PROVEEDOR
                    PdfPTable tablaInfo = new PdfPTable(2);
                    tablaInfo.WidthPercentage = 100;
                    tablaInfo.SetWidths(new float[] { 50f, 50f });

                    string infoIzquierda =
                        $"Nro Factura: {_compraActual.nro_factura}\n" +
                        $"Fecha Compra: {_compraActual.fecha_compra:dd/MM/yyyy HH:mm:ss}";

                    string infoDerecha =
                        $"Responsable: {(_compraActual.NombreComprador ?? "N/D")} (DNI: {(_compraActual.DniUsuario ?? "")})\n" +
                        $"Proveedor: {(_compraActual.NombreProveedor ?? "N/D")} (CUIT: {(_compraActual.CuitProveedor ?? "")})";

                    PdfPCell cIzq = new PdfPCell(new Phrase(infoIzquierda, fuenteTexto));
                    cIzq.Border = PdfPCell.NO_BORDER;
                    tablaInfo.AddCell(cIzq);

                    PdfPCell cDer = new PdfPCell(new Phrase(infoDerecha, fuenteTexto));
                    cDer.Border = PdfPCell.NO_BORDER;
                    tablaInfo.AddCell(cDer);

                    doc.Add(tablaInfo);
                    doc.Add(new Paragraph(" "));

                    // GRILLA DE DETALLE DE PRODUCTOS (COMPRA)
                    PdfPTable tablaDetalle = new PdfPTable(5);
                    tablaDetalle.WidthPercentage = 100;
                    tablaDetalle.SetWidths(new float[] { 18f, 37f, 15f, 15f, 15f });

                    string[] headers = { "Código", "Producto", "Cantidad", "Costo U. ($)", "Subtotal ($)" };
                    foreach (string h in headers)
                    {
                        PdfPCell th = new PdfPCell(new Phrase(h, fuenteTh));
                        th.BackgroundColor = colorPrimario;
                        th.HorizontalAlignment = Element.ALIGN_CENTER;
                        th.Padding = 6;
                        tablaDetalle.AddCell(th);
                    }

                    CNCompra objCN = new CNCompra();
                    List<EDetalleCompra> listaDetalles = objCN.ObtenerDetalleCompra(_compraActual.compra_id);

                    decimal totalGeneral = 0;
                    if (listaDetalles != null)
                    {
                        foreach (var item in listaDetalles)
                        {
                            decimal subtotalFila = item.cantidad * item.costo_unitario;
                            totalGeneral += subtotalFila;

                            PdfPCell tdCod = new PdfPCell(new Phrase(item.CodigoProducto ?? "N/D", fuenteTexto));
                            tdCod.Padding = 5;
                            tablaDetalle.AddCell(tdCod);

                            PdfPCell tdProd = new PdfPCell(new Phrase(item.NombreProducto ?? "Producto", fuenteTexto));
                            tdProd.Padding = 5;
                            tablaDetalle.AddCell(tdProd);

                            PdfPCell tdCant = new PdfPCell(new Phrase(item.cantidad.ToString(), fuenteTexto));
                            tdCant.HorizontalAlignment = Element.ALIGN_CENTER;
                            tdCant.Padding = 5;
                            tablaDetalle.AddCell(tdCant);

                            PdfPCell tdCosto = new PdfPCell(new Phrase($"$ {item.costo_unitario:N2}", fuenteTexto));
                            tdCosto.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tdCosto.Padding = 5;
                            tablaDetalle.AddCell(tdCosto);

                            PdfPCell tdSub = new PdfPCell(new Phrase($"$ {subtotalFila:N2}", fuenteTexto));
                            tdSub.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tdSub.Padding = 5;
                            tablaDetalle.AddCell(tdSub);
                        }
                    }

                    doc.Add(tablaDetalle);
                    doc.Add(new Paragraph(" "));

                    // ==========================================
                    // TOTALES DE LA COMPRA
                    // ==========================================
                    PdfPTable tablaTotales = new PdfPTable(2);
                    tablaTotales.WidthPercentage = 45;
                    tablaTotales.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tablaTotales.SetWidths(new float[] { 60f, 40f });

                    iTextSharp.text.Font fuenteTotalFinal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, colorPrimario);
                    tablaTotales.AddCell(new PdfPCell(new Phrase("TOTAL GENERAL:", fuenteTotalFinal)) { Border = PdfPCell.TOP_BORDER, Padding = 5 });
                    tablaTotales.AddCell(new PdfPCell(new Phrase($"$ {totalGeneral:N2}", fuenteTotalFinal)) { Border = PdfPCell.TOP_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });

                    doc.Add(tablaTotales);

                    doc.Close();

                    MessageBox.Show("Comprobante de compra PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante PDF de compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DetalleCompraProducto_Load(object sender, EventArgs e)
        {
            // 1. Rellenar los datos de la cabecera con la información del objeto
            lblNroFactura.Text = $"Detalle de la compra: {_compraActual.nro_factura}";
            lblFechaHora.Text = _compraActual.fecha_compra.ToString("dd/MM/yyyy HH:mm:ss");
            lblResponsable.Text = _compraActual.NombreComprador;
            lblDniResponsable.Text = _compraActual.DniUsuario;
            lblProveedor.Text = _compraActual.NombreProveedor;
            lblCuitProveedor.Text = _compraActual.CuitProveedor;

            // 2. Cargar los detalles en el DataGridView interno
            CargarDetallesGrilla();
        }

        private void CargarDetallesGrilla()
        {
            dgvDetalleItems.AutoGenerateColumns = false;

            // Vinculamos las columnas con las propiedades planas de EDetalleCompra
            dgvDetalleItems.Columns["colCodigo"].DataPropertyName = "CodigoProducto";
            dgvDetalleItems.Columns["colProducto"].DataPropertyName = "NombreProducto";
            dgvDetalleItems.Columns["colCantidad"].DataPropertyName = "cantidad";
            dgvDetalleItems.Columns["colCostoUnitario"].DataPropertyName = "costo_unitario";
            dgvDetalleItems.Columns["colSubtotal"].DataPropertyName = "SubtotalFila";

            CNCompra objCN = new CNCompra();
            var listaDetalles = objCN.ObtenerDetalleCompra(_compraActual.compra_id);

            dgvDetalleItems.DataSource = listaDetalles;

            // Calcular el total general sumando los subtotales
            decimal totalGeneral = 0;
            foreach (var item in listaDetalles)
            {
                totalGeneral += (item.cantidad * item.costo_unitario);
            }

            lblTotalGeneral.Text = "$" + totalGeneral.ToString("0.00");
            lblTotalComprados.Text = listaDetalles.Count.ToString(); // Cantidad de ítems distintos o suma de cantidades
        }
    }
}
