using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Vendedor
{
    public partial class BuscarClienteForm : Form
    {
        private readonly CNCliente objCNCliente = new CNCliente();
        public ECliente ClienteSeleccionado { get; private set; }

        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "colSeleccionar")
            {
                ClienteSeleccionado = dgvListaClientes.Rows[e.RowIndex].DataBoundItem as ECliente;
                if (ClienteSeleccionado != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            CargarCLiente();
        }

        private void CargarCLiente()
        {
            dgvListaClientes.AutoGenerateColumns = false;

            dgvListaClientes.Columns["colNroCliente"].DataPropertyName = "cliente_id";
            dgvListaClientes.Columns["colDni"].DataPropertyName = "dni";
            dgvListaClientes.Columns["colApellido"].DataPropertyName = "apellido";
            dgvListaClientes.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaClientes.Columns["colTelefono"].DataPropertyName = "telefono";
            dgvListaClientes.Columns["colDireccion"].DataPropertyName = "direccion";

            var listaClientes = objCNCliente.Listar("")
                                    .Where(c => c.estado == 1)
                                    .ToList();
            dgvListaClientes.DataSource = listaClientes;
        }

        private void BuscarClientePorDatos()
        {
            string textoBusqueda = txtBuscarCliente.Text.Trim();
            CNCliente objCNCliente = new CNCliente();
            var listaFiltrada = objCNCliente.Buscar(textoBusqueda, 1);

            dgvListaClientes.DataSource = listaFiltrada;
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarClientePorDatos();
        }
    }
}