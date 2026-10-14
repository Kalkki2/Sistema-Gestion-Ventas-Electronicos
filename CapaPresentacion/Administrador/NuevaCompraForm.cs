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
    public partial class NuevaCompraForm : Form
    {
        private int idProductoSeleccionado = 0;
        private int idProveedorSeleccionado = 0;
        public NuevaCompraForm()
        {
            InitializeComponent();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvItemsCompra.Rows.Count > 0)
            {
                MessageBox.Show("No puede cambiar de proveedor porque ya hay productos agregados a la compra. Si desea cambiar de proveedor, elimine los ítems de la lista o limpie el formulario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (BuscarProveedorForm frm = new BuscarProveedorForm())
            {
                var resultado = frm.ShowDialog();

                // Si eligió un proveedor y dio OK
                if (resultado == DialogResult.OK)
                {
                    if (frm._Proveedor != null)
                    {
                        // Guardamos el ID por si acaso para después
                        idProveedorSeleccionado = frm._Proveedor.proveedor_id;

                        // Cargamos los datos del proveedor seleccionado en los TextBox de la compra
                        txtProveedorCompra.Text = frm._Proveedor.razon_social;
                        txtCorreoProveedor.Text = frm._Proveedor.email;
                        txtTelefonoProveedor.Text = frm._Proveedor.telefono;
                    }
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN CLAVE: No dejar buscar productos si no se ha seleccionado un proveedor antes
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor primero antes de buscar sus productos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrimos el formulario modal pasándole el ID del proveedor actual
            using (BuscarProductoCompraForm frm = new BuscarProductoCompraForm(idProveedorSeleccionado))
            {
                var resultado = frm.ShowDialog();

                if (resultado == DialogResult.OK && frm._Producto != null)
                {
                    idProductoSeleccionado = frm._Producto.producto_id;

                    // Rellenamos los campos de la interfaz con la información del producto seleccionado
                    txtProductoCompra.Text = frm._Producto.nombre;
                    txtPrecioCompra.Text = frm._Producto.precio_venta.ToString("0.00");
                    txtCategoriaCompra.Text = frm._Producto.oCategoria.nombre;
                    txtMarcaCompra.Text = frm._Producto.oMarca.nombre;
                }
            }
        }

        private void btnGenerarCompra_Click(object sender, EventArgs e)
        {
            // 1. Validaciones previas
            if (string.IsNullOrWhiteSpace(txtNroFactura.Text))
            {
                MessageBox.Show("Debe ingresar el número de factura o comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroFactura.Focus();
                return;
            }

            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor antes de generar la compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvItemsCompra.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la lista de compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmación del usuario antes de guardar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea generar esta nueva compra?",
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
                // 3. Crear el objeto de Cabecera (Compra)
                ECompra objCompra = new ECompra()
                {
                    nro_factura = txtNroFactura.Text.Trim(),
                    estado = 1, // 1 = Activo / Registrado
                    usuario_id = SesionActual.UsuarioLogueado.usuario_id,
                    proveedor_id = idProveedorSeleccionado
                };

                // 4. Recorrer la grilla para armar la lista de detalles
                List<EDetalleCompra> listaDetalles = new List<EDetalleCompra>();

                foreach (DataGridViewRow row in dgvItemsCompra.Rows)
                {
                    listaDetalles.Add(new EDetalleCompra()
                    {
                        producto_id = Convert.ToInt32(row.Cells["colProductoId"].Value),
                        cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value),
                        costo_unitario = Convert.ToDecimal(row.Cells["colCostoUnitario"].Value),
                        porcentaje_margen = Convert.ToDecimal(row.Cells["colMargenVenta"].Value) // <--- Agregado para enviar el margen a la capa de negocio
                    });
                }

                // 5. Enviar a la Capa de Negocio
                CNCompra objCNCompra = new CNCompra();
                string mensaje = string.Empty;
                bool exito = objCNCompra.Registrar(objCompra, listaDetalles, out mensaje);

                if (exito)
                {
                    MessageBox.Show("La compra se generó con éxito y el stock fue actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormularioCompleto();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la compra: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LimpiarFormularioCompleto()
        {
            txtNroFactura.Clear();
            txtProveedorCompra.Clear();
            txtCorreoProveedor.Clear();
            txtTelefonoProveedor.Clear();
            idProveedorSeleccionado = 0;

            dgvItemsCompra.Rows.Clear();
            lblTotalCompra.Text = "$0.00";

            LimpiarCamposProducto();
            txtNroFactura.Focus();
        }

        private void CalcularPrecioVenta()
        {
            try
            {
                // 1. Obtenemos el precio de costo ingresado (manejando puntos o comas)
                decimal precioCosto = 0;
                if (!string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
                {
                    decimal.TryParse(txtPrecioCompra.Text.Replace(".", ","), out precioCosto);
                }

                // 2. Obtenemos el porcentaje de margen (asumiendo que es un NumericUpDown o TextBox)
                decimal margenPorcentaje = 0;
                // Si tu margen es un NumericUpDown llamado numMargen:
                decimal.TryParse(txtMargenVenta.Value.ToString(), out margenPorcentaje);

                // (O si es un TextBox llamado txtMargen, usa esto en su lugar):
                // decimal.TryParse(txtMargen.Text.Replace(".", ","), out margenPorcentaje);

                // 3. Aplicamos la fórmula comercial: Precio Venta = Costo + (Costo * (Margen / 100))
                decimal precioVenta = precioCosto + (precioCosto * (margenPorcentaje / 100));

                // 4. Mostramos el resultado formateado con 2 decimales en el campo o etiqueta de Precio Venta
                txtPrecioVenta.Text = precioVenta.ToString("0.00");
            }
            catch (Exception)
            {
                txtPrecioVenta.Text = "0.00";
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }

        private void txtMargenVenta_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }

        private void btnAgregarItemProducto_Click(object sender, EventArgs e)
        {
            // 1. Validaciones previas
            if (idProductoSeleccionado == 0 || string.IsNullOrWhiteSpace(txtProductoCompra.Text))
            {
                MessageBox.Show("Debe seleccionar un producto primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = 0;
            if (!int.TryParse(txtCantidadCompra.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal costoUnitario = 0;
            if (!decimal.TryParse(txtPrecioCompra.Text.Replace(".", ","), out costoUnitario) || costoUnitario <= 0)
            {
                MessageBox.Show("El precio de costo no es válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal margen = 0;
            decimal.TryParse(txtMargenVenta.Value.ToString(), out margen);

            decimal precioVenta = 0;
            decimal.TryParse(txtPrecioVenta.Text.Replace(".", ","), out precioVenta);

            // 2. Calcular el Subtotal de la línea
            decimal subtotal = cantidad * costoUnitario;

            // 3. Validar si el producto ya fue agregado a la grilla usando la columna oculta
            foreach (DataGridViewRow row in dgvItemsCompra.Rows)
            {
                if (row.Cells["colProductoId"].Value != null && Convert.ToInt32(row.Cells["colProductoId"].Value) == idProductoSeleccionado)
                {
                    MessageBox.Show("Este producto ya fue agregado a la lista de la compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // 4. Agregar la fila a la grilla (La primera posición es el ID oculto, la segunda el NroItem visual)
            int nroItem = dgvItemsCompra.Rows.Count + 1;
            dgvItemsCompra.Rows.Add(new object[] {
        idProductoSeleccionado,            // colProductoId (Oculta)
        nroItem,                           // NroItem visual (1, 2, 3...)
        txtProductoCompra.Text,            // Producto (Nombre)
        cantidad,                          // Cantidad
        costoUnitario.ToString("0.00"),    // Costo Unit.
        margen.ToString("0.00"),           // % Margen
        precioVenta.ToString("0.00"),      // Precio Venta
        subtotal.ToString("0.00")          // Subtotal
    });

            // 5. Calcular y actualizar el TOTAL GENERAL de la compra
            CalcularTotalCompra();

            // 6. Limpiar los campos del producto para el siguiente ingreso
            LimpiarCamposProducto();
        }

        // Método para sumar todos los subtotales de la grilla y mostrarlos en el TOTAL
        private void CalcularTotalCompra()
        {
            decimal totalGeneral = 0;

            foreach (DataGridViewRow row in dgvItemsCompra.Rows)
            {
                if (row.Cells["colSubtotal"].Value != null)
                {
                    decimal subtotalFila = 0;
                    decimal.TryParse(row.Cells["colSubtotal"].Value.ToString(), out subtotalFila);
                    totalGeneral += subtotalFila;
                }
            }

            // Actualiza la etiqueta del total (Ej: lblTotalCompra)
            lblTotalCompra.Text = "$" + totalGeneral.ToString("0.00");
        }

        // Método para limpiar solo la sección del producto tras agregarlo
        private void LimpiarCamposProducto()
        {
            idProductoSeleccionado = 0;
            txtProductoCompra.Clear();
            txtCategoriaCompra.Clear();
            txtMarcaCompra.Clear();
            txtPrecioCompra.Clear();
            txtMargenVenta.Value = 0;
            txtPrecioVenta.Clear();
            // numCantidad.Value = 0; // o 1 según prefieras
        }

        private void dgvItemsCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {// Verificamos que no sea el encabezado de la tabla
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvItemsCompra.Columns[e.ColumnIndex].Name;

            // 1. LÓGICA DE ELIMINAR ÍTEM
            if (nombreColumna == "colEliminar")
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar este producto de la compra?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Eliminamos la fila seleccionada de la grilla
                    dgvItemsCompra.Rows.RemoveAt(e.RowIndex);

                    // Recalculamos el total general de la compra
                    CalcularTotalCompra();

                    // Opcional: Reordenar los números de ítem (NroItem) para que queden correlativos (1, 2, 3...)
                    ActualizarNumeracionItems();
                }
            }

            // 2. ACCIÓN DE EDITAR
            else if (nombreColumna == "colEditar")
            {
                DataGridViewRow fila = dgvItemsCompra.Rows[e.RowIndex];

                // Recuperamos el ID del producto guardado en la celda oculta
                idProductoSeleccionado = Convert.ToInt32(fila.Cells["colProductoId"].Value);
                txtProductoCompra.Text = fila.Cells[2].Value.ToString(); // Producto (Nombre)

                // Consultamos a la capa de negocio los datos completos del producto (para recuperar Categoría y Marca)
                CNProducto objCNProducto = new CNProducto();
                var listaProductos = objCNProducto.ListarProductosPorProveedor(idProveedorSeleccionado);
                var productoEncontrado = listaProductos.FirstOrDefault(p => p.producto_id == idProductoSeleccionado);

                if (productoEncontrado != null)
                {
                    // Rellenamos categoría y marca con los objetos reales
                    txtCategoriaCompra.Text = productoEncontrado.oCategoria != null ? productoEncontrado.oCategoria.nombre : "";
                    txtMarcaCompra.Text = productoEncontrado.oMarca != null ? productoEncontrado.oMarca.nombre : "";
                }

                // Recuperamos la cantidad, costo y margen de la grilla
                if (int.TryParse(fila.Cells[3].Value?.ToString(), out int cantidadActual))
                {
                    txtCantidadCompra.Text = cantidadActual.ToString();
                }

                txtPrecioCompra.Text = fila.Cells[4].Value?.ToString(); // Costo Unitario

                if (decimal.TryParse(fila.Cells[5].Value?.ToString(), out decimal margenActual))
                {
                    txtMargenVenta.Value = margenActual; // % Margen
                }

                txtPrecioVenta.Text = fila.Cells[6].Value?.ToString(); // Precio Venta

                // Quitamos temporalmente la fila de la grilla para que se vuelva a agregar actualizada al presionar el botón
                dgvItemsCompra.Rows.RemoveAt(e.RowIndex);

                // Recalculamos el total y reordenamos la numeración
                CalcularTotalCompra();
                ActualizarNumeracionItems();

                MessageBox.Show("Modifique los datos en la parte superior y presione 'Agregar Ítem' para registrar los cambios.", "Editar Ítem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método auxiliar para mantener la numeración correlativa de los ítems (1, 2, 3...)
        private void ActualizarNumeracionItems()
        {
            int contador = 1;
            foreach (DataGridViewRow row in dgvItemsCompra.Rows)
            {
                row.Cells[1].Value = contador; // Suponiendo que la columna "NroItem" está en el índice 1
                contador++;
            }
        }

        private void NuevaCompraForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
        }
    }
}
