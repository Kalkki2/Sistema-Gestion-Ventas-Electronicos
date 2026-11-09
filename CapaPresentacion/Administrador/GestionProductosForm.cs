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
        private CNProveedor objCNProveedor = new CNProveedor();
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
            txtPrecio.Clear();
            txtStock.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            errorProvider1.Clear();

            idProductoSeleccionado = 0;

            btnAgregarProducto.Text = "Agregar";
            txtCodigo.Focus();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Existen campos vacíos o con datos incorrectos. Por favor, revíselos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay errores
            }

            
            //  Mapeo del objeto EProducto
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
                CargarProductos();
                LimpiarCampos(); 
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dgvListaProductos.Columns["colStockMinimo"].DataPropertyName = "stock_minimo";
            dgvListaProductos.Columns["colProveedor"].DataPropertyName = "NombreProveedor";
            dgvListaProductos.Columns["colCategoria"].DataPropertyName = "NombreCategoria";
            dgvListaProductos.Columns["colMarca"].DataPropertyName = "NombreMarca";
            dgvListaProductos.Columns["colFechaAlta"].DataPropertyName = "fecha_alta"; 
             dgvListaProductos.Columns["colFechaModificacion"].DataPropertyName = "fecha_ultima_modificacion";
            dgvListaProductos.Columns["colEstado"].DataPropertyName = "EstadoTexto";

            var lista = objCNProducto.ListarProductos();
            dgvListaProductos.DataSource = lista;

            ActualizarContadores(lista);
        }

       

        private void GestionProductosForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            dgvListaProductos.CellFormatting -= dgvListaProductos_CellFormatting; 
            dgvListaProductos.CellFormatting += dgvListaProductos_CellFormatting;

            CargarCategorias();
            CargarProveedores();
            CargarEstado();
            CargarFiltrosCombos(); 
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

        private void CargarProveedores()
        {
            List<EProveedor> lista = objCNProveedor.ListarProveedoreActivos();
            cmbProveedor.DataSource = lista;
            cmbProveedor.DisplayMember = "razon_social";
            cmbProveedor.ValueMember = "proveedor_id";
            cmbProveedor.SelectedIndex = -1;
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

                    // Cargar datos en las cajas de texto
                    txtCodigo.Text = producto.codigo;
                    txtNombre.Text = producto.nombre;
                    txtDescripcion.Text = producto.descripcion;
                    txtPrecio.Text = producto.precio_venta.ToString();
                    txtStock.Text = producto.stock.ToString();

                    // Seleccionar valor en ComboBox Categoría
                    cmbCategoria.SelectedValue = producto.categoria_id;

                    // NOTA: Como la marca depende de la categoría (cascada),
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
            lblCantTotalProductos.Text = lista.Count.ToString();

            int stockBajo = lista.Count(p => p.stock < p.stock_minimo);
            lblCantStockBajo.Text = stockBajo.ToString();
        }

        private void CargarFiltrosCombos()
        {
            // Filtro Categoría (Todas las categorías + "Todos")
            var listaCat = objCNProducto.ListarCategorias();
            listaCat.Insert(0, new ECategoria { categoria_id = 0, nombre = "Todos" });
            cmbFiltroCategoria.DataSource = listaCat;
            cmbFiltroCategoria.DisplayMember = "nombre";
            cmbFiltroCategoria.ValueMember = "categoria_id";
            cmbFiltroCategoria.SelectedIndex = 0;

            // Filtro Marca (Todas las marcas + "Todos" - Independiente)
            var listaMar = objCNProducto.ListarMarcas();
            listaMar.Insert(0, new EMarca { marca_id = 0, nombre = "Todos" });
            cmbFiltroMarca.DataSource = listaMar;
            cmbFiltroMarca.DisplayMember = "nombre";
            cmbFiltroMarca.ValueMember = "marca_id";
            cmbFiltroMarca.SelectedIndex = 0;

            // Filtro Proveedor (Todos los proveedores + "Todos")
            var listaProv = objCNProveedor.ListarProveedoreActivos();
            listaProv.Insert(0, new EProveedor { proveedor_id = 0, razon_social = "Todos" });
            cmbFiltroProveedor.DataSource = listaProv;
            cmbFiltroProveedor.DisplayMember = "razon_social";
            cmbFiltroProveedor.ValueMember = "proveedor_id";
            cmbFiltroProveedor.SelectedIndex = 0;

            // Filtro Estado
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = -1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 });
            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void AplicarFiltros()
        {
            dgvListaProductos.AutoGenerateColumns = false;
            int categoriaId = 0;
            if (cmbFiltroCategoria.SelectedValue is int catId)
                categoriaId = catId;

            int marcaId = 0;
            if (cmbFiltroMarca.SelectedValue is int mId)
                marcaId = mId;

            int proveedorId = 0;
            if (cmbFiltroProveedor.SelectedValue is int provId)
                proveedorId = provId;

            int estado = -1;
            if (cmbFiltroEstado.SelectedItem is OpcionCombo opEstado)
                estado = Convert.ToInt32(opEstado.Valor);

            string textoBusqueda = txtBuscarProducto.Text.Trim();

            var listaFiltrada = objCNProducto.BuscarProductosGeneral(categoriaId, marcaId, proveedorId, estado, textoBusqueda);

            dgvListaProductos.DataSource = listaFiltrada;
            ActualizarContadores(listaFiltrada);
            dgvListaProductos.Refresh();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dgvListaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvListaProductos.NewRowIndex) return;
            string colName = dgvListaProductos.Columns[e.ColumnIndex].Name;

            var producto = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;

            if (producto != null)
            {
                if (producto.stock < producto.stock_minimo)
                {
                    e.CellStyle.BackColor = Color.Gold;
                    e.CellStyle.ForeColor = Color.Black; 
                }
            }

            if (colName == "colEliminar")
            {
                var ProductoRow = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;

                if (ProductoRow != null)
                {
                    // Evaluamos si estado == 1 (Activo)
                    if (ProductoRow.estado == 1)
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

        private bool ValidarCampos()
        {
            bool esValido = true;
            errorProvider1.Clear(); // Limpia errores anteriores

            // Validar Código 
            string codigo = txtCodigo.Text.Trim();
            if (string.IsNullOrWhiteSpace(codigo))
            {
                errorProvider1.SetError(txtCodigo, "El código del producto es obligatorio.");
                esValido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(codigo, @"^\d{6}$"))
            {
                errorProvider1.SetError(txtCodigo, "El código debe ser un número entero de exactamente 6 dígitos.");
                esValido = false;
            }

            // Validar Nombre
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                errorProvider1.SetError(txtNombre, "El nombre del producto es obligatorio.");
                esValido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras.");
                esValido = false;
            }
            else if (nombre.Length < 7)
            {
                errorProvider1.SetError(txtNombre, "El nombre debe tener al menos 7 caracteres.");
                esValido = false;
            }

            // Validar Descripción
            string descripcion = txtDescripcion.Text;
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                errorProvider1.SetError(txtDescripcion, "La descripción del producto es obligatoria.");
                esValido = false;
            }
            else if (descripcion.Replace(" ", "").Length < 10)
            {
                errorProvider1.SetError(txtDescripcion, "La descripción debe tener al menos 10 caracteres (sin contar espacios).");
                esValido = false;
            }

            // Validar ComboBox de Categoría
            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCategoria, "Debe seleccionar una categoría.");
                esValido = false;
            }

            // Validar ComboBox de Marca
            if (cmbMarca.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbMarca, "Debe seleccionar una marca.");
                esValido = false;
            }

            //  Validar ComboBox de Proveedor
            if (cmbProveedor.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbProveedor, "Debe seleccionar un proveedor.");
                esValido = false;
            }

            //  Validar ComboBox de Estado
            if (cmbEstado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            LimpiarCampos();
            MessageBox.Show("Se ha cancelado la operación y limpiado el formulario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
 }
