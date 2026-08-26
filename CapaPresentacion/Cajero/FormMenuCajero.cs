using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Cajero
{
    public partial class FormMenuCajero : Form
    {
        private decimal acumuladoSubtotal = 0;
        private string detalleCompra = "";
        private int cantidadTotalItems = 0;
        public FormMenuCajero()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;   
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FormMenuCajero_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad) &&
         decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                decimal subtotalProducto = cantidad * precio;

                acumuladoSubtotal += subtotalProducto;
                cantidadTotalItems += (int)cantidad;

                lblSubtotal.Text = acumuladoSubtotal.ToString("C2");

                detalleCompra += $"{txtCodigo.Text} (x{cantidad}), ";

                DialogResult respuesta = MessageBox.Show(
                    "¿Deseas agregar otro producto a esta compra?",
                    "Agregar Producto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    txtCodigo.Clear();
                    txtCantidad.Clear();
                    txtPrecio.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    txtCodigo.Clear();
                    txtCantidad.Clear();
                    txtPrecio.Clear();
                    btnConfirmar.Focus();

                    MessageBox.Show("Productos cargados. Selecciona el medio de pago y haz clic en CONFIRMAR para finalizar.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa números válidos en Cantidad y Precio.");
            }

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (acumuladoSubtotal == 0)
            {
                MessageBox.Show("Agrega al menos un producto antes de confirmar.");
                return;
            }
            string medioPago = "";
            foreach (var item in chkMedioPAgo.CheckedItems)
            {
                medioPago += item.ToString() + " ";
            }
            string detalleFinal = detalleCompra.TrimEnd(',', ' ');
            int n = dgbVentas.Rows.Add();
            dgbVentas.Rows[n].Cells[0].Value = TxtCliente.Text;                   
            dgbVentas.Rows[n].Cells[1].Value = "Varios";                          
            dgbVentas.Rows[n].Cells[2].Value = cantidadTotalItems.ToString();
            dgbVentas.Rows[n].Cells[3].Value = medioPago.Trim();
            dgbVentas.Rows[n].Cells[4].Value = detalleFinal;                      
            dgbVentas.Rows[n].Cells[5].Value = acumuladoSubtotal.ToString("C2");  

            MessageBox.Show("¡Venta confirmada con éxito!");

            acumuladoSubtotal = 0;
            cantidadTotalItems = 0;
            detalleCompra = "";
            lblSubtotal.Text = "$0.00";
            TxtCliente.Clear();

            for (int i = 0; i < chkMedioPAgo.Items.Count; i++)
            {
                chkMedioPAgo.SetItemChecked(i, false);
            }

        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }
    }
}
