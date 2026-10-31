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
    public partial class ListaCompraClientesForm : Form
    {
        private ECliente _cliente;
        private CNCliente _objCNCliente = new CNCliente();
        public ListaCompraClientesForm(ECliente oCliente)
        {
            InitializeComponent();
            _cliente = oCliente;
        }

        private void ListaCompraClientesForm_Load(object sender, EventArgs e)
        {
            if (_cliente != null)
            {
                // Ajusta los nombres de tus Labels según cómo los tengas en el Diseñador
                lblNombreCliente.Text = $"{_cliente.apellido}, {_cliente.nombre}";
                lblDniCliente.Text = _cliente.dni;
            }
            CargarComprasDelCliente();
        }

        private void CargarComprasDelCliente()
        {
            dgvComprasCliente.AutoGenerateColumns = false;

            dgvComprasCliente.AutoGenerateColumns = false;

            // Mapeamos las columnas del DataGridView con las propiedades de EVenta
            dgvComprasCliente.Columns["colNroVenta"].DataPropertyName = "nro_venta";
            dgvComprasCliente.Columns["colFechaVenta"].DataPropertyName = "fecha_venta";
            dgvComprasCliente.Columns["colVendedor"].DataPropertyName = "NombreComprador";
            dgvComprasCliente.Columns["colMetodoPago"].DataPropertyName = "NombreMetodoPago";

            // APUNTAMOS A TotalVenta (propiedad con ajuste de recargo/descuento incluido)
            dgvComprasCliente.Columns["colTotal"].DataPropertyName = "TotalVenta";

            // Obtenemos la lista de ventas asociadas a este cliente específico
            List<EVenta> listaCompras = _objCNCliente.ListarVentasPorCliente(_cliente.cliente_id);
            dgvComprasCliente.DataSource = listaCompras;

            // MOSTRAMOS EL MONTO TOTAL ACUMULADO
            decimal totalMonetario = listaCompras.Sum(v => v.TotalVenta);
            lblTotalCompras.Text = $"{listaCompras.Count} compras (Total: $ {totalMonetario:N2})";
        }

        private void dgvComprasCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvComprasCliente.NewRowIndex) return;

            string colName = dgvComprasCliente.Columns[e.ColumnIndex].Name;

            if (colName == "colVerDetalle")
            {
                e.Value = Properties.Resources.icono_editar; 
            }
        }

        private void dgvComprasCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvComprasCliente.Columns[e.ColumnIndex].Name;

            // Al hacer clic en el botón "Ver Detalle" de una compra específica
            if (colName == "colVerDetalle")
            {
                EVenta ventaSeleccionada = dgvComprasCliente.Rows[e.RowIndex].DataBoundItem as EVenta;

                if (ventaSeleccionada != null)
                {
                    // Abrimos tu formulario DetalleVenta pasándole la venta seleccionada
                    using (DetalleVenta modalDetalle = new DetalleVenta(ventaSeleccionada))
                    {
                        modalDetalle.ShowDialog();
                    }
                }
            }
        }
    }
}
