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
    public partial class GestionVentasForm : Form
    {
        private CNMetodoPago objCNMetodoPago = new CNMetodoPago();
        private bool cargandoFormulario = true;
        public GestionVentasForm()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: true);
        }

        private void GestionVentasForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarHistorialVentas();
            CargarConfiguracionPagos();
            CargarFiltroMetodoPago();
            CargarFiltroEstado();

            cargandoFormulario = false; 
            FiltrarHistorial(aplicarFechas: false);
        }

        

        private void btnAplicarAjusteFormaPago_Click(object sender, EventArgs e)
        {
            if (cmbMetodoPago.SelectedValue == null || cmbTipoAjuste.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un método de pago y un tipo de ajuste.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea aplicar este ajuste a la forma de pago?",
                "Confirmar ajuste",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            int metodoPagoId = Convert.ToInt32(cmbMetodoPago.SelectedValue);
            int tipoAjusteId = Convert.ToInt32(cmbTipoAjuste.SelectedValue);
            decimal porcentaje = Convert.ToDecimal(txtPorcentajeAjuste.Value);

            string mensaje = string.Empty;
            bool resultado = objCNMetodoPago.Actualizar(metodoPagoId, porcentaje, tipoAjusteId, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Se aplicó el ajuste con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarConfiguracionPagos(); // Recargamos para refrescar
            }
            else
            {
                MessageBox.Show("Error al actualizar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SincronizarDatosMetodoPago();
        }

        private void CargarHistorialVentas()
        {
            dgvHistorialVentas.AutoGenerateColumns = false;

            dgvHistorialVentas.Columns["colNroVenta"].DataPropertyName = "nro_venta";
            dgvHistorialVentas.Columns["colDniCliente"].DataPropertyName = "DniCliente";
            dgvHistorialVentas.Columns["colCliente"].DataPropertyName = "NombreCliente";
            dgvHistorialVentas.Columns["colDniVendedor"].DataPropertyName = "DniUsuario";
            dgvHistorialVentas.Columns["colVendedor"].DataPropertyName = "NombreComprador";
            dgvHistorialVentas.Columns["colMetodoPago"].DataPropertyName = "NombreMetodoPago";
            dgvHistorialVentas.Columns["colTipoAjuste"].DataPropertyName = "NombreTipoAjuste";
            dgvHistorialVentas.Columns["colFechaVenta"].DataPropertyName = "fecha_venta";
            dgvHistorialVentas.Columns["colTotal"].DataPropertyName = "TotalVenta";
            dgvHistorialVentas.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            CNVenta objCNVenta = new CNVenta();
            dgvHistorialVentas.DataSource = objCNVenta.ListarHistorialVentas();
        }

        private void dgvHistorialVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no se haga clic en los encabezados (fila -1)
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvHistorialVentas.Columns[e.ColumnIndex].Name;

            // Si hace clic en la columna configurada como botón "Ver Detalle"
            if (nombreColumna == "colVerDetalle")
            {
                // Extraemos el objeto EVenta de la fila seleccionada en la grilla
                EVenta ventaSeleccionada = (EVenta)dgvHistorialVentas.Rows[e.RowIndex].DataBoundItem;

                if (ventaSeleccionada != null)
                {
                    // Abrimos el formulario modal pasándole el objeto por el constructor
                    using (DetalleVenta modal = new DetalleVenta(ventaSeleccionada))
                    {
                        modal.ShowDialog(); // Esto abre la ventana que diseñaste con los datos de la venta y productos
                    }
                }
            }
        }

        private void CargarConfiguracionPagos()
        {
            // Cargar Tipos de Ajuste
            cmbTipoAjuste.DataSource = objCNMetodoPago.ListarTiposAjuste();
            cmbTipoAjuste.DisplayMember = "nombre";
            cmbTipoAjuste.ValueMember = "tipo_ajuste_id";

            // Cargar Métodos de Pago
            cmbMetodoPago.DataSource = objCNMetodoPago.Listar();
            cmbMetodoPago.DisplayMember = "nombre";
            cmbMetodoPago.ValueMember = "metodo_pago_id";

            // Si hay elementos, seleccionamos el primero y cargamos sus datos en los controles
            if (cmbMetodoPago.Items.Count > 0)
            {
                cmbMetodoPago.SelectedIndex = 0;
                SincronizarDatosMetodoPago();
            }
        }

        private void SincronizarDatosMetodoPago()
        {
            if (cmbMetodoPago.SelectedItem != null)
            {
                EMetodoPago metodoSeleccionado = (EMetodoPago)cmbMetodoPago.SelectedItem;

                // Rellenamos el porcentaje actual para que pueda modificarlo
                txtPorcentajeAjuste.Value = metodoSeleccionado.porcentaje;

                // Seleccionamos el tipo de ajuste fijo que le pertenece
                cmbTipoAjuste.SelectedValue = metodoSeleccionado.tipo_ajuste_id;
            }
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            SincronizarDatosMetodoPago();
        }

        private void FiltrarHistorial(bool aplicarFechas = true)
        {
            CNVenta objCNVenta = new CNVenta();
            if (cargandoFormulario) return;

            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            if (aplicarFechas)
            {
                if (dtpDesde.Value.Date > dtpHasta.Value.Date)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                fechaDesde = dtpDesde.Value.Date;
                fechaHasta = dtpHasta.Value.Date;
            }

            try
            {
                string dniVendedor = txtBuscarVendedorDni.Text.Trim();
                string dniCliente = txtBuscarClienteDni.Text.Trim();

                int metodoPagoId = 0;
                if (cmbFiltroMetodoPago.SelectedValue != null)
                {
                    int.TryParse(cmbFiltroMetodoPago.SelectedValue.ToString(), out metodoPagoId);
                }

                int estadoId = -1; // Por defecto "Todos"
                if (cmbFiltroEstado.SelectedItem is OpcionCombo opcionSeleccionada)
                {
                    estadoId = Convert.ToInt32(opcionSeleccionada.Valor);
                }

                // Llamada a la capa de negocio
                var listaFiltrada = objCNVenta.Buscar(null, dniVendedor, dniCliente, metodoPagoId, estadoId, fechaDesde, fechaHasta);

                dgvHistorialVentas.DataSource = listaFiltrada;
                lblCantTotalVentas.Text = listaFiltrada.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarVendedorDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void txtBuscarClienteDni_TextChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void cmbFiltroMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void CargarFiltroMetodoPago()
        {
            CNMetodoPago objCNMetodoPagoFiltro = new CNMetodoPago();
            var listaMetodos = objCNMetodoPagoFiltro.Listar();

            listaMetodos.Insert(0, new EMetodoPago { metodo_pago_id = 0, nombre = "Todos" });

            cmbFiltroMetodoPago.DataSource = listaMetodos;
            cmbFiltroMetodoPago.DisplayMember = "nombre";
            cmbFiltroMetodoPago.ValueMember = "metodo_pago_id";
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
            cmbFiltroEstado.SelectedIndex = 0; // Selecciona "Todos" por defecto
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarHistorial(aplicarFechas: false);
        }

        private void dgvHistorialVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvHistorialVentas.NewRowIndex) return;

            string colName = dgvHistorialVentas.Columns[e.ColumnIndex].Name;

            if (colName == "colVerDetalle")
            {
                e.Value = Properties.Resources.icono_editar;
            }
        }
    }
}
