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

namespace CapaPresentacion.Administrador
{
    public partial class BuscarProductoCompraForm : Form
    {
        // Propiedad pública para retornar el producto seleccionado a la pantalla de compras
        public EProducto _Producto { get; set; }
        private CNProducto objCNProducto = new CNProducto();
        private int _idProveedorSeleccionado;
        public BuscarProductoCompraForm(int idProveedor)
        {
            InitializeComponent();
            _idProveedorSeleccionado = idProveedor;
        }

        private void CargarProductosPorProveedor()
        {
            dgvListaProductos.AutoGenerateColumns = false;

            dgvListaProductos.Columns["colCodigo"].DataPropertyName = "codigo";
            dgvListaProductos.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaProductos.Columns["colPrecio"].DataPropertyName = "precio_venta";
            dgvListaProductos.Columns["colStock"].DataPropertyName = "stock";

            dgvListaProductos.Columns["colCategoria"].DataPropertyName = "NombreCategoria";
            dgvListaProductos.Columns["colMarca"].DataPropertyName = "NombreMarca";

            // Llamamos a la capa de negocio para obtener la lista del proveedor seleccionado
            CNProducto objCN = new CNProducto();
            dgvListaProductos.DataSource = objCN.ListarProductosPorProveedor(_idProveedorSeleccionado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void BuscarProductoCompraForm_Load(object sender, EventArgs e)
        {
            CargarProductosPorProveedor();
            CargarComboMarcas();
        }

        private void dgvListaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvListaProductos.NewRowIndex) return;

            string colName = dgvListaProductos.Columns[e.ColumnIndex].Name;

            if (colName == "btnSeleccionar")
            {
                e.Value = Properties.Resources.dedo;
            }
        }

        private void CargarComboMarcas()
        {
            var listaMarca = objCNProducto.ListarMarcas();
            listaMarca.Insert(0, new EMarca { marca_id = 0, nombre = "Todos" });
            cmbFiltroMarca.DataSource = listaMarca;
            cmbFiltroMarca.DisplayMember = "nombre";
            cmbFiltroMarca.ValueMember = "marca_id";
            cmbFiltroMarca.SelectedIndex = 0;
        }

        private void EjecutarBusqueda()
        {
            string textoBusqueda = txtBuscarProducto.Text.Trim(); // Nombre de tu TextBox de búsqueda
            int idMarcaSeleccionada = 0;

            if (cmbFiltroMarca.SelectedValue != null)
            {
                int.TryParse(cmbFiltroMarca.SelectedValue.ToString(), out idMarcaSeleccionada);
            }

            var listaFiltrada = objCNProducto.BuscarProductosPorFiltro(_idProveedorSeleccionado, textoBusqueda, idMarcaSeleccionada);

            dgvListaProductos.DataSource = listaFiltrada;
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            EjecutarBusqueda();
        }

        private void cmbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroMarca.SelectedIndex == -1) return;
            EjecutarBusqueda();
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvListaProductos.Columns[e.ColumnIndex].Name == "btnSeleccionar" ||
                    dgvListaProductos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    _Producto = (EProducto)dgvListaProductos.Rows[e.RowIndex].DataBoundItem;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
