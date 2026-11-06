using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
                saveFileDialog.FileName = $"Reporte_Detallado_Ventas_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 1. Invocamos a la Capa de Negocio
                    CNVenta objCNVenta = new CNVenta();
                    List<EReporteVentaDetallado> listaDetallada = objCNVenta.ObtenerReportedetalladoVentas(fechaDesde, fechaHasta);

                    StringBuilder sb = new StringBuilder();

                    // 2. Encabezados de las columnas del CSV
                    sb.AppendLine("Nro Venta;Fecha y Hora;Vendedor;Cliente;Producto;Cantidad;Precio Unitario;Subtotal");

                    // 3. Recorremos la lista obtenida de la Capa de Negocio
                    foreach (var item in listaDetallada)
                    {
                        string linea = $"{item.NroVenta};" +
                                       $"{item.FechaVenta:dd/MM/yyyy HH:mm};" +
                                       $"\"{item.Vendedor}\";" +
                                       $"\"{item.Cliente}\";" +
                                       $"\"{item.Producto}\";" +
                                       $"{item.Cantidad};" +
                                       $"{item.PrecioUnitario.ToString().Replace(',', '.')};" +
                                       $"{item.Subtotal.ToString().Replace(',', '.')}";

                        sb.AppendLine(linea);
                    }

                    // 4. Guardamos en disco en UTF8
                    File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show("Reporte detallado exportado a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
 }

