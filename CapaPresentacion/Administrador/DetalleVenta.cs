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
    public partial class DetalleVenta : Form
    {
        private EVenta _venta;
        public DetalleVenta(EVenta ventaSeleccionada)
        {
            InitializeComponent();
            _venta = ventaSeleccionada;
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            if (_venta == null) return;

            // Cargar cabecera del comprobante
            lblDireccion.Text = _venta.nro_venta;
            lblValorFechaHora.Text = _venta.fecha_venta.ToString("dd/MM/yyyy HH:mm:ss");

            if (_venta.oUsuario != null)
            {
                lblApeYNomVendedor.Text = $"{_venta.oUsuario.apellido}, {_venta.oUsuario.nombre}";
                lblDniVendedor.Text = _venta.oUsuario.dni;
            }

            if (_venta.oCliente != null)
            {
                lblApeYNomCliente.Text = $"{_venta.oCliente.apellido}, {_venta.oCliente.nombre}";
                lblDniCliente.Text = _venta.oCliente.dni;
            }

            if (_venta.oMetodoPago != null)
            {
                lblFormaPago.Text = _venta.oMetodoPago.nombre;
            }

            // Cargar el detalle de los productos en el DataGridView
            CargarDetalleProductos();
        }

        private void CargarDetalleProductos()
        {
            CNVenta objCNVenta = new CNVenta();
            List<EDetalleVenta> listaDetalle = objCNVenta.ObtenerDetalleVenta(_venta.venta_id);

            dgvDetalleVenta.AutoGenerateColumns = false;

            // Mapeo de columnas con las propiedades de EDetalleVenta
            dgvDetalleVenta.Columns["colProducto"].DataPropertyName = "NombreProducto";
            dgvDetalleVenta.Columns["colCantidad"].DataPropertyName = "cantidad";
            dgvDetalleVenta.Columns["colPrecio"].DataPropertyName = "precio_unitario";
            dgvDetalleVenta.Columns["colSubtotal"].DataPropertyName = "SubtotalFila";

            dgvDetalleVenta.DataSource = listaDetalle;

            //  Calcular los totales, subtotales y el ajuste (descuento/recargo)
            decimal totalBruto = 0;
            if (listaDetalle != null)
            {
                foreach (var item in listaDetalle)
                {
                    totalBruto += item.SubtotalFila;
                }
            }

            // Mostramos el total bruto de los productos
            lblTotalBruto.Text = $"$ {totalBruto:N2}";

            // Obtenemos los valores guardados en la venta
            decimal porcentaje = _venta.porcentaje_aplicado; // Ej: 10.00
            decimal montoAjuste = (totalBruto * porcentaje) / 100; // Multiplicación corregida
            decimal totalFinal = totalBruto;

            // Evaluamos el tipo de ajuste
            string tipoAjusteNombre = _venta.NombreTipoAjuste;

            if (tipoAjusteNombre == "Descuento" || (_venta.oMetodoPago != null && _venta.oMetodoPago.tipo_ajuste_id == 2))
            {
                lblTextoAjuste.Text = $"Ajuste Descuento %{porcentaje:0.##}";
                lblMontoAjuste.Text = $"- $ {montoAjuste:N2}";
                totalFinal = totalBruto - montoAjuste; // Resta corregida
            }
            else if (tipoAjusteNombre == "Recargo" || (_venta.oMetodoPago != null && _venta.oMetodoPago.tipo_ajuste_id == 1))
            {
                lblTextoAjuste.Text = $"Ajuste Recargo %{porcentaje:0.##}";
                lblMontoAjuste.Text = $"+ $ {montoAjuste:N2}";
                totalFinal = totalBruto + montoAjuste;
            }
            else // Sin ajuste
            {
                lblTextoAjuste.Text = "Sin ajuste";
                lblMontoAjuste.Text = "$ 0.00";
                totalFinal = totalBruto;
            }

            // Mostramos el total final a pagar
            lblTotalAPagar.Text = $"$ {totalFinal:N2}";
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Configurar el cuadro de diálogo para guardar el archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"Comprobante_{_venta.nro_venta}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 2. Definir el documento con márgenes limpios
                    Document doc = new Document(PageSize.A4, 36, 36, 36, 36);
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    // 3. Colores institucionales
                    BaseColor colorPrimario = new BaseColor(15, 23, 42);   // #0f172a
                    BaseColor colorGrisClaro = new BaseColor(241, 245, 249); // #f1f5f9
                    BaseColor colorTexto = new BaseColor(51, 65, 85);      // #334155

                    // Fuentes tipográficas de iTextSharp explícitamente con su namespace completo para evitar ambigüedades
                    iTextSharp.text.Font fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, colorPrimario);
                    iTextSharp.text.Font fuenteSubTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, colorPrimario);
                    iTextSharp.text.Font fuenteTexto = FontFactory.GetFont(FontFactory.HELVETICA, 9, colorTexto);
                    iTextSharp.text.Font fuenteTextoBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, colorTexto);
                    iTextSharp.text.Font fuenteTh = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.WHITE);

                    // ==========================================
                    // ENCABEZADO: TÍTULO Y DATOS DE LA EMPRESA
                    // ==========================================
                    PdfPTable tablaHeader = new PdfPTable(2);
                    tablaHeader.WidthPercentage = 100;
                    tablaHeader.SetWidths(new float[] { 50f, 50f });

                    PdfPCell celdaLogo = new PdfPCell(new Phrase("MUSNOC", fuenteTitulo));
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

                    // ==========================================
                    // INFORMACIÓN DE LA VENTA, VENDEDOR Y CLIENTE
                    // ==========================================
                    PdfPTable tablaInfo = new PdfPTable(2);
                    tablaInfo.WidthPercentage = 100;
                    tablaInfo.SetWidths(new float[] { 50f, 50f });

                    string infoIzquierda =
                        $"Nro Venta: {_venta.nro_venta}\n" +
                        $"Fecha: {_venta.fecha_venta:dd/MM/yyyy HH:mm:ss}\n" +
                        $"Forma de Pago: {(_venta.oMetodoPago != null ? _venta.oMetodoPago.nombre : "N/D")}";

                    string infoDerecha =
                        $"Vendedor: {(_venta.oUsuario != null ? $"{_venta.oUsuario.apellido}, {_venta.oUsuario.nombre}" : "N/D")} (DNI: {(_venta.oUsuario != null ? _venta.oUsuario.dni : "")})\n" +
                        $"Cliente: {(_venta.oCliente != null ? $"{_venta.oCliente.apellido}, {_venta.oCliente.nombre}" : "N/D")} (DNI: {(_venta.oCliente != null ? _venta.oCliente.dni : "")})";

                    PdfPCell cIzq = new PdfPCell(new Phrase(infoIzquierda, fuenteTexto));
                    cIzq.Border = PdfPCell.NO_BORDER;
                    tablaInfo.AddCell(cIzq);

                    PdfPCell cDer = new PdfPCell(new Phrase(infoDerecha, fuenteTexto));
                    cDer.Border = PdfPCell.NO_BORDER;
                    tablaInfo.AddCell(cDer);

                    doc.Add(tablaInfo);
                    doc.Add(new Paragraph(" "));

                    // ==========================================
                    // GRILLA DE DETALLE DE PRODUCTOS
                    // ==========================================
                    PdfPTable tablaDetalle = new PdfPTable(4);
                    tablaDetalle.WidthPercentage = 100;
                    tablaDetalle.SetWidths(new float[] { 50f, 15f, 17f, 18f });

                    string[] headers = { "Producto", "Cantidad", "Precio ($)", "Subtotal ($)" };
                    foreach (string h in headers)
                    {
                        PdfPCell th = new PdfPCell(new Phrase(h, fuenteTh));
                        th.BackgroundColor = colorPrimario;
                        th.HorizontalAlignment = Element.ALIGN_CENTER;
                        th.Padding = 6;
                        tablaDetalle.AddCell(th);
                    }

                    CNVenta objCNVenta = new CNVenta();
                    List<EDetalleVenta> listaDetalle = objCNVenta.ObtenerDetalleVenta(_venta.venta_id);

                    decimal totalBruto = 0;
                    if (listaDetalle != null)
                    {
                        foreach (var item in listaDetalle)
                        {
                            totalBruto += item.SubtotalFila;

                            PdfPCell tdProd = new PdfPCell(new Phrase(item.oProducto != null ? item.oProducto.nombre : "Producto", fuenteTexto));
                            tdProd.Padding = 5;
                            tablaDetalle.AddCell(tdProd);

                            PdfPCell tdCant = new PdfPCell(new Phrase(item.cantidad.ToString(), fuenteTexto));
                            tdCant.HorizontalAlignment = Element.ALIGN_CENTER;
                            tdCant.Padding = 5;
                            tablaDetalle.AddCell(tdCant);

                            PdfPCell tdPrecio = new PdfPCell(new Phrase($"$ {item.precio_unitario:N2}", fuenteTexto));
                            tdPrecio.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tdPrecio.Padding = 5;
                            tablaDetalle.AddCell(tdPrecio);

                            PdfPCell tdSub = new PdfPCell(new Phrase($"$ {item.SubtotalFila:N2}", fuenteTexto));
                            tdSub.HorizontalAlignment = Element.ALIGN_RIGHT;
                            tdSub.Padding = 5;
                            tablaDetalle.AddCell(tdSub);
                        }
                    }

                    doc.Add(tablaDetalle);
                    doc.Add(new Paragraph(" "));

                    // ==========================================
                    // TOTALES Y AJUSTES (RECARGOS / DESCUENTOS)
                    // ==========================================
                    decimal porcentaje = _venta.porcentaje_aplicado;
                    decimal montoAjuste = (totalBruto * porcentaje) / 100;
                    decimal totalFinal = totalBruto;
                    string textoAjusteDesc = "Sin ajuste";
                    string montoAjusteStr = "$ 0,00";

                    string tipoAjusteNombre = _venta.NombreTipoAjuste;
                    if (tipoAjusteNombre == "Descuento" || (_venta.oMetodoPago != null && _venta.oMetodoPago.tipo_ajuste_id == 2))
                    {
                        textoAjusteDesc = $"Ajuste Descuento %{porcentaje:0.##}";
                        montoAjusteStr = $"- $ {montoAjuste:N2}";
                        totalFinal = totalBruto - montoAjuste;
                    }
                    else if (tipoAjusteNombre == "Recargo" || (_venta.oMetodoPago != null && _venta.oMetodoPago.tipo_ajuste_id == 1))
                    {
                        textoAjusteDesc = $"Ajuste Recargo %{porcentaje:0.##}";
                        montoAjusteStr = $"+ $ {montoAjuste:N2}";
                        totalFinal = totalBruto + montoAjuste;
                    }

                    PdfPTable tablaTotales = new PdfPTable(2);
                    tablaTotales.WidthPercentage = 45;
                    tablaTotales.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tablaTotales.SetWidths(new float[] { 60f, 40f });

                    tablaTotales.AddCell(new PdfPCell(new Phrase("TOTAL:", fuenteTextoBold)) { Border = PdfPCell.NO_BORDER, Padding = 3 });
                    tablaTotales.AddCell(new PdfPCell(new Phrase($"$ {totalBruto:N2}", fuenteTextoBold)) { Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 3 });

                    tablaTotales.AddCell(new PdfPCell(new Phrase(textoAjusteDesc, fuenteTexto)) { Border = PdfPCell.NO_BORDER, Padding = 3 });
                    tablaTotales.AddCell(new PdfPCell(new Phrase(montoAjusteStr, fuenteTexto)) { Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 3 });

                    iTextSharp.text.Font fuenteTotalFinal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, colorPrimario);
                    tablaTotales.AddCell(new PdfPCell(new Phrase("TOTAL A PAGAR:", fuenteTotalFinal)) { Border = PdfPCell.TOP_BORDER, Padding = 5 });
                    tablaTotales.AddCell(new PdfPCell(new Phrase($"$ {totalFinal:N2}", fuenteTotalFinal)) { Border = PdfPCell.TOP_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });

                    doc.Add(tablaTotales);

                    doc.Close();

                    MessageBox.Show("Comprobante PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el comprobante PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }


