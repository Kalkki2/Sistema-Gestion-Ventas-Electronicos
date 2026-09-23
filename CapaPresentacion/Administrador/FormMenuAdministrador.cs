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
    public partial class FormMenuAdministrador : Form
    {
        public FormMenuAdministrador()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijoUnico<T>() where T : Form, new()
        {
            // 1. Cerrar todos los formularios hijos que estén abiertos actualmente
            // Hacemos un .ToArray() para evitar errores al modificar la colección mientras la recorremos
            foreach (Form hijo in this.MdiChildren.ToArray())
            {
                hijo.Close(); // Esto destruye y libera el formulario anterior
            }

            // 2. Instanciar y mostrar el nuevo formulario hijo
            T nuevoForm = new T
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None, // Quita los bordes
                Dock = DockStyle.Fill                   // Ocupa todo el espacio exacto
            };

            nuevoForm.Show();
        }

        private void btnMenuItemProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<GestionProductosForm>();
        }

        private void btnMenuItemCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<GestionClientesForm>();
        }

        private void btnMenuItemUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<GestionUsuariosForm>();
        }

        private void btnMenuItemVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<GestionVentasForm>();
        }

        private void btnMenuItemProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<GestionProveedoresForm>();
        }

        private void btnMenuItemCompra_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<GestionComprasForm>();
        }

        private void btnMenuItemSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
         "¿Está seguro de que desea cerrar sesión?",
         "Cerrar sesión",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question
     );

            if (resultado == DialogResult.Yes)
            {
                // Al cerrar este formulario, el evento 'FormClosed' que pusiste 
                // en el Login hará que este último vuelva a mostrarse (this.Show()) automáticamente.
                this.Close();
            }
        }

        private void FormMenuAdministrador_Load(object sender, EventArgs e)
        {
            btnMenuItemSalir.CausesValidation = false;
        }
    }
}
