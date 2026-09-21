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

namespace CapaPresentacion.GerenteComercial
{
    public partial class FormMenuGerenteComercial : Form
    {
        public FormMenuGerenteComercial()
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
        private void btnMenuItemInforme_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<DashboardVentasForm>();
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

        private void btnMenuItemReporte_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<ReportesForm>();
        }
    }
}
