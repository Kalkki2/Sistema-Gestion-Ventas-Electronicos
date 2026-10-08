using CapaEntidad;
using CapaNegocio;

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
        private CNProducto objCNProducto = new CNProducto();
        private int idProductoSeleccionado = 0;
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
            // 1. Validaciones de campos
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtCodigo)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtNombre)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtDescripcion)) ||
              
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) 
               )
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de continuar.", "Campos vacíos o con error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex == -1 || cmbMarca.SelectedIndex == -1 || cmbProveedor.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar Categoría, Proveedor, Marca y Estado.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Mapeo del objeto EProducto
            OpcionCombo estadoSeleccionado = (OpcionCombo)cmbEstado.SelectedItem;

            // Validación y conversión segura para campos numéricos
            decimal precioVenta = 0;
            decimal.TryParse(txtPrecio.Text.Trim(), out precioVenta);

            int stockValor = 0;
            int.TryParse(txtStock.Text.Trim(), out stockValor);

            EProducto oProducto = new EProducto()
            {
                producto_id = idProductoSeleccionado,
                codigo = txtCodigo.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                descripcion = txtDescripcion.Text.Trim(),
                precio_venta = precioVenta, // Seguro contra vacíos
                stock = stockValor,         // Seguro contra vacíos
                stock_minimo = 5,           // Puedes ajustarlo si tienes un campo para stock mínimo
                estado = Convert.ToInt32(estadoSeleccionado.Valor),
                marca_id = Convert.ToInt32(cmbMarca.SelectedValue),
                categoria_id = Convert.ToInt32(cmbCategoria.SelectedValue),
                proveedor_id = Convert.ToInt32(cmbProveedor.SelectedValue)
            };

            string mensaje = string.Empty;
            bool resultado = false;

            // 3. Evaluar si es Registro Nuevo o Actualización
            if (idProductoSeleccionado == 0)
            {
                // NUEVO
                DialogResult confirmacion = MessageBox.Show("¿Desea registrar este nuevo producto?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                resultado = objCNProducto.Registrar(oProducto, out mensaje);
            }
            else
            {
                // EDITAR / ACTUALIZAR (Lo puedes habilitar cuando programes la edición en la grilla)
                DialogResult confirmacion = MessageBox.Show("¿Desea actualizar los datos de este producto?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                resultado = objCNProducto.Editar(oProducto, out mensaje);
            }

            // 4. Respuesta
            if (resultado)
            {
                MessageBox.Show(idProductoSeleccionado == 0 ? "Producto registrado con éxito." : "Producto actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProductos();
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) && string.IsNullOrWhiteSpace(txtNombre.Text) &&
                string.IsNullOrWhiteSpace(txtPrecio.Text) && string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                cmbCategoria.SelectedIndex == -1 && cmbMarca.SelectedIndex == -1 &&
                cmbProveedor.SelectedIndex == -1 && cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("No hay nada cargado para limpiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void CargarProductos()
        {
            dgvListaProductos.AutoGenerateColumns = false;

            dgvListaProductos.Columns["colCodigo"].DataPropertyName = "codigo";
            dgvListaProductos.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaProductos.Columns["colDescripcion"].DataPropertyName = "descripcion";
            dgvListaProductos.Columns["colPrecioVenta"].DataPropertyName = "precio_venta";
            dgvListaProductos.Columns["colStock"].DataPropertyName = "stock";
            dgvListaProductos.Columns["colProveedor"].DataPropertyName = "NombreProveedor";
            dgvListaProductos.Columns["colCategoria"].DataPropertyName = "NombreCategoria";
            dgvListaProductos.Columns["colMarca"].DataPropertyName = "NombreMarca";
            dgvListaProductos.Columns["colFechaAlta"].DataPropertyName = "fecha_alta";
            dgvListaProductos.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            var lista = objCNProducto.ListarProductos();
            dgvListaProductos.DataSource = lista;

            // Actualiza los contadores de la parte superior
            ActualizarContadores(lista);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // Hacemos que el botón de la lupa ejecute el mismo filtro general
            btnFiltrar_Click(sender, e);
        }

        private void GestionProductosForm_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarCategorias();
            CargarProveedores();
            CargarEstado();
            CargarFiltrosCombos(); // <-- Inicializa los combos de filtrado
            CargarProductos();
        }

        private void CargarCategorias()
        {
            List<ECategoria> lista = objCNProducto.ListarCategorias();
            cmbCategoria.DataSource = lista;
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "categoria_id";
            cmbCategoria.SelectedIndex = -1;
        }

        private void CargarEstado()
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

        private void CargarProveedores()
        {
            List<EProveedor> lista = objCNProducto.ListarProveedores();
            cmbProveedor.DataSource = lista;
            cmbProveedor.DisplayMember = "razon_social";
            cmbProveedor.ValueMember = "proveedor_id";
            cmbProveedor.SelectedIndex = -1;
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
                errorProvider1.SetError(txtDescripcion, "La descripcion solo debe contener letras y números.");
            }
            else if (txtDescripcion.Text.Length < 3 || txtDescripcion.Text.Length > 40)
            {
                errorProvider1.SetError(txtDescripcion, "La descripcion debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, "");
            }
            
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex != -1 && cmbCategoria.SelectedValue is int categoriaId)
            {
                List<EMarca> listaMarcas = objCNProducto.ListarMarcasPorCategoria(categoriaId);
                cmbMarca.DataSource = listaMarcas;
                cmbMarca.DisplayMember = "nombre";
                cmbMarca.ValueMember = "marca_id";
                cmbMarca.SelectedIndex = -1;
            }
        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvListaProductos.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "colEditar")
            {
                var producto = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;

                if (producto != null)
                {
                    idProductoSeleccionado = producto.producto_id;

                    // 1. DESVINCULAR temporalmente los eventos Validating (si los tienes implementados para validación en vivo)
                    // txtCodigo.Validating -= txtCodigo_Validating;
                    // txtNombre.Validating -= txtNombre_Validating;
                    // txtPrecio.Validating -= txtPrecio_Validating;
                    // txtStock.Validating -= txtStock_Validating;
                    // txtDescripcion.Validating -= txtDescripcion_Validating;

                    // 2. Cargar datos en las cajas de texto
                    txtCodigo.Text = producto.codigo;
                    txtNombre.Text = producto.nombre;
                    txtDescripcion.Text = producto.descripcion;
                    txtPrecio.Text = producto.precio_venta.ToString();
                    txtStock.Text = producto.stock.ToString();

                    // 3. Seleccionar valor en ComboBox Categoría
                    cmbCategoria.SelectedValue = producto.categoria_id;

                    // NOTA: Como la marca depende de la categoría (cascada), asegurate de cargar 
                    // las marcas de esa categoría antes de asignar el SelectedValue de la marca:
                    if (cmbCategoria.SelectedValue != null)
                    {
                        int idCat = Convert.ToInt32(cmbCategoria.SelectedValue);
                        cmbMarca.DataSource = objCNProducto.ListarMarcasPorCategoria(idCat);
                        cmbMarca.DisplayMember = "nombre";
                        cmbMarca.ValueMember = "marca_id";
                    }
                    cmbMarca.SelectedValue = producto.marca_id;

                    // 4. Seleccionar valor en ComboBox Proveedor
                    cmbProveedor.SelectedValue = producto.proveedor_id;

                    // 5. Seleccionar valor en ComboBox Estado (comparando con int)
                    foreach (OpcionCombo item in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(item.Valor) == producto.estado)
                        {
                            cmbEstado.SelectedItem = item;
                            break;
                        }
                    }

                    // 6. VINCULAR NUEVAMENTE los eventos Validating (si los desvinculaste antes)
                    // txtCodigo.Validating += txtCodigo_Validating;
                    // txtNombre.Validating += txtNombre_Validating;
                    // txtPrecio.Validating += txtPrecio_Validating;
                    // txtStock.Validating += txtStock_Validating;
                    // txtDescripcion.Validating += txtDescripcion_Validating;

                    errorProvider1.Clear();

                    // Cambiar texto del botón de acción principal de "Agregar" a "Actualizar" 
                    // (Asegúrate de cambiar "btnAgregarProducto" por el nombre de tu botón en el formulario)
                    btnAgregarProducto.Text = "Actualizar";
                }
            }

            if (nombreColumna == "colEliminar")
            {
                var productoSeleccionado = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;

                if (productoSeleccionado != null)
                {
                    int estadoActual = productoSeleccionado.estado; // 1 o 0
                    int nuevoEstado = (estadoActual == 1) ? 0 : 1;   // Invierte el estado

                    string accion = (estadoActual == 1) ? "desactivar" : "reactivar";
                    string titulo = (estadoActual == 1) ? "Desactivar Producto" : "Reactivar Producto";

                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} el producto {productoSeleccionado.nombre}?",
                        titulo,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        bool respuesta = objCNProducto.CambiarEstado(productoSeleccionado.producto_id, nuevoEstado, out mensaje);

                        if (respuesta)
                        {
                            MessageBox.Show($"Producto {accion}do con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarProductos(); // Recarga la grilla para reflejar el cambio de estado
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ActualizarContadores(List<EProducto> lista)
        {
            // Cambia 'lblTotalProductos' por el nombre real del Label de tu tarjeta azul
            lblCantTotalProductos.Text = lista.Count.ToString();

            // Calcula los que tienen stock menor o igual al stock mínimo (ej: stock <= 5)
            // Cambia 'lblStockBajo' por el nombre real del Label de tu tarjeta naranja
            int stockBajo = lista.Count(p => p.stock <= p.stock_minimo);
            lblCantProductosStockBajo.Text = stockBajo.ToString();
        }

        private void CargarFiltrosCombos()
        {
            // 1. Filtro Categoría
            var listaCat = objCNProducto.ListarCategorias();
            listaCat.Insert(0, new ECategoria { categoria_id = 0, nombre = "Todos" });
            cmbFiltroCategoria.DataSource = listaCat;
            cmbFiltroCategoria.DisplayMember = "nombre";
            cmbFiltroCategoria.ValueMember = "categoria_id";
            cmbFiltroCategoria.SelectedIndex = 0;

            // 2. Filtro Proveedor
            var listaProv = objCNProducto.ListarProveedores();
            listaProv.Insert(0, new EProveedor { proveedor_id = 0, razon_social = "Todos" });
            cmbFiltroProveedor.DataSource = listaProv;
            cmbFiltroProveedor.DisplayMember = "razon_social";
            cmbFiltroProveedor.ValueMember = "proveedor_id";
            cmbFiltroProveedor.SelectedIndex = 0;

            // 3. Filtro Estado
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = -1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 });
            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCategoria.SelectedIndex != -1 && cmbFiltroCategoria.SelectedValue is int categoriaId)
            {
                if (categoriaId == 0)
                {
                    cmbFiltroMarca.DataSource = null;
                    cmbFiltroMarca.Items.Clear();
                    cmbFiltroMarca.Items.Add(new EMarca { marca_id = 0, nombre = "Todos" });
                    cmbFiltroMarca.SelectedIndex = 0;
                }
                else
                {
                    var listaMarcas = objCNProducto.ListarMarcasPorCategoria(categoriaId);
                    listaMarcas.Insert(0, new EMarca { marca_id = 0, nombre = "Todos" });
                    cmbFiltroMarca.DataSource = listaMarcas;
                    cmbFiltroMarca.DisplayMember = "nombre";
                    cmbFiltroMarca.ValueMember = "marca_id";
                    cmbFiltroMarca.SelectedIndex = 0;
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var listaProductos = objCNProducto.ListarProductos();

            // 1. Filtro por Texto (Código o Nombre) en la caja de búsqueda rápida
            string textoBusqueda = txtBuscarProducto.Text.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                listaProductos = listaProductos.Where(p =>
                    p.codigo.ToLower().Contains(textoBusqueda) ||
                    p.nombre.ToLower().Contains(textoBusqueda)
                ).ToList();
            }

            // 2. Filtro por Categoría
            if (cmbFiltroCategoria.SelectedIndex > 0 && cmbFiltroCategoria.SelectedValue is int idCat && idCat > 0)
            {
                listaProductos = listaProductos.Where(p => p.categoria_id == idCat).ToList();
            }

            // 3. Filtro por Marca
            if (cmbFiltroMarca.SelectedIndex > 0 && cmbFiltroMarca.SelectedValue is int idMarca && idMarca > 0)
            {
                listaProductos = listaProductos.Where(p => p.marca_id == idMarca).ToList();
            }

            // 4. Filtro por Proveedor
            if (cmbFiltroProveedor.SelectedIndex > 0 && cmbFiltroProveedor.SelectedValue is int idProv && idProv > 0)
            {
                listaProductos = listaProductos.Where(p => p.proveedor_id == idProv).ToList();
            }

            // 5. Filtro por Estado
            if (cmbFiltroEstado.SelectedItem is OpcionCombo estadoOpt && Convert.ToInt32(estadoOpt.Valor) != -1)
            {
                int estadoVal = Convert.ToInt32(estadoOpt.Valor);
                listaProductos = listaProductos.Where(p => p.estado == estadoVal).ToList();
            }

            // Volcar los resultados filtrados al DataGridView y actualizar contadores
            dgvListaProductos.DataSource = listaProductos;
            ActualizarContadores(listaProductos);
        }
    }
 }
