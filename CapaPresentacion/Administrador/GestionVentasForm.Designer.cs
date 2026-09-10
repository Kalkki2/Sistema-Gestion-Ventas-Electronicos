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
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloHistorialVenta = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNroVentaDetalle = new System.Windows.Forms.Label();
            this.dgvListaDetalle = new System.Windows.Forms.DataGridView();
            this.colDetalleNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetallePrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloDetalleVenta = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCardTotalVentas = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCantTotalVentas = new System.Windows.Forms.Label();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.pnlContenedorVentas = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContenedorDetallesVentas = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlCardTotalVentas.SuspendLayout();
            this.pnlContenedorVentas.SuspendLayout();
            this.pnlContenedorDetallesVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(457, 55);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(89, 26);
            this.btnFiltrarPorFecha.TabIndex = 31;
            this.btnFiltrarPorFecha.Text = "Filtrar";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(323, 60);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(114, 20);
            this.dtpHasta.TabIndex = 30;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(152, 60);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(114, 20);
            this.dtpDesde.TabIndex = 29;
            // 
            // lblFiltrarHasta
            // 
            this.lblFiltrarHasta.AutoSize = true;
            this.lblFiltrarHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarHasta.Location = new System.Drawing.Point(272, 60);
            this.lblFiltrarHasta.Name = "lblFiltrarHasta";
            this.lblFiltrarHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFiltrarHasta.TabIndex = 12;
            this.lblFiltrarHasta.Text = "Hasta";
            // 
            // lblFiltrarDesde
            // 
            this.lblFiltrarDesde.AutoSize = true;
            this.lblFiltrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarDesde.Location = new System.Drawing.Point(97, 63);
            this.lblFiltrarDesde.Name = "lblFiltrarDesde";
            this.lblFiltrarDesde.Size = new System.Drawing.Size(49, 17);
            this.lblFiltrarDesde.TabIndex = 11;
            this.lblFiltrarDesde.Text = "Desde";
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroVenta,
            this.colFechaVenta,
            this.colMetodoPago,
            this.colCliente,
            this.colVendedor,
            this.colDetalles});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaVentas.Location = new System.Drawing.Point(7, 101);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.RowHeadersVisible = false;
            this.dgvListaVentas.Size = new System.Drawing.Size(632, 75);
            this.dgvListaVentas.TabIndex = 1;
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
            this.colFechaVenta.Width = 110;
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Metodo Pago";
            this.colMetodoPago.Name = "colMetodoPago";
            this.colMetodoPago.Width = 120;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colVendedor
            // 
            this.colVendedor.HeaderText = "Vendendor";
            this.colVendedor.Name = "colVendedor";
            // 
            // colDetalles
            // 
            this.colDetalles.HeaderText = "Ver detalle";
            this.colDetalles.Name = "colDetalles";
            // 
            // lblTituloHistorialVenta
            // 
            this.lblTituloHistorialVenta.AutoSize = true;
            this.lblTituloHistorialVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorialVenta.Location = new System.Drawing.Point(6, 10);
            this.lblTituloHistorialVenta.Name = "lblTituloHistorialVenta";
            this.lblTituloHistorialVenta.Size = new System.Drawing.Size(140, 17);
            this.lblTituloHistorialVenta.TabIndex = 9;
            this.lblTituloHistorialVenta.Text = "Historia de ventas";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(421, 256);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(99, 29);
            this.lblPrecioTotal.TabIndex = 20;
            this.lblPrecioTotal.Text = "$XXXX";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(360, 266);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 17);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total: ";
            // 
            // lblNroVentaDetalle
            // 
            this.lblNroVentaDetalle.AutoSize = true;
            this.lblNroVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVentaDetalle.Location = new System.Drawing.Point(195, 14);
            this.lblNroVentaDetalle.Name = "lblNroVentaDetalle";
            this.lblNroVentaDetalle.Size = new System.Drawing.Size(85, 29);
            this.lblNroVentaDetalle.TabIndex = 18;
            this.lblNroVentaDetalle.Text = "XXXX";
            // 
            // dgvListaDetalle
            // 
            this.dgvListaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetalleNroVenta,
            this.colDetalleProducto,
            this.colDetalleCantidad,
            this.colDetallePrecio,
            this.colDetalleSubtotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaDetalle.Location = new System.Drawing.Point(3, 55);
            this.dgvListaDetalle.Name = "dgvListaDetalle";
            this.dgvListaDetalle.RowHeadersVisible = false;
            this.dgvListaDetalle.Size = new System.Drawing.Size(489, 75);
            this.dgvListaDetalle.TabIndex = 11;
            // 
            // colDetalleNroVenta
            // 
            this.colDetalleNroVenta.HeaderText = "Nro Venta";
            this.colDetalleNroVenta.Name = "colDetalleNroVenta";
            this.colDetalleNroVenta.Width = 90;
            // 
            // colDetalleProducto
            // 
            this.colDetalleProducto.FillWeight = 120F;
            this.colDetalleProducto.HeaderText = "Producto";
            this.colDetalleProducto.Name = "colDetalleProducto";
            this.colDetalleProducto.Width = 123;
            // 
            // colDetalleCantidad
            // 
            this.colDetalleCantidad.HeaderText = "Cantidad";
            this.colDetalleCantidad.Name = "colDetalleCantidad";
            this.colDetalleCantidad.Width = 75;
            // 
            // colDetallePrecio
            // 
            this.colDetallePrecio.HeaderText = "Precio";
            this.colDetallePrecio.Name = "colDetallePrecio";
            // 
            // colDetalleSubtotal
            // 
            this.colDetalleSubtotal.HeaderText = "Subtotal";
            this.colDetalleSubtotal.Name = "colDetalleSubtotal";
            // 
            // lblTituloDetalleVenta
            // 
            this.lblTituloDetalleVenta.AutoSize = true;
            this.lblTituloDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleVenta.Location = new System.Drawing.Point(3, 24);
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
            // pnlCardTotalVentas
            // 
            this.pnlCardTotalVentas.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardTotalVentas.Controls.Add(this.lblCantTotalVentas);
            this.pnlCardTotalVentas.Controls.Add(this.lblTituloTotalVentas);
            this.pnlCardTotalVentas.FillColor = System.Drawing.Color.White;
            this.pnlCardTotalVentas.Location = new System.Drawing.Point(19, 67);
            this.pnlCardTotalVentas.Name = "pnlCardTotalVentas";
            this.pnlCardTotalVentas.Radius = 7;
            this.pnlCardTotalVentas.ShadowColor = System.Drawing.Color.Black;
            this.pnlCardTotalVentas.ShadowDepth = 50;
            this.pnlCardTotalVentas.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlCardTotalVentas.Size = new System.Drawing.Size(190, 86);
            this.pnlCardTotalVentas.TabIndex = 25;
            // 
            // lblCantTotalVentas
            // 
            this.lblCantTotalVentas.AutoSize = true;
            this.lblCantTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalVentas.Location = new System.Drawing.Point(10, 36);
            this.lblCantTotalVentas.Name = "lblCantTotalVentas";
            this.lblCantTotalVentas.Size = new System.Drawing.Size(41, 29);
            this.lblCantTotalVentas.TabIndex = 18;
            this.lblCantTotalVentas.Text = "12";
            // 
            // lblTituloTotalVentas
            // 
            this.lblTituloTotalVentas.AutoSize = true;
            this.lblTituloTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalVentas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloTotalVentas.Location = new System.Drawing.Point(12, 14);
            this.lblTituloTotalVentas.Name = "lblTituloTotalVentas";
            this.lblTituloTotalVentas.Size = new System.Drawing.Size(90, 15);
            this.lblTituloTotalVentas.TabIndex = 19;
            this.lblTituloTotalVentas.Text = "Total Ventas:";
            // 
            // pnlContenedorVentas
            // 
            this.pnlContenedorVentas.BorderColor = System.Drawing.Color.Gray;
            this.pnlContenedorVentas.BorderRadius = 5;
            this.pnlContenedorVentas.BorderThickness = 1;
            this.pnlContenedorVentas.Controls.Add(this.dgvListaVentas);
            this.pnlContenedorVentas.Controls.Add(this.btnFiltrarPorFecha);
            this.pnlContenedorVentas.Controls.Add(this.lblFiltrarDesde);
            this.pnlContenedorVentas.Controls.Add(this.lblFiltrarHasta);
            this.pnlContenedorVentas.Controls.Add(this.lblTituloHistorialVenta);
            this.pnlContenedorVentas.Controls.Add(this.dtpHasta);
            this.pnlContenedorVentas.Controls.Add(this.dtpDesde);
            this.pnlContenedorVentas.Location = new System.Drawing.Point(12, 187);
            this.pnlContenedorVentas.Name = "pnlContenedorVentas";
            this.pnlContenedorVentas.Size = new System.Drawing.Size(644, 302);
            this.pnlContenedorVentas.TabIndex = 32;
            // 
            // pnlContenedorDetallesVentas
            // 
            this.pnlContenedorDetallesVentas.BorderColor = System.Drawing.Color.Gray;
            this.pnlContenedorDetallesVentas.BorderRadius = 5;
            this.pnlContenedorDetallesVentas.BorderThickness = 1;
            this.pnlContenedorDetallesVentas.Controls.Add(this.dgvListaDetalle);
            this.pnlContenedorDetallesVentas.Controls.Add(this.lblPrecioTotal);
            this.pnlContenedorDetallesVentas.Controls.Add(this.lblTotal);
            this.pnlContenedorDetallesVentas.Controls.Add(this.lblTituloDetalleVenta);
            this.pnlContenedorDetallesVentas.Controls.Add(this.lblNroVentaDetalle);
            this.pnlContenedorDetallesVentas.Location = new System.Drawing.Point(662, 187);
            this.pnlContenedorDetallesVentas.Name = "pnlContenedorDetallesVentas";
            this.pnlContenedorDetallesVentas.Size = new System.Drawing.Size(496, 302);
            this.pnlContenedorDetallesVentas.TabIndex = 33;
            // 
            // GestionVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 561);
            this.Controls.Add(this.pnlContenedorDetallesVentas);
            this.Controls.Add(this.pnlContenedorVentas);
            this.Controls.Add(this.pnlCardTotalVentas);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "GestionVentasForm";
            this.Text = "GestionVentasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlCardTotalVentas.ResumeLayout(false);
            this.pnlCardTotalVentas.PerformLayout();
            this.pnlContenedorVentas.ResumeLayout(false);
            this.pnlContenedorVentas.PerformLayout();
            this.pnlContenedorDetallesVentas.ResumeLayout(false);
            this.pnlContenedorDetallesVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.Label lblTituloHistorialVenta;
        private System.Windows.Forms.Label lblNroVentaDetalle;
        private System.Windows.Forms.DataGridView dgvListaDetalle;
        private System.Windows.Forms.Label lblTituloDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetallePrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalleSubtotal;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedor;
        private System.Windows.Forms.DataGridViewButtonColumn colDetalles;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCardTotalVentas;
        private System.Windows.Forms.Label lblCantTotalVentas;
        private System.Windows.Forms.Label lblTituloTotalVentas;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorVentas;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorDetallesVentas;
    }
}