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
    public partial class NuevaVentaForm : Form
    {
        private readonly CNMetodoPago objCNMetodoPago = new CNMetodoPago();
        private readonly CNVenta objCNVenta = new CNVenta();

        // IDs y variables de control directas
        private int idClienteSeleccionado = 0;
        private int idProductoSeleccionado = 0;
        private int stockProductoSeleccionado = 0;
        private string codigoProductoSeleccionado = string.Empty;

        private List<EMetodoPago> metodosPago = new List<EMetodoPago>();
        private List<ETipoAjuste> tiposAjuste = new List<ETipoAjuste>();

        public NuevaVentaForm()
        {
            InitializeComponent();
        }

        private void NuevaVentaForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }

            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarMetodosPago();
            ActualizarTotalesVenta();
        }

        // Trae de la base los métodos de pago con su porcentaje y tipo de ajuste
        private void CargarMetodosPago()
        {
            try
            {
                metodosPago = objCNMetodoPago.Listar();
                tiposAjuste = objCNMetodoPago.ListarTiposAjuste();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los métodos de pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbFiltroMetodoPago.DataSource = null;
            cmbFiltroMetodoPago.DataSource = metodosPago;
            cmbFiltroMetodoPago.DisplayMember = "nombre";         // Lo que ve el usuario (ej: Efectivo, Tarjeta)
            cmbFiltroMetodoPago.ValueMember = "metodo_pago_id";   // El ID interno

            if (cmbFiltroMetodoPago.Items.Count > 0)
            {
                cmbFiltroMetodoPago.SelectedIndex = 0;
            }

            // Aseguramos el evento de cambio de selección
            cmbFiltroMetodoPago.SelectedIndexChanged -= cmbFiltroMetodoPago_SelectedIndexChanged;
            cmbFiltroMetodoPago.SelectedIndexChanged += cmbFiltroMetodoPago_SelectedIndexChanged;
        }



        // Calcula el descuento (resta) o recargo (suma) según el método de pago elegido
        private void CalcularAjuste(decimal subtotal, out decimal montoAjuste, out string titulo)
        {
            montoAjuste = 0m;
            titulo = "Sin ajuste:";

            if (cmbFiltroMetodoPago.SelectedItem == null) return;

            EMetodoPago m = cmbFiltroMetodoPago.SelectedItem as EMetodoPago;
            if (m == null) return;

            ETipoAjuste t = tiposAjuste.FirstOrDefault(x => x.tipo_ajuste_id == m.tipo_ajuste_id);
            string tipo = (t != null && t.nombre != null) ? t.nombre.ToLower() : "";

            decimal monto = Math.Round(subtotal * m.porcentaje / 100m, 2);

            if (tipo.Contains("desc"))
            {
                montoAjuste = -monto; // Resta al total
                titulo = $"Descuento {m.nombre} ({m.porcentaje.ToString("0.##")}%):";
            }
            else if (tipo.Contains("recar"))
            {
                montoAjuste = monto;  // Suma al total
                titulo = $"Recargo {m.nombre} ({m.porcentaje.ToString("0.##")}%):";
            }
            else
            {
                titulo = $"Sin ajuste ({m.nombre}):";
            }
        }



        // ===== Buscadores =====
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente primero antes de buscar productos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (BuscarProductoVentaForm frm = new BuscarProductoVentaForm())
            {
                var resultado = frm.ShowDialog();
                if (resultado == DialogResult.OK && frm.ProductoSeleccionado != null)
                {
                    idProductoSeleccionado = frm.ProductoSeleccionado.producto_id;
                    codigoProductoSeleccionado = frm.ProductoSeleccionado.codigo;
                    txtNombreProducto.Text = frm.ProductoSeleccionado.nombre;
                    txtPrecioProducto.Text = frm.ProductoSeleccionado.precio_venta.ToString("0.00");
                    stockProductoSeleccionado = frm.ProductoSeleccionado.stock;
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            bool hayProductos = false;
            foreach (DataGridViewRow row in dgvListaProductos.Rows)
            {
                // Si la fila no es la de "nuevo registro" y tiene un ID de producto válido
                if (!row.IsNewRow && row.Cells["colProductoId"].Value != null && Convert.ToInt32(row.Cells["colProductoId"].Value) > 0)
                {
                    hayProductos = true;
                    break;
                }
            }

            if (hayProductos)
            {
                MessageBox.Show("No puede cambiar de cliente porque ya hay productos agregados a la venta. Si desea cambiar, elimine los ítems de la lista o limpie el formulario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (BuscarClienteForm frm = new BuscarClienteForm())
            {
                var resultado = frm.ShowDialog();

                if (resultado == DialogResult.OK && frm.ClienteSeleccionado != null)
                {
                    idClienteSeleccionado = frm.ClienteSeleccionado.cliente_id;
                    txtNomYApeCliente.Text = frm.ClienteSeleccionado.nombre + " " + frm.ClienteSeleccionado.apellido;
                    txtDniCliente.Text = frm.ClienteSeleccionado.dni;
                }
            }
        }

        // ===== Ítems de la venta =====
        private void btnAgregarItemVenta_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente antes de agregar productos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idProductoSeleccionado == 0 || string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Debe seleccionar un producto primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = Convert.ToInt32(txtCantidadCompra.Value);
            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadCompra.Focus();
                return;
            }

            if (cantidad > stockProductoSeleccionado)
            {
                MessageBox.Show(
                    $"No hay suficiente stock disponible para este producto.\n\nStock actual: {stockProductoSeleccionado}\nCantidad solicitada: {cantidad}",
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtCantidadCompra.Focus();
                return;
            }

            decimal precioUnitario = 0;
            if (!decimal.TryParse(txtPrecioProducto.Text.Replace(".", ","), out precioUnitario) || precioUnitario <= 0)
            {
                MessageBox.Show("El precio unitario no es válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgvListaProductos.Rows)
            {
                if (row.Cells["colProductoId"].Value != null && Convert.ToInt32(row.Cells["colProductoId"].Value) == idProductoSeleccionado)
                {
                    MessageBox.Show("Este producto ya fue agregado a la lista de la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            decimal subtotal = cantidad * precioUnitario;
            int nroItem = dgvListaProductos.Rows.Count + 1;

            dgvListaProductos.Rows.Add(new object[] {
                idProductoSeleccionado,             // colProductoId (Oculta)
                nroItem,                            // NroItem visual
                codigoProductoSeleccionado,         // Código
                txtNombreProducto.Text,             // Producto (Nombre)
                cantidad,                           // Cantidad
                precioUnitario.ToString("0.00"),    // Precio Unitario
                subtotal.ToString("0.00")           // Subtotal
            });

            ActualizarTotalesVenta();
            LimpiarCamposProducto();
        }

        private void LimpiarCamposProducto()
        {
            idProductoSeleccionado = 0;
            codigoProductoSeleccionado = string.Empty;
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadCompra.Value = 0;
        }

        // ===== CÁLCULO DE TOTALES, DESCUENTOS Y RECARGOS =====
        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente antes de confirmar la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvListaProductos.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la lista de venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbFiltroMetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un método de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea confirmar esta nueva venta?",
                "Confirmar registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                EMetodoPago metodoSeleccionado = cmbFiltroMetodoPago.SelectedItem as EMetodoPago;
                EVenta objVenta = new EVenta()
                {
                    nro_venta = string.Empty, // Se asignará automáticamente en la BD basado en el ID
                    estado = 1, // 1 = Activo / Registrado
                    usuario_id = SesionActual.UsuarioLogueado.usuario_id,
                    cliente_id = idClienteSeleccionado,
                    metodo_pago_id = metodoSeleccionado.metodo_pago_id,
                    porcentaje_aplicado = metodoSeleccionado.porcentaje
                };

                // Recorrer la grilla para armar la lista de detalles
                List<EDetalleVenta> listaDetalles = new List<EDetalleVenta>();
                decimal subtotalGeneral = 0;

                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    if (row.Cells["colProductoId"].Value != null)
                    {
                        decimal precioUnitarioFila = 0;
                        decimal.TryParse(row.Cells["colPrecioUnitario"].Value?.ToString().Replace(".", ","), out precioUnitarioFila);

                        int cantidadFila = 0;
                        int.TryParse(row.Cells["colCantidad"].Value?.ToString(), out cantidadFila);

                        decimal subtotalFila = cantidadFila * precioUnitarioFila;
                        subtotalGeneral += subtotalFila;

                        listaDetalles.Add(new EDetalleVenta()
                        {
                            producto_id = Convert.ToInt32(row.Cells["colProductoId"].Value),
                            cantidad = cantidadFila,
                            precio_unitario = precioUnitarioFila
                        });
                    }
                }

                // Calcular el total final aplicando descuento/recargo
                decimal montoAjuste = Math.Round(subtotalGeneral * metodoSeleccionado.porcentaje / 100m, 2);
                ETipoAjuste tipoAjuste = tiposAjuste.FirstOrDefault(x => x.tipo_ajuste_id == metodoSeleccionado.tipo_ajuste_id);
                string tipoAjusteNombre = (tipoAjuste != null && tipoAjuste.nombre != null) ? tipoAjuste.nombre.ToLower() : "";

                decimal totalFinal = subtotalGeneral;
                if (tipoAjusteNombre.Contains("desc"))
                {
                    totalFinal = subtotalGeneral - montoAjuste;
                }
                else if (tipoAjusteNombre.Contains("recar"))
                {
                    totalFinal = subtotalGeneral + montoAjuste;
                }

                // Enviar a la Capa de Negocio
                CNVenta objCNVentaLogica = new CNVenta();
                string mensaje = string.Empty;
                bool exito = objCNVentaLogica.Registrar(objVenta, listaDetalles, out mensaje);

                if (exito)
                {
                    using (ConfirmacionVentaForm frmModal = new ConfirmacionVentaForm(objVenta.nro_venta, totalFinal))
                    {
                        frmModal.ShowDialog();
                    }

                    LimpiarFormularioCompleto();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            // 1. Preguntar si realmente desea cancelar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cancelar la venta?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            LimpiarFormularioCompleto();
            MessageBox.Show("La venta se canceló con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===== Limpieza y validaciones =====
        private class ItemVenta
        {
            public int ProductoId { get; set; }
            public string Codigo { get; set; }
            public string Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int Stock { get; set; }
            public decimal Subtotal { get { return Cantidad * PrecioUnitario; } }
        }

        private void cmbFiltroMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotalesVenta();
        }

       

        // Método para sumar los subtotales de la grilla, calcular descuentos/recargos y actualizar los totales
        private void ActualizarTotalesVenta()
        {
            decimal subtotalGeneral = 0;

            foreach (DataGridViewRow row in dgvListaProductos.Rows)
            {
                if (row.Cells["colSubtotal"]?.Value != null)
                {
                    decimal subtotalFila = 0;
                    decimal.TryParse(row.Cells["colSubtotal"].Value.ToString().Replace(".", ","), out subtotalFila);
                    subtotalGeneral += subtotalFila;
                }
            }

            decimal montoAjuste = 0m;
            string tituloAjuste = "Sin ajuste:";
            CalcularAjuste(subtotalGeneral, out montoAjuste, out tituloAjuste);

            decimal totalFinal = subtotalGeneral + montoAjuste;
            if (totalFinal < 0) totalFinal = 0;

            if (lblSubtotalVenta != null) lblSubtotalVenta.Text = "$" + subtotalGeneral.ToString("0.00");
            if (lblTituloAjuste != null) lblTituloAjuste.Text = tituloAjuste;
            if (lblMontoAjuste != null) lblMontoAjuste.Text = (montoAjuste < 0 ? "- $" : "$") + Math.Abs(montoAjuste).ToString("0.00");
            if (lblTotalVenta != null) lblTotalVenta.Text = "$ " + totalFinal.ToString("0.00");
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvListaProductos.Columns[e.ColumnIndex].Name;

            // 1. LÓGICA DE ELIMINAR ÍTEM
            if (nombreColumna == "colEliminar")
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar este producto de la venta?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Eliminamos la fila seleccionada de la grilla
                    dgvListaProductos.Rows.RemoveAt(e.RowIndex);

                    // Recalculamos los totales de la venta
                    ActualizarTotalesVenta();

                    // Reordenamos la numeración de los ítems (1, 2, 3...)
                    ActualizarNumeracionItems();
                }
            }
            // ACCIÓN DE EDITAR
            else if (nombreColumna == "colEditar")
            {
                DataGridViewRow fila = dgvListaProductos.Rows[e.RowIndex];

                // Recuperamos los datos de la fila seleccionada y los cargamos arriba
                idProductoSeleccionado = Convert.ToInt32(fila.Cells["colProductoId"].Value);
                codigoProductoSeleccionado = fila.Cells["colCodigo"]?.Value?.ToString() ?? string.Empty;
                txtNombreProducto.Text = fila.Cells["colProducto"]?.Value?.ToString() ?? string.Empty;

                if (int.TryParse(fila.Cells["colCantidad"]?.Value?.ToString(), out int cantidadActual))
                {
                    txtCantidadCompra.Value = cantidadActual; // (O el nombre de tu NumericUpDown de cantidad)
                }

                txtPrecioProducto.Text = fila.Cells["colPrecioUnitario"]?.Value?.ToString() ?? "0.00";

                // Quitamos temporalmente la fila de la grilla para que se vuelva a agregar actualizada al presionar el botón de agregar
                dgvListaProductos.Rows.RemoveAt(e.RowIndex);

                // Recalculamos los totales y reordenamos la numeración
                ActualizarTotalesVenta();
                ActualizarNumeracionItems();

                MessageBox.Show("Modifique los datos en la parte superior y presione 'Agregar Producto' para registrar los cambios.", "Editar Ítem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarNumeracionItems()
            {
                int contador = 1;
                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    if (row.Cells["colNroItem"] != null)
                    {
                        row.Cells["colNroItem"].Value = contador;
                    }
                    contador++;
                }
         }

        private void LimpiarFormularioCompleto()
        {
            idClienteSeleccionado = 0;
            txtNomYApeCliente.Clear();
            txtDniCliente.Clear();
            dgvListaProductos.Rows.Clear();
            stockProductoSeleccionado = 0;
            LimpiarCamposProducto();
            ActualizarTotalesVenta();
        }
    }
 }
