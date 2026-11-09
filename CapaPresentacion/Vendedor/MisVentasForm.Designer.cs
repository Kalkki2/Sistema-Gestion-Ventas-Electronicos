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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisVentasForm));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlHistorialVentas = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvMisVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoAjuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCambiarEstado = new System.Windows.Forms.DataGridViewImageColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTituloHistorialVentas = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cmbFiltroEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFiltroMetodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarClienteDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarPorDNI = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltrarMetodoPago = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblIniciales = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlHistorialVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisVentas)).BeginInit();
            this.pnlContenedorFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            this.pnlHistorialVentas.BorderThickness = 1;
            this.pnlHistorialVentas.Controls.Add(this.dgvMisVentas);
            this.pnlHistorialVentas.Controls.Add(this.lblTituloHistorialVentas);
            this.pnlHistorialVentas.FillColor = System.Drawing.Color.Transparent;
            this.pnlHistorialVentas.Location = new System.Drawing.Point(5, 257);
            this.pnlHistorialVentas.Name = "pnlHistorialVentas";
            this.pnlHistorialVentas.Size = new System.Drawing.Size(1151, 370);
            this.pnlHistorialVentas.TabIndex = 61;
            // 
            // dgvMisVentas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvMisVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMisVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMisVentas.ColumnHeadersHeight = 25;
            this.dgvMisVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroVenta,
            this.colDniCliente,
            this.colCliente,
            this.colMetodoPago,
            this.colTipoAjuste,
            this.colFechaVenta,
            this.colTotal,
            this.colEstado,
            this.colCambiarEstado,
            this.colVerDetalle});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMisVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMisVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMisVentas.Location = new System.Drawing.Point(3, 41);
            this.dgvMisVentas.Name = "dgvMisVentas";
            this.dgvMisVentas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMisVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMisVentas.RowTemplate.Height = 25;
            this.dgvMisVentas.Size = new System.Drawing.Size(1143, 283);
            this.dgvMisVentas.TabIndex = 7;
            this.dgvMisVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvMisVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvMisVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMisVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMisVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMisVentas.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvMisVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMisVentas.ThemeStyle.RowsStyle.Height = 25;
            this.dgvMisVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvMisVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisVentas_CellContentClick);
            this.dgvMisVentas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMisVentas_CellFormatting);
            // 
            // colNroVenta
            // 
            this.colNroVenta.FillWeight = 60F;
            this.colNroVenta.HeaderText = "Nro Venta";
            this.colNroVenta.Name = "colNroVenta";
            // 
            // colDniCliente
            // 
            this.colDniCliente.FillWeight = 60F;
            this.colDniCliente.HeaderText = "DNI Cliente";
            this.colDniCliente.Name = "colDniCliente";
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 150F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Metodo Pago";
            this.colMetodoPago.Name = "colMetodoPago";
            // 
            // colTipoAjuste
            // 
            this.colTipoAjuste.HeaderText = "Tipo Ajuste";
            this.colTipoAjuste.Name = "colTipoAjuste";
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.FillWeight = 70F;
            this.colFechaVenta.HeaderText = "Fecha Venta";
            this.colFechaVenta.Name = "colFechaVenta";
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 70F;
            this.colTotal.HeaderText = "Total ($)";
            this.colTotal.Name = "colTotal";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colCambiarEstado
            // 
            this.colCambiarEstado.FillWeight = 80F;
            this.colCambiarEstado.HeaderText = "Anular/Activar";
            this.colCambiarEstado.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colCambiarEstado.Name = "colCambiarEstado";
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.FillWeight = 60F;
            this.colVerDetalle.HeaderText = "Ver Detalle";
            this.colVerDetalle.Image = global::CapaPresentacion.Properties.Resources.icono_editar;
            this.colVerDetalle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroEstado);
            this.pnlContenedorFiltros.Controls.Add(this.label1);
            this.pnlContenedorFiltros.Controls.Add(this.dtpHasta);
            this.pnlContenedorFiltros.Controls.Add(this.dtpDesde);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarHasta);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarDesde);
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrar);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroMetodoPago);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarClienteDni);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorDNI);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarMetodoPago);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(5, 67);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(681, 178);
            this.pnlContenedorFiltros.TabIndex = 62;
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroEstado.BorderColor = System.Drawing.Color.DimGray;
            this.cmbFiltroEstado.BorderRadius = 5;
            this.cmbFiltroEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFiltroEstado.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroEstado.ItemHeight = 21;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "Todos",
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(250, 135);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(150, 27);
            this.cmbFiltroEstado.StartIndex = 0;
            this.cmbFiltroEstado.TabIndex = 53;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Estado";
            // 
            // dtpHasta
            // 
            this.dtpHasta.BorderRadius = 5;
            this.dtpHasta.Checked = true;
            this.dtpHasta.FillColor = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(426, 40);
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
            this.dtpDesde.Location = new System.Drawing.Point(291, 40);
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
            this.lblFiltrarHasta.Location = new System.Drawing.Point(470, 20);
            this.lblFiltrarHasta.Name = "lblFiltrarHasta";
            this.lblFiltrarHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFiltrarHasta.TabIndex = 47;
            this.lblFiltrarHasta.Text = "Hasta";
            // 
            // lblFiltrarDesde
            // 
            this.lblFiltrarDesde.AutoSize = true;
            this.lblFiltrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarDesde.Location = new System.Drawing.Point(329, 20);
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
            this.btnFiltrar.Location = new System.Drawing.Point(572, 40);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(89, 27);
            this.btnFiltrar.TabIndex = 45;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbFiltroMetodoPago
            // 
            this.cmbFiltroMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroMetodoPago.BorderColor = System.Drawing.Color.DimGray;
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
            this.cmbFiltroMetodoPago.Size = new System.Drawing.Size(187, 27);
            this.cmbFiltroMetodoPago.StartIndex = 0;
            this.cmbFiltroMetodoPago.TabIndex = 22;
            this.cmbFiltroMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroMetodoPago_SelectedIndexChanged);
            // 
            // txtBuscarClienteDni
            // 
            this.txtBuscarClienteDni.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscarClienteDni.BorderRadius = 5;
            this.txtBuscarClienteDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarClienteDni.DefaultText = "";
            this.txtBuscarClienteDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarClienteDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarClienteDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarClienteDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarClienteDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarClienteDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarClienteDni.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarClienteDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarClienteDni.IconLeft = global::CapaPresentacion.Properties.Resources.icono_lupa;
            this.txtBuscarClienteDni.Location = new System.Drawing.Point(16, 40);
            this.txtBuscarClienteDni.Name = "txtBuscarClienteDni";
            this.txtBuscarClienteDni.PlaceholderText = "";
            this.txtBuscarClienteDni.SelectedText = "";
            this.txtBuscarClienteDni.Size = new System.Drawing.Size(242, 27);
            this.txtBuscarClienteDni.TabIndex = 0;
            this.txtBuscarClienteDni.TextChanged += new System.EventHandler(this.txtBuscarClienteDni_TextChanged);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlnfoUsuario
            // 
            this.pnlnfoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnfoUsuario.Controls.Add(this.lblIniciales);
            this.pnlnfoUsuario.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlnfoUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlnfoUsuario.Controls.Add(this.lblRolUsuario);
            this.pnlnfoUsuario.Location = new System.Drawing.Point(943, 4);
            this.pnlnfoUsuario.Name = "pnlnfoUsuario";
            this.pnlnfoUsuario.Size = new System.Drawing.Size(215, 55);
            this.pnlnfoUsuario.TabIndex = 14;
            // 
            // lblIniciales
            // 
            this.lblIniciales.BackColor = System.Drawing.Color.Black;
            this.lblIniciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIniciales.Location = new System.Drawing.Point(12, 10);
            this.lblIniciales.Name = "lblIniciales";
            this.lblIniciales.Size = new System.Drawing.Size(31, 26);
            this.lblIniciales.TabIndex = 12;
            this.lblIniciales.Text = "AA";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::CapaPresentacion.Properties.Resources.Fondo_negro;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(49, 50);
            this.guna2CirclePictureBox1.TabIndex = 12;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(58, 11);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(95, 17);
            this.lblNombreUsuario.TabIndex = 11;
            this.lblNombreUsuario.Text = "Perez, Juan";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuario.Location = new System.Drawing.Point(58, 31);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(83, 15);
            this.lblRolUsuario.TabIndex = 11;
            this.lblRolUsuario.Text = "Administrador";
            // 
            // MisVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 561);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Controls.Add(this.pnlHistorialVentas);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "MisVentasForm";
            this.Text = "MisVentasForm";
            this.Load += new System.EventHandler(this.MisVentasForm_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlHistorialVentas.ResumeLayout(false);
            this.pnlHistorialVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisVentas)).EndInit();
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlHistorialVentas;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMisVentas;
        private System.Windows.Forms.Label lblTituloHistorialVentas;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroMetodoPago;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarClienteDni;
        private System.Windows.Forms.Label lblBuscarPorDNI;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltrarMetodoPago;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoAjuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewImageColumn colCambiarEstado;
        private System.Windows.Forms.DataGridViewImageColumn colVerDetalle;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIniciales;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
    }
}