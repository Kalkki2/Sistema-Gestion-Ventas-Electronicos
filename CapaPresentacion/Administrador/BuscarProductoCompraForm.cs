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
        

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscarProducto.Text.Trim();

            var lista = objCNProducto.ListarProductosPorProveedor(_idProveedorSeleccionado);

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                // Filtramos localmente por código o nombre de los productos de ese proveedor
                var listaFiltrada = lista.Where(p => p.codigo.Contains(busqueda) || p.nombre.Contains(busqueda)).ToList();
                dgvListaProductos.DataSource = listaFiltrada;
            }
            else
            {
                dgvListaProductos.DataSource = lista;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Al hacer clic en el botón de la fila, extraemos el objeto y cerramos el modal con OK
            if (e.RowIndex >= 0)
            {
                if (dgvListaProductos.Columns[e.ColumnIndex].Name == "colSeleccionar" ||
                    dgvListaProductos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    _Producto = (EProducto)dgvListaProductos.Rows[e.RowIndex].DataBoundItem;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BuscarProductoCompraForm_Load(object sender, EventArgs e)
        {
            CargarProductosPorProveedor();
        }
    }
}
