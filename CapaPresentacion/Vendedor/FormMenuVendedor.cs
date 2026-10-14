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
    public partial class FormMenuVendedor : Form
    {
        public FormMenuVendedor()
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

       
        
            
        private void btnMenuVendedorItemClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<ClientesForm>();
        }

        private void btnMenuVendedorItemProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<ProductosForm>();
        }

        private void btnMenuVendedorItemVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<MisVentasForm>();
        }

        private void btnMenuItemVendedorNuevaVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijoUnico<NuevaVentaForm>();
        }

        private void btnMenuItemSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?",
                                                      "Cerrar Sesión",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SesionActual.UsuarioLogueado = null;
                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
        }
    }
}
