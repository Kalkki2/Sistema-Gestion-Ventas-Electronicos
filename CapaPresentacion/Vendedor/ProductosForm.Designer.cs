namespace CapaPresentacion.Vendedor
{
    partial class ProductosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFiltroMarca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbFiltroCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarPorCodONombre = new System.Windows.Forms.Label();
            this.lblFiltraMarca = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltraCategoria = new System.Windows.Forms.Label();
            this.pnlContenedorCatalogo = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvListaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloCatlogoProductos = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros.SuspendLayout();
            this.pnlContenedorCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrar);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarProducto);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroMarca);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroCategoria);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarProducto);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorCodONombre);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltraMarca);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltraCategoria);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(5, 67);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.Radius = 5;
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowDepth = 25;
            this.pnlContenedorFiltros.ShadowShift = 3;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(439, 183);
            this.pnlContenedorFiltros.TabIndex = 43;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.BorderRadius = 5;
            this.btnFiltrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltrar.FillColor = System.Drawing.Color.Silver;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Image = global::CapaPresentacion.Properties.Resources.icono_filtro;
            this.btnFiltrar.Location = new System.Drawing.Point(332, 134);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(89, 27);
            this.btnFiltrar.TabIndex = 45;
            this.btnFiltrar.Text = "Filtrar";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.BorderRadius = 5;
            this.btnBuscarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarProducto.FillColor = System.Drawing.Color.Silver;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Image = global::CapaPresentacion.Properties.Resources.icono_lupa;
            this.btnBuscarProducto.Location = new System.Drawing.Point(257, 42);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(89, 27);
            this.btnBuscarProducto.TabIndex = 44;
            this.btnBuscarProducto.Text = "Buscar";
            // 
            // cmbFiltroMarca
            // 
            this.cmbFiltroMarca.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroMarca.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbFiltroMarca.BorderRadius = 5;
            this.cmbFiltroMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroMarca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFiltroMarca.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroMarca.ItemHeight = 21;
            this.cmbFiltroMarca.Items.AddRange(new object[] {
            "categoria 1",
            "categoria 2"});
            this.cmbFiltroMarca.Location = new System.Drawing.Point(164, 134);
            this.cmbFiltroMarca.Name = "cmbFiltroMarca";
            this.cmbFiltroMarca.Size = new System.Drawing.Size(150, 27);
            this.cmbFiltroMarca.TabIndex = 24;
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroCategoria.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbFiltroCategoria.BorderRadius = 5;
            this.cmbFiltroCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFiltroCategoria.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroCategoria.ItemHeight = 21;
            this.cmbFiltroCategoria.Items.AddRange(new object[] {
            "categoria 1",
            "categoria 2"});
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(8, 134);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(150, 27);
            this.cmbFiltroCategoria.TabIndex = 22;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProducto.BorderRadius = 5;
            this.txtBuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProducto.DefaultText = "";
            this.txtBuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProducto.Location = new System.Drawing.Point(9, 42);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PlaceholderText = "";
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.Size = new System.Drawing.Size(242, 27);
            this.txtBuscarProducto.TabIndex = 0;
            // 
            // lblBuscarPorCodONombre
            // 
            this.lblBuscarPorCodONombre.AutoSize = true;
            this.lblBuscarPorCodONombre.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorCodONombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCodONombre.Location = new System.Drawing.Point(11, 22);
            this.lblBuscarPorCodONombre.Name = "lblBuscarPorCodONombre";
            this.lblBuscarPorCodONombre.Size = new System.Drawing.Size(195, 17);
            this.lblBuscarPorCodONombre.TabIndex = 21;
            this.lblBuscarPorCodONombre.Text = "Buscar por Codigo o Nombre:";
            // 
            // lblFiltraMarca
            // 
            this.lblFiltraMarca.AutoSize = true;
            this.lblFiltraMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltraMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraMarca.Location = new System.Drawing.Point(161, 114);
            this.lblFiltraMarca.Name = "lblFiltraMarca";
            this.lblFiltraMarca.Size = new System.Drawing.Size(47, 17);
            this.lblFiltraMarca.TabIndex = 12;
            this.lblFiltraMarca.Text = "Marca";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(13, 91);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(73, 17);
            this.lblFiltrarPor.TabIndex = 16;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // lblFiltraCategoria
            // 
            this.lblFiltraCategoria.AutoSize = true;
            this.lblFiltraCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltraCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraCategoria.Location = new System.Drawing.Point(10, 114);
            this.lblFiltraCategoria.Name = "lblFiltraCategoria";
            this.lblFiltraCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblFiltraCategoria.TabIndex = 11;
            this.lblFiltraCategoria.Text = "Categoria ";
            // 
            // pnlContenedorCatalogo
            // 
            this.pnlContenedorCatalogo.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorCatalogo.BorderRadius = 8;
            this.pnlContenedorCatalogo.BorderThickness = 1;
            this.pnlContenedorCatalogo.Controls.Add(this.dgvListaProductos);
            this.pnlContenedorCatalogo.Controls.Add(this.lblTituloCatlogoProductos);
            this.pnlContenedorCatalogo.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCatalogo.Location = new System.Drawing.Point(7, 265);
            this.pnlContenedorCatalogo.Name = "pnlContenedorCatalogo";
            this.pnlContenedorCatalogo.Size = new System.Drawing.Size(1149, 275);
            this.pnlContenedorCatalogo.TabIndex = 47;
            // 
            // dgvListaProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colPrecio,
            this.colStock,
            this.colCategoria,
            this.colMarca});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaProductos.Location = new System.Drawing.Point(2, 41);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersVisible = false;
            this.dgvListaProductos.RowTemplate.Height = 23;
            this.dgvListaProductos.Size = new System.Drawing.Size(1143, 231);
            this.dgvListaProductos.TabIndex = 7;
            this.dgvListaProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvListaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaProductos.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvListaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProductos.ThemeStyle.RowsStyle.Height = 23;
            this.dgvListaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            // 
            // lblTituloCatlogoProductos
            // 
            this.lblTituloCatlogoProductos.AutoSize = true;
            this.lblTituloCatlogoProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCatlogoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCatlogoProductos.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCatlogoProductos.Location = new System.Drawing.Point(5, 15);
            this.lblTituloCatlogoProductos.Name = "lblTituloCatlogoProductos";
            this.lblTituloCatlogoProductos.Size = new System.Drawing.Size(170, 16);
            this.lblTituloCatlogoProductos.TabIndex = 6;
            this.lblTituloCatlogoProductos.Text = "Catalogo de Productos:";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-3, -2);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1179, 64);
            this.pnlEncabezado.TabIndex = 59;
            // 
            // pnlnfoUsuario
            // 
            this.pnlnfoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnfoUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlnfoUsuario.Controls.Add(this.picUsuario);
            this.pnlnfoUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlnfoUsuario.Location = new System.Drawing.Point(965, 5);
            this.pnlnfoUsuario.Name = "pnlnfoUsuario";
            this.pnlnfoUsuario.Size = new System.Drawing.Size(187, 55);
            this.pnlnfoUsuario.TabIndex = 3;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(52, 11);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(128, 17);
            this.lblNombreUsuario.TabIndex = 11;
            this.lblNombreUsuario.Text = "Pereira, Luciana";
            // 
            // picUsuario
            // 
            this.picUsuario.Location = new System.Drawing.Point(3, 5);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(43, 42);
            this.picUsuario.TabIndex = 3;
            this.picUsuario.TabStop = false;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuario.Location = new System.Drawing.Point(76, 30);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(60, 15);
            this.lblRolUsuario.TabIndex = 11;
            this.lblRolUsuario.Text = "Vendedor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(14, 7);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Productos";
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 561);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlContenedorCatalogo);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.pnlContenedorCatalogo.ResumeLayout(false);
            this.pnlContenedorCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarProducto;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroMarca;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscarPorCodONombre;
        private System.Windows.Forms.Label lblFiltraMarca;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltraCategoria;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorCatalogo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaProductos;
        private System.Windows.Forms.Label lblTituloCatlogoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
    }
}