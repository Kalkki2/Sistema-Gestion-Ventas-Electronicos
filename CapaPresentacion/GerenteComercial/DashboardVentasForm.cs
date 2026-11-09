using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.GerenteComercial
{
    public partial class DashboardVentasForm : Form
    {
        CNVenta objCNVenta = new CNVenta();
        public DashboardVentasForm()
        {
            InitializeComponent();
        }

        private void DashboardVentasForm_Load(object sender, EventArgs e)
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

            // Ampliamos el rango temporalmente para asegurarnos de capturar ventas existentes
            DateTime fechaDesde = new DateTime(2025, 1, 1); // O una fecha muy antigua
            DateTime fechaHasta = DateTime.Now.AddDays(1);

            cmbMesTendencia.DataSource = new Dictionary<int, string>()
            {
                {1, "Enero"}, {2, "Febrero"}, {3, "Marzo"}, {4, "Abril"},
                {5, "Mayo"}, {6, "Junio"}, {7, "Julio"}, {8, "Agosto"},
                {9, "Septiembre"}, {10, "Octubre"}, {11, "Noviembre"}, {12, "Diciembre"}
            }.ToList();
            cmbMesTendencia.DisplayMember = "Value";
            cmbMesTendencia.ValueMember = "Key";
            cmbMesTendencia.SelectedValue = DateTime.Now.Month;

            // Rellenar combo de años para la tendencia
            cmbAnioTendencia.DataSource = new List<int> { 2024, 2025, 2026, 2027 };
            cmbAnioTendencia.SelectedItem = DateTime.Now.Year;

            CargarDashboard(fechaDesde, fechaHasta);
            CargarGraficoTendenciaPorMesAnio();
        }

        //Carga el Dashboard con los datos HISTORICOS
        private void CargarDashboard(DateTime fechaDesde, DateTime fechaHasta)
        {
            CargarGraficoVentasPorMarca(fechaDesde, fechaHasta);
            CargarGraficoVentasMonetarias(fechaDesde, fechaHasta);
            CargarGraficoVentasPorMetodoPago(fechaDesde, fechaHasta);

            CargarTarjetasResumen(fechaDesde, fechaHasta);

            CargarTop10ProductosDelDia(fechaDesde, fechaHasta);
            CargarTop5Personal(fechaDesde, fechaHasta);

        }

        private void CargarGraficoVentasPorMarca(DateTime fechaDesde, DateTime fechaHasta)
        {
            CNVenta objCNVenta = new CNVenta();
            List<EMarcaVenta> listaDatos = objCNVenta.ObtenerVentasPorMarca(fechaDesde, fechaHasta);

            // 1. Limpiar áreas, series y leyendas previas
            crtCantVentasXMarca.Series.Clear(); // Puedes mantener el mismo control Chart o renombrarlo
            crtCantVentasXMarca.ChartAreas.Clear();
            crtCantVentasXMarca.Legends.Clear();
            crtCantVentasXMarca.Annotations.Clear();

            // 2. Configurar el Área del Gráfico (Dona)
            var chartArea = crtCantVentasXMarca.ChartAreas.Add("AreaDonaMarca");
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisX.LabelStyle.Enabled = false;
            chartArea.AxisY.LabelStyle.Enabled = false;

            // 3. Crear la Serie de tipo Dona (Doughnut)
            var serie = crtCantVentasXMarca.Series.Add("SeriesMarca");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            // Grosor del agujero central
            serie["DoughnutRadius"] = "62";

            // Habilitar porcentajes dentro de las porciones
            serie.IsValueShownAsLabel = true;
            serie.Label = "#PERCENT{P0}";
            serie.LabelForeColor = Color.White;

            serie.BorderColor = Color.White;
            serie.BorderWidth = 2;

            // 4. Paleta de colores modernos
            Color[] coloresModernos = new Color[] {
        Color.FromArgb(13, 110, 253),
        Color.FromArgb(25, 135, 84),
        Color.FromArgb(253, 126, 20),
        Color.FromArgb(111, 66, 193),
        Color.FromArgb(220, 53, 69)
    };

            int colorIndex = 0;

            // 5. Cargar los datos obtenidos de la BD
            foreach (var item in listaDatos)
            {
                int cantidadUnidades = item.TotalVentas;

                int pointIndex = serie.Points.AddXY(item.Marca, cantidadUnidades);
                var punto = serie.Points[pointIndex];

                punto.Color = coloresModernos[colorIndex % coloresModernos.Length];
                colorIndex++;

                // Muestra el nombre de la marca y sus unidades en la leyenda lateral (ej: "Samsung (15)")
                punto.LegendText = $"{item.Marca} ({cantidadUnidades})";
            }

            // 6. Configurar la Leyenda lateral derecha
            var leyenda = crtCantVentasXMarca.Legends.Add("LeyendaDerechaMarca");
            leyenda.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        }
        private void CargarGraficoTendenciaPorMesAnio()
        {
            if (cmbMesTendencia.SelectedValue == null || cmbAnioTendencia.SelectedItem == null) return;

            int mes = (int)cmbMesTendencia.SelectedValue;
            int anio = (int)cmbAnioTendencia.SelectedItem;

            List<ETendenciaVenta> listaDatos = objCNVenta.ObtenerTendenciaVentasDiariasPorMesAnio(mes, anio);

            string nombreSerie = "Series1";
            if (crtTendenciaVentas.Series.IndexOf(nombreSerie) == -1)
            {
                crtTendenciaVentas.Series.Add(nombreSerie);
            }

            crtTendenciaVentas.Series[nombreSerie].Points.Clear();
            crtTendenciaVentas.Series[nombreSerie].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            crtTendenciaVentas.Series[nombreSerie].IsValueShownAsLabel = true;
            crtTendenciaVentas.ChartAreas[0].AxisY.Minimum = 0;

            decimal totalGananciaMes = 0;

            foreach (var item in listaDatos)
            {
                int pointIndex = crtTendenciaVentas.Series[nombreSerie].Points.AddXY(item.Fecha, item.TotalVentas);
                var punto = crtTendenciaVentas.Series[nombreSerie].Points[pointIndex];

                punto.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                punto.MarkerSize = 10;
                punto.MarkerColor = Color.FromArgb(13, 110, 253);
                punto.LabelForeColor = Color.FromArgb(13, 110, 253);

                // Sumamos al acumulador (asumiendo que item.TotalVentas es decimal o numérico)
                totalGananciaMes += Convert.ToDecimal(item.TotalVentas);
            }

            // Mostrar el total acumulado en el Label (reemplaza 'lblGananciaMes' por el nombre real de tu label)
            lblTotalVentaMensual.Text = "$ " + totalGananciaMes.ToString("N2");
        }


        private void CargarTarjetasResumen(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Total Ventas (en $)
            decimal totalVentas = objCNVenta.CalcularTotalVentasPorFecha(fechaDesde, fechaHasta);
            lblTotalVentas.Text = "$ " + totalVentas.ToString("N2");

            // Total Artículos Vendidos (en unidades)
            int totalArticulos = objCNVenta.CalcularTotalArticulosVendidosPorFecha(fechaDesde, fechaHasta);
            lblTotalArticulos.Text = totalArticulos.ToString("N0");

            // Total Clientes Únicos
            int totalClientes = objCNVenta.CalcularTotalClientesUnicosPorFecha(fechaDesde, fechaHasta);
            lblTotalClientes.Text = totalClientes.ToString("N0");
        }

        private void CargarTop10ProductosDelDia(DateTime fechaDesde, DateTime fechaHasta)
        {
            dgvTopProductos.AutoGenerateColumns = false;

            dgvTopProductos.Columns["colCodigo"].DataPropertyName = "codigo";
            dgvTopProductos.Columns["colProducto"].DataPropertyName = "nombre";
            dgvTopProductos.Columns["colCantidad"].DataPropertyName = "cantidad_vendida";
            dgvTopProductos.Columns["colTotalVentas"].DataPropertyName = "total_recaudado";

            var lista = objCNVenta.ListarTop10ProductosMasVendidos(fechaDesde, fechaHasta);
            dgvTopProductos.DataSource = lista;
        }

        private void CargarGraficoVentasMonetarias(DateTime fechaDesde, DateTime fechaHasta)
        {
            CNVenta objCNVenta = new CNVenta();
            List<ECategoriaVenta> listaDatos = objCNVenta.ObtenerVentasMonetariasPorCategoria(fechaDesde, fechaHasta);

            // 1. Limpiar el control Chart exclusivo
            crtVentasMonetarias.Series.Clear();
            crtVentasMonetarias.ChartAreas.Clear();
            crtVentasMonetarias.Legends.Clear();

            // 2. Configurar el área del gráfico
            var chartArea = crtVentasMonetarias.ChartAreas.Add("AreaBarrasVerticales");
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            // Fuentes y estilo de los ejes
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 8.5F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 8.5F);

            chartArea.AxisX.Interval = 1; // Muestra todas las categorías sin saltarse ninguna
            chartArea.AxisX.LabelStyle.Angle = -25; // Inclina un poquito los nombres si son largos para que entren cómodos

            // Margen interno para que las barras no choquen contra los bordes del cuadro
            chartArea.Position = new ElementPosition(3, 8, 94, 85);

            // 3. Crear la Serie de tipo COLUMNA VERTICAL
            var serie = crtVentasMonetarias.Series.Add("SeriesColumnaDinero");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Configurar etiquetas de valores arriba de cada columna
            serie.IsValueShownAsLabel = true;
            serie.Label = "$ #VAL{N0}";
            serie.LabelForeColor = Color.FromArgb(30, 50, 80);
            serie.BorderColor = Color.Transparent;

            // 4. Paleta de colores modernos (coincidente con el gráfico de al lado)
            Color[] coloresBarras = new Color[] {
        Color.FromArgb(13, 110, 253),  // Azul
        Color.FromArgb(25, 135, 84),   // Verde
        Color.FromArgb(253, 126, 20),  // Naranja
        Color.FromArgb(111, 66, 193),  // Morado
        Color.FromArgb(220, 53, 69)    // Rojo
    };

            int colorIndex = 0;

            // 5. Cargar los datos a las columnas verticales
            foreach (var item in listaDatos)
            {
                int pointIndex = serie.Points.AddXY(item.Categoria, item.TotalVentas);
                var punto = serie.Points[pointIndex];

                punto.Color = coloresBarras[colorIndex % coloresBarras.Length];
                colorIndex++;
            }
        }

        // Carga la grilla con el personal que mas vendio
        private void CargarTop5Personal(DateTime fechaDesde, DateTime fechaHasta)
        {
            dgvTopVendedores.AutoGenerateColumns = false;
            dgvTopVendedores.Columns["colVendedor"].DataPropertyName = "NombreVendedor";
            dgvTopVendedores.Columns["colTotalVentasVendedor"].DataPropertyName = "TotalVentas";
            dgvTopVendedores.Columns["colCantArticulos"].DataPropertyName = "CantidadArticulos";
            dgvTopVendedores.Columns["colPorcentaje"].DataPropertyName = "Porcentaje";
            dgvTopVendedores.Columns["colPorcentaje"].DefaultCellStyle.Format = "0.0' %'"; // Formato de porcentaje

            var lista = objCNVenta.ObtenerTop5PersonalVentas(fechaDesde, fechaHasta);
            dgvTopVendedores.DataSource = lista;
        }

        private void CargarGraficoVentasPorMetodoPago(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<EMetodoPagoVenta> listaDatos = objCNVenta.ObtenerVentasPorMetodoPago(fechaDesde, fechaHasta);

            // 1. Limpiar áreas, series y leyendas previas
            crtMetodoPago.Series.Clear();
            crtMetodoPago.ChartAreas.Clear();
            crtMetodoPago.Legends.Clear();

            // 2. Configurar el Área del Gráfico
            var chartArea = crtMetodoPago.ChartAreas.Add("AreaTorta");
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisX.LabelStyle.Enabled = false;
            chartArea.AxisY.LabelStyle.Enabled = false;

            // 3. Crear la Serie de tipo Torta (Pie)
            var serie = crtMetodoPago.Series.Add("SeriesMetodoPago");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // 4. Paleta de colores modernos
            Color[] coloresMetodos = new Color[] {
                Color.FromArgb(59, 173, 64) ,  // verde claro
                Color.FromArgb(93, 159, 186),  // azul
        
            };

            int colorIndex = 0;

            // 5. Cargar los datos y configurar la leyenda para que muestre el porcentaje automático (#PERCENT)
            foreach (var item in listaDatos)
            {
                int pointIndex = serie.Points.AddXY(item.MetodoPago, item.TotalRecaudado);
                var punto = serie.Points[pointIndex];

                punto.Color = coloresMetodos[colorIndex % coloresMetodos.Length];
                colorIndex++;

                punto.LegendText = "#VALX (#PERCENT)";
            }

            // 6. Configurar la Leyenda lateral derecha
            var leyenda = crtMetodoPago.Legends.Add("LeyendaMetodos");
            leyenda.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
          
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1); 

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDashboard(fechaDesde, fechaHasta);
        }

        private void btnFiltrarTendencia_Click(object sender, EventArgs e)
        {
            CargarGraficoTendenciaPorMesAnio();
        }
    }
}
