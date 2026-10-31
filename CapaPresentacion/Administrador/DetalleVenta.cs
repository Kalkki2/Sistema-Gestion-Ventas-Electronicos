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
            if (_venta == null) return;

            // Cargar cabecera del comprobante
            lblDireccion.Text = _venta.nro_venta;
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

            // Cargar el detalle de los productos en el DataGridView
            CargarDetalleProductos();
        }

        private void CargarDetalleProductos()
        {
            CNVenta objCNVenta = new CNVenta();
            List<EDetalleVenta> listaDetalle = objCNVenta.ObtenerDetalleVenta(_venta.venta_id);

            dgvDetalleVenta.AutoGenerateColumns = false;

            // Mapeo de columnas con las propiedades de EDetalleVenta
            dgvDetalleVenta.Columns["colProducto"].DataPropertyName = "NombreProducto";
            dgvDetalleVenta.Columns["colCantidad"].DataPropertyName = "cantidad";
            dgvDetalleVenta.Columns["colPrecio"].DataPropertyName = "precio_unitario";
            dgvDetalleVenta.Columns["colSubtotal"].DataPropertyName = "SubtotalFila";

            dgvDetalleVenta.DataSource = listaDetalle;

            //  Calcular los totales, subtotales y el ajuste (descuento/recargo)
            decimal totalBruto = 0;
            if (listaDetalle != null)
            {
                foreach (var item in listaDetalle)
                {
                    totalBruto += item.SubtotalFila;
                }
            }

            // Mostramos el total bruto de los productos
            lblTotalBruto.Text = $"$ {totalBruto:N2}";

            // Obtenemos los valores guardados en la venta
            decimal porcentaje = _venta.porcentaje_aplicado; // Ej: 10.00
            decimal montoAjuste = (totalBruto * porcentaje) / 100; // Multiplicación corregida
            decimal totalFinal = totalBruto;

            // Evaluamos el tipo de ajuste
            string tipoAjusteNombre = _venta.NombreTipoAjuste;

            if (tipoAjusteNombre == "Descuento" || (_venta.oMetodoPago != null && _venta.oMetodoPago.tipo_ajuste_id == 2))
            {
                lblTextoAjuste.Text = $"Ajuste Descuento %{porcentaje:0.##}";
                lblMontoAjuste.Text = $"- $ {montoAjuste:N2}";
                totalFinal = totalBruto - montoAjuste; // Resta corregida
            }
            else if (tipoAjusteNombre == "Recargo" || (_venta.oMetodoPago != null && _venta.oMetodoPago.tipo_ajuste_id == 1))
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
    

