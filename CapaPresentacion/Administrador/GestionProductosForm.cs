using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Administrador
{
    public partial class GestionProductosForm : Form
    {
        public GestionProductosForm()
        {
            InitializeComponent();
        }

       
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();

            // Deseleccionar los ComboBoxes (vuelven a quedar en blanco)
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            txtCodigo.Focus(); // Regresa el cursor al primer campo
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if ( !string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) || !string.IsNullOrEmpty(errorProvider1.GetError(txtCodigo))  || 
                 string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de agregar.", "Campos vacíos o con error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que se haya seleccionado una opción en los ComboBox
            if (cmbCategoria.SelectedIndex == -1 || cmbMarca.SelectedIndex == -1 || cmbProveedor.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opción en todas las listas desplegables (Categoría, Marca, Proveedor y Estado).", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea registrar este nuevo producto?",
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
            MessageBox.Show("El producto se registró con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Limpia los campos para un nuevo ingreso
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) && string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtPrecio.Text) && string.IsNullOrWhiteSpace(txtDescripcion.Text)
                && string.IsNullOrWhiteSpace(txtStock.Text) && cmbCategoria.SelectedIndex == -1 && cmbMarca.SelectedIndex == -1 && cmbProveedor.SelectedIndex == -1 && cmbEstado.SelectedIndex == -1)
            {
                // Si no hay nada escrito en los campos
                MessageBox.Show("No hay nada cargador para agregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProducto.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void GestionProductosForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);
        }

       

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (!ulong.TryParse(codigo, out _))
            {
                errorProvider1.SetError(txtCodigo, "El código solo debe contener números.");
            }else if (codigo.Length != 7)
            {
                errorProvider1.SetError(txtCodigo, "El código debe tener exactamente 7 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtCodigo, "");
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras.");
            }
            else if (txtNombre.Text.Length < 3 || txtNombre.Text.Length > 40)
            {
                errorProvider1.SetError(txtNombre, "El nombre debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDescripcion.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9\\s]+$"))
            {
                errorProvider1.SetError(txtDescripcion, "La dirección solo debe contener letras y números.");
            }
            else if (txtDescripcion.Text.Length < 3 || txtDescripcion.Text.Length > 40)
            {
                errorProvider1.SetError(txtDescripcion, "La dirección debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, "");
            }
            
        }
    }
 }
