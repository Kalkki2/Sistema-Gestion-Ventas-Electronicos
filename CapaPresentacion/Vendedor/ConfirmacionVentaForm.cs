using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vendedor
{
    public partial class ConfirmacionVentaForm : Form
    {
        public ConfirmacionVentaForm(string nroTransaccion, decimal montoTotal)
        {
            InitializeComponent();

            // Asignas los valores a tus etiquetas (Labels) del modal:
            lblNroTransaccion.Text = nroTransaccion;
            lblMontoTotal.Text = "$ " + montoTotal.ToString("0.00");
        }

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
