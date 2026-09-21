using CapaPresentacion.Administrador;
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
    public partial class NuevaVentaForm : Form
    {
        public NuevaVentaForm()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoForm frm = new BuscarProductoForm();
            frm.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClienteForm frm = new BuscarClienteForm();
            frm.ShowDialog();
        }
    }
}
