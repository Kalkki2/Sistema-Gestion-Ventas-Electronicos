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

namespace CapaPresentacion.Vendedor
{
    public partial class ProductosForm : Form
    {
        

        // Todos los productos traídos de la base; los filtros trabajan sobre esta lista
        private List<EProducto> todosLosProductos = new List<EProducto>();

        // Evita que los combos disparen filtros mientras se están cargando
        private bool cargando = false;

        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
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

            cargando = true; 

            LimpiarDetalle();
            CargarCombosCategoriaYMarcas();
            CargarProductos();

            cargando = false; 
            AplicarFiltros();
        }


        private void CargarProductos()
        {
            dgvListaProductos.AutoGenerateColumns = false;

            dgvListaProductos.Columns["colCodigo"].DataPropertyName = "codigo";
            dgvListaProductos.Columns["colNombre"].DataPropertyName = "nombre";
            dgvListaProductos.Columns["colPrecio"].DataPropertyName = "precio_venta";
            dgvListaProductos.Columns["colStock"].DataPropertyName = "stock";
            dgvListaProductos.Columns["colCategoria"].DataPropertyName = "NombreCategoria";
            dgvListaProductos.Columns["colMarca"].DataPropertyName = "NombreMarca";

            CNProducto objCNProducto = new CNProducto();

            var listaPoductosActivos = objCNProducto.ListarProductosActivos();
            dgvListaProductos.DataSource = listaPoductosActivos;
        }

        // Llena los combos con las categorías y marcas que tienen los productos cargados
        private void CargarCombosCategoriaYMarcas()
        {
            CNProducto objCNProducto = new CNProducto();

            List<ECategoria> listaCategoria = objCNProducto.ListarCategorias();
            listaCategoria.Insert(0, new ECategoria { categoria_id = 0, nombre = "Todos" });
            cmbFiltroCategoria.DataSource = listaCategoria;
            cmbFiltroCategoria.DisplayMember = "nombre";
            cmbFiltroCategoria.ValueMember = "categoria_id";
            cmbFiltroCategoria.SelectedIndex = 0;

            List<EMarca> listaMarca = objCNProducto.ListarMarcas();
            listaMarca.Insert(0, new EMarca { marca_id = 0, nombre = "Todos" });
            cmbFiltroMarca.DataSource = listaMarca;
            cmbFiltroMarca.DisplayMember = "nombre";
            cmbFiltroMarca.ValueMember = "marca_id";
            cmbFiltroMarca.SelectedIndex = 0;
        
        }

        // Deja vacío el panel de detalles (el diseño trae un producto de ejemplo escrito a mano)
        private void LimpiarDetalle()
        {
            guna2TextBox2.Text = string.Empty;
            guna2TextBox3.Text = string.Empty;
            guna2TextBox4.Text = string.Empty;
            guna2TextBox5.Text = string.Empty;
            guna2TextBox6.Text = string.Empty;
            guna2TextBox7.Text = string.Empty;
            guna2TextBox8.Text = string.Empty;
        }



        private void AplicarFiltros()
        {
            if (cargando) return; // Evita disparos mientras inicializan los combos

            int idCategoria = 0;
            if (cmbFiltroCategoria.SelectedValue != null)
            {
                int.TryParse(cmbFiltroCategoria.SelectedValue.ToString(), out idCategoria);
            }

            int idMarca = 0;
            if (cmbFiltroMarca.SelectedValue != null)
            {
                int.TryParse(cmbFiltroMarca.SelectedValue.ToString(), out idMarca);
            }

            string textoBusqueda = txtBuscarProducto.Text.Trim();

            CNProducto objCNProducto = new CNProducto();
            var listaFiltrada = objCNProducto.BuscarProductosActivosPorFiltro(idCategoria, idMarca, textoBusqueda);

            // Actualizamos la grilla
            dgvListaProductos.DataSource = listaFiltrada;
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

        private void dgvListaProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvListaProductos.Columns[e.ColumnIndex].Name != "colVerDetalle") return;

            EProducto p = dgvListaProductos.Rows[e.RowIndex].DataBoundItem as EProducto;
            if (p == null) return;

            guna2TextBox2.Text = p.codigo;                       // Código
            guna2TextBox3.Text = p.nombre;                       // Nombre
            guna2TextBox4.Text = p.precio_venta.ToString("N2");  // Precio actual
            guna2TextBox5.Text = p.stock + " Unidades";          // Stock disponible
            guna2TextBox6.Text = p.NombreMarca;                  // Marca
            guna2TextBox7.Text = p.NombreCategoria;              // Categoría
            guna2TextBox8.Text = p.descripcion;                  // Descripción
        }
    }
}