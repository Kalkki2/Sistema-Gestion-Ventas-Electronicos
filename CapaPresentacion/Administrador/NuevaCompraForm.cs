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
    public partial class NuevaCompraForm : Form
    {
        public NuevaCompraForm()
        {
            InitializeComponent();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedorForm frm = new BuscarProveedorForm();
            frm.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoForm frm = new BuscarProductoForm();
            frm.ShowDialog();
        }

        private void btnGenerarCompra_Click(object sender, EventArgs e)
        {
            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea generar esta nueva compra?",
                "Confirmar registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario responde 'No', cancelamos la operación
            if (respuesta == DialogResult.No)
            {
                return;
            }
            // Mensaje de éxito
            MessageBox.Show("La compra se genero con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Limpia los campos para un nuevo ingreso
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtProveedorCompra.Clear();
            txtTelefonoProveedor.Clear();
            txtCorreoProveedor.Clear();
            txtProductoCompra.Clear();
            txtPrecioCompra.Clear();
            txtCategoriaCompra.Clear();
            txtMarcaCompra.Clear();
            txtProveedorCompra.Focus(); // Regresa el cursor al primer campo
        }
    }
}
