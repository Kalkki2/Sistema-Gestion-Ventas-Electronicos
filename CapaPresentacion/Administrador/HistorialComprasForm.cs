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
    public partial class HistorialCompras : Form
    {
        CNCompra objCNCompra = new CNCompra();
        public HistorialCompras()
        {
            InitializeComponent();
        }

        private void HistorialComprasForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            CargarHistorialCompras();
            CargarOpcioneComboboxEstado();
        }

        private void CargarHistorialCompras()
        {
            dgvHistorialCompras.AutoGenerateColumns = false;

            dgvHistorialCompras.Columns["colNroFactura"].DataPropertyName = "nro_factura";
            dgvHistorialCompras.Columns["colCuitProveedor"].DataPropertyName = "CuitProveedor";
            dgvHistorialCompras.Columns["colProveedor"].DataPropertyName = "NombreProveedor";
            dgvHistorialCompras.Columns["colDniUsuario"].DataPropertyName = "DniUsuario";
            dgvHistorialCompras.Columns["colComprador"].DataPropertyName = "NombreComprador";
            dgvHistorialCompras.Columns["colFechaCompra"].DataPropertyName = "fecha_compra";
            dgvHistorialCompras.Columns["colTotal"].DataPropertyName = "TotalCompra";
            dgvHistorialCompras.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            dgvHistorialCompras.DataSource = objCNCompra.ListarHistorialCompras();
        }

        private void dgvHistorialCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvHistorialCompras.Columns[e.ColumnIndex].Name;

            // VER DETALLE
            if (colName == "colVerDetalle")
            {
                ECompra compraSeleccionada = (ECompra)dgvHistorialCompras.Rows[e.RowIndex].DataBoundItem;

                if (compraSeleccionada != null)
                {
                    using (DetalleCompraProducto modal = new DetalleCompraProducto(compraSeleccionada))
                    {
                        modal.ShowDialog();
                    }
                }
            }

            // CAMBIAR ESTADO (ANULAR / REACTIVAR)
            if (colName == "colCambiarEstado")
            {
                var compraRow = dgvHistorialCompras.Rows[e.RowIndex].DataBoundItem as ECompra;
                if (compraRow != null)
                {
                    int estadoActual = compraRow.estado;
                    int nuevoEstado = (estadoActual == 1) ? 0 : 1;
                    string accion = (estadoActual == 1) ? "anular" : "reactivar";

                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} la compra con Nro de Factura: {compraRow.nro_factura}?",
                        $"Confirmar {accion}",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        bool respuesta = objCNCompra.CambiarEstado(compraRow.compra_id, nuevoEstado, out mensaje);

                        if (respuesta)
                        {
                            MessageBox.Show($"La compra se pudo {accion} con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarHistorialCompras();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cambiar el estado de la compra: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void FiltrarHistorial()
        {
            string nroFactura = txtBuscarCompraPorNroFactura.Text.Trim();
            string cuitProveedor = txtBuscarProveedorPorCuit.Text.Trim();
            string dniUsuario = txtBuscarUsuarioPorDni.Text.Trim();

            // Leemos el estado seleccionado en el ComboBox de manera segura
            int? estadoFiltro = null;
            if (cmbFiltroEstado.SelectedItem != null)
            {
                var itemSeleccionado = cmbFiltroEstado.SelectedItem as OpcionCombo;
                if (itemSeleccionado != null)
                {
                    int.TryParse(itemSeleccionado.Valor.ToString(), out int valEstado);
                    estadoFiltro = valEstado;
                }
            }

            // Pasamos los parámetros incluyendo el estado
            var resultados = objCNCompra.Buscar(nroFactura, cuitProveedor, dniUsuario, null, null, estadoFiltro);
            dgvHistorialCompras.DataSource = resultados;
        }

        private void txtBuscarCompraPorNroFactura_TextChanged(object sender, EventArgs e)
        {
            FiltrarHistorial();
        }

        private void txtBuscarProveedorPorCuit_TextChanged(object sender, EventArgs e)
        {
            FiltrarHistorial();
        }

        private void txtBuscarUsuarioPorDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarHistorial();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;

            // Si desde es mayor que hasta -> Informar error
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'. Por favor, verifique los valores.",
                                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos los textos de búsqueda
            string nroFactura = txtBuscarCompraPorNroFactura.Text.Trim();
            string cuitProveedor = txtBuscarProveedorPorCuit.Text.Trim();
            string dniUsuario = txtBuscarUsuarioPorDni.Text.Trim();

            // PASAMOS 'null' AQUÍ: Esto hace que el filtro de estado se ignore 
            // y traiga todos los registros (activos y anulados) dentro de ese rango de fechas y textos.
            var resultados = objCNCompra.Buscar(nroFactura, cuitProveedor, dniUsuario, fechaDesde, fechaHasta, null);

            dgvHistorialCompras.DataSource = resultados;

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron compras en el rango de fechas o filtros seleccionados.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHistorialCompras();
            }
        }

        private void dgvHistorialCompras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvHistorialCompras.NewRowIndex) return;

            string colName = dgvHistorialCompras.Columns[e.ColumnIndex].Name;

            // Ícono para Ver Detalle
            if (colName == "colVerDetalle")
            {
                e.Value = Properties.Resources.icono_editar; 
            }

            // Ícono dinámico para Cambiar Estado (Anular / Reactivar)
            if (colName == "colCambiarEstado")
            {
                var compraRow = dgvHistorialCompras.Rows[e.RowIndex].DataBoundItem as ECompra;
                if (compraRow != null)
                {
                    if (compraRow.estado == 1)
                    {
                        e.Value = Properties.Resources.icono_eliminar; 
                    }
                    else
                    {
                        e.Value = Properties.Resources.icono_reactivar; 
                    }
                }
            }
        }

        private void CargarOpcioneComboboxEstado()
        {
            cmbFiltroEstado.Items.Add(new OpcionCombo() { Texto = "Todos", Valor = 2 });
            cmbFiltroEstado.Items.Add(new OpcionCombo() { Texto = "Activo", Valor = 1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo() { Texto = "Anulado", Valor = 0 });
            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0; // Selecciona "Todos" por defecto
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroEstado.SelectedIndex != -1)
            {
                FiltrarHistorial();
            }
        }
    }
}
