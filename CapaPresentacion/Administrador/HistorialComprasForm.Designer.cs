namespace CapaPresentacion.Administrador
{
    partial class HistorialCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarPoveedorPorCuit = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarProveedorPorCuit = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarPorCuit = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvHistorialCompras = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDniUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCambiaEstado = new System.Windows.Forms.DataGridViewImageColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnBuscarUsuarioPorDNI = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarPorUsuarioPorDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompras)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlContenedorFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpHasta
            // 
            this.dtpHasta.BorderRadius = 5;
            this.dtpHasta.Checked = true;
            this.dtpHasta.FillColor = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(232, 172);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(129, 27);
            this.dtpHasta.TabIndex = 51;
            this.dtpHasta.Value = new System.DateTime(2026, 9, 19, 2, 30, 25, 702);
            // 
            // dtpDesde
            // 
            this.dtpDesde.BorderRadius = 5;
            this.dtpDesde.Checked = true;
            this.dtpDesde.FillColor = System.Drawing.Color.White;
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(59, 172);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(129, 27);
            this.dtpDesde.TabIndex = 50;
            this.dtpDesde.Value = new System.DateTime(2026, 9, 19, 2, 30, 25, 702);
            // 
            // lblFiltrarHasta
            // 
            this.lblFiltrarHasta.AutoSize = true;
            this.lblFiltrarHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarHasta.Location = new System.Drawing.Point(191, 176);
            this.lblFiltrarHasta.Name = "lblFiltrarHasta";
            this.lblFiltrarHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFiltrarHasta.TabIndex = 47;
            this.lblFiltrarHasta.Text = "Hasta";
            // 
            // lblFiltrarDesde
            // 
            this.lblFiltrarDesde.AutoSize = true;
            this.lblFiltrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarDesde.Location = new System.Drawing.Point(16, 176);
            this.lblFiltrarDesde.Name = "lblFiltrarDesde";
            this.lblFiltrarDesde.Size = new System.Drawing.Size(49, 17);
            this.lblFiltrarDesde.TabIndex = 46;
            this.lblFiltrarDesde.Text = "Desde";
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
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(367, 172);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(89, 27);
            this.btnFiltrar.TabIndex = 45;
            this.btnFiltrar.Text = "Filtrar";
            // 
            // btnBuscarPoveedorPorCuit
            // 
            this.btnBuscarPoveedorPorCuit.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPoveedorPorCuit.BorderRadius = 5;
            this.btnBuscarPoveedorPorCuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPoveedorPorCuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPoveedorPorCuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPoveedorPorCuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarPoveedorPorCuit.FillColor = System.Drawing.Color.Silver;
            this.btnBuscarPoveedorPorCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscarPoveedorPorCuit.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarPoveedorPorCuit.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPoveedorPorCuit.Image")));
            this.btnBuscarPoveedorPorCuit.Location = new System.Drawing.Point(257, 35);
            this.btnBuscarPoveedorPorCuit.Name = "btnBuscarPoveedorPorCuit";
            this.btnBuscarPoveedorPorCuit.Size = new System.Drawing.Size(89, 27);
            this.btnBuscarPoveedorPorCuit.TabIndex = 44;
            this.btnBuscarPoveedorPorCuit.Text = "Buscar";
            // 
            // txtBuscarProveedorPorCuit
            // 
            this.txtBuscarProveedorPorCuit.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProveedorPorCuit.BorderRadius = 5;
            this.txtBuscarProveedorPorCuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProveedorPorCuit.DefaultText = "";
            this.txtBuscarProveedorPorCuit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarProveedorPorCuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarProveedorPorCuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedorPorCuit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedorPorCuit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedorPorCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarProveedorPorCuit.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProveedorPorCuit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedorPorCuit.Location = new System.Drawing.Point(25, 35);
            this.txtBuscarProveedorPorCuit.Name = "txtBuscarProveedorPorCuit";
            this.txtBuscarProveedorPorCuit.PlaceholderText = "";
            this.txtBuscarProveedorPorCuit.SelectedText = "";
            this.txtBuscarProveedorPorCuit.Size = new System.Drawing.Size(226, 27);
            this.txtBuscarProveedorPorCuit.TabIndex = 0;
            // 
            // lblBuscarPorCuit
            // 
            this.lblBuscarPorCuit.AutoSize = true;
            this.lblBuscarPorCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCuit.Location = new System.Drawing.Point(27, 15);
            this.lblBuscarPorCuit.Name = "lblBuscarPorCuit";
            this.lblBuscarPorCuit.Size = new System.Drawing.Size(208, 17);
            this.lblBuscarPorCuit.TabIndex = 21;
            this.lblBuscarPorCuit.Text = "Buscar por CUIT del proveedor:";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(23, 139);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(73, 17);
            this.lblFiltrarPor.TabIndex = 16;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.dgvHistorialCompras);
            this.guna2Panel1.Controls.Add(this.lblCatalogo);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(21, 325);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1146, 357);
            this.guna2Panel1.TabIndex = 65;
            // 
            // dgvHistorialCompras
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHistorialCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialCompras.ColumnHeadersHeight = 35;
            this.dgvHistorialCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroFactura,
            this.colCuitProveedor,
            this.colProveedor,
            this.ColDniUsuario,
            this.colComprador,
            this.colFechaCompra,
            this.colTotal,
            this.colEstado,
            this.colCambiaEstado,
            this.colVerDetalle});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialCompras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistorialCompras.Location = new System.Drawing.Point(4, 40);
            this.dgvHistorialCompras.Name = "dgvHistorialCompras";
            this.dgvHistorialCompras.RowHeadersVisible = false;
            this.dgvHistorialCompras.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialCompras.RowTemplate.Height = 25;
            this.dgvHistorialCompras.Size = new System.Drawing.Size(1139, 290);
            this.dgvHistorialCompras.TabIndex = 7;
            this.dgvHistorialCompras.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHistorialCompras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvHistorialCompras.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialCompras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialCompras.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvHistorialCompras.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialCompras.ThemeStyle.RowsStyle.Height = 25;
            this.dgvHistorialCompras.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvHistorialCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialCompras_CellContentClick);
            // 
            // colNroFactura
            // 
            this.colNroFactura.HeaderText = "Nro Factura";
            this.colNroFactura.Name = "colNroFactura";
            // 
            // colCuitProveedor
            // 
            this.colCuitProveedor.HeaderText = "CUIT Proveedor";
            this.colCuitProveedor.Name = "colCuitProveedor";
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            // 
            // ColDniUsuario
            // 
            this.ColDniUsuario.HeaderText = "DNI Usuario";
            this.ColDniUsuario.Name = "ColDniUsuario";
            // 
            // colComprador
            // 
            this.colComprador.HeaderText = "Usuario Responsable";
            this.colComprador.Name = "colComprador";
            // 
            // colFechaCompra
            // 
            this.colFechaCompra.HeaderText = "Fecha Compra";
            this.colFechaCompra.Name = "colFechaCompra";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colCambiaEstado
            // 
            this.colCambiaEstado.HeaderText = "Cambiar Estado";
            this.colCambiaEstado.Name = "colCambiaEstado";
            this.colCambiaEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCambiaEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.HeaderText = "Ver Detalle";
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.Location = new System.Drawing.Point(11, 3);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(157, 17);
            this.lblCatalogo.TabIndex = 38;
            this.lblCatalogo.Text = "Historial de compras";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-2, -3);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1222, 64);
            this.pnlEncabezado.TabIndex = 67;
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
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Historial de Compras";
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarUsuarioPorDNI);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarPorUsuarioPorDni);
            this.pnlContenedorFiltros.Controls.Add(this.label1);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarPoveedorPorCuit);
            this.pnlContenedorFiltros.Controls.Add(this.dtpHasta);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarProveedorPorCuit);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorCuit);
            this.pnlContenedorFiltros.Controls.Add(this.dtpDesde);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarHasta);
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrar);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarDesde);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(25, 78);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(503, 228);
            this.pnlContenedorFiltros.TabIndex = 68;
            // 
            // btnBuscarUsuarioPorDNI
            // 
            this.btnBuscarUsuarioPorDNI.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuarioPorDNI.BorderRadius = 5;
            this.btnBuscarUsuarioPorDNI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarUsuarioPorDNI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarUsuarioPorDNI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarUsuarioPorDNI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarUsuarioPorDNI.FillColor = System.Drawing.Color.Silver;
            this.btnBuscarUsuarioPorDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscarUsuarioPorDNI.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarUsuarioPorDNI.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuarioPorDNI.Image")));
            this.btnBuscarUsuarioPorDNI.Location = new System.Drawing.Point(257, 98);
            this.btnBuscarUsuarioPorDNI.Name = "btnBuscarUsuarioPorDNI";
            this.btnBuscarUsuarioPorDNI.Size = new System.Drawing.Size(89, 27);
            this.btnBuscarUsuarioPorDNI.TabIndex = 54;
            this.btnBuscarUsuarioPorDNI.Text = "Buscar";
            // 
            // txtBuscarPorUsuarioPorDni
            // 
            this.txtBuscarPorUsuarioPorDni.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPorUsuarioPorDni.BorderRadius = 5;
            this.txtBuscarPorUsuarioPorDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPorUsuarioPorDni.DefaultText = "";
            this.txtBuscarPorUsuarioPorDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarPorUsuarioPorDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarPorUsuarioPorDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPorUsuarioPorDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPorUsuarioPorDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarPorUsuarioPorDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarPorUsuarioPorDni.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarPorUsuarioPorDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarPorUsuarioPorDni.Location = new System.Drawing.Point(25, 98);
            this.txtBuscarPorUsuarioPorDni.Name = "txtBuscarPorUsuarioPorDni";
            this.txtBuscarPorUsuarioPorDni.PlaceholderText = "";
            this.txtBuscarPorUsuarioPorDni.SelectedText = "";
            this.txtBuscarPorUsuarioPorDni.Size = new System.Drawing.Size(226, 27);
            this.txtBuscarPorUsuarioPorDni.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Buscar por DNI del usuario:";
            // 
            // HistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 749);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "HistorialCompras";
            this.Text = "HistorialComprasForm";
            this.Load += new System.EventHandler(this.HistorialComprasForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompras)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarPoveedorPorCuit;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProveedorPorCuit;
        private System.Windows.Forms.Label lblBuscarPorCuit;
        private System.Windows.Forms.Label lblFiltrarPor;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorialCompras;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDniUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewImageColumn colCambiaEstado;
        private System.Windows.Forms.DataGridViewImageColumn colVerDetalle;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2Button btnBuscarUsuarioPorDNI;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarPorUsuarioPorDni;
        private System.Windows.Forms.Label label1;
    }
}