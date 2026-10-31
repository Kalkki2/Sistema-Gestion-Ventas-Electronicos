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
    public partial class GestionProveedoresForm : Form
    {
        private CNProducto objCNProducto = new CNProducto();
        private CNProveedor objCNProveedor = new CNProveedor();
        private int idProveedorSeleccionado = 0;

        public GestionProveedoresForm()
        {
            InitializeComponent();
        }

        private void GestionProveedoresForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null)
            {
               lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
               lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre;
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

             CargarProveedores();
             CargarCmbEstado();
             CargarFiltros();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreComercial.Text) && string.IsNullOrWhiteSpace(txtRazonSocial.Text) && string.IsNullOrWhiteSpace(txtCuit.Text) &&
               string.IsNullOrWhiteSpace(txtTelefono.Text) && string.IsNullOrWhiteSpace(txtDireccion.Text) && string.IsNullOrWhiteSpace(txtCorreo.Text) && cmbEstado.SelectedIndex == -1)
            {
                // Si no hay nada escrito en los campos
                MessageBox.Show("No hay nada cargado para cancear/limpiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            // Valida que los TextBox no tengan errores activos del ErrorProvider o estén vacíos
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtDireccion)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtTelefono)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtCorreo)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtRazonSocial)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtCuit)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtNombreComercial)) ||
                string.IsNullOrWhiteSpace(txtNombreComercial.Text) ||
                string.IsNullOrWhiteSpace(txtRazonSocial.Text) ||
                string.IsNullOrWhiteSpace(txtCuit.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Hay campos con errores o vacíos. Corríjalos antes de agregar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpcionCombo estadoSeleccionado = (OpcionCombo)cmbEstado.SelectedItem;

            EProveedor oProveedor = new EProveedor()
            {
                proveedor_id = idProveedorSeleccionado,
                cuit = txtCuit.Text.Trim(),
                nombre_comercial = txtNombreComercial.Text.Trim(),
                razon_social = txtRazonSocial.Text.Trim(),
                email = txtCorreo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                direccion = txtDireccion.Text.Trim(),
                estado = Convert.ToInt32(estadoSeleccionado.Valor)
            };

            string mensaje = string.Empty;
            bool resultado = false;

            if (idProveedorSeleccionado == 0)
            {
                // REGISTRAR NUEVO
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea registrar este nuevo proveedor?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No) return;

                resultado = objCNProveedor.Registrar(oProveedor, out mensaje);
            }
            else
            {
                // ACTUALIZAR / EDITAR
                DialogResult respuesta = MessageBox.Show("¿Desea actualizar los datos de este proveedor?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No) return;

                resultado = objCNProveedor.EditarProveedor(oProveedor, out mensaje);
            }

            if (resultado)
            {
                MessageBox.Show(idProveedorSeleccionado == 0 ? "El proveedor se registró con éxito." : "El proveedor se actualizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProveedores();
            }
            else
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreComercial.Clear();
            txtRazonSocial.Clear();
            txtCuit.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            cmbEstado.SelectedIndex = 0;

            //  Reiniciar el ID seleccionado para que el sistema sepa que el próximo guardado será un NUEVO registro
            idProveedorSeleccionado = 0;

            // Restaurar el texto del botón si cambia al editar
            btnAgregarProveedor.Text = "Agregar Proveedor"; 

            txtNombreComercial.Focus();
        }

        private void txtNombreComercial_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNombreComercial.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtNombreComercial, "El nombre comercial solo debe contener letras.");
            }
            else if (txtNombreComercial.Text.Length < 3 || txtNombreComercial.Text.Length > 40)
            {
                errorProvider1.SetError(txtNombreComercial, "El nombre comercial  debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtNombreComercial, "");
            }
        }

        private void txtRazonSocial_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtRazonSocial.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$"))
            {
                errorProvider1.SetError(txtRazonSocial, "LA razon social solo debe contener letras.");
            }
            else if (txtRazonSocial.Text.Length < 3 || txtRazonSocial.Text.Length > 40)
            {
                errorProvider1.SetError(txtRazonSocial, "LA razon social  debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtRazonSocial, "");
            }
        }

        private void txtCuit_Validating(object sender, CancelEventArgs e)
        {
            string cuit = txtCuit.Text.Trim();

            if (!ulong.TryParse(cuit, out _))
            {
                errorProvider1.SetError(txtCuit, "El CUIT solo debe contener números.");
            }
            else if (cuit.Length != 11)
            {
                errorProvider1.SetError(txtCuit, "El CUIT debe tener exactamente 11 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtCuit, "");
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo electrónico válido (ej: usuario@dominio.com).");
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();

            if (!ulong.TryParse(telefono, out _))
            {
                errorProvider1.SetError(txtTelefono, "El TELEFONO solo debe contener números.");
            }
            else if (telefono.Length != 10)
            {
                errorProvider1.SetError(txtTelefono, "El TELEFONO debe tener exactamente 10 dígitos.");
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtDireccion.Text, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ0-9\\s]+$"))
            {
                errorProvider1.SetError(txtDireccion, "La dirección solo debe contener letras y números.");
            }
            else if (txtDireccion.Text.Length < 3 || txtDireccion.Text.Length > 40)
            {
                errorProvider1.SetError(txtDireccion, "La dirección debe tener entre 3 y 40 caracteres.");
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
        }
        

        private void CargarProveedores()
        {
            dgvListaProveedores.AutoGenerateColumns = false;

            //  Mapear las columnas con las propiedades de EProveedor
            dgvListaProveedores.Columns["colCuit"].DataPropertyName = "cuit";
            dgvListaProveedores.Columns["colNombreComercial"].DataPropertyName = "nombre_comercial";
            dgvListaProveedores.Columns["colRazonSocial"].DataPropertyName = "razon_social";
            dgvListaProveedores.Columns["colDireccion"].DataPropertyName = "direccion";
            dgvListaProveedores.Columns["colCorreo"].DataPropertyName = "email";
            dgvListaProveedores.Columns["colTelefono"].DataPropertyName = "telefono";
            dgvListaProveedores.Columns["colCategoria"].DataPropertyName = "CategoriasTexto";
            dgvListaProveedores.Columns["colEstado"].DataPropertyName = "EstadoTexto";
            dgvListaProveedores.Columns["colFechaAlta"].DataPropertyName = "fecha_alta";
            dgvListaProveedores.Columns["colFechaModificacion"].DataPropertyName = "fecha_ultima_modificacion";

            // Obtener la lista desde la Capa de Negocio
            var lista = objCNProveedor.Listar();

            // Asignar origen de datos y actualizar tarjeta de total
            dgvListaProveedores.DataSource = lista;
            lblCantTotalProveedores.Text = lista.Count.ToString(); // Ajusta el nombre del label si tu etiqueta de total se llama distinto
        }

        private void CargarCmbEstado()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });
            cmbEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0; // Por defecto Activo
        }

        private void CargarFiltros()
        {
            //Carga los comboBox de las estados
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = null });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 });
            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0;

            //Carga los comboBox de las Categorias
            var listaCat = objCNProducto.ListarCategorias();
            listaCat.Insert(0, new ECategoria { categoria_id = 0, nombre = "Todos" });
            cmbFiltroCategoria.DataSource = listaCat;
            cmbFiltroCategoria.DisplayMember = "nombre";
            cmbFiltroCategoria.ValueMember = "categoria_id";
            cmbFiltroCategoria.SelectedIndex = 0;
        }

        private void dgvListaProveedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvListaProveedores.NewRowIndex) return;

            string colName = dgvListaProveedores.Columns[e.ColumnIndex].Name;

            if (colName == "colEditar")
            {
                e.Value = Properties.Resources.icono_editar;
            }

            if (colName == "colEliminar")
            {
                var proveedorRow = dgvListaProveedores.Rows[e.RowIndex].DataBoundItem as EProveedor;
                if (proveedorRow != null)
                {
                    if (proveedorRow.estado == 1)
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

        private void dgvListaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvListaProveedores.Columns[e.ColumnIndex].Name;

            if (colName == "colEditar")
            {
                var proveedor = dgvListaProveedores.Rows[e.RowIndex].DataBoundItem as EProveedor;
                if (proveedor != null)
                {
                    idProveedorSeleccionado = proveedor.proveedor_id;

                    txtNombreComercial.Text = proveedor.nombre_comercial;
                    txtRazonSocial.Text = proveedor.razon_social;
                    txtCuit.Text = proveedor.cuit;
                    txtCorreo.Text = proveedor.email;
                    txtTelefono.Text = proveedor.telefono;
                    txtDireccion.Text = proveedor.direccion;

                    foreach (OpcionCombo item in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(item.Valor) == proveedor.estado)
                        {
                            cmbEstado.SelectedItem = item;
                            break;
                        }
                    }

                    btnAgregarProveedor.Text = "Actualizar";
                }
            }

            if (colName == "colEliminar")
            {
                var proveedorRow = dgvListaProveedores.Rows[e.RowIndex].DataBoundItem as EProveedor;
                if (proveedorRow != null)
                {
                    int estadoActual = proveedorRow.estado;
                    int nuevoEstado = (estadoActual == 1) ? 0 : 1;
                    string accion = (estadoActual == 1) ? "desactivar" : "reactivar";

                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} al proveedor {proveedorRow.nombre_comercial}?",
                        $"Confirmar {accion}",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        string mensajeError = string.Empty;
                        bool respuesta = objCNProveedor.CambiarEstado(proveedorRow.proveedor_id, nuevoEstado, out mensajeError);

                        if (respuesta)
                        {
                            MessageBox.Show($"Proveedor {accion}do con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarProveedores();
                        }
                        else
                        {
                            // Mostramos el mensaje detallado que vino desde la base de datos o negocio
                            MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            // Obtenemos lo que el usuario va escribiendo
            string busqueda = txtBuscarProveedor.Text.Trim();

            // Si el cuadro de texto está vacío, cargamos todos los proveedores normales
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                CargarProveedores();
                return;
            }

            // Llamamos directamente a tu método de la capa de negocio que ya tienes creado
            var resultados = objCNProveedor.Buscar(busqueda);

            // Actualizamos el DataGridView y el contador
            dgvListaProveedores.DataSource = resultados;
            lblCantTotalProveedores.Text = resultados.Count.ToString();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroEstado.SelectedItem == null) return;

            int? estadoSeleccionado = null;
            OpcionCombo opcion = (OpcionCombo)cmbFiltroEstado.SelectedItem;

            if (opcion.Valor != null)
            {
                estadoSeleccionado = Convert.ToInt32(opcion.Valor);
            }

            var listaFiltrada = objCNProveedor.FiltrarPorEstado(estadoSeleccionado);
            dgvListaProveedores.DataSource = listaFiltrada;
            lblCantTotalProveedores.Text = listaFiltrada.Count.ToString();
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroCategoria.SelectedIndex == -1) return;

            int categoriaId = 0;
            if (cmbFiltroCategoria.SelectedValue != null)
            {
                int.TryParse(cmbFiltroCategoria.SelectedValue.ToString(), out categoriaId);
            }

            // Llamas a un método de tu capa de negocio específico para categoría
            var listaFiltrada = objCNProveedor.ListarProveedorPorCategoria(categoriaId);

            dgvListaProveedores.DataSource = listaFiltrada;
            lblCantTotalProveedores.Text = listaFiltrada.Count.ToString();
        }
    }
}
