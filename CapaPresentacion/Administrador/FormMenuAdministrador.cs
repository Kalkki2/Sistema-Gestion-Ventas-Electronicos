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

        private void AbrirFormularioHijo<T>() where T : Form, new()
        {
            // 1. Verificar si ya está abierto
            Form formExistente = this.MdiChildren.FirstOrDefault(f => f is T);

            if (formExistente != null)
            {
                formExistente.BringToFront();
                return;
            }

            // 2. Instanciar el nuevo formulario hijo
            T nuevoForm = new T
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None, // Quita los bordes de ventana
                Dock = DockStyle.Fill                   // Se ajusta al espacio restante del MDI
            };

            nuevoForm.Show();
        }

        private void btnMenuItemProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<GestionProductosForm>();
        }

        private void btnMenuItemCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<GestionClientesForm>();
        }

        private void btnMenuItemUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<GestionUsuariosForm>();
        }

        private void btnMenuItemVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<GestionVentasForm>();
        }

        private void btnMenuItemProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<GestionProveedoresForm>();
        }
    }
}
