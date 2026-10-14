using CapaEntidad;
using CapaNegocio;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace CapaPresentacion.Administrador
{
    public partial class GestionUsuariosForm : Form
    {
        private CNUsuario objCNUsuario = new CNUsuario();
        private CNPerfil objCNPerfil = new CNPerfil();
        private int idUsuarioSeleccionado = 0;
        public GestionUsuariosForm()
        {
            InitializeComponent();
        }


        private void GestionUsuariosForm_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioLogueado != null){
                lblNombreUsuario.Text = $"{SesionActual.UsuarioLogueado.apellido}, {SesionActual.UsuarioLogueado.nombre}";
                lblRolUsuario.Text = SesionActual.UsuarioLogueado.oPerfil.nombre; 
            }
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", cultura);

            CargarUsuarios();
            CargarFiltros();
        }
        private void CargarUsuarios()
        {
            // 1. Desactivar la generación automática de columnas
            dgvListaUsuarios.AutoGenerateColumns = false;

            // 2. Mapear las columnas creadas en el Diseñador con las propiedades de EUsuario
            dgvListaUsuarios.Columns["colDNI"].DataPropertyName = "dni";
            dgvListaUsuarios.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaUsuarios.Columns["colApellido"].DataPropertyName = "apellido";
            dgvListaUsuarios.Columns["colCorreo"].DataPropertyName = "email"; // Actualizado a email
            dgvListaUsuarios.Columns["colTelefono"].DataPropertyName = "telefono";
            dgvListaUsuarios.Columns["colDireccion"].DataPropertyName = "direccion";
            dgvListaUsuarios.Columns["colPerfil"].DataPropertyName = "NombrePerfil";
            dgvListaUsuarios.Columns["colEstado"].DataPropertyName = "EstadoTexto";
            dgvListaUsuarios.Columns["colFechaAlta"].DataPropertyName = "fecha_alta"; // Actualizado a fecha_alta

            // 3. Obtener la lista mapeada desde la Capa de Negocio
            var lista = objCNUsuario.Listar();

            // 4. Llenar el DataGridView y actualizar la tarjeta de total
            dgvListaUsuarios.DataSource = lista;
            lblCantTotalUsuarios.Text = lista.Count.ToString();
        }

        private void dgvListaUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvListaUsuarios.NewRowIndex) return;

            string colName = dgvListaUsuarios.Columns[e.ColumnIndex].Name;

            if (colName == "colEditar")
            {
                e.Value = Properties.Resources.icono_editar;
            }

            if (colName == "colEliminar")
            {
                var usuarioRow = dgvListaUsuarios.Rows[e.RowIndex].DataBoundItem as EUsuario;

                if (usuarioRow != null)
                {
                    // Evaluamos si estado == 1 (Activo)
                    if (usuarioRow.estado == 1)
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

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreColumna = dgvListaUsuarios.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "colEditar")
            {
                var usuarioSeleccionado = dgvListaUsuarios.Rows[e.RowIndex].DataBoundItem as EUsuario;

                if (usuarioSeleccionado != null)
                {
                    // Abrimos el modal pasándole el usuario seleccionado
                    using (RegistrarEditarUsuarioForm frmModal = new RegistrarEditarUsuarioForm(usuarioSeleccionado))
                    {
                        DialogResult resultado = frmModal.ShowDialog(this);
                        if (resultado == DialogResult.OK)
                        {
                            CargarUsuarios(); // Recarga la grilla con los cambios actualizados
                        }
                    }
                }
            }

            if (nombreColumna == "colEliminar")
            {
                var usuarioSeleccionado = dgvListaUsuarios.Rows[e.RowIndex].DataBoundItem as EUsuario;

                if (usuarioSeleccionado != null)
                {
                    int estadoActual = usuarioSeleccionado.estado; // 1 o 0
                    int nuevoEstado = (estadoActual == 1) ? 0 : 1;   // Invierte el estado

                    string accion = (estadoActual == 1) ? "desactivar" : "reactivar";
                    string titulo = (estadoActual == 1) ? "Desactivar Usuario" : "Reactivar Usuario";

                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de que desea {accion} al usuario {usuarioSeleccionado.nombre} {usuarioSeleccionado.apellido}?",
                        titulo,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        bool respuesta = objCNUsuario.CambiarEstado(usuarioSeleccionado.usuario_id, nuevoEstado);

                        if (respuesta)
                        {
                            MessageBox.Show($"Usuario {accion}do con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cambiar el estado del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

       

       

        public class OpcionCombo
        {
            public string Texto { get; set; }
            public object Valor { get; set; }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
            {
                MessageBox.Show("Debe completar el campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string busqueda = txtBuscarUsuario.Text.Trim();
            var resultados = objCNUsuario.Buscar(busqueda);

            dgvListaUsuarios.DataSource = resultados;
            lblCantTotalUsuarios.Text = resultados.Count.ToString();

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
        }

        private void btnFiltrarUsuario_Click(object sender, EventArgs e)
        {
            if (cmbFiltroEstado.SelectedIndex == -1 || cmbFiltroPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar Estado o Perfil para filtrar", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idPerfilSeleccionado = null;
            int? estadoSeleccionado = null; // Cambiado a int?

            if (cmbFiltroPerfil.SelectedValue != null)
            {
                int idPerfil = Convert.ToInt32(cmbFiltroPerfil.SelectedValue);
                if (idPerfil > 0)
                {
                    idPerfilSeleccionado = idPerfil;
                }
            }

            if (cmbFiltroEstado.SelectedItem != null)
            {
                OpcionCombo opcionEstado = (OpcionCombo)cmbFiltroEstado.SelectedItem;
                if (opcionEstado.Valor != null)
                {
                    estadoSeleccionado = Convert.ToInt32(opcionEstado.Valor);
                }
            }

            var usuariosFiltrados = objCNUsuario.Filtrar(idPerfilSeleccionado, estadoSeleccionado);

            dgvListaUsuarios.DataSource = usuariosFiltrados;
            lblCantTotalUsuarios.Text = usuariosFiltrados.Count.ToString();

            if (usuariosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron usuarios con los criterios de búsqueda seleccionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CargarFiltros()
        {
            List<EPerfil> listaPerfiles = objCNPerfil.Listar();
            listaPerfiles.Insert(0, new EPerfil { perfil_id = 0, nombre = "Todos" });

            cmbFiltroPerfil.DataSource = listaPerfiles;
            cmbFiltroPerfil.DisplayMember = "nombre";
            cmbFiltroPerfil.ValueMember = "perfil_id";
            cmbFiltroPerfil.SelectedIndex = 0;

            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Todos", Valor = null });
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Activo", Valor = 1 });   // int 1
            cmbFiltroEstado.Items.Add(new OpcionCombo { Texto = "Inactivo", Valor = 0 }); // int 0

            cmbFiltroEstado.DisplayMember = "Texto";
            cmbFiltroEstado.ValueMember = "Valor";
            cmbFiltroEstado.SelectedIndex = 0;
        }

        

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (dgvListaUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
                sfd.FileName = "Reporte_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Crear documento PDF (en formato Horizontal o Vertical, aquí usaremos PageSize.A4 en orientación horizontal para que quepan más columnas)
                        Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 20f);
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        // Título del reporte
                        Paragraph titulo = new Paragraph("Lista de usuarios", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);
                        doc.Add(new Paragraph(" ")); // Espacio en blanco

                        // Contar cuántas columnas de texto/datos hay (excluyendo imágenes)
                        int totalColumnasValidas = 0;
                        foreach (DataGridViewColumn col in dgvListaUsuarios.Columns)
                        {
                            if (!(col is DataGridViewImageColumn)) totalColumnasValidas++;
                        }

                        // Crear tabla PDF
                        PdfPTable pdfTable = new PdfPTable(totalColumnasValidas);
                        pdfTable.WidthPercentage = 100;

                        // Agregar Encabezados
                        foreach (DataGridViewColumn col in dgvListaUsuarios.Columns)
                        {
                            if (col is DataGridViewImageColumn) continue;

                            PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 230);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdfTable.AddCell(cell);
                        }

                        // Agregar Filas de Datos
                        foreach (DataGridViewRow row in dgvListaUsuarios.Rows)
                        {
                            if (row.IsNewRow) continue;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.OwningColumn is DataGridViewImageColumn) continue;

                                string valor = cell.Value != null ? cell.Value.ToString() : "";
                                PdfPCell pdfCell = new PdfPCell(new Phrase(valor, FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                                pdfTable.AddCell(pdfCell);
                            }
                        }

                        // Agregar la tabla al documento y cerrar
                        doc.Add(pdfTable);
                        doc.Close();

                        MessageBox.Show("Archivo PDF exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            using (RegistrarEditarUsuarioForm frmModal = new RegistrarEditarUsuarioForm())
            {
                DialogResult resultado = frmModal.ShowDialog(this);
                if (resultado == DialogResult.OK)
                {
                    CargarUsuarios(); // Recarga la grilla y el contador
                }
            }
        }
    }
    }

