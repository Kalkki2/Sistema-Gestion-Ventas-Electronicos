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

    public partial class BuscarProveedorForm : Form
    {
        private CNProducto objCNProducto = new CNProducto();
        public EProveedor _Proveedor { get; set; }
        private CNProveedor objCNProveedor = new CNProveedor();
        public BuscarProveedorForm()
        {
            InitializeComponent();
        }
       

        private void BuscarProveedorForm_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarFiltrosCombos();
        }

        private void CargarFiltrosCombos()
        {
            var listaCat = objCNProducto.ListarCategorias();
            listaCat.Insert(0, new ECategoria { categoria_id = 0, nombre = "Todos" });
            cmbFiltroCategoria.DataSource = listaCat;
            cmbFiltroCategoria.DisplayMember = "nombre";
            cmbFiltroCategoria.ValueMember = "categoria_id";
            cmbFiltroCategoria.SelectedIndex = 0;
        }

        private void CargarProveedores()
        {
            dgvListaProveedores.AutoGenerateColumns = false;

            dgvListaProveedores.Columns["colCuit"].DataPropertyName = "cuit";
            dgvListaProveedores.Columns["colNombre"].DataPropertyName = "razon_social";
            dgvListaProveedores.Columns["colCorreo"].DataPropertyName = "email";
            dgvListaProveedores.Columns["colTelefono"].DataPropertyName = "telefono";

            var listaActivos = objCNProveedor.ListarProveedoreActivos();
            dgvListaProveedores.DataSource = listaActivos;
        }

        private void dgvListaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvListaProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar" ||
                    dgvListaProveedores.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    _Proveedor = (EProveedor)dgvListaProveedores.Rows[e.RowIndex].DataBoundItem;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores();
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCategoria.SelectedIndex != -1)
            {
                FiltrarProveedores();
            }
        }

        private void FiltrarProveedores()
        {
            string textoBusqueda = txtBuscarProveedor.Text.Trim().ToLower();

            int categoriaIdSeleccionada = 0;
            if (cmbFiltroCategoria.SelectedValue != null)
            {
                int.TryParse(cmbFiltroCategoria.SelectedValue.ToString(), out categoriaIdSeleccionada);
            }

            // 1. Traemos los proveedores activos base
            var listaProveedores = objCNProveedor.ListarProveedoreActivos();

            // 2. Si se seleccionó una categoría específica (diferente de "Todos" que es 0)
            if (categoriaIdSeleccionada > 0)
            {
                // Llamamos al método que busca los proveedores de esa categoría
                var proveedoresDeCategoria = objCNProveedor.ListarProveedorPorCategoria(categoriaIdSeleccionada);
                var idsValidos = proveedoresDeCategoria.Select(p => p.proveedor_id).ToList();

                // Filtramos la lista para quedarnos solo con los de esa categoría
                listaProveedores = listaProveedores.Where(p => idsValidos.Contains(p.proveedor_id)).ToList();
            }

            // 3. Si además hay texto escrito en el buscador, filtramos por CUIT o Razón Social
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                listaProveedores = listaProveedores.Where(p =>
                    p.cuit.ToLower().Contains(textoBusqueda) ||
                    p.razon_social.ToLower().Contains(textoBusqueda)
                ).ToList();
            }

            // Actualizamos el DataGridView
            dgvListaProveedores.DataSource = listaProveedores;
        }

        private void dgvListaProveedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvListaProveedores.NewRowIndex) return;

            string colName = dgvListaProveedores.Columns[e.ColumnIndex].Name;

            if (colName == "btnSeleccionar")
            {
                e.Value = Properties.Resources.dedo;
            }
        }
    }
}