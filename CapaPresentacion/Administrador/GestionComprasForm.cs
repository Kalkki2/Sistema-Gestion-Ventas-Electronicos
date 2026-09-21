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

namespace CapaPresentacion.Administrador
{
    public partial class GestionComprasForm : Form
    {
        public GestionComprasForm()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProductoForm frm = new BuscarProductoForm();
            frm.ShowDialog();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedorForm frm = new BuscarProveedorForm();
            frm.ShowDialog();
        }

        private void btnAgregarItemProducto_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtProveedorCompra.Text) || string.IsNullOrWhiteSpace(txtTelefonoProveedor.Text) || string.IsNullOrWhiteSpace(txtCorreoProveedor.Text) || string.IsNullOrWhiteSpace(txtProductoCompra.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) || string.IsNullOrWhiteSpace(txtCantidadCompra.Text))
            {
                MessageBox.Show("Debe completar todos los campos de texto obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que se haya seleccionado una opción en los ComboBox
            if (cmbCategoriaCompra.SelectedIndex == -1 || cmbMarcaCompra.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opción en todas las listas desplegable.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea agregar este nuevo item?",
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
            MessageBox.Show("El item  se cargo con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            // Deseleccionar los ComboBoxes (vuelven a quedar en blanco)
            cmbCategoriaCompra.SelectedIndex = -1;
            cmbMarcaCompra.SelectedIndex = -1;
            txtProveedorCompra.Focus(); // Regresa el cursor al primer campo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProveedorCompra.Text) && string.IsNullOrWhiteSpace(txtTelefonoProveedor.Text) && string.IsNullOrWhiteSpace(txtCorreoProveedor.Text) && string.IsNullOrWhiteSpace(txtProductoCompra.Text) &&
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) && string.IsNullOrWhiteSpace(txtCantidadCompra.Text ) && cmbCategoriaCompra.SelectedIndex == -1 && cmbMarcaCompra.SelectedIndex == -1)
            {
                // Si no hay nada escrito en los campos
                MessageBox.Show("No hay nada cargado para cancear/limpiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnBuscarPoveedorPorCuit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProveedor.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void dgvHistorialCompraProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se hizo clic en una fila válida (evita errores si hacen clic en los encabezados)
            // y comprobar que la columna clickeada es la de nuestro botón ("btnAccion")
            if (e.RowIndex >= 0 && dgvHistorialCompraProductos.Columns[e.ColumnIndex].Name == "colVerDetalle")
            {
                // Instanciar y abrir el formulario modal
                using (DetalleCompraProducto modal = new DetalleCompraProducto())
                {
                    // Mostrar el formulario como modal (bloquea la ventana principal hasta que se cierre)
                    DialogResult resultado = modal.ShowDialog();
                }
            }
        }
    }
}
