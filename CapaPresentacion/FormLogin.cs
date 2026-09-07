using CapaPresentacion.Administrador;
using CapaPresentacion.GerenteComercial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarRolAdministrador_Click(object sender, EventArgs e)
        {
            FormMenuAdministrador formAdmin = new FormMenuAdministrador();

            // Al cerrar el formulario hijo, volvemos a mostrar Form1
            formAdmin.FormClosed += (s, args) => this.Show();

            formAdmin.Show();
            this.Hide();
        }

        private void btnIniciarRolGerenteComercial_Click(object sender, EventArgs e)
        {
            FormMenuGerenteComercial formAdmin = new FormMenuGerenteComercial();

            // Al cerrar el formulario hijo, volvemos a mostrar Form1
            formAdmin.FormClosed += (s, args) => this.Show();

            formAdmin.Show();
            this.Hide();

        }
    }
}
