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
        public EProveedor _Proveedor { get; set; }
        private CNProveedor objCNProveedor = new CNProveedor();
        public BuscarProveedorForm()
        {
            InitializeComponent();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProveedor.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void BuscarProveedorForm_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            // 1. Desactivar la generación automática de columnas
            dgvListaProveedores.AutoGenerateColumns = false;

            // 2. Mapear las columnas con las propiedades de EProveedor
            dgvListaProveedores.Columns["colCuit"].DataPropertyName = "cuit";
            dgvListaProveedores.Columns["colNombre"].DataPropertyName = "razon_social";
            dgvListaProveedores.Columns["colCorreo"].DataPropertyName = "email";
            dgvListaProveedores.Columns["colTelefono"].DataPropertyName = "telefono";

            // 3. Obtener la lista y asignarla
            var lista = objCNProveedor.Listar().Where(p => p.estado == 1).ToList();
            dgvListaProveedores.DataSource = lista;
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


    }
}