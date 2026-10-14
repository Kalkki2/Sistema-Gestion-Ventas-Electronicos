using CapaEntidad;
using CapaNegocio;
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
    public partial class RegistrarEditarUsuarioForm : Form
    {
        private CNUsuario objCNUsuario = new CNUsuario();
        private CNPerfil objCNPerfil = new CNPerfil();

        // Propiedad para almacenar el usuario a editar (si es null, es nuevo registro)
        private EUsuario usuarioActual;
        public RegistrarEditarUsuarioForm(EUsuario usuarioAEditar = null)
        {
            InitializeComponent();
            usuarioActual = usuarioAEditar;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RegistrarEditarUsuarioForm_Load(object sender, EventArgs e)
        {
            CargarCmbPerfil();
            CargarCmbEstado();

            // Si se pasó un usuario, cargamos sus datos en los controles
            if (usuarioActual != null)
            {
                this.Text = "Editar Usuario";
                btnAgregarUsuario.Text = "Actualizar";

                txtNombre.Text = usuarioActual.nombre;
                txtApellido.Text = usuarioActual.apellido;
                txtDni.Text = usuarioActual.dni;
                txtCorreo.Text = usuarioActual.email;
                txtTelefono.Text = usuarioActual.telefono;
                txtDireccion.Text = usuarioActual.direccion;
                txtContrasenia.Text = usuarioActual.contrasenia;

                cmbPerfil.SelectedValue = usuarioActual.perfil_id;

                foreach (OpcionCombo item in cmbEstado.Items)
                {
                    if (Convert.ToInt32(item.Valor) == usuarioActual.estado)
                    {
                        cmbEstado.SelectedItem = item;
                        break;
                    }
                }
            }
            else
            {
                this.Text = "Registrar Nuevo Usuario";
                btnAgregarUsuario.Text = "Guardar";
            }
        }

        private void CargarCmbPerfil()
        {
            List<EPerfil> listaPerfiles = objCNPerfil.Listar();
            cmbPerfil.ValueMember = "perfil_id";
            cmbPerfil.DisplayMember = "nombre";
            cmbPerfil.DataSource = listaPerfiles;
            cmbPerfil.SelectedIndex = -1;
        }

        private void CargarCmbEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = -1;
        }

        public class OpcionCombo
        {
            public string Texto { get; set; }
            public object Valor { get; set; }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // 1. Validaciones de campos vacíos o con errores en el ErrorProvider
            if (
                string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de continuar.", "Campos vacíos o con error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEstado.SelectedIndex == -1 || cmbPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar Estado y Perfil.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpcionCombo estadoSeleccionado = (OpcionCombo)cmbEstado.SelectedItem;

            // 2. Mapeo del objeto
            EUsuario oUsuario = new EUsuario()
            {
                usuario_id = usuarioActual == null ? 0 : usuarioActual.usuario_id,
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                dni = txtDni.Text.Trim(),
                email = txtCorreo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                direccion = txtDireccion.Text.Trim(),
                contrasenia = txtContrasenia.Text.Trim(),
                estado = Convert.ToInt32(estadoSeleccionado.Valor),
                perfil_id = Convert.ToInt32(cmbPerfil.SelectedValue)
            };

            string mensaje = string.Empty;
            bool resultado = false;

            // 3. Evaluar si registra o edita
            if (usuarioActual == null)
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea registrar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                resultado = objCNUsuario.Registrar(oUsuario, out mensaje);
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea actualizar los datos de este usuario?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                resultado = objCNUsuario.Editar(oUsuario, out mensaje);
            }

            // 4. Respuesta y cierre del modal indicando éxito
            if (resultado)
            {
                MessageBox.Show(usuarioActual == null ? "Usuario registrado con éxito." : "Usuario actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Muy importante para avisar al form principal que recargue
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
