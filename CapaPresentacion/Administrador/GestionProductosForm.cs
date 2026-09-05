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
    public partial class GestionProductosForm : Form
    {
        public GestionProductosForm()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Debe completar todos los campos de texto obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

  

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();

            // Deseleccionar los ComboBoxes (vuelven a quedar en blanco)
            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            txtCodigo.Focus(); // Regresa el cursor al primer campo
        }
    }
}
