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
    public partial class DetalleVenta : Form
    {
        private EVenta _venta;
        public DetalleVenta(EVenta ventaSeleccionada)
        {
            InitializeComponent();
            _venta = ventaSeleccionada;
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            // 1. Cargar los datos de la cabecera en los Labels correspondientes
            lblValorNroVenta.Text = _venta.nro_venta;
            lblValorFechaHora.Text = _venta.fecha_venta.ToString("dd/MM/yyyy HH:mm:ss");

            if (_venta.oUsuario != null)
            {
                lblApeYNomVendedor.Text = $"{_venta.oUsuario.apellido}, {_venta.oUsuario.nombre}";
                lblDniVendedor.Text = _venta.oUsuario.dni;
            }

            if (_venta.oCliente != null)
            {
                lblApeYNomCliente.Text = $"{_venta.oCliente.apellido}, {_venta.oCliente.nombre}";
                lblDniCliente.Text = _venta.oCliente.dni;
            }

            if (_venta.oMetodoPago != null)
            {
                lblFormaPago.Text = _venta.oMetodoPago.nombre;
            }

            // 2. Cargar el detalle de los productos en el DataGridView
            CargarDetalleProductos();
        }

        private void CargarDetalleProductos()
        {
            CNVenta objCNVenta = new CNVenta();
            List<EDetalleVenta> listaDetalle = objCNVenta.ObtenerDetalleVenta(_venta.venta_id);

            dgvDetalleVenta.AutoGenerateColumns = false;
            dgvDetalleVenta.Columns["colProducto"].DataPropertyName = "NombreProducto";
            dgvDetalleVenta.Columns["colCantidad"].DataPropertyName = "cantidad";
            dgvDetalleVenta.Columns["colPrecio"].DataPropertyName = "precio_unitario";
            dgvDetalleVenta.Columns["colSubtotal"].DataPropertyName = "SubtotalFila";

            dgvDetalleVenta.DataSource = listaDetalle;

            // 3. Calcular los totales, subtotales y el ajuste (descuento/recargo)
            decimal totalBruto = 0;
            foreach (var item in listaDetalle)
            {
                totalBruto += item.SubtotalFila;
            }

            // Mostramos el total bruto de los productos
            lblTotalBruto.Text = $"$ {totalBruto:N2}";

            // Obtenemos los valores congelados que se guardaron en la venta
            decimal porcentaje = _venta.porcentaje_aplicado; // Ej: 10.00
            decimal montoAjuste = (totalBruto * porcentaje) / 100;
            decimal totalFinal = totalBruto;

            // Evaluamos el tipo de ajuste (1: Recargo, 2: Descuento, 3: Sin ajuste)
            if (_venta.tipo_ajuste_id == 2) // Descuento
            {
                lblTextoAjuste.Text = $"Ajuste Descuento %{porcentaje:0.##}";
                lblMontoAjuste.Text = $"- $ {montoAjuste:N2}";
                totalFinal = totalBruto - montoAjuste;
            }
            else if (_venta.tipo_ajuste_id == 1) // Recargo
            {
                lblTextoAjuste.Text = $"Ajuste Recargo %{porcentaje:0.##}";
                lblMontoAjuste.Text = $"+ $ {montoAjuste:N2}";
                totalFinal = totalBruto + montoAjuste;
            }
            else // Sin ajuste
            {
                lblTextoAjuste.Text = "Sin ajuste";
                lblMontoAjuste.Text = "$ 0.00";
                totalFinal = totalBruto;
            }

            // Mostramos el total final a pagar
            lblTotalAPagar.Text = $"$ {totalFinal:N2}";
        }
    }
}
