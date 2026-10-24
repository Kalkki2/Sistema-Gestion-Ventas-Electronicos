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
    public partial class ProductosForm : Form
    {
        private readonly CNProducto objCNProducto = new CNProducto();

        // Todos los productos traídos de la base; los filtros trabajan sobre esta lista
        private List<EProducto> todosLosProductos = new List<EProducto>();

        // Evita que los combos disparen filtros mientras se están cargando
        private bool cargando = false;

        public ProductosForm()
        {
            InitializeComponent();

            // Columnas de la grilla -> propiedades de EProducto
            dgvListaProductos.AutoGenerateColumns = false;
            colCodigo.DataPropertyName = "codigo";
            colNombre.DataPropertyName = "nombre";
            colPrecio.DataPropertyName = "precio_venta";
            colStock.DataPropertyName = "stock";
            colCategoria.DataPropertyName = "NombreCategoria";
            colMarca.DataPropertyName = "NombreMarca";

            colPrecio.DefaultCellStyle.Format = "C2";
            colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // El botón "Ver Detalles" (Column1) sale con texto
            Column1.Text = "Ver";
            Column1.UseColumnTextForButtonValue = true;

            // Filtros dinámicos: se aplican mientras se escribe o se cambia un combo
            txtBuscarProducto.TextChanged += (s, e) => AplicarFiltros();
            cmbFiltroCategoria.SelectedIndexChanged += (s, e) => AplicarFiltros();
            cmbFiltroMarca.SelectedIndexChanged += (s, e) => AplicarFiltros();
            btnFiltrar.Click += (s, e) => AplicarFiltros();

            dgvListaProductos.CellContentClick += dgvListaProductos_CellContentClick;
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            LimpiarDetalle();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                todosLosProductos = objCNProducto.ListarProductos();
                CargarCombos();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Llena los combos con las categorías y marcas que tienen los productos cargados
        private void CargarCombos()
        {
            cargando = true;

            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.Add("Todos");
            foreach (string nombre in todosLosProductos
                .Select(p => p.NombreCategoria)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct()
                .OrderBy(n => n))
            {
                cmbFiltroCategoria.Items.Add(nombre);
            }
            cmbFiltroCategoria.SelectedIndex = 0;

            cmbFiltroMarca.Items.Clear();
            cmbFiltroMarca.Items.Add("Todos");
            foreach (string nombre in todosLosProductos
                .Select(p => p.NombreMarca)
                .Where(n => !string.IsNullOrEmpty(n))
                .Distinct()
                .OrderBy(n => n))
            {
                cmbFiltroMarca.Items.Add(nombre);
            }
            cmbFiltroMarca.SelectedIndex = 0;

            cargando = false;
        }

        // Filtra por texto (código o nombre), categoría y marca, todo combinado
        private void AplicarFiltros()
        {
            if (cargando) return;

            string texto = txtBuscarProducto.Text.Trim();
            string categoria = cmbFiltroCategoria.Text;
            string marca = cmbFiltroMarca.Text;

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

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        // Botón "Ver Detalles": pasa los datos del producto al panel de la derecha
        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvListaProductos.Columns[e.ColumnIndex].Name != "Column1") return;

            EProducto p = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;
            if (p == null) return;

            guna2TextBox2.Text = p.codigo;                       // Código
            guna2TextBox3.Text = p.nombre;                       // Nombre
            guna2TextBox4.Text = p.precio_venta.ToString("C2");  // Precio actual
            guna2TextBox5.Text = p.stock + " Unidades";          // Stock disponible
            guna2TextBox6.Text = p.NombreMarca;                  // Marca
            guna2TextBox7.Text = p.NombreCategoria;              // Categoría
            guna2TextBox8.Text = p.descripcion;                  // Descripción
        }

        // Deja vacío el panel de detalles (el diseño trae un producto de ejemplo escrito a mano)
        private void LimpiarDetalle()
        {
            guna2TextBox2.Text = string.Empty;
            guna2TextBox3.Text = string.Empty;
            guna2TextBox4.Text = string.Empty;
            guna2TextBox5.Text = string.Empty;
            guna2TextBox6.Text = string.Empty;
            guna2TextBox7.Text = string.Empty;
            guna2TextBox8.Text = string.Empty;
        }
    }
}