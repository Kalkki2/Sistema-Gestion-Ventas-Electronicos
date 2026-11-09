using CapaEntidad;
using CapaNegocio;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Drawing;

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

                if (!string.IsNullOrEmpty(SesionActual.UsuarioLogueado.apellido) && !string.IsNullOrEmpty(SesionActual.UsuarioLogueado.nombre))
                {
                    char inicialApellido = char.ToUpper(SesionActual.UsuarioLogueado.apellido[0]);
                    char inicialNombre = char.ToUpper(SesionActual.UsuarioLogueado.nombre[0]);

                    lblIniciales.Text = $"{inicialApellido}{inicialNombre}";
                }
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

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            List<EProducto> listaProductos = dgvListaProductos.DataSource as List<EProducto>;

            if (listaProductos == null || listaProductos.Count == 0)
            {
                MessageBox.Show("No hay registros de productos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Configurar el diálogo para guardar el archivo PDF
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = $"Reporte_Productos_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear documento PDF en orientación horizontal
                    Document doc = new Document(PageSize.A4.Rotate(), 20f, 20f, 30f, 30f);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    // Definición de fuentes corporativas
                    iTextSharp.text.Font fontEmpresa = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, new BaseColor(27, 38, 59));
                    iTextSharp.text.Font fontInfoEmpresa = FontFactory.GetFont(FontFactory.HELVETICA, 8.5f, new BaseColor(80, 90, 100));
                    iTextSharp.text.Font fontSubTituloGen = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.GRAY);
                    iTextSharp.text.Font fontCabeceraTabla = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7.5f, BaseColor.WHITE);
                    iTextSharp.text.Font fontContenido = FontFactory.GetFont(FontFactory.HELVETICA, 7f, BaseColor.BLACK);
                    iTextSharp.text.Font fontContenidoNegrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7f, BaseColor.BLACK);
                    iTextSharp.text.Font fontAlertaStock = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 7f, new BaseColor(180, 40, 40));

                    // CABECERA  (MUSNOC)
                    PdfPTable tablaHeader = new PdfPTable(2);
                    tablaHeader.WidthPercentage = 100;
                    tablaHeader.SetWidths(new float[] { 50f, 50f });

                    PdfPCell cellLeft = new PdfPCell(new Phrase("MUSNOC", fontEmpresa));
                    cellLeft.Border = PdfPCell.NO_BORDER;
                    cellLeft.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tablaHeader.AddCell(cellLeft);

                    Paragraph pInfo = new Paragraph();
                    pInfo.Alignment = Element.ALIGN_RIGHT;
                    pInfo.Add(new Chunk("Dirección: Av. 3 Abril Corrientes - Corrientes - Argentina\n", fontInfoEmpresa));
                    pInfo.Add(new Chunk("Tel: +54 9 379 634-7610", fontInfoEmpresa));

                    PdfPCell cellRight = new PdfPCell(pInfo);
                    cellRight.Border = PdfPCell.NO_BORDER;
                    cellRight.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cellRight.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tablaHeader.AddCell(cellRight);

                    doc.Add(tablaHeader);

                    // Línea divisoria inferior de la cabecera
                    PdfPTable lineaDivisoria = new PdfPTable(1);
                    lineaDivisoria.WidthPercentage = 100;
                    PdfPCell cellLine = new PdfPCell(new Phrase(" "));
                    cellLine.Border = PdfPCell.BOTTOM_BORDER;
                    cellLine.BorderWidthBottom = 1.5f;
                    cellLine.BorderColorBottom = new BaseColor(27, 38, 59);
                    cellLine.FixedHeight = 6f;
                    lineaDivisoria.AddCell(cellLine);

                    doc.Add(lineaDivisoria);
                    doc.Add(new Paragraph(" "));

                    // Metadatos, conteo de stock bajo y fecha de generación
                    string usuarioNombre = SesionActual.UsuarioLogueado != null ? $"{SesionActual.UsuarioLogueado.nombre} {SesionActual.UsuarioLogueado.apellido}" : "Sistema";
                    int totalStockBajo = listaProductos.Count(p => p.stock < p.stock_minimo);
                    Paragraph infoGen = new Paragraph($"Listado de Productos (Filtrado / General) — Alertas de Stock Bajo: {totalStockBajo} — Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} por {usuarioNombre}", fontSubTituloGen);
                    doc.Add(infoGen);
                    doc.Add(new Paragraph(" "));

                    // TABLA PRINCIPAL DE PRODUCTOS (12 Columnas)
                    PdfPTable tablaProductos = new PdfPTable(12);
                    tablaProductos.WidthPercentage = 100;
                    tablaProductos.SetWidths(new float[] { 7f, 11f, 14f, 8f, 7f, 7f, 11f, 10f, 9f, 8f, 8f, 10f });

                    // Cabeceras de la tabla
                    string[] cabeceras = { "Código", "Nombre", "Descripción", "Precio ($)", "Stock", "Stock Mín.", "Proveedor", "Categoría", "Marca", "F. Alta", "F. Modif.", "Estado" };
                    foreach (var cabecera in cabeceras)
                    {
                        PdfPCell celdaCabecera = new PdfPCell(new Phrase(cabecera, fontCabeceraTabla));
                        celdaCabecera.BackgroundColor = new BaseColor(41, 128, 185); // Azul institucional
                        celdaCabecera.HorizontalAlignment = Element.ALIGN_CENTER;
                        celdaCabecera.VerticalAlignment = Element.ALIGN_MIDDLE;
                        celdaCabecera.Padding = 4;
                        tablaProductos.AddCell(celdaCabecera);
                    }

                    // Rellenar filas con los datos de los productos
                    foreach (var prod in listaProductos)
                    {
                        bool esStockBajo = prod.stock < prod.stock_minimo;
                        BaseColor colorFondoStock = esStockBajo ? new BaseColor(255, 243, 205) : BaseColor.WHITE;

                        AgregarCeldaContenido(tablaProductos, prod.codigo, fontContenidoNegrita, Element.ALIGN_CENTER, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, prod.nombre, fontContenido, Element.ALIGN_LEFT, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, prod.descripcion, fontContenido, Element.ALIGN_LEFT, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, $"$ {prod.precio_venta:N2}", fontContenido, Element.ALIGN_RIGHT, BaseColor.WHITE);

                        // Celda de Stock con alerta si es menor al stock mínimo
                        AgregarCeldaContenido(tablaProductos, prod.stock.ToString(), esStockBajo ? fontAlertaStock : fontContenidoNegrita, Element.ALIGN_CENTER, colorFondoStock);

                        AgregarCeldaContenido(tablaProductos, prod.stock_minimo.ToString(), fontContenido, Element.ALIGN_CENTER, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, prod.NombreProveedor, fontContenido, Element.ALIGN_LEFT, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, prod.NombreCategoria, fontContenido, Element.ALIGN_CENTER, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, prod.NombreMarca, fontContenido, Element.ALIGN_CENTER, BaseColor.WHITE);

                        string fechaAltaStr = prod.fecha_alta != null && prod.fecha_alta != DateTime.MinValue ? Convert.ToDateTime(prod.fecha_alta).ToString("dd/MM/yyyy") : "-";
                        string fechaModifStr = prod.fecha_ultima_modificacion != null && prod.fecha_ultima_modificacion != DateTime.MinValue ? Convert.ToDateTime(prod.fecha_ultima_modificacion).ToString("dd/MM/yyyy") : "-";

                        AgregarCeldaContenido(tablaProductos, fechaAltaStr, fontContenido, Element.ALIGN_CENTER, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, fechaModifStr, fontContenido, Element.ALIGN_CENTER, BaseColor.WHITE);
                        AgregarCeldaContenido(tablaProductos, prod.EstadoTexto, fontContenido, Element.ALIGN_CENTER, BaseColor.WHITE);
                    }

                    doc.Add(tablaProductos);
                    doc.Close();

                    MessageBox.Show("Archivo PDF de productos exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método auxiliar privado para celdas con soporte de color de fondo personalizado
        private void AgregarCeldaContenido(PdfPTable tabla, string texto, iTextSharp.text.Font fuente, int alineacion, BaseColor colorFondo)
        {
            PdfPCell celda = new PdfPCell(new Phrase(texto ?? "", fuente));
            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            celda.HorizontalAlignment = alineacion;
            celda.BackgroundColor = colorFondo;
            celda.Padding = 3.5f;
            tabla.AddCell(celda);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            List<EProducto> listaProductos = dgvListaProductos.DataSource as List<EProducto>;

            if (listaProductos == null || listaProductos.Count == 0)
            {
                MessageBox.Show("No hay registros de productos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Configurar el diálogo para guardar el archivo Excel
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Reporte_Productos_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            savefile.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Configuración de licencia requerida por EPPlus 8+
                    ExcelPackage.License.SetNonCommercialOrganization("MUSNOC");

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet ws = package.Workbook.Worksheets.Add("Lista de Productos");
                        ws.View.ShowGridLines = true;

                        int filaActual = 1;

                        // CABECERA  (MUSNOC)
                        ws.Cells[filaActual, 1].Value = "MUSNOC";
                        ws.Cells[filaActual, 1].Style.Font.Size = 16;
                        ws.Cells[filaActual, 1].Style.Font.Bold = true;
                        ws.Cells[filaActual, 1].Style.Font.Color.SetColor(Color.FromArgb(27, 38, 59));
                        filaActual++;

                        ws.Cells[filaActual, 1].Value = "Dirección: Av. 3 Abril Corrientes - Corrientes - Argentina";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Color.SetColor(Color.Gray);
                        filaActual++;

                        ws.Cells[filaActual, 1].Value = "Tel: +54 9 379 634-7610";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Color.SetColor(Color.Gray);
                        filaActual++;

                        string usuarioNombre = SesionActual.UsuarioLogueado != null ? $"{SesionActual.UsuarioLogueado.nombre} {SesionActual.UsuarioLogueado.apellido}" : "Sistema";
                        int totalStockBajo = listaProductos.Count(p => p.stock < p.stock_minimo);
                        ws.Cells[filaActual, 1].Value = $"Listado de Productos (Filtrado / General) — Alertas de Stock Bajo: {totalStockBajo} — Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} por {usuarioNombre}";
                        ws.Cells[filaActual, 1].Style.Font.Size = 9;
                        ws.Cells[filaActual, 1].Style.Font.Italic = true;
                        filaActual += 2;

                        //  CABECERAS DE LA TABLA 
                        string[] cabeceras = { "Código", "Nombre", "Descripción", "Precio ($)", "Stock", "Stock Mín.", "Proveedor", "Categoría", "Marca", "F. Alta", "F. Modif.", "Estado" };
                        for (int i = 0; i < cabeceras.Length; i++)
                        {
                            var cell = ws.Cells[filaActual, i + 1];
                            cell.Value = cabeceras[i];
                            cell.Style.Font.Bold = true;
                            cell.Style.Font.Size = 10;
                            cell.Style.Font.Color.SetColor(Color.FromArgb(41, 128, 185)); // Azul institucional
                        }
                        filaActual++;

                        // RELLENAR DATOS DE PRODUCTOS
                        foreach (var prod in listaProductos)
                        {
                            ws.Cells[filaActual, 1].Value = prod.codigo;
                            ws.Cells[filaActual, 1].Style.Font.Bold = true;
                            ws.Cells[filaActual, 2].Value = prod.nombre;
                            ws.Cells[filaActual, 3].Value = prod.descripcion;

                            var celdaPrecio = ws.Cells[filaActual, 4];
                            celdaPrecio.Value = prod.precio_venta;
                            celdaPrecio.Style.Numberformat.Format = "$ #,##0.00";

                            // Alerta y resaltado de stock bajo
                            bool esStockBajo = prod.stock < prod.stock_minimo;
                            var celdaStock = ws.Cells[filaActual, 5];
                            celdaStock.Value = prod.stock;
                            celdaStock.Style.Font.Bold = true;

                            if (esStockBajo)
                            {
                                celdaStock.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                celdaStock.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 243, 205)); // Fondo amarillo claro
                                celdaStock.Style.Font.Color.SetColor(Color.FromArgb(180, 40, 40)); // Texto rojo oscuro
                            }

                            ws.Cells[filaActual, 6].Value = prod.stock_minimo;
                            ws.Cells[filaActual, 7].Value = prod.NombreProveedor;
                            ws.Cells[filaActual, 8].Value = prod.NombreCategoria;
                            ws.Cells[filaActual, 9].Value = prod.NombreMarca;

                            string fechaAltaStr = prod.fecha_alta != null && prod.fecha_alta != DateTime.MinValue ? Convert.ToDateTime(prod.fecha_alta).ToString("dd/MM/yyyy") : "-";
                            string fechaModifStr = prod.fecha_ultima_modificacion != null && prod.fecha_ultima_modificacion != DateTime.MinValue ? Convert.ToDateTime(prod.fecha_ultima_modificacion).ToString("dd/MM/yyyy") : "-";

                            ws.Cells[filaActual, 10].Value = fechaAltaStr;
                            ws.Cells[filaActual, 11].Value = fechaModifStr;
                            ws.Cells[filaActual, 12].Value = prod.EstadoTexto;

                            ws.Cells[filaActual, 1, filaActual, 12].Style.Font.Size = 9.5f;
                            filaActual++;
                        }

                        // Ajustar automáticamente el ancho de las celdas
                        ws.Cells[ws.Dimension.Address].AutoFitColumns();

                        // Guardar y exportar el archivo físico
                        File.WriteAllBytes(savefile.FileName, package.GetAsByteArray());
                    }

                    MessageBox.Show("Reporte de Excel de productos generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(savefile.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
 }
