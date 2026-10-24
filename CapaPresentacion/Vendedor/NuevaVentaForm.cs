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

        private EProducto productoSeleccionado;
        private ECliente clienteSeleccionado;
        private ItemVenta itemEnEdicion;
        private readonly List<ItemVenta> itemsVenta = new List<ItemVenta>();

        // Configuración de descuentos y recargos que carga el administrador (tabla metodo_pago)
        private List<EMetodoPago> metodosPago = new List<EMetodoPago>();
        private List<ETipoAjuste> tiposAjuste = new List<ETipoAjuste>();

        // Texto "Descuento Efectivo(10%):" del diseño; se busca por su texto para poder cambiarlo
        private Label lblTituloAjuste;

        public NuevaVentaForm()
        {
            InitializeComponent();

            dgvListaProductos.AutoGenerateColumns = false;
            colCodigo.DataPropertyName = "Codigo";
            colCategoria.DataPropertyName = "Producto";
            colNombre.DataPropertyName = "Cantidad";
            colPrecio.DataPropertyName = "PrecioUnitario";
            colStock.DataPropertyName = "Subtotal";
            colPrecio.DefaultCellStyle.Format = "C2";
            colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colStock.DefaultCellStyle.Format = "C2";
            colStock.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Botones de la grilla: Column1 = Eliminar, Column2 = Editar
            dgvListaProductos.CellContentClick += dgvListaProductos_CellContentClick;
            cmbFiltroMetodoPago.SelectedIndexChanged += (s, e) => ActualizarGrillaYTotales();
        }

        private void NuevaVentaForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            lblTituloAjuste = BuscarLabel(this, "Descuento");
            CargarMetodosPago();
            ActualizarGrillaYTotales();
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

            cmbFiltroMetodoPago.Items.Clear();
            foreach (EMetodoPago m in metodosPago)
            {
                cmbFiltroMetodoPago.Items.Add(m.nombre);
            }
            if (cmbFiltroMetodoPago.Items.Count > 0)
            {
                cmbFiltroMetodoPago.SelectedIndex = 0;
            }
        }

        private static Label BuscarLabel(Control padre, string inicio)
        {
            foreach (Control c in padre.Controls)
            {
                Label l = c as Label;
                if (l != null && l.Text != null && l.Text.StartsWith(inicio, StringComparison.OrdinalIgnoreCase))
                    return l;

                Label hijo = BuscarLabel(c, inicio);
                if (hijo != null) return hijo;
            }
            return null;
        }

        // Calcula el descuento (resta) o recargo (suma) según el método de pago elegido
        private void CalcularAjuste(decimal subtotal, out decimal montoAjuste, out string titulo)
        {
            montoAjuste = 0m;
            titulo = "Sin ajuste:";

            EMetodoPago m = metodosPago.FirstOrDefault(x => x.nombre == cmbFiltroMetodoPago.Text);
            if (m == null) return;

            ETipoAjuste t = tiposAjuste.FirstOrDefault(x => x.tipo_ajuste_id == m.tipo_ajuste_id);
            string tipo = (t != null && t.nombre != null) ? t.nombre.ToLower() : "";
            decimal monto = Math.Round(subtotal * m.porcentaje / 100m, 2);

            if (tipo.Contains("desc"))
            {
                montoAjuste = -monto;
                titulo = "Descuento " + m.nombre + " (" + m.porcentaje.ToString("0.##") + "%):";
            }
            else if (tipo.Contains("recar"))
            {
                montoAjuste = monto;
                titulo = "Recargo " + m.nombre + " (" + m.porcentaje.ToString("0.##") + "%):";
            }
            else
            {
                titulo = "Sin ajuste (" + m.nombre + "):";
            }
        }

        private void ActualizarGrillaYTotales()
        {
            dgvListaProductos.DataSource = null;
            dgvListaProductos.DataSource = itemsVenta.ToList();

            decimal subtotal = itemsVenta.Sum(i => i.Subtotal);
            decimal ajuste;
            string titulo;
            CalcularAjuste(subtotal, out ajuste, out titulo);
            decimal total = subtotal + ajuste;

            if (lblTituloAjuste != null) lblTituloAjuste.Text = titulo;

            label9.Text = subtotal.ToString("C2");
            label11.Text = ajuste < 0 ? "- " + Math.Abs(ajuste).ToString("C2")
                         : ajuste > 0 ? "+ " + ajuste.ToString("C2")
                         : 0m.ToString("C2");
            label7.Text = total.ToString("C2");
        }

        // ===== Buscadores =====

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (BuscarProductoVentaForm frm = new BuscarProductoVentaForm())
            {
                if (frm.ShowDialog(this) == DialogResult.OK && frm.ProductoSeleccionado != null)
                {
                    productoSeleccionado = frm.ProductoSeleccionado;
                    txtNombreProducto.Text = productoSeleccionado.nombre;
                    txtPrecioProducto.Text = productoSeleccionado.precio_venta.ToString("N2");
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (BuscarClienteForm frm = new BuscarClienteForm())
            {
                if (frm.ShowDialog(this) == DialogResult.OK && frm.ClienteSeleccionado != null)
                {
                    clienteSeleccionado = frm.ClienteSeleccionado;
                    txtNomYApeCliente.Text = clienteSeleccionado.nombre + " " + clienteSeleccionado.apellido;
                    txtDniCliente.Text = clienteSeleccionado.dni;
                }
            }
        }

        // ===== Ítems de la venta =====

        private void btnAgregarItemVenta_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null || productoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente y un producto antes de agregar el ítem.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCantidadCompra.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadCompra.Focus();
                return;
            }

            int cantidad = (int)txtCantidadCompra.Value;

            // Se está editando un ítem existente: solo cambia la cantidad
            if (itemEnEdicion != null)
            {
                if (cantidad > productoSeleccionado.stock)
                {
                    MessageBox.Show("La cantidad supera el stock disponible.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                itemEnEdicion.Cantidad = cantidad;
                itemEnEdicion = null;
                ActualizarGrillaYTotales();
                LimpiarProducto();
                return;
            }

            ItemVenta itemExistente = itemsVenta.FirstOrDefault(i => i.ProductoId == productoSeleccionado.producto_id);
            int cantidadTotal = cantidad + (itemExistente != null ? itemExistente.Cantidad : 0);

            if (cantidadTotal > productoSeleccionado.stock)
            {
                MessageBox.Show("La cantidad supera el stock disponible.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemExistente == null)
            {
                itemsVenta.Add(new ItemVenta
                {
                    ProductoId = productoSeleccionado.producto_id,
                    Codigo = productoSeleccionado.codigo,
                    Producto = productoSeleccionado.nombre,
                    Cantidad = cantidad,
                    PrecioUnitario = productoSeleccionado.precio_venta,
                    Stock = productoSeleccionado.stock
                });
            }
            else
            {
                itemExistente.Cantidad = cantidadTotal;
            }

            ActualizarGrillaYTotales();
            LimpiarProducto();
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= itemsVenta.Count)
                return;

            string columna = dgvListaProductos.Columns[e.ColumnIndex].Name;

            if (columna == "Column1") // Eliminar
            {
                if (itemEnEdicion == itemsVenta[e.RowIndex]) itemEnEdicion = null;
                itemsVenta.RemoveAt(e.RowIndex);
                ActualizarGrillaYTotales();
            }
            else if (columna == "Column2") // Editar: sube el ítem a los campos y deja cambiar la cantidad
            {
                ItemVenta item = itemsVenta[e.RowIndex];
                itemEnEdicion = item;
                productoSeleccionado = new EProducto
                {
                    producto_id = item.ProductoId,
                    codigo = item.Codigo,
                    nombre = item.Producto,
                    precio_venta = item.PrecioUnitario,
                    stock = item.Stock
                };
                txtNombreProducto.Text = item.Producto;
                txtPrecioProducto.Text = item.PrecioUnitario.ToString("N2");
                txtCantidadCompra.Value = item.Cantidad;
                txtCantidadCompra.Focus();
            }
        }

        // ===== Confirmar y cancelar =====

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Cliente requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemsVenta.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Venta vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConfirmacionVentaForm frm = new ConfirmacionVentaForm();
            frm.ShowDialog();
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea Cancelar la venta?",
                "Confirmar cancelaciion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("La venta se cancelo con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }

        // ===== Limpieza y validaciones =====

        private void LimpiarCampos()
        {
            txtNomYApeCliente.Clear();
            txtDniCliente.Clear();
            clienteSeleccionado = null;
            itemsVenta.Clear();
            LimpiarProducto();
            ActualizarGrillaYTotales();
        }

        private void LimpiarProducto()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadCompra.Value = 0;
            productoSeleccionado = null;
            itemEnEdicion = null;
        }

        private void txtCantidadCompra_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidadCompra.Value <= 0)
            {
                errorProvider1.SetError(txtCantidadCompra, "El valor debe ser mayor a 0.");
            }
            else
            {
                errorProvider1.SetError(txtCantidadCompra, "");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }

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
    }
}