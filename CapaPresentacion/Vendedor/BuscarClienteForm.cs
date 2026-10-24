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
        private List<ECliente> clientes = new List<ECliente>();

        public ECliente ClienteSeleccionado { get; private set; }

        public BuscarClienteForm()
        {
            InitializeComponent();
            ConfigurarGrilla();
            CargarClientes();

            // Filtra mientras se escribe
            txtBuscarCliente.TextChanged += (s, e) => CargarClientes(txtBuscarCliente.Text.Trim());

            dgvListaClientes.CellContentClick -= dgvListaClientes_CellContentClick;
            dgvListaClientes.CellContentClick += dgvListaClientes_CellContentClick;

            DataGridViewButtonColumn colSel = dgvListaClientes.Columns["colSeleccionar"] as DataGridViewButtonColumn;
            if (colSel != null)
            {
                colSel.Text = "Seleccionar";
                colSel.UseColumnTextForButtonValue = true;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            CargarClientes(txtBuscarCliente.Text.Trim());
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

        private void ConfigurarGrilla()
        {
            dgvListaClientes.AutoGenerateColumns = false;
            colNroCliente.DataPropertyName = "cliente_id";
            colDni.DataPropertyName = "dni";
            colNombre.DataPropertyName = "nombre";
            colApellido.DataPropertyName = "apellido";
            colTelefono.DataPropertyName = "telefono";
            colDireccion.DataPropertyName = "direccion";
        }

        private void CargarClientes(string filtro = "")
        {
            // Lista los clientes de la tabla cliente; el filtro (DNI, nombre, apellido o teléfono) lo resuelve la capa de datos
            clientes = objCNCliente.Listar(filtro);

            dgvListaClientes.DataSource = null;
            dgvListaClientes.DataSource = clientes;
        }
    }
}