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

namespace CapaPresentacion.Vendedor
{
    public partial class BuscarProductoVentaForm : Form
    {
        private readonly CNProducto objCNProducto = new CNProducto();
        private List<EProducto> todosLosProductos = new List<EProducto>();
        private bool cargando = true; // true hasta que terminen de cargarse los combos

        public EProducto ProductoSeleccionado { get; private set; }

        public BuscarProductoVentaForm()
        {
            InitializeComponent();

            // Configuración de la grilla hecha por código (el diseño de esta rama no la trae)
            dgvListaProductos.AutoGenerateColumns = false;
            if (dgvListaProductos.Columns.Count >= 7)
            {
                dgvListaProductos.Columns[0].DataPropertyName = "codigo";
                dgvListaProductos.Columns[1].DataPropertyName = "nombre";
                dgvListaProductos.Columns[2].DataPropertyName = "precio_venta";
                dgvListaProductos.Columns[2].DefaultCellStyle.Format = "C2";
                dgvListaProductos.Columns[3].DataPropertyName = "stock";
                dgvListaProductos.Columns[4].DataPropertyName = "NombreCategoria";
                dgvListaProductos.Columns[5].DataPropertyName = "NombreMarca";

                DataGridViewButtonColumn colSel = dgvListaProductos.Columns[6] as DataGridViewButtonColumn;
                if (colSel != null)
                {
                    colSel.Text = "Seleccionar";
                    colSel.UseColumnTextForButtonValue = true;
                }
            }

            // Eventos enganchados por código (se desenganchan antes por si el diseño ya los tenía)
            this.Load -= BuscarProductoVentaForm_Load;
            this.Load += BuscarProductoVentaForm_Load;
            dgvListaProductos.CellContentClick -= dgvListaProductos_CellContentClick;
            dgvListaProductos.CellContentClick += dgvListaProductos_CellContentClick;

            // Filtros dinámicos: se aplican mientras se escribe o se cambia un combo
            // guna2ComboBox2 = Categoría, guna2ComboBox1 = Marca
            txtBuscarProducto.TextChanged += (s, e) => AplicarFiltros();
            guna2ComboBox2.SelectedIndexChanged += (s, e) => AplicarFiltros();
            guna2ComboBox1.SelectedIndexChanged += (s, e) => AplicarFiltros();
        }

        private void BuscarProductoVentaForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvListaProductos.AutoGenerateColumns = false;
            todosLosProductos = objCNProducto.ListarProductos();
            CargarCombos();
            AplicarFiltros();
        }

        // Llena los combos con las categorías y marcas de los productos cargados
        private void CargarCombos()
        {
            cargando = true;

            guna2ComboBox2.Items.Clear();
            guna2ComboBox2.Items.Add("Todos");
            foreach (string nombre in todosLosProductos
                .Select(p => p.NombreCategoria)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct().OrderBy(n => n))
            {
                guna2ComboBox2.Items.Add(nombre);
            }
            guna2ComboBox2.SelectedIndex = 0;

            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("Todos");
            foreach (string nombre in todosLosProductos
                .Select(p => p.NombreMarca)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct().OrderBy(n => n))
            {
                guna2ComboBox1.Items.Add(nombre);
            }
            guna2ComboBox1.SelectedIndex = 0;

            cargando = false;
        }

        private void AplicarFiltros()
        {
            if (cargando) return;

            string texto = txtBuscarProducto.Text.Trim();
            string categoria = guna2ComboBox2.Text;
            string marca = guna2ComboBox1.Text;

            var filtrados = todosLosProductos.Where(p =>
                (string.IsNullOrEmpty(texto)
                    || (p.codigo ?? "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
                    || (p.nombre ?? "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                && (string.IsNullOrEmpty(categoria) || categoria == "Todos" || p.NombreCategoria == categoria)
                && (string.IsNullOrEmpty(marca) || marca == "Todos" || p.NombreMarca == marca)
            ).ToList();

            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = filtrados;
        }

        private void dgvListaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var producto = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;
                if (producto != null)
                {
                    string nombreColumna = dgvListaProductos.Columns[e.ColumnIndex].Name;

                    if (nombreColumna.Contains("Categoria"))
                    {
                        e.Value = producto.NombreCategoria;
                        e.FormattingApplied = true;
                    }

                    if (nombreColumna.Contains("Marca"))
                    {
                        e.Value = producto.NombreMarca;
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Solo reaccionar en la columna Seleccionar (la número 6)
            if (e.ColumnIndex != 6) return;

            EProducto producto = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;
            if (producto == null)
            {
                MessageBox.Show("No se pudo leer el producto de esa fila.");
                return;
            }

            ProductoSeleccionado = producto;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}