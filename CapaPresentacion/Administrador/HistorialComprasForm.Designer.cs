namespace CapaPresentacion.Administrador
{
    partial class HistorialComprasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.cmbFiltroMetodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarPorCuit = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltrarMetodoPago = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvHistorialCompraProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarPoveedorPorCuit = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompraProductos)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.dtpHasta);
            this.pnlContenedorFiltros.Controls.Add(this.dtpDesde);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarHasta);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarDesde);
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrar);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarPoveedorPorCuit);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroMetodoPago);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarProveedor);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorCuit);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarMetodoPago);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(25, 122);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.Radius = 5;
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowDepth = 25;
            this.pnlContenedorFiltros.ShadowShift = 3;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(449, 197);
            this.pnlContenedorFiltros.TabIndex = 66;
            // 
            // dtpHasta
            // 
            this.dtpHasta.BorderRadius = 5;
            this.dtpHasta.Checked = true;
            this.dtpHasta.FillColor = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(222, 159);
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
            this.dtpDesde.Location = new System.Drawing.Point(49, 159);
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
            this.lblFiltrarHasta.Location = new System.Drawing.Point(181, 163);
            this.lblFiltrarHasta.Name = "lblFiltrarHasta";
            this.lblFiltrarHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFiltrarHasta.TabIndex = 47;
            this.lblFiltrarHasta.Text = "Hasta";
            // 
            // lblFiltrarDesde
            // 
            this.lblFiltrarDesde.AutoSize = true;
            this.lblFiltrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarDesde.Location = new System.Drawing.Point(6, 163);
            this.lblFiltrarDesde.Name = "lblFiltrarDesde";
            this.lblFiltrarDesde.Size = new System.Drawing.Size(49, 17);
            this.lblFiltrarDesde.TabIndex = 46;
            this.lblFiltrarDesde.Text = "Desde";
            // 
            // cmbFiltroMetodoPago
            // 
            this.cmbFiltroMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroMetodoPago.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbFiltroMetodoPago.BorderRadius = 5;
            this.cmbFiltroMetodoPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroMetodoPago.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroMetodoPago.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFiltroMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroMetodoPago.ItemHeight = 21;
            this.cmbFiltroMetodoPago.Items.AddRange(new object[] {
            "Todos",
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.cmbFiltroMetodoPago.Location = new System.Drawing.Point(19, 112);
            this.cmbFiltroMetodoPago.Name = "cmbFiltroMetodoPago";
            this.cmbFiltroMetodoPago.Size = new System.Drawing.Size(150, 27);
            this.cmbFiltroMetodoPago.StartIndex = 0;
            this.cmbFiltroMetodoPago.TabIndex = 22;
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProveedor.BorderRadius = 5;
            this.txtBuscarProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProveedor.DefaultText = "";
            this.txtBuscarProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedor.Location = new System.Drawing.Point(16, 25);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.PlaceholderText = "";
            this.txtBuscarProveedor.SelectedText = "";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(226, 27);
            this.txtBuscarProveedor.TabIndex = 0;
            // 
            // lblBuscarPorCuit
            // 
            this.lblBuscarPorCuit.AutoSize = true;
            this.lblBuscarPorCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCuit.Location = new System.Drawing.Point(18, 5);
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
            this.lblFiltrarPor.Location = new System.Drawing.Point(16, 66);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(73, 17);
            this.lblFiltrarPor.TabIndex = 16;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // lblFiltrarMetodoPago
            // 
            this.lblFiltrarMetodoPago.AutoSize = true;
            this.lblFiltrarMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarMetodoPago.Location = new System.Drawing.Point(16, 92);
            this.lblFiltrarMetodoPago.Name = "lblFiltrarMetodoPago";
            this.lblFiltrarMetodoPago.Size = new System.Drawing.Size(92, 17);
            this.lblFiltrarMetodoPago.TabIndex = 11;
            this.lblFiltrarMetodoPago.Text = "Metodo Pago";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.dgvHistorialCompraProductos);
            this.guna2Panel1.Controls.Add(this.lblCatalogo);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(21, 325);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(695, 245);
            this.guna2Panel1.TabIndex = 65;
            // 
            // dgvHistorialCompraProductos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHistorialCompraProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialCompraProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistorialCompraProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCompra,
            this.colProveedor,
            this.colComprador,
            this.colTotal,
            this.colVerDetalle});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialCompraProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHistorialCompraProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistorialCompraProductos.Location = new System.Drawing.Point(4, 40);
            this.dgvHistorialCompraProductos.Name = "dgvHistorialCompraProductos";
            this.dgvHistorialCompraProductos.RowHeadersVisible = false;
            this.dgvHistorialCompraProductos.RowTemplate.Height = 23;
            this.dgvHistorialCompraProductos.Size = new System.Drawing.Size(688, 200);
            this.dgvHistorialCompraProductos.TabIndex = 7;
            this.dgvHistorialCompraProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHistorialCompraProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvHistorialCompraProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialCompraProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialCompraProductos.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvHistorialCompraProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialCompraProductos.ThemeStyle.RowsStyle.Height = 23;
            this.dgvHistorialCompraProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // colNroCompra
            // 
            this.colNroCompra.HeaderText = "Nro Compra";
            this.colNroCompra.Name = "colNroCompra";
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            // 
            // colComprador
            // 
            this.colComprador.HeaderText = "Comprador";
            this.colComprador.Name = "colComprador";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
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
            this.btnFiltrar.Location = new System.Drawing.Point(357, 159);
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
            this.btnBuscarPoveedorPorCuit.Image = global::CapaPresentacion.Properties.Resources.icono_lupa;
            this.btnBuscarPoveedorPorCuit.Location = new System.Drawing.Point(248, 25);
            this.btnBuscarPoveedorPorCuit.Name = "btnBuscarPoveedorPorCuit";
            this.btnBuscarPoveedorPorCuit.Size = new System.Drawing.Size(89, 27);
            this.btnBuscarPoveedorPorCuit.TabIndex = 44;
            this.btnBuscarPoveedorPorCuit.Text = "Buscar";
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
            // HistorialComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 749);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "HistorialComprasForm";
            this.Text = "HistorialComprasForm";
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCompraProductos)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarPoveedorPorCuit;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroMetodoPago;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label lblBuscarPorCuit;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltrarMetodoPago;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorialCompraProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colVerDetalle;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
    }
}