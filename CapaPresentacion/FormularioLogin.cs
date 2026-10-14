using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Administrador;
using CapaPresentacion.GerenteComercial;
using CapaPresentacion.Vendedor;
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
    public partial class FormularioLogin : Form
    {
        private CNUsuario objCNUsuario = new CNUsuario();
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Usamos el TextBox del DNI y el de la contraseña
            EUsuario oUsuario = objCNUsuario.Login(txtDniLogin.Text, txtContraseniaLogin.Text, out mensaje);

            if (oUsuario != null)
            {
                // 1. Guardamos el usuario en la sesión global para saber qué vendedor realiza operaciones
                SesionActual.UsuarioLogueado = oUsuario;

                // 2. Evaluamos el perfil / rol para abrir su respectivo menú
                string rol = oUsuario.oPerfil.nombre.ToLower();

                if (rol.Contains("administrador"))
                {
                    FormMenuAdministrador formAdmin = new FormMenuAdministrador();
                    formAdmin.FormClosed += (s, args) => this.Show();
                    formAdmin.Show();
                    this.Hide();
                }
                else if (rol.Contains("gerente"))
                {
                    FormMenuGerenteComercial formGerente = new FormMenuGerenteComercial();
                    formGerente.FormClosed += (s, args) => this.Show();
                    formGerente.Show();
                    this.Hide();
                }
                else if (rol.Contains("vendedor"))
                {
                    FormMenuVendedor formVendedor = new FormMenuVendedor();
                    formVendedor.FormClosed += (s, args) => this.Show();
                    formVendedor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario no tiene un rol asignado válido en el sistema.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(mensaje != string.Empty ? mensaje : "DNI o contraseña incorrectos, o usuario inactivo.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseniaLogin.Clear();
                txtDniLogin.Focus();
            }
        }

        private void picVerContrasenia_Click(object sender, EventArgs e)
        {
            if (txtContraseniaLogin.UseSystemPasswordChar)
            {
                txtContraseniaLogin.UseSystemPasswordChar = false;
                picVerContrasenia.Image = Properties.Resources.icono_ojo_abierto; 
            }
            else
            {
                txtContraseniaLogin.UseSystemPasswordChar = true;
                picVerContrasenia.Image = Properties.Resources.icono_ojo_cerrado; 
            }
        }

       
    }
}
