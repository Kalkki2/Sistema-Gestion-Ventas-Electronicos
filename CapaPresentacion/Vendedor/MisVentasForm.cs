using CapaEntidad;
using CapaNegocio;
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
    public partial class MisVentasForm : Form
    {
        private bool cargandoFormulario = true;
        public MisVentasForm()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FiltrarVentas();
        }

        private void MisVentasForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }

            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1); 
            dtpHasta.Value = DateTime.Now;

            CargarMisVentas();
            CargarFiltroMetodoPago();
            CargarFiltroEstado();

            cargandoFormulario = false;
        }

        private void CargarMisVentas()
        {
            dgvMisVentas.AutoGenerateColumns = false;

            dgvMisVentas.Columns["colNroVenta"].DataPropertyName = "nro_venta";
            dgvMisVentas.Columns["colDniCliente"].DataPropertyName = "DniCliente";
            dgvMisVentas.Columns["colCliente"].DataPropertyName = "NombreCliente";
            dgvMisVentas.Columns["colMetodoPago"].DataPropertyName = "NombreMetodoPago";
            dgvMisVentas.Columns["colTipoAjuste"].DataPropertyName = "NombreTipoAjuste";
            dgvMisVentas.Columns["colFechaVenta"].DataPropertyName = "fecha_venta";
            dgvMisVentas.Columns["colTotal"].DataPropertyName = "TotalVenta";
            dgvMisVentas.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            if (SesionActual.UsuarioLogueado != null)
            {
                int idVendedorActual = SesionActual.UsuarioLogueado.usuario_id;
                CNVenta objCNVenta = new CNVenta();

                var lista = objCNVenta.ListarHistorialVentasPorUsuario(idVendedorActual);
                dgvMisVentas.DataSource = lista;
            }
        }

        private void dgvMisVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no se haga clic en los encabezados (fila -1)
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvMisVentas.Columns[e.ColumnIndex].Name;

            // Si hace clic en la columna configurada como botón "Ver Detalle" 
            // (Asegúrate de que el nombre de la columna botón en tu grilla se llame "colVerDetalle")
            if (nombreColumna == "colVerDetalle")
            {
                // Extraemos el objeto EVenta de la fila seleccionada en la grilla
                EVenta ventaSeleccionada = (EVenta)dgvMisVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada != null)
                {
                    // Abrimos el formulario modal DetalleVenta pasándole el objeto por el constructor
                    using (DetalleVenta modal = new DetalleVenta(ventaSeleccionada))
                    {
                        modal.ShowDialog(); // Muestra el detalle con los productos, cantidades y precios
                    }
                }
            }

            if (nombreColumna == "colCambiarEstado")
            {
                EVenta ventaSeleccionada = (EVenta)dgvMisVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada != null)
                {
                    // Definimos el nuevo estado opuesto (si está en 1 pasa a 0, y viceversa)
                    int nuevoEstado = ventaSeleccionada.estado == 1 ? 0 : 1;
                    string mensajeAccion = nuevoEstado == 1 ? "activar" : "anular";

                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro de que deseas {mensajeAccion} la venta Nro: {ventaSeleccionada.nro_venta}?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        CNVenta objCNVenta = new CNVenta();

                        // Llamamos a un método en tu capa de negocio para actualizar el estado en la BD
                        bool actualizado = objCNVenta.CambiarEstado(ventaSeleccionada.venta_id, nuevoEstado, out string mensaje);

                        if (actualizado)
                        {
                            MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargamos la grilla para reflejar el cambio inmediatamente
                            FiltrarVentas();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el estado: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtBuscarClienteDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarVentas();
        }

        private void FiltrarVentas()
        {
            if (cargandoFormulario || SesionActual.UsuarioLogueado == null) return;
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                CNVenta objCNVenta = new CNVenta();

                int idVendedorActual = SesionActual.UsuarioLogueado.usuario_id;
                string dniCliente = txtBuscarClienteDni.Text.Trim();

                int metodoPagoId = 0;
                if (cmbFiltroMetodoPago.SelectedValue != null)
                {
                    int.TryParse(cmbFiltroMetodoPago.SelectedValue.ToString(), out metodoPagoId);
                }

                int estadoId = -1; // Por defecto "Todos"
                if (cmbFiltroEstado.SelectedItem is OpcionCombo opcionSeleccionada && opcionSeleccionada.Valor != null)
                {
                    int.TryParse(opcionSeleccionada.Valor.ToString(), out estadoId);
                }

                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;

                var listaFiltrada = objCNVenta.Buscar(idVendedorActual, null, dniCliente, metodoPagoId, estadoId, fechaDesde, fechaHasta);

                dgvMisVentas.AutoGenerateColumns = false;
                dgvMisVentas.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFiltroMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroMetodoPago.SelectedValue != null)
            {
                FiltrarVentas();
            }
        }

        private void CargarFiltroMetodoPago()
        {
            CNMetodoPago objCNMetodoPagoFiltro = new CNMetodoPago();
            var listaMetodos = objCNMetodoPagoFiltro.Listar();

            listaMetodos.Insert(0, new EMetodoPago { metodo_pago_id = 0, nombre = "Todos" });

            cmbFiltroMetodoPago.DisplayMember = "nombre";
            cmbFiltroMetodoPago.ValueMember = "metodo_pago_id";
            cmbFiltroMetodoPago.DataSource = listaMetodos;

            cmbFiltroMetodoPago.SelectedIndex = 0;
        }

        private void CargarFiltroEstado()
        {
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = -1 }); 
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Completados", Valor = 1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Anulados", Valor = 0 });
            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0; 
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoFormulario) return;
            FiltrarVentas();
        }
    }
}
