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

        }

        private void BuscarProductoVentaForm_Load_1(object sender, EventArgs e)
        {
            cargando = true;

            CargarCombosCategoriaYMarcas();
            CargarProductos();

            cargando = false; 
            AplicarFiltros();
        }


        private void CargarProductos()
        {
            dgvListaProductos.AutoGenerateColumns = false;

            dgvListaProductos.Columns["colCodigo"].DataPropertyName = "codigo";
            dgvListaProductos.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaProductos.Columns["colPrecio"].DataPropertyName = "precio_venta";
            dgvListaProductos.Columns["colStock"].DataPropertyName = "stock";
            dgvListaProductos.Columns["colCategoria"].DataPropertyName = "NombreCategoria";
            dgvListaProductos.Columns["colMarca"].DataPropertyName = "NombreMarca";

            CNProducto objCNProducto = new CNProducto();

            var listaPoductosActivos = objCNProducto.ListarProductosActivos();
            dgvListaProductos.DataSource = listaPoductosActivos;
        }

        // Llena los combos con las categorías y marcas que tienen los productos cargados
        private void CargarCombosCategoriaYMarcas()
        {
            CNProducto objCNProducto = new CNProducto();

            List<ECategoria> listaCategoria = objCNProducto.ListarCategorias();
            listaCategoria.Insert(0, new ECategoria { categoria_id = 0, nombre = "Todos" });
            cmbFiltroCategoria.DataSource = listaCategoria;
            cmbFiltroCategoria.DisplayMember = "nombre";
            cmbFiltroCategoria.ValueMember = "categoria_id";
            cmbFiltroCategoria.SelectedIndex = 0;

            List<EMarca> listaMarca = objCNProducto.ListarMarcas();
            listaMarca.Insert(0, new EMarca { marca_id = 0, nombre = "Todos" });
            cmbFiltroMarca.DataSource = listaMarca;
            cmbFiltroMarca.DisplayMember = "nombre";
            cmbFiltroMarca.ValueMember = "marca_id";
            cmbFiltroMarca.SelectedIndex = 0;

        }

        private void AplicarFiltros()
        {
            if (cargando) return; // Evita disparos mientras inicializan los combos

            int idCategoria = 0;
            if (cmbFiltroCategoria.SelectedValue != null)
            {
                int.TryParse(cmbFiltroCategoria.SelectedValue.ToString(), out idCategoria);
            }

            int idMarca = 0;
            if (cmbFiltroMarca.SelectedValue != null)
            {
                int.TryParse(cmbFiltroMarca.SelectedValue.ToString(), out idMarca);
            }

            string textoBusqueda = txtBuscarProducto.Text.Trim();

            CNProducto objCNProducto = new CNProducto();
            var listaFiltrada = objCNProducto.BuscarProductosActivosPorFiltro(idCategoria, idMarca, textoBusqueda);

            // Actualizamos la grilla
            dgvListaProductos.DataSource = listaFiltrada;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dgvListaProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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