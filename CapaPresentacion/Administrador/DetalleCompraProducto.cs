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
    public partial class DetalleCompraProducto : Form
    {
        private ECompra _compraActual;
        public DetalleCompraProducto(ECompra compraSeleccionada)
        {
            InitializeComponent();
            _compraActual = compraSeleccionada;
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetalleCompraProducto_Load(object sender, EventArgs e)
        {
            // 1. Rellenar los datos de la cabecera con la información del objeto
            lblNroFactura.Text = $"Detalle de la compra: {_compraActual.nro_factura}";
            lblFechaHora.Text = _compraActual.fecha_compra.ToString("dd/MM/yyyy HH:mm:ss");
            lblResponsable.Text = _compraActual.NombreComprador;
            lblDniResponsable.Text = _compraActual.DniUsuario;
            lblProveedor.Text = _compraActual.NombreProveedor;
            lblCuitProveedor.Text = _compraActual.CuitProveedor;

            // 2. Cargar los detalles en el DataGridView interno
            CargarDetallesGrilla();
        }

        private void CargarDetallesGrilla()
        {
            dgvDetalleItems.AutoGenerateColumns = false;

            // Vinculamos las columnas con las propiedades planas de EDetalleCompra
            dgvDetalleItems.Columns["colCodigo"].DataPropertyName = "CodigoProducto";
            dgvDetalleItems.Columns["colProducto"].DataPropertyName = "NombreProducto";
            dgvDetalleItems.Columns["colCantidad"].DataPropertyName = "cantidad";
            dgvDetalleItems.Columns["colCostoUnitario"].DataPropertyName = "costo_unitario";
            dgvDetalleItems.Columns["colSubtotal"].DataPropertyName = "SubtotalFila";

            CNCompra objCN = new CNCompra();
            var listaDetalles = objCN.ObtenerDetalleCompra(_compraActual.compra_id);

            dgvDetalleItems.DataSource = listaDetalles;

            // Calcular el total general sumando los subtotales
            decimal totalGeneral = 0;
            foreach (var item in listaDetalles)
            {
                totalGeneral += (item.cantidad * item.costo_unitario);
            }

            lblTotalGeneral.Text = "$" + totalGeneral.ToString("0.00");
            lblTotalComprados.Text = listaDetalles.Count.ToString(); // Cantidad de ítems distintos o suma de cantidades
        }
    }
}
