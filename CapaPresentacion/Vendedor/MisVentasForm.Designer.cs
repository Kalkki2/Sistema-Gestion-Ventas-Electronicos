namespace CapaPresentacion.Vendedor
{
    partial class MisVentasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlHistorialVentas = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvHistorialVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloHistorialVentas = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFiltroMetodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarPorDNI = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltrarMetodoPago = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnGenerarComprobante = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblValorClienteComprador = new System.Windows.Forms.Label();
            this.lblValorDniComprador = new System.Windows.Forms.Label();
            this.lblDniComprador = new System.Windows.Forms.Label();
            this.lblValorHoraCompra = new System.Windows.Forms.Label();
            this.lblValorFechaCompra = new System.Windows.Forms.Label();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.lblValorNroCompra = new System.Windows.Forms.Label();
            this.lblNroCompra = new System.Windows.Forms.Label();
            this.lblTiqueFactura = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlHistorialVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.pnlContenedorFiltros.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-2, -3);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1179, 64);
            this.pnlEncabezado.TabIndex = 60;
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
            this.lblTitulo.Size = new System.Drawing.Size(130, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Mis Ventas";
            // 
            // pnlHistorialVentas
            // 
            this.pnlHistorialVentas.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlHistorialVentas.BorderRadius = 8;
            this.pnlHistorialVentas.BorderThickness = 1;
            this.pnlHistorialVentas.Controls.Add(this.dgvHistorialVentas);
            this.pnlHistorialVentas.Controls.Add(this.lblTituloHistorialVentas);
            this.pnlHistorialVentas.FillColor = System.Drawing.Color.Transparent;
            this.pnlHistorialVentas.Location = new System.Drawing.Point(5, 257);
            this.pnlHistorialVentas.Name = "pnlHistorialVentas";
            this.pnlHistorialVentas.Size = new System.Drawing.Size(703, 370);
            this.pnlHistorialVentas.TabIndex = 61;
            // 
            // dgvHistorialVentas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHistorialVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroVenta,
            this.colCliente,
            this.colFechaVenta,
            this.colCantVendida,
            this.colMetodoPago,
            this.colTotal,
            this.colBtnVerDetalle});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistorialVentas.Location = new System.Drawing.Point(3, 41);
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.RowHeadersVisible = false;
            this.dgvHistorialVentas.RowTemplate.Height = 23;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(697, 236);
            this.dgvHistorialVentas.TabIndex = 7;
            this.dgvHistorialVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvHistorialVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialVentas.ThemeStyle.RowsStyle.Height = 23;
            this.dgvHistorialVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // colNroVenta
            // 
            this.colNroVenta.FillWeight = 65F;
            this.colNroVenta.HeaderText = "NroVenta";
            this.colNroVenta.Name = "colNroVenta";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.FillWeight = 90F;
            this.colFechaVenta.HeaderText = "Fecha Venta";
            this.colFechaVenta.Name = "colFechaVenta";
            // 
            // colCantVendida
            // 
            this.colCantVendida.FillWeight = 90F;
            this.colCantVendida.HeaderText = "Cant Vendida";
            this.colCantVendida.Name = "colCantVendida";
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Metodo Pago";
            this.colMetodoPago.Name = "colMetodoPago";
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 70F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colBtnVerDetalle
            // 
            this.colBtnVerDetalle.FillWeight = 90F;
            this.colBtnVerDetalle.HeaderText = "Ver Detalle";
            this.colBtnVerDetalle.Name = "colBtnVerDetalle";
            // 
            // lblTituloHistorialVentas
            // 
            this.lblTituloHistorialVentas.AutoSize = true;
            this.lblTituloHistorialVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloHistorialVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorialVentas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloHistorialVentas.Location = new System.Drawing.Point(5, 15);
            this.lblTituloHistorialVentas.Name = "lblTituloHistorialVentas";
            this.lblTituloHistorialVentas.Size = new System.Drawing.Size(139, 16);
            this.lblTituloHistorialVentas.TabIndex = 6;
            this.lblTituloHistorialVentas.Text = "Historial de Ventas";
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.dtpHasta);
            this.pnlContenedorFiltros.Controls.Add(this.dtpDesde);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarHasta);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarDesde);
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrar);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarCliente);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroMetodoPago);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarCliente);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorDNI);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarMetodoPago);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(5, 67);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.Radius = 5;
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowDepth = 25;
            this.pnlContenedorFiltros.ShadowShift = 3;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(561, 178);
            this.pnlContenedorFiltros.TabIndex = 62;
            // 
            // dtpHasta
            // 
            this.dtpHasta.BorderRadius = 5;
            this.dtpHasta.Checked = true;
            this.dtpHasta.FillColor = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(313, 135);
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
            this.dtpDesde.Location = new System.Drawing.Point(178, 135);
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
            this.lblFiltrarHasta.Location = new System.Drawing.Point(357, 115);
            this.lblFiltrarHasta.Name = "lblFiltrarHasta";
            this.lblFiltrarHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFiltrarHasta.TabIndex = 47;
            this.lblFiltrarHasta.Text = "Hasta";
            // 
            // lblFiltrarDesde
            // 
            this.lblFiltrarDesde.AutoSize = true;
            this.lblFiltrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarDesde.Location = new System.Drawing.Point(216, 115);
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
            this.btnFiltrar.Image = global::CapaPresentacion.Properties.Resources.icono_filtro;
            this.btnFiltrar.Location = new System.Drawing.Point(459, 135);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(89, 27);
            this.btnFiltrar.TabIndex = 45;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BorderRadius = 5;
            this.btnBuscarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarCliente.FillColor = System.Drawing.Color.Silver;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Image = global::CapaPresentacion.Properties.Resources.icono_lupa;
            this.btnBuscarCliente.Location = new System.Drawing.Point(264, 40);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(89, 27);
            this.btnBuscarCliente.TabIndex = 44;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
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
            this.cmbFiltroMetodoPago.Location = new System.Drawing.Point(15, 135);
            this.cmbFiltroMetodoPago.Name = "cmbFiltroMetodoPago";
            this.cmbFiltroMetodoPago.Size = new System.Drawing.Size(150, 27);
            this.cmbFiltroMetodoPago.StartIndex = 0;
            this.cmbFiltroMetodoPago.TabIndex = 22;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarCliente.BorderRadius = 5;
            this.txtBuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCliente.DefaultText = "";
            this.txtBuscarCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.Location = new System.Drawing.Point(16, 40);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PlaceholderText = "";
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.Size = new System.Drawing.Size(242, 27);
            this.txtBuscarCliente.TabIndex = 0;
            // 
            // lblBuscarPorDNI
            // 
            this.lblBuscarPorDNI.AutoSize = true;
            this.lblBuscarPorDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorDNI.Location = new System.Drawing.Point(18, 20);
            this.lblBuscarPorDNI.Name = "lblBuscarPorDNI";
            this.lblBuscarPorDNI.Size = new System.Drawing.Size(178, 17);
            this.lblBuscarPorDNI.TabIndex = 21;
            this.lblBuscarPorDNI.Text = "Buscar por DNI del Cliente:";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(12, 89);
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
            this.lblFiltrarMetodoPago.Location = new System.Drawing.Point(12, 115);
            this.lblFiltrarMetodoPago.Name = "lblFiltrarMetodoPago";
            this.lblFiltrarMetodoPago.Size = new System.Drawing.Size(92, 17);
            this.lblFiltrarMetodoPago.TabIndex = 11;
            this.lblFiltrarMetodoPago.Text = "Metodo Pago";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnGenerarComprobante);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label11);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.label8);
            this.guna2ShadowPanel1.Controls.Add(this.label9);
            this.guna2ShadowPanel1.Controls.Add(this.lblValorClienteComprador);
            this.guna2ShadowPanel1.Controls.Add(this.lblValorDniComprador);
            this.guna2ShadowPanel1.Controls.Add(this.lblDniComprador);
            this.guna2ShadowPanel1.Controls.Add(this.lblValorHoraCompra);
            this.guna2ShadowPanel1.Controls.Add(this.lblValorFechaCompra);
            this.guna2ShadowPanel1.Controls.Add(this.lblFechaCompra);
            this.guna2ShadowPanel1.Controls.Add(this.lblValorNroCompra);
            this.guna2ShadowPanel1.Controls.Add(this.lblNroCompra);
            this.guna2ShadowPanel1.Controls.Add(this.lblTiqueFactura);
            this.guna2ShadowPanel1.Controls.Add(this.label16);
            this.guna2ShadowPanel1.Controls.Add(this.guna2DataGridView1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(721, 171);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 25;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(435, 490);
            this.guna2ShadowPanel1.TabIndex = 63;
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarComprobante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGenerarComprobante.BorderRadius = 5;
            this.btnGenerarComprobante.BorderThickness = 1;
            this.btnGenerarComprobante.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarComprobante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarComprobante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarComprobante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarComprobante.FillColor = System.Drawing.Color.Transparent;
            this.btnGenerarComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGenerarComprobante.Location = new System.Drawing.Point(250, 423);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(180, 33);
            this.btnGenerarComprobante.TabIndex = 62;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "$XXXXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "TOTAL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Cliente: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Efectivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Forma pago: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Pereira, Luciana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Vendedor: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "22222222";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "DNI: ";
            // 
            // lblValorClienteComprador
            // 
            this.lblValorClienteComprador.AutoSize = true;
            this.lblValorClienteComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorClienteComprador.Location = new System.Drawing.Point(302, 131);
            this.lblValorClienteComprador.Name = "lblValorClienteComprador";
            this.lblValorClienteComprador.Size = new System.Drawing.Size(77, 16);
            this.lblValorClienteComprador.TabIndex = 52;
            this.lblValorClienteComprador.Text = "Perez, Juan";
            // 
            // lblValorDniComprador
            // 
            this.lblValorDniComprador.AutoSize = true;
            this.lblValorDniComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDniComprador.Location = new System.Drawing.Point(302, 106);
            this.lblValorDniComprador.Name = "lblValorDniComprador";
            this.lblValorDniComprador.Size = new System.Drawing.Size(63, 16);
            this.lblValorDniComprador.TabIndex = 51;
            this.lblValorDniComprador.Text = "11111111";
            // 
            // lblDniComprador
            // 
            this.lblDniComprador.AutoSize = true;
            this.lblDniComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniComprador.Location = new System.Drawing.Point(14, 106);
            this.lblDniComprador.Name = "lblDniComprador";
            this.lblDniComprador.Size = new System.Drawing.Size(36, 16);
            this.lblDniComprador.TabIndex = 50;
            this.lblDniComprador.Text = "DNI: ";
            // 
            // lblValorHoraCompra
            // 
            this.lblValorHoraCompra.AutoSize = true;
            this.lblValorHoraCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHoraCompra.Location = new System.Drawing.Point(379, 71);
            this.lblValorHoraCompra.Name = "lblValorHoraCompra";
            this.lblValorHoraCompra.Size = new System.Drawing.Size(55, 16);
            this.lblValorHoraCompra.TabIndex = 49;
            this.lblValorHoraCompra.Text = "09:04:47";
            // 
            // lblValorFechaCompra
            // 
            this.lblValorFechaCompra.AutoSize = true;
            this.lblValorFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFechaCompra.Location = new System.Drawing.Point(302, 71);
            this.lblValorFechaCompra.Name = "lblValorFechaCompra";
            this.lblValorFechaCompra.Size = new System.Drawing.Size(71, 16);
            this.lblValorFechaCompra.TabIndex = 48;
            this.lblValorFechaCompra.Text = "11/08/2026";
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCompra.Location = new System.Drawing.Point(13, 71);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(94, 16);
            this.lblFechaCompra.TabIndex = 47;
            this.lblFechaCompra.Text = "Fecha y Hora: ";
            // 
            // lblValorNroCompra
            // 
            this.lblValorNroCompra.AutoSize = true;
            this.lblValorNroCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorNroCompra.Location = new System.Drawing.Point(302, 55);
            this.lblValorNroCompra.Name = "lblValorNroCompra";
            this.lblValorNroCompra.Size = new System.Drawing.Size(91, 16);
            this.lblValorNroCompra.TabIndex = 46;
            this.lblValorNroCompra.Text = "000000000344";
            // 
            // lblNroCompra
            // 
            this.lblNroCompra.AutoSize = true;
            this.lblNroCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCompra.Location = new System.Drawing.Point(13, 54);
            this.lblNroCompra.Name = "lblNroCompra";
            this.lblNroCompra.Size = new System.Drawing.Size(84, 16);
            this.lblNroCompra.TabIndex = 45;
            this.lblNroCompra.Text = "Nro compra: ";
            // 
            // lblTiqueFactura
            // 
            this.lblTiqueFactura.AutoSize = true;
            this.lblTiqueFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblTiqueFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiqueFactura.Location = new System.Drawing.Point(7, 38);
            this.lblTiqueFactura.Name = "lblTiqueFactura";
            this.lblTiqueFactura.Size = new System.Drawing.Size(154, 16);
            this.lblTiqueFactura.TabIndex = 44;
            this.lblTiqueFactura.Text = "TIQUE FACTURA \"B\"";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(10, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "DETALLE DE VENTA:";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(16, 182);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 23;
            this.guna2DataGridView1.Size = new System.Drawing.Size(411, 191);
            this.guna2DataGridView1.TabIndex = 8;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 23;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 23;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Poducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // MisVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 561);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Controls.Add(this.pnlHistorialVentas);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "MisVentasForm";
            this.Text = "MisVentasForm";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlHistorialVentas.ResumeLayout(false);
            this.pnlHistorialVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlHistorialVentas;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorialVentas;
        private System.Windows.Forms.Label lblTituloHistorialVentas;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarCliente;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroMetodoPago;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscarPorDNI;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltrarMetodoPago;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnVerDetalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblValorClienteComprador;
        private System.Windows.Forms.Label lblValorDniComprador;
        private System.Windows.Forms.Label lblDniComprador;
        private System.Windows.Forms.Label lblValorHoraCompra;
        private System.Windows.Forms.Label lblValorFechaCompra;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.Label lblValorNroCompra;
        private System.Windows.Forms.Label lblNroCompra;
        private System.Windows.Forms.Label lblTiqueFactura;
        private Guna.UI2.WinForms.Guna2Button btnGenerarComprobante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}