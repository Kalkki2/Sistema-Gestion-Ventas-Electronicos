namespace CapaPresentacion.Administrador
{
    partial class GestionVentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVentasForm));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorHistorialVentas = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExportarPDF = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportarEXCEL = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHistorialVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTituloHistorialVentas = new System.Windows.Forms.Label();
            this.pnlCardTotalVentas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblCantTotalVentas = new System.Windows.Forms.Label();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtpHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarVendedor = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFiltroMetodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarVendedorDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarPorDNI = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltrarMetodoPago = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAplicarAjusteFormaPago = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPorcentajeAjuste = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoAjuste = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDniVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoAjuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlContenedorHistorialVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.pnlCardTotalVentas.SuspendLayout();
            this.pnlContenedorFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeAjuste)).BeginInit();
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
            this.pnlEncabezado.Size = new System.Drawing.Size(1222, 64);
            this.pnlEncabezado.TabIndex = 20;
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
            this.lblTitulo.Size = new System.Drawing.Size(204, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gestion de ventas";
            // 
            // pnlContenedorHistorialVentas
            // 
            this.pnlContenedorHistorialVentas.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorHistorialVentas.BorderRadius = 8;
            this.pnlContenedorHistorialVentas.BorderThickness = 1;
            this.pnlContenedorHistorialVentas.Controls.Add(this.btnExportarPDF);
            this.pnlContenedorHistorialVentas.Controls.Add(this.btnExportarEXCEL);
            this.pnlContenedorHistorialVentas.Controls.Add(this.dgvHistorialVentas);
            this.pnlContenedorHistorialVentas.Controls.Add(this.lblTituloHistorialVentas);
            this.pnlContenedorHistorialVentas.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorHistorialVentas.Location = new System.Drawing.Point(12, 276);
            this.pnlContenedorHistorialVentas.Name = "pnlContenedorHistorialVentas";
            this.pnlContenedorHistorialVentas.Size = new System.Drawing.Size(1132, 312);
            this.pnlContenedorHistorialVentas.TabIndex = 60;
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarPDF.BorderColor = System.Drawing.Color.Red;
            this.btnExportarPDF.BorderRadius = 5;
            this.btnExportarPDF.BorderThickness = 1;
            this.btnExportarPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportarPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportarPDF.FillColor = System.Drawing.SystemColors.Control;
            this.btnExportarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.ForeColor = System.Drawing.Color.Red;
            this.btnExportarPDF.Image = global::CapaPresentacion.Properties.Resources.Gemini_Generated_Image_59msj059msj059ms;
            this.btnExportarPDF.ImageSize = new System.Drawing.Size(21, 25);
            this.btnExportarPDF.Location = new System.Drawing.Point(417, 8);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(125, 35);
            this.btnExportarPDF.TabIndex = 10;
            this.btnExportarPDF.Text = "Exportar PDF";
            // 
            // btnExportarEXCEL
            // 
            this.btnExportarEXCEL.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarEXCEL.BorderColor = System.Drawing.Color.Green;
            this.btnExportarEXCEL.BorderRadius = 5;
            this.btnExportarEXCEL.BorderThickness = 1;
            this.btnExportarEXCEL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarEXCEL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarEXCEL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportarEXCEL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportarEXCEL.FillColor = System.Drawing.SystemColors.Control;
            this.btnExportarEXCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarEXCEL.ForeColor = System.Drawing.Color.Green;
            this.btnExportarEXCEL.Image = global::CapaPresentacion.Properties.Resources.icono_excel;
            this.btnExportarEXCEL.ImageSize = new System.Drawing.Size(21, 25);
            this.btnExportarEXCEL.Location = new System.Drawing.Point(557, 8);
            this.btnExportarEXCEL.Name = "btnExportarEXCEL";
            this.btnExportarEXCEL.Size = new System.Drawing.Size(125, 35);
            this.btnExportarEXCEL.TabIndex = 9;
            this.btnExportarEXCEL.Text = "Exportar Excel";
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
            this.colDniCliente,
            this.colCliente,
            this.colDniVendedor,
            this.colVendedor,
            this.colMetodoPago,
            this.colTipoAjuste,
            this.colTotal,
            this.colFechaVenta,
            this.colEstado,
            this.colVerDetalle});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorialVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistorialVentas.Location = new System.Drawing.Point(4, 49);
            this.dgvHistorialVentas.Name = "dgvHistorialVentas";
            this.dgvHistorialVentas.RowHeadersVisible = false;
            this.dgvHistorialVentas.RowTemplate.Height = 23;
            this.dgvHistorialVentas.Size = new System.Drawing.Size(1113, 246);
            this.dgvHistorialVentas.TabIndex = 7;
            this.dgvHistorialVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialVentas.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvHistorialVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialVentas.ThemeStyle.RowsStyle.Height = 23;
            this.dgvHistorialVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvHistorialVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialVentas_CellContentClick);
            // 
            // lblTituloHistorialVentas
            // 
            this.lblTituloHistorialVentas.AutoSize = true;
            this.lblTituloHistorialVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloHistorialVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorialVentas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloHistorialVentas.Location = new System.Drawing.Point(5, 15);
            this.lblTituloHistorialVentas.Name = "lblTituloHistorialVentas";
            this.lblTituloHistorialVentas.Size = new System.Drawing.Size(137, 16);
            this.lblTituloHistorialVentas.TabIndex = 6;
            this.lblTituloHistorialVentas.Text = "Historial de ventas";
            // 
            // pnlCardTotalVentas
            // 
            this.pnlCardTotalVentas.BorderRadius = 10;
            this.pnlCardTotalVentas.Controls.Add(this.lblCantTotalVentas);
            this.pnlCardTotalVentas.Controls.Add(this.lblTituloTotalVentas);
            this.pnlCardTotalVentas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.pnlCardTotalVentas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(240)))));
            this.pnlCardTotalVentas.Location = new System.Drawing.Point(557, 67);
            this.pnlCardTotalVentas.Name = "pnlCardTotalVentas";
            this.pnlCardTotalVentas.Size = new System.Drawing.Size(174, 80);
            this.pnlCardTotalVentas.TabIndex = 62;
            // 
            // lblCantTotalVentas
            // 
            this.lblCantTotalVentas.AutoSize = true;
            this.lblCantTotalVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblCantTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblCantTotalVentas.Location = new System.Drawing.Point(23, 36);
            this.lblCantTotalVentas.Name = "lblCantTotalVentas";
            this.lblCantTotalVentas.Size = new System.Drawing.Size(32, 33);
            this.lblCantTotalVentas.TabIndex = 19;
            this.lblCantTotalVentas.Text = "0";
            // 
            // lblTituloTotalVentas
            // 
            this.lblTituloTotalVentas.AutoSize = true;
            this.lblTituloTotalVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblTituloTotalVentas.Location = new System.Drawing.Point(3, 16);
            this.lblTituloTotalVentas.Name = "lblTituloTotalVentas";
            this.lblTituloTotalVentas.Size = new System.Drawing.Size(99, 16);
            this.lblTituloTotalVentas.TabIndex = 5;
            this.lblTituloTotalVentas.Text = "Total Ventas:";
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.dtpHasta);
            this.pnlContenedorFiltros.Controls.Add(this.dtpDesde);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarHasta);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarDesde);
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrar);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarVendedor);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroMetodoPago);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarVendedorDni);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorDNI);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarMetodoPago);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(9, 67);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.Radius = 5;
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowDepth = 25;
            this.pnlContenedorFiltros.ShadowShift = 3;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(542, 178);
            this.pnlContenedorFiltros.TabIndex = 63;
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
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(448, 135);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(89, 27);
            this.btnFiltrar.TabIndex = 45;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarVendedor.BorderRadius = 5;
            this.btnBuscarVendedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarVendedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarVendedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarVendedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarVendedor.FillColor = System.Drawing.Color.Silver;
            this.btnBuscarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscarVendedor.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarVendedor.Image")));
            this.btnBuscarVendedor.Location = new System.Drawing.Point(218, 40);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(89, 27);
            this.btnBuscarVendedor.TabIndex = 44;
            this.btnBuscarVendedor.Text = "Buscar";
            this.btnBuscarVendedor.Click += new System.EventHandler(this.btnBuscarVendedor_Click);
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
            // txtBuscarVendedorDni
            // 
            this.txtBuscarVendedorDni.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarVendedorDni.BorderRadius = 5;
            this.txtBuscarVendedorDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarVendedorDni.DefaultText = "";
            this.txtBuscarVendedorDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarVendedorDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarVendedorDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarVendedorDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarVendedorDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarVendedorDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarVendedorDni.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarVendedorDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarVendedorDni.Location = new System.Drawing.Point(16, 40);
            this.txtBuscarVendedorDni.Name = "txtBuscarVendedorDni";
            this.txtBuscarVendedorDni.PlaceholderText = "";
            this.txtBuscarVendedorDni.SelectedText = "";
            this.txtBuscarVendedorDni.Size = new System.Drawing.Size(182, 27);
            this.txtBuscarVendedorDni.TabIndex = 0;
            this.txtBuscarVendedorDni.Validating += new System.ComponentModel.CancelEventHandler(this.txtBuscarVendedor_Validating);
            // 
            // lblBuscarPorDNI
            // 
            this.lblBuscarPorDNI.AutoSize = true;
            this.lblBuscarPorDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorDNI.Location = new System.Drawing.Point(12, 20);
            this.lblBuscarPorDNI.Name = "lblBuscarPorDNI";
            this.lblBuscarPorDNI.Size = new System.Drawing.Size(197, 17);
            this.lblBuscarPorDNI.TabIndex = 21;
            this.lblBuscarPorDNI.Text = "Buscar por DNI del Vendedor:";
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
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnCancelar);
            this.guna2ShadowPanel1.Controls.Add(this.btnAplicarAjusteFormaPago);
            this.guna2ShadowPanel1.Controls.Add(this.label13);
            this.guna2ShadowPanel1.Controls.Add(this.txtPorcentajeAjuste);
            this.guna2ShadowPanel1.Controls.Add(this.label10);
            this.guna2ShadowPanel1.Controls.Add(this.cmbTipoAjuste);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.cmbMetodoPago);
            this.guna2ShadowPanel1.Controls.Add(this.label12);
            this.guna2ShadowPanel1.Controls.Add(this.label14);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(737, 67);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 25;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(431, 181);
            this.guna2ShadowPanel1.TabIndex = 64;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.Silver;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(185, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 27);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAplicarAjusteFormaPago
            // 
            this.btnAplicarAjusteFormaPago.BackColor = System.Drawing.Color.Transparent;
            this.btnAplicarAjusteFormaPago.BorderRadius = 5;
            this.btnAplicarAjusteFormaPago.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicarAjusteFormaPago.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAplicarAjusteFormaPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAplicarAjusteFormaPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAplicarAjusteFormaPago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnAplicarAjusteFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAplicarAjusteFormaPago.ForeColor = System.Drawing.Color.White;
            this.btnAplicarAjusteFormaPago.Location = new System.Drawing.Point(297, 135);
            this.btnAplicarAjusteFormaPago.Name = "btnAplicarAjusteFormaPago";
            this.btnAplicarAjusteFormaPago.Size = new System.Drawing.Size(117, 27);
            this.btnAplicarAjusteFormaPago.TabIndex = 52;
            this.btnAplicarAjusteFormaPago.Text = "Aplicar Ajuste";
            this.btnAplicarAjusteFormaPago.Click += new System.EventHandler(this.btnAplicarAjusteFormaPago_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(398, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 20);
            this.label13.TabIndex = 111;
            this.label13.Text = "%";
            // 
            // txtPorcentajeAjuste
            // 
            this.txtPorcentajeAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeAjuste.Location = new System.Drawing.Point(279, 84);
            this.txtPorcentajeAjuste.Name = "txtPorcentajeAjuste";
            this.txtPorcentajeAjuste.ReadOnly = true;
            this.txtPorcentajeAjuste.Size = new System.Drawing.Size(113, 26);
            this.txtPorcentajeAjuste.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(282, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Porcentaje(%)";
            // 
            // cmbTipoAjuste
            // 
            this.cmbTipoAjuste.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoAjuste.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbTipoAjuste.BorderRadius = 5;
            this.cmbTipoAjuste.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAjuste.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoAjuste.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbTipoAjuste.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoAjuste.ItemHeight = 21;
            this.cmbTipoAjuste.Items.AddRange(new object[] {
            "Descuento",
            "Recargo",
            "Sin Ajuste"});
            this.cmbTipoAjuste.Location = new System.Drawing.Point(142, 84);
            this.cmbTipoAjuste.Name = "cmbTipoAjuste";
            this.cmbTipoAjuste.Size = new System.Drawing.Size(118, 27);
            this.cmbTipoAjuste.StartIndex = 0;
            this.cmbTipoAjuste.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tipo Ajuste";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.cmbMetodoPago.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbMetodoPago.BorderRadius = 5;
            this.cmbMetodoPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMetodoPago.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.cmbMetodoPago.ItemHeight = 21;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(17, 84);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(118, 27);
            this.cmbMetodoPago.StartIndex = 0;
            this.cmbMetodoPago.TabIndex = 22;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(393, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Configuaracion  de Descuento y Recargo por Forma de pago";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Metodo Pago";
            // 
            // colNroVenta
            // 
            this.colNroVenta.HeaderText = "Nro Venta";
            this.colNroVenta.Name = "colNroVenta";
            this.colNroVenta.Visible = false;
            // 
            // colDniCliente
            // 
            this.colDniCliente.HeaderText = "DNI Cliente";
            this.colDniCliente.Name = "colDniCliente";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colDniVendedor
            // 
            this.colDniVendedor.HeaderText = "DNI Vendedor";
            this.colDniVendedor.Name = "colDniVendedor";
            // 
            // colVendedor
            // 
            this.colVendedor.HeaderText = "Vendedor";
            this.colVendedor.Name = "colVendedor";
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
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.HeaderText = "Fecha Venta";
            this.colFechaVenta.Name = "colFechaVenta";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.HeaderText = "VerDetalles";
            this.colVerDetalle.Name = "colVerDetalle";
            // 
            // GestionVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 561);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.pnlCardTotalVentas);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Controls.Add(this.pnlContenedorHistorialVentas);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "GestionVentasForm";
            this.Text = "GestionVentasForm";
            this.Load += new System.EventHandler(this.GestionVentasForm_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlContenedorHistorialVentas.ResumeLayout(false);
            this.pnlContenedorHistorialVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.pnlCardTotalVentas.ResumeLayout(false);
            this.pnlCardTotalVentas.PerformLayout();
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeAjuste)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorHistorialVentas;
        private Guna.UI2.WinForms.Guna2Button btnExportarPDF;
        private Guna.UI2.WinForms.Guna2Button btnExportarEXCEL;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorialVentas;
        private System.Windows.Forms.Label lblTituloHistorialVentas;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCardTotalVentas;
        private System.Windows.Forms.Label lblCantTotalVentas;
        private System.Windows.Forms.Label lblTituloTotalVentas;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarVendedor;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroMetodoPago;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarVendedorDni;
        private System.Windows.Forms.Label lblBuscarPorDNI;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltrarMetodoPago;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoAjuste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnAplicarAjusteFormaPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txtPorcentajeAjuste;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoAjuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colVerDetalle;
    }
}