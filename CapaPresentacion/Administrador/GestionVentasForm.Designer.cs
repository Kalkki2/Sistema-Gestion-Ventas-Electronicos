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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNroVentaDetalle = new System.Windows.Forms.Label();
            this.lblTituloDetalleVenta = new System.Windows.Forms.Label();
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
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlContenedorDetalleVenta = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDetalleVenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCardTotalVentas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblCantTotalVentas = new System.Windows.Forms.Label();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlContenedorHistorialVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).BeginInit();
            this.pnlContenedorDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.pnlCardTotalVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(538, 155);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(89, 26);
            this.btnFiltrarPorFecha.TabIndex = 31;
            this.btnFiltrarPorFecha.Text = "Filtrar";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(404, 160);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(114, 20);
            this.dtpHasta.TabIndex = 30;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(233, 160);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(114, 20);
            this.dtpDesde.TabIndex = 29;
            // 
            // lblFiltrarHasta
            // 
            this.lblFiltrarHasta.AutoSize = true;
            this.lblFiltrarHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarHasta.Location = new System.Drawing.Point(353, 160);
            this.lblFiltrarHasta.Name = "lblFiltrarHasta";
            this.lblFiltrarHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFiltrarHasta.TabIndex = 12;
            this.lblFiltrarHasta.Text = "Hasta";
            // 
            // lblFiltrarDesde
            // 
            this.lblFiltrarDesde.AutoSize = true;
            this.lblFiltrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarDesde.Location = new System.Drawing.Point(178, 163);
            this.lblFiltrarDesde.Name = "lblFiltrarDesde";
            this.lblFiltrarDesde.Size = new System.Drawing.Size(49, 17);
            this.lblFiltrarDesde.TabIndex = 11;
            this.lblFiltrarDesde.Text = "Desde";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(367, 298);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(99, 29);
            this.lblPrecioTotal.TabIndex = 20;
            this.lblPrecioTotal.Text = "$XXXX";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(306, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 17);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total: ";
            // 
            // lblNroVentaDetalle
            // 
            this.lblNroVentaDetalle.AutoSize = true;
            this.lblNroVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVentaDetalle.Location = new System.Drawing.Point(208, 8);
            this.lblNroVentaDetalle.Name = "lblNroVentaDetalle";
            this.lblNroVentaDetalle.Size = new System.Drawing.Size(85, 29);
            this.lblNroVentaDetalle.TabIndex = 18;
            this.lblNroVentaDetalle.Text = "XXXX";
            // 
            // lblTituloDetalleVenta
            // 
            this.lblTituloDetalleVenta.AutoSize = true;
            this.lblTituloDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleVenta.Location = new System.Drawing.Point(16, 14);
            this.lblTituloDetalleVenta.Name = "lblTituloDetalleVenta";
            this.lblTituloDetalleVenta.Size = new System.Drawing.Size(186, 17);
            this.lblTituloDetalleVenta.TabIndex = 10;
            this.lblTituloDetalleVenta.Text = "Detalle de la venta Nro: ";
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
            this.pnlContenedorHistorialVentas.Location = new System.Drawing.Point(8, 187);
            this.pnlContenedorHistorialVentas.Name = "pnlContenedorHistorialVentas";
            this.pnlContenedorHistorialVentas.Size = new System.Drawing.Size(648, 328);
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
            this.btnExportarPDF.Location = new System.Drawing.Point(363, 8);
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
            this.btnExportarEXCEL.Location = new System.Drawing.Point(503, 8);
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
            this.colFechaVenta,
            this.colMetodoPago,
            this.colCliente,
            this.colVendedor,
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
            this.dgvHistorialVentas.Size = new System.Drawing.Size(641, 246);
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
            // lblTituloHistorialVentas
            // 
            this.lblTituloHistorialVentas.AutoSize = true;
            this.lblTituloHistorialVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloHistorialVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorialVentas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloHistorialVentas.Location = new System.Drawing.Point(5, 15);
            this.lblTituloHistorialVentas.Name = "lblTituloHistorialVentas";
            this.lblTituloHistorialVentas.Size = new System.Drawing.Size(112, 16);
            this.lblTituloHistorialVentas.TabIndex = 6;
            this.lblTituloHistorialVentas.Text = "Lista de ventas";
            // 
            // colNroVenta
            // 
            this.colNroVenta.HeaderText = "Nro Venta";
            this.colNroVenta.Name = "colNroVenta";
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.HeaderText = "Fecha Venta";
            this.colFechaVenta.Name = "colFechaVenta";
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Metodo Pago";
            this.colMetodoPago.Name = "colMetodoPago";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colVendedor
            // 
            this.colVendedor.HeaderText = "Vendedor";
            this.colVendedor.Name = "colVendedor";
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
            // pnlContenedorDetalleVenta
            // 
            this.pnlContenedorDetalleVenta.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorDetalleVenta.BorderRadius = 8;
            this.pnlContenedorDetalleVenta.BorderThickness = 1;
            this.pnlContenedorDetalleVenta.Controls.Add(this.dgvDetalleVenta);
            this.pnlContenedorDetalleVenta.Controls.Add(this.lblTituloDetalleVenta);
            this.pnlContenedorDetalleVenta.Controls.Add(this.lblPrecioTotal);
            this.pnlContenedorDetalleVenta.Controls.Add(this.lblTotal);
            this.pnlContenedorDetalleVenta.Controls.Add(this.lblNroVentaDetalle);
            this.pnlContenedorDetalleVenta.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorDetalleVenta.Location = new System.Drawing.Point(663, 187);
            this.pnlContenedorDetalleVenta.Name = "pnlContenedorDetalleVenta";
            this.pnlContenedorDetalleVenta.Size = new System.Drawing.Size(475, 328);
            this.pnlContenedorDetalleVenta.TabIndex = 61;
            // 
            // dgvDetalleVenta
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleVenta.Location = new System.Drawing.Point(4, 49);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.RowTemplate.Height = 23;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(468, 246);
            this.dgvDetalleVenta.TabIndex = 7;
            this.dgvDetalleVenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.Height = 23;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nro Venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // pnlCardTotalVentas
            // 
            this.pnlCardTotalVentas.BorderRadius = 10;
            this.pnlCardTotalVentas.Controls.Add(this.lblCantTotalVentas);
            this.pnlCardTotalVentas.Controls.Add(this.lblTituloTotalVentas);
            this.pnlCardTotalVentas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.pnlCardTotalVentas.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(240)))));
            this.pnlCardTotalVentas.Location = new System.Drawing.Point(8, 67);
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
            // GestionVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 561);
            this.Controls.Add(this.pnlCardTotalVentas);
            this.Controls.Add(this.pnlContenedorDetalleVenta);
            this.Controls.Add(this.pnlContenedorHistorialVentas);
            this.Controls.Add(this.btnFiltrarPorFecha);
            this.Controls.Add(this.lblFiltrarDesde);
            this.Controls.Add(this.lblFiltrarHasta);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Name = "GestionVentasForm";
            this.Text = "GestionVentasForm";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlContenedorHistorialVentas.ResumeLayout(false);
            this.pnlContenedorHistorialVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialVentas)).EndInit();
            this.pnlContenedorDetalleVenta.ResumeLayout(false);
            this.pnlContenedorDetalleVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.pnlCardTotalVentas.ResumeLayout(false);
            this.pnlCardTotalVentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private System.Windows.Forms.Label lblNroVentaDetalle;
        private System.Windows.Forms.Label lblTituloDetalleVenta;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colVerDetalle;
        private System.Windows.Forms.Label lblTituloHistorialVentas;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorDetalleVenta;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlCardTotalVentas;
        private System.Windows.Forms.Label lblCantTotalVentas;
        private System.Windows.Forms.Label lblTituloTotalVentas;
    }
}