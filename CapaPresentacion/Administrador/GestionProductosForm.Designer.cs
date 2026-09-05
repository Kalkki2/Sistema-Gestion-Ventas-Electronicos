namespace CapaPresentacion.Administrador
{
    partial class GestionProductosForm
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
            this.pnlCardTotalProductos = new System.Windows.Forms.Panel();
            this.lblCantTotalProductos = new System.Windows.Forms.Label();
            this.lblTituloTotalProductos = new System.Windows.Forms.Label();
            this.pnlContenedorCatalogo = new System.Windows.Forms.Panel();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloCatalogoProductos = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltraMarca = new System.Windows.Forms.Label();
            this.cmbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblFiltraCategoria = new System.Windows.Forms.Label();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFormularioProducto = new System.Windows.Forms.Panel();
            this.lblTituloInformacionProducto = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblBuscarPorCodONombre = new System.Windows.Forms.Label();
            this.lblFiltraEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblFiltraProveedor = new System.Windows.Forms.Label();
            this.cmbFiltroProveedor = new System.Windows.Forms.ComboBox();
            this.pnlCardStockBajo = new System.Windows.Forms.Panel();
            this.picIconoAlerta = new System.Windows.Forms.PictureBox();
            this.lblCantProductosStockBajo = new System.Windows.Forms.Label();
            this.lblTituloStockBajo = new System.Windows.Forms.Label();
            this.pnlCardTotalProductos.SuspendLayout();
            this.pnlContenedorCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlFormularioProducto.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlCardStockBajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCardTotalProductos
            // 
            this.pnlCardTotalProductos.BackColor = System.Drawing.Color.White;
            this.pnlCardTotalProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalProductos.Controls.Add(this.lblCantTotalProductos);
            this.pnlCardTotalProductos.Controls.Add(this.lblTituloTotalProductos);
            this.pnlCardTotalProductos.Location = new System.Drawing.Point(601, 82);
            this.pnlCardTotalProductos.Name = "pnlCardTotalProductos";
            this.pnlCardTotalProductos.Size = new System.Drawing.Size(187, 75);
            this.pnlCardTotalProductos.TabIndex = 15;
            // 
            // lblCantTotalProductos
            // 
            this.lblCantTotalProductos.AutoSize = true;
            this.lblCantTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalProductos.Location = new System.Drawing.Point(9, 27);
            this.lblCantTotalProductos.Name = "lblCantTotalProductos";
            this.lblCantTotalProductos.Size = new System.Drawing.Size(69, 29);
            this.lblCantTotalProductos.TabIndex = 17;
            this.lblCantTotalProductos.Text = "7053";
            // 
            // lblTituloTotalProductos
            // 
            this.lblTituloTotalProductos.AutoSize = true;
            this.lblTituloTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalProductos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloTotalProductos.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTotalProductos.Name = "lblTituloTotalProductos";
            this.lblTituloTotalProductos.Size = new System.Drawing.Size(111, 15);
            this.lblTituloTotalProductos.TabIndex = 17;
            this.lblTituloTotalProductos.Text = "Total Productos:";
            // 
            // pnlContenedorCatalogo
            // 
            this.pnlContenedorCatalogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedorCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorCatalogo.Controls.Add(this.dgvListaProductos);
            this.pnlContenedorCatalogo.Controls.Add(this.lblTituloCatalogoProductos);
            this.pnlContenedorCatalogo.Location = new System.Drawing.Point(5, 372);
            this.pnlContenedorCatalogo.Name = "pnlContenedorCatalogo";
            this.pnlContenedorCatalogo.Size = new System.Drawing.Size(1151, 177);
            this.pnlContenedorCatalogo.TabIndex = 14;
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colPrecio,
            this.colStock,
            this.colProveedor,
            this.colCategoria,
            this.colMarca,
            this.colFechaAlta,
            this.colEstado,
            this.colEditar,
            this.colEliminar});
            this.dgvListaProductos.Location = new System.Drawing.Point(6, 64);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersVisible = false;
            this.dgvListaProductos.Size = new System.Drawing.Size(1141, 63);
            this.dgvListaProductos.TabIndex = 17;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 80;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 130;
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
            this.colStock.Width = 70;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Width = 130;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Width = 125;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Width = 125;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Name = "colEditar";
            this.colEditar.Width = 65;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Width = 65;
            // 
            // lblTituloCatalogoProductos
            // 
            this.lblTituloCatalogoProductos.AutoSize = true;
            this.lblTituloCatalogoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCatalogoProductos.Location = new System.Drawing.Point(-4, 29);
            this.lblTituloCatalogoProductos.Name = "lblTituloCatalogoProductos";
            this.lblTituloCatalogoProductos.Size = new System.Drawing.Size(172, 17);
            this.lblTituloCatalogoProductos.TabIndex = 9;
            this.lblTituloCatalogoProductos.Text = "Catálogo de productos";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(9, 97);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(73, 17);
            this.lblFiltrarPor.TabIndex = 16;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // lblFiltraMarca
            // 
            this.lblFiltraMarca.AutoSize = true;
            this.lblFiltraMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraMarca.Location = new System.Drawing.Point(127, 120);
            this.lblFiltraMarca.Name = "lblFiltraMarca";
            this.lblFiltraMarca.Size = new System.Drawing.Size(47, 17);
            this.lblFiltraMarca.TabIndex = 12;
            this.lblFiltraMarca.Text = "Marca";
            // 
            // cmbFiltroMarca
            // 
            this.cmbFiltroMarca.BackColor = System.Drawing.Color.White;
            this.cmbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroMarca.FormattingEnabled = true;
            this.cmbFiltroMarca.Items.AddRange(new object[] {
            "Samsung",
            "Lenovo",
            "Hp"});
            this.cmbFiltroMarca.Location = new System.Drawing.Point(130, 143);
            this.cmbFiltroMarca.Name = "cmbFiltroMarca";
            this.cmbFiltroMarca.Size = new System.Drawing.Size(118, 24);
            this.cmbFiltroMarca.TabIndex = 13;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(3, 52);
            this.txtBuscarProducto.Multiline = true;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(277, 27);
            this.txtBuscarProducto.TabIndex = 11;
            // 
            // lblFiltraCategoria
            // 
            this.lblFiltraCategoria.AutoSize = true;
            this.lblFiltraCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraCategoria.Location = new System.Drawing.Point(9, 120);
            this.lblFiltraCategoria.Name = "lblFiltraCategoria";
            this.lblFiltraCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblFiltraCategoria.TabIndex = 11;
            this.lblFiltraCategoria.Text = "Categoria ";
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.BackColor = System.Drawing.Color.White;
            this.cmbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Items.AddRange(new object[] {
            "Celulares",
            "Notebooks"});
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(12, 143);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(112, 24);
            this.cmbFiltroCategoria.TabIndex = 11;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-3, -2);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1220, 65);
            this.pnlEncabezado.TabIndex = 13;
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
            this.lblNombreUsuario.Location = new System.Drawing.Point(69, 11);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(95, 17);
            this.lblNombreUsuario.TabIndex = 11;
            this.lblNombreUsuario.Text = "Perez, Juan";
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
            this.lblRolUsuario.Location = new System.Drawing.Point(69, 28);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(83, 15);
            this.lblRolUsuario.TabIndex = 11;
            this.lblRolUsuario.Text = "Administrador";
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
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 29);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gestion de productos";
            // 
            // pnlFormularioProducto
            // 
            this.pnlFormularioProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFormularioProducto.Controls.Add(this.lblTituloInformacionProducto);
            this.pnlFormularioProducto.Controls.Add(this.lblEstado);
            this.pnlFormularioProducto.Controls.Add(this.cmbEstado);
            this.pnlFormularioProducto.Controls.Add(this.btnCancelar);
            this.pnlFormularioProducto.Controls.Add(this.btnAgregarProducto);
            this.pnlFormularioProducto.Controls.Add(this.lblProveedor);
            this.pnlFormularioProducto.Controls.Add(this.cmbProveedor);
            this.pnlFormularioProducto.Controls.Add(this.lblMarca);
            this.pnlFormularioProducto.Controls.Add(this.cmbMarca);
            this.pnlFormularioProducto.Controls.Add(this.lblCategoria);
            this.pnlFormularioProducto.Controls.Add(this.cmbCategoria);
            this.pnlFormularioProducto.Controls.Add(this.txtStock);
            this.pnlFormularioProducto.Controls.Add(this.lblStock);
            this.pnlFormularioProducto.Controls.Add(this.txtPrecio);
            this.pnlFormularioProducto.Controls.Add(this.lblPrecio);
            this.pnlFormularioProducto.Controls.Add(this.txtNombre);
            this.pnlFormularioProducto.Controls.Add(this.lblNombre);
            this.pnlFormularioProducto.Controls.Add(this.txtCodigo);
            this.pnlFormularioProducto.Controls.Add(this.lblCodigo);
            this.pnlFormularioProducto.Location = new System.Drawing.Point(5, 82);
            this.pnlFormularioProducto.Name = "pnlFormularioProducto";
            this.pnlFormularioProducto.Size = new System.Drawing.Size(551, 284);
            this.pnlFormularioProducto.TabIndex = 12;
            // 
            // lblTituloInformacionProducto
            // 
            this.lblTituloInformacionProducto.AutoSize = true;
            this.lblTituloInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformacionProducto.Location = new System.Drawing.Point(13, 7);
            this.lblTituloInformacionProducto.Name = "lblTituloInformacionProducto";
            this.lblTituloInformacionProducto.Size = new System.Drawing.Size(178, 16);
            this.lblTituloInformacionProducto.TabIndex = 12;
            this.lblTituloInformacionProducto.Text = "Informacion del producto";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(280, 78);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 17);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado: ";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(280, 98);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(222, 24);
            this.cmbEstado.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(279, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 34);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(413, 132);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(89, 34);
            this.btnAgregarProducto.TabIndex = 16;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(13, 225);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(82, 17);
            this.lblProveedor.TabIndex = 14;
            this.lblProveedor.Text = "Proveedor: ";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.White;
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "TecnoDistribuidora S.A.",
            "ElectroComponentes del Sur"});
            this.cmbProveedor.Location = new System.Drawing.Point(16, 245);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(222, 24);
            this.cmbProveedor.TabIndex = 13;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(14, 179);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 17);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca: ";
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.Color.White;
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Samsung",
            "Lenovo",
            "Hp"});
            this.cmbMarca.Location = new System.Drawing.Point(17, 199);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(222, 24);
            this.cmbMarca.TabIndex = 11;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(13, 132);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.White;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Celulares",
            "Notebooks"});
            this.cmbCategoria.Location = new System.Drawing.Point(16, 152);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(222, 24);
            this.cmbCategoria.TabIndex = 8;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(279, 50);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(75, 25);
            this.txtStock.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(276, 30);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 17);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock: ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(388, 50);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(114, 25);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(385, 30);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(17, 45);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 101);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(222, 25);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(17, 81);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Controls.Add(this.lblBuscarPorCodONombre);
            this.pnlFiltros.Controls.Add(this.lblFiltraEstado);
            this.pnlFiltros.Controls.Add(this.cmbFiltroEstado);
            this.pnlFiltros.Controls.Add(this.lblFiltraProveedor);
            this.pnlFiltros.Controls.Add(this.cmbFiltroProveedor);
            this.pnlFiltros.Controls.Add(this.txtBuscarProducto);
            this.pnlFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlFiltros.Controls.Add(this.cmbFiltroCategoria);
            this.pnlFiltros.Controls.Add(this.lblFiltraCategoria);
            this.pnlFiltros.Controls.Add(this.lblFiltraMarca);
            this.pnlFiltros.Controls.Add(this.cmbFiltroMarca);
            this.pnlFiltros.Location = new System.Drawing.Point(600, 183);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(556, 183);
            this.pnlFiltros.TabIndex = 16;
            // 
            // lblBuscarPorCodONombre
            // 
            this.lblBuscarPorCodONombre.AutoSize = true;
            this.lblBuscarPorCodONombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCodONombre.Location = new System.Drawing.Point(3, 30);
            this.lblBuscarPorCodONombre.Name = "lblBuscarPorCodONombre";
            this.lblBuscarPorCodONombre.Size = new System.Drawing.Size(195, 17);
            this.lblBuscarPorCodONombre.TabIndex = 21;
            this.lblBuscarPorCodONombre.Text = "Buscar por Codigo o Nombre:";
            // 
            // lblFiltraEstado
            // 
            this.lblFiltraEstado.AutoSize = true;
            this.lblFiltraEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraEstado.Location = new System.Drawing.Point(371, 123);
            this.lblFiltraEstado.Name = "lblFiltraEstado";
            this.lblFiltraEstado.Size = new System.Drawing.Size(52, 17);
            this.lblFiltraEstado.TabIndex = 19;
            this.lblFiltraEstado.Text = "Estado";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.BackColor = System.Drawing.Color.White;
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(374, 143);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(114, 24);
            this.cmbFiltroEstado.TabIndex = 20;
            // 
            // lblFiltraProveedor
            // 
            this.lblFiltraProveedor.AutoSize = true;
            this.lblFiltraProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraProveedor.Location = new System.Drawing.Point(251, 123);
            this.lblFiltraProveedor.Name = "lblFiltraProveedor";
            this.lblFiltraProveedor.Size = new System.Drawing.Size(74, 17);
            this.lblFiltraProveedor.TabIndex = 17;
            this.lblFiltraProveedor.Text = "Proveedor";
            // 
            // cmbFiltroProveedor
            // 
            this.cmbFiltroProveedor.BackColor = System.Drawing.Color.White;
            this.cmbFiltroProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroProveedor.FormattingEnabled = true;
            this.cmbFiltroProveedor.Items.AddRange(new object[] {
            "TecnoDistribuidora S.A.",
            "ElectroComponentes del Sur"});
            this.cmbFiltroProveedor.Location = new System.Drawing.Point(254, 143);
            this.cmbFiltroProveedor.Name = "cmbFiltroProveedor";
            this.cmbFiltroProveedor.Size = new System.Drawing.Size(114, 24);
            this.cmbFiltroProveedor.TabIndex = 18;
            // 
            // pnlCardStockBajo
            // 
            this.pnlCardStockBajo.BackColor = System.Drawing.Color.White;
            this.pnlCardStockBajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardStockBajo.Controls.Add(this.picIconoAlerta);
            this.pnlCardStockBajo.Controls.Add(this.lblCantProductosStockBajo);
            this.pnlCardStockBajo.Controls.Add(this.lblTituloStockBajo);
            this.pnlCardStockBajo.Location = new System.Drawing.Point(805, 82);
            this.pnlCardStockBajo.Name = "pnlCardStockBajo";
            this.pnlCardStockBajo.Size = new System.Drawing.Size(177, 75);
            this.pnlCardStockBajo.TabIndex = 18;
            // 
            // picIconoAlerta
            // 
            this.picIconoAlerta.Image = global::CapaPresentacion.Properties.Resources.icono_advertencia;
            this.picIconoAlerta.Location = new System.Drawing.Point(118, 13);
            this.picIconoAlerta.Name = "picIconoAlerta";
            this.picIconoAlerta.Size = new System.Drawing.Size(45, 45);
            this.picIconoAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIconoAlerta.TabIndex = 12;
            this.picIconoAlerta.TabStop = false;
            // 
            // lblCantProductosStockBajo
            // 
            this.lblCantProductosStockBajo.AutoSize = true;
            this.lblCantProductosStockBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantProductosStockBajo.ForeColor = System.Drawing.Color.Gold;
            this.lblCantProductosStockBajo.Location = new System.Drawing.Point(10, 27);
            this.lblCantProductosStockBajo.Name = "lblCantProductosStockBajo";
            this.lblCantProductosStockBajo.Size = new System.Drawing.Size(46, 31);
            this.lblCantProductosStockBajo.TabIndex = 17;
            this.lblCantProductosStockBajo.Text = "10";
            // 
            // lblTituloStockBajo
            // 
            this.lblTituloStockBajo.AutoSize = true;
            this.lblTituloStockBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloStockBajo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloStockBajo.Location = new System.Drawing.Point(12, 9);
            this.lblTituloStockBajo.Name = "lblTituloStockBajo";
            this.lblTituloStockBajo.Size = new System.Drawing.Size(79, 15);
            this.lblTituloStockBajo.TabIndex = 17;
            this.lblTituloStockBajo.Text = "Stock Bajo:";
            // 
            // GestionProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 561);
            this.Controls.Add(this.pnlCardStockBajo);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlCardTotalProductos);
            this.Controls.Add(this.pnlContenedorCatalogo);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlFormularioProducto);
            this.Name = "GestionProductosForm";
            this.Text = "GestionProductosForm";
            this.pnlCardTotalProductos.ResumeLayout(false);
            this.pnlCardTotalProductos.PerformLayout();
            this.pnlContenedorCatalogo.ResumeLayout(false);
            this.pnlContenedorCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlFormularioProducto.ResumeLayout(false);
            this.pnlFormularioProducto.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlCardStockBajo.ResumeLayout(false);
            this.pnlCardStockBajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconoAlerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardTotalProductos;
        private System.Windows.Forms.Label lblCantTotalProductos;
        private System.Windows.Forms.Label lblTituloTotalProductos;
        private System.Windows.Forms.Panel pnlContenedorCatalogo;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltraMarca;
        private System.Windows.Forms.ComboBox cmbFiltroMarca;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblFiltraCategoria;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.Label lblTituloCatalogoProductos;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFormularioProducto;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlCardStockBajo;
        private System.Windows.Forms.Label lblCantProductosStockBajo;
        private System.Windows.Forms.Label lblTituloStockBajo;
        private System.Windows.Forms.Label lblTituloInformacionProducto;
        private System.Windows.Forms.Label lblFiltraProveedor;
        private System.Windows.Forms.ComboBox cmbFiltroProveedor;
        private System.Windows.Forms.Label lblFiltraEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Label lblBuscarPorCodONombre;
        private System.Windows.Forms.PictureBox picIconoAlerta;
    }
}