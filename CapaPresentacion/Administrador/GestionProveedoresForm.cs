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

        private void CargarProveedores()
        {
            dgvListaProveedores.AutoGenerateColumns = false;

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

            var listaProveedores = objCNProveedor.ListarProveedores();

            dgvListaProveedores.DataSource = listaProveedores;
            lblCantTotalProveedores.Text = listaProveedores.Count.ToString(); // Ajusta el nombre del label si tu etiqueta de total se llama distinto
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
            if (!ValidarCamposProveedor())
            {
                MessageBox.Show("Existen campos vacíos o con datos incorrectos. Por favor, revíselos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                resultado = objCNProveedor.RegistrarProveedor(oProveedor, out mensaje);
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
                        bool respuesta = objCNProveedor.CambiarEstadoProveedor(proveedorRow.proveedor_id, nuevoEstado, out mensajeError);

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


        private bool ValidarCajaTexto(Control txt, string mensajeError, int min, int max, bool soloLetras)
        {
            string texto = txt.Text.Trim();

            if (string.IsNullOrEmpty(texto) || texto.Length < min || texto.Length > max || (soloLetras && !Regex.IsMatch(texto, "^[a-zA-ZáéíóúÁÉÍÓÚñÑ\\s]+$")))
            {
                errorProvider1.SetError(txt, mensajeError);
                txt.Focus();
                return false; // Falló la validación
            }

            errorProvider1.SetError(txt, ""); // Limpia el error si está bien
            return true; // Pasó
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

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarProveedor.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                CargarProveedores();
                return;
            }

            var resultados = objCNProveedor.BuscarProveedorPorCuitOCorreo(busqueda);

            dgvListaProveedores.DataSource = resultados;
            lblCantTotalProveedores.Text = resultados.Count.ToString();
        }

        private bool ValidarCamposProveedor()
        {
            bool esValido = true;
            errorProvider1.Clear(); // Limpia errores anteriores

            // Validar Nombre Comercial (Obligatorio, solo letras, entre 3 y 40 caracteres)
            string nombreComercial = txtNombreComercial.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreComercial))
            {
                errorProvider1.SetError(txtNombreComercial, "El nombre comercial es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(nombreComercial, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtNombreComercial, "El nombre comercial solo debe contener letras.");
                esValido = false;
            }
            else if (nombreComercial.Length < 3 || nombreComercial.Length > 40)
            {
                errorProvider1.SetError(txtNombreComercial, "Debe tener entre 3 y 40 caracteres.");
                esValido = false;
            }

            // Validar Razón Social (Obligatorio, solo letras, entre 3 y 40 caracteres)
            string razonSocial = txtRazonSocial.Text.Trim();
            if (string.IsNullOrWhiteSpace(razonSocial))
            {
                errorProvider1.SetError(txtRazonSocial, "La razón social es obligatoria.");
                esValido = false;
            }
            else if (!Regex.IsMatch(razonSocial, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                errorProvider1.SetError(txtRazonSocial, "La razón social solo debe contener letras.");
                esValido = false;
            }
            else if (razonSocial.Length < 3 || razonSocial.Length > 40)
            {
                errorProvider1.SetError(txtRazonSocial, "Debe tener entre 3 y 40 caracteres.");
                esValido = false;
            }

            // 3. Validar CUIT (Obligatorio, estrictamente numérico y exactamente 11 caracteres)
            string cuit = txtCuit.Text.Trim();
            if (string.IsNullOrWhiteSpace(cuit))
            {
                errorProvider1.SetError(txtCuit, "El CUIT es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(cuit, @"^\d{11}$"))
            {
                errorProvider1.SetError(txtCuit, "El CUIT debe ser numérico y tener exactamente 11 caracteres.");
                esValido = false;
            }

            // 4. Validar Correo (Obligatorio, más de 10 caracteres y formato válido)
            string correo = txtCorreo.Text.Trim();
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(correo))
            {
                errorProvider1.SetError(txtCorreo, "El correo electrónico es obligatorio.");
                esValido = false;
            }
            else if (correo.Length <= 10)
            {
                errorProvider1.SetError(txtCorreo, "El correo debe tener más de 10 caracteres.");
                esValido = false;
            }
            else if (!Regex.IsMatch(correo, patronCorreo))
            {
                errorProvider1.SetError(txtCorreo, "Correo inválido. Ejemplo: proveedor@dominio.com");
                esValido = false;
            }

            // Validar Teléfono (Obligatorio, numérico, exactamente 10 dígitos)
            string telefono = txtTelefono.Text.Trim();
            if (string.IsNullOrWhiteSpace(telefono))
            {
                errorProvider1.SetError(txtTelefono, "El teléfono es obligatorio.");
                esValido = false;
            }
            else if (!Regex.IsMatch(telefono, @"^\d{10}$"))
            {
                errorProvider1.SetError(txtTelefono, "El teléfono debe ser numérico y tener exactamente 10 dígitos.");
                esValido = false;
            }

            // Validar Dirección (Obligatorio, más de 10 caracteres)
            string direccion = txtDireccion.Text.Trim();
            if (string.IsNullOrWhiteSpace(direccion))
            {
                errorProvider1.SetError(txtDireccion, "La dirección es obligatoria.");
                esValido = false;
            }
            else if (direccion.Length <= 10)
            {
                errorProvider1.SetError(txtDireccion, "La dirección debe tener más de 10 caracteres.");
                esValido = false;
            }

            // Validar ComboBox de Estado (Obligatorio)
            if (cmbEstado.SelectedIndex == -1 || cmbEstado.SelectedItem == null)
            {
                errorProvider1.SetError(cmbEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;
        }
    }
}
