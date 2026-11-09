using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Administrador;
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

namespace CapaPresentacion.GerenteComercial
{
    public partial class ReportesForm : Form
    {
        private CNVenta objCNVenta = new CNVenta();
        private bool cargandoFormulario = true;
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
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

            CargarHistorialReporte();
            cargandoFormulario = false;
            FiltrarReportePorFechas();
        }

        private void CargarHistorialReporte()
        {
            dgvResultadosReporte.AutoGenerateColumns = false;

            // Mapeo exacto de las columnas de tu grilla de reportes
            dgvResultadosReporte.Columns["colNroVenta"].DataPropertyName = "nro_venta";
            dgvResultadosReporte.Columns["colFechaVenta"].DataPropertyName = "fecha_venta";
            dgvResultadosReporte.Columns["colVendedor"].DataPropertyName = "NombreComprador";
            dgvResultadosReporte.Columns["colCliente"].DataPropertyName = "NombreCliente";
            dgvResultadosReporte.Columns["colMetodoPago"].DataPropertyName = "NombreMetodoPago";
            dgvResultadosReporte.Columns["colEstado"].DataPropertyName = "EstadoTexto";
            dgvResultadosReporte.Columns["colTotal"].DataPropertyName = "TotalVenta";

            // Cargamos todas las ventas activas o el listado general
            var listaVentas = objCNVenta.ListarHistorialVentas();
            dgvResultadosReporte.DataSource = listaVentas;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarReportePorFechas();
        }

        private void FiltrarReportePorFechas()
        {
            if (cargandoFormulario) return;

            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime fechaDesde = dtpDesde.Value.Date;
                DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1); 

                var listaFiltrada = objCNVenta.Buscar(null, string.Empty, string.Empty, 0, 1, fechaDesde, fechaHasta);

                dgvResultadosReporte.DataSource = listaFiltrada;

                // Actualizar las tarjetas de resumen superiores con los datos exactos del filtro
                lblVentasRealizadas.Text = listaFiltrada.Count.ToString("N0");
                lblTotalVendido.Text = "$ " + listaFiltrada.Sum(x => x.TotalVenta).ToString("N2");
                lblProductoVendido.Text = objCNVenta.CalcularTotalArticulosVendidosPorFecha(fechaDesde, fechaHasta).ToString("N0");
                lblClientesAtendidos.Text = objCNVenta.CalcularTotalClientesUnicosPorFecha(fechaDesde, fechaHasta).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvResultadosReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no sea el encabezado
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvResultadosReporte.Columns[e.ColumnIndex].Name;

            // Si hacen clic en la columna de ver detalle (o si quieres que se abra al hacer clic en cualquier celda de la fila)
            if (nombreColumna == "colVerDetalle" || nombreColumna == "colNroVenta")
            {
                EVenta ventaSeleccionada = (EVenta)dgvResultadosReporte.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada != null)
                {
                    // Reutilizamos exactamente el mismo modal DetalleVenta que ya creaste y usas en gestión
                    using (DetalleVenta modal = new DetalleVenta(ventaSeleccionada))
                    {
                        modal.ShowDialog();
                    }
                }
            }
        }

        private void btnExportarReporteExcel_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<EVenta> listaVentas = dgvResultadosReporte.DataSource as List<EVenta>;

            if (listaVentas == null || listaVentas.Count == 0)
            {
                MessageBox.Show("No hay registros de ventas en el rango seleccionado para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Reporte_Ventas_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            savefile.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Configuración de licencia requerida por EPPlus 8+
                    OfficeOpenXml.ExcelPackage.License.SetNonCommercialOrganization("MUSNOC");

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Reporte de Ventas");
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
                        ws.Cells[filaActual, 1].Value = $"Reporte de Ventas del {dtpDesde.Value:dd/MM/yyyy} al {dtpHasta.Value:dd/MM/yyyy} — Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} por {usuarioNombre}";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Italic = true;
                        filaActual += 2;

                        CNVenta objCNVenta = new CNVenta();

                        // RECORRIDO DE CADA VENTA Y SUS DETALLES
                        foreach (var venta in listaVentas)
                        {
                            // A. Cabecera principal de la Venta (7 Columnas coincidentes con la grilla)
                            string[] cabecerasVenta = { "Nro Venta", "Fecha Venta", "Vendedor", "Cliente", "Método Pago", "Total ($)", "Estado" };
                            for (int i = 0; i < cabecerasVenta.Length; i++)
                            {
                                var cell = ws.Cells[filaActual, i + 1];
                                cell.Value = cabecerasVenta[i];
                                cell.Style.Font.Bold = true;
                                cell.Style.Font.Size = 10;
                                cell.Style.Font.Color.SetColor(Color.FromArgb(41, 128, 185)); // Azul institucional
                            }
                            filaActual++;

                            // B. Datos de la Venta
                            ws.Cells[filaActual, 1].Value = venta.nro_venta;
                            ws.Cells[filaActual, 1].Style.Font.Bold = true;
                            ws.Cells[filaActual, 2].Value = Convert.ToDateTime(venta.fecha_venta).ToString("dd/MM/yyyy HH:mm");
                            ws.Cells[filaActual, 3].Value = venta.NombreComprador;
                            ws.Cells[filaActual, 4].Value = venta.NombreCliente;
                            ws.Cells[filaActual, 5].Value = venta.NombreMetodoPago;

                            var celdaTotal = ws.Cells[filaActual, 6];
                            celdaTotal.Value = venta.TotalVenta;
                            celdaTotal.Style.Numberformat.Format = "$ #,##0.00";
                            celdaTotal.Style.Font.Bold = true;

                            ws.Cells[filaActual, 7].Value = venta.EstadoTexto;
                            filaActual++;

                            // C. Sub-tabla con el Detalle de Productos de la venta
                            var listaDetalles = objCNVenta.ObtenerDetalleVenta(venta.venta_id);

                            if (listaDetalles != null && listaDetalles.Count > 0)
                            {
                                filaActual++;

                                string[] cabecerasDetalle = { "Producto / Artículo", "Cantidad", "Precio Unitario", "Subtotal" };
                                int colInicioDetalle = 2; // Desplazado para mantener jerarquía visual

                                for (int i = 0; i < cabecerasDetalle.Length; i++)
                                {
                                    var cell = ws.Cells[filaActual, colInicioDetalle + i];
                                    cell.Value = cabecerasDetalle[i];
                                    cell.Style.Font.Bold = true;
                                    cell.Style.Font.Size = 9;
                                    cell.Style.Font.Color.SetColor(Color.FromArgb(100, 110, 120)); // Gris secundario
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

                            // Espacio de separación limpio entre ventas
                            filaActual += 2;
                        }

                        // Ajustar automáticamente el ancho de las celdas
                        ws.Cells[ws.Dimension.Address].AutoFitColumns();

                        // Guardar y exportar el archivo físico
                        File.WriteAllBytes(savefile.FileName, package.GetAsByteArray());
                    }

                    MessageBox.Show("Reporte de Excel de ventas generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

