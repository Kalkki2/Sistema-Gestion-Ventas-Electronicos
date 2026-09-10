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
    public partial class GestionComprasForm : Form
    {
        public GestionComprasForm()
        {
            InitializeComponent();
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            BuscarProductoForm frm = new BuscarProductoForm();
            frm.ShowDialog();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedorForm frm = new BuscarProveedorForm();
            frm.ShowDialog();
        }
    }
}
