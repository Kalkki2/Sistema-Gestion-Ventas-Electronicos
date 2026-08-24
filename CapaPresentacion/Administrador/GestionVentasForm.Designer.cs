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
            this.pnlContenedorHistorial = new System.Windows.Forms.Panel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnDescargarPDFHistoria = new System.Windows.Forms.Button();
            this.lblFiltrarHasta = new System.Windows.Forms.Label();
            this.lblFiltrarDesde = new System.Windows.Forms.Label();
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.lblTituloHistorialVenta = new System.Windows.Forms.Label();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlContenedorDetallesVenta = new System.Windows.Forms.Panel();
            this.lblNroVentaDetalle = new System.Windows.Forms.Label();
            this.dgvListaDetalle = new System.Windows.Forms.DataGridView();
            this.lblTituloDetalleVenta = new System.Windows.Forms.Label();
            this.colDetalleNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetallePrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalleSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.btnDescargarPDFDetalle = new System.Windows.Forms.Button();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCardTotalVentas = new System.Windows.Forms.Panel();
            this.lblCantTotalVentas = new System.Windows.Forms.Label();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.pnlContenedorHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            this.pnlContenedorDetallesVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlCardTotalVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorHistorial
            // 
            this.pnlContenedorHistorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedorHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorHistorial.Controls.Add(this.btnFiltrarPorFecha);
            this.pnlContenedorHistorial.Controls.Add(this.dtpHasta);
            this.pnlContenedorHistorial.Controls.Add(this.dtpDesde);
            this.pnlContenedorHistorial.Controls.Add(this.btnDescargarPDFHistoria);
            this.pnlContenedorHistorial.Controls.Add(this.lblFiltrarHasta);
            this.pnlContenedorHistorial.Controls.Add(this.lblFiltrarDesde);
            this.pnlContenedorHistorial.Controls.Add(this.dgvListaVentas);
            this.pnlContenedorHistorial.Controls.Add(this.lblTituloHistorialVenta);
            this.pnlContenedorHistorial.Location = new System.Drawing.Point(12, 176);
            this.pnlContenedorHistorial.Name = "pnlContenedorHistorial";
            this.pnlContenedorHistorial.Size = new System.Drawing.Size(679, 346);
            this.pnlContenedorHistorial.TabIndex = 18;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(319, 58);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(114, 20);
            this.dtpHasta.TabIndex = 30;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(148, 58);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(114, 20);
            this.dtpDesde.TabIndex = 29;
            // 
            // btnDescargarPDFHistoria
            // 
            this.btnDescargarPDFHistoria.Location = new System.Drawing.Point(585, 3);
            this.btnDescargarPDFHistoria.Name = "btnDescargarPDFHistoria";
            this.btnDescargarPDFHistoria.Size = new System.Drawing.Size(89, 26);
            this.btnDescargarPDFHistoria.TabIndex = 28;
            this.btnDescargarPDFHistoria.Text = "Descargar PDF";
            this.btnDescargarPDFHistoria.UseVisualStyleBackColor = true;
            // 
            // lblFiltrarHasta
            // 
            this.lblFiltrarHasta.AutoSize = true;
            this.lblFiltrarHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarHasta.Location = new System.Drawing.Point(268, 58);
            this.lblFiltrarHasta.Name = "lblFiltrarHasta";
            this.lblFiltrarHasta.Size = new System.Drawing.Size(45, 17);
            this.lblFiltrarHasta.TabIndex = 12;
            this.lblFiltrarHasta.Text = "Hasta";
            // 
            // lblFiltrarDesde
            // 
            this.lblFiltrarDesde.AutoSize = true;
            this.lblFiltrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarDesde.Location = new System.Drawing.Point(93, 61);
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
            this.dgvListaVentas.Location = new System.Drawing.Point(3, 99);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.RowHeadersVisible = false;
            this.dgvListaVentas.Size = new System.Drawing.Size(666, 75);
            this.dgvListaVentas.TabIndex = 1;
            // 
            // lblTituloHistorialVenta
            // 
            this.lblTituloHistorialVenta.AutoSize = true;
            this.lblTituloHistorialVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistorialVenta.Location = new System.Drawing.Point(3, 9);
            this.lblTituloHistorialVenta.Name = "lblTituloHistorialVenta";
            this.lblTituloHistorialVenta.Size = new System.Drawing.Size(140, 17);
            this.lblTituloHistorialVenta.TabIndex = 9;
            this.lblTituloHistorialVenta.Text = "Historia de ventas";
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
            this.colFechaVenta.Width = 123;
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
            this.colDetalles.Width = 120;
            // 
            // pnlContenedorDetallesVenta
            // 
            this.pnlContenedorDetallesVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorDetallesVenta.Controls.Add(this.btnDescargarPDFDetalle);
            this.pnlContenedorDetallesVenta.Controls.Add(this.lblPrecioTotal);
            this.pnlContenedorDetallesVenta.Controls.Add(this.lblTotal);
            this.pnlContenedorDetallesVenta.Controls.Add(this.lblNroVentaDetalle);
            this.pnlContenedorDetallesVenta.Controls.Add(this.dgvListaDetalle);
            this.pnlContenedorDetallesVenta.Controls.Add(this.lblTituloDetalleVenta);
            this.pnlContenedorDetallesVenta.Location = new System.Drawing.Point(697, 176);
            this.pnlContenedorDetallesVenta.Name = "pnlContenedorDetallesVenta";
            this.pnlContenedorDetallesVenta.Size = new System.Drawing.Size(513, 346);
            this.pnlContenedorDetallesVenta.TabIndex = 19;
            // 
            // lblNroVentaDetalle
            // 
            this.lblNroVentaDetalle.AutoSize = true;
            this.lblNroVentaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVentaDetalle.Location = new System.Drawing.Point(180, 10);
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
            this.dgvListaDetalle.Location = new System.Drawing.Point(6, 54);
            this.dgvListaDetalle.Name = "dgvListaDetalle";
            this.dgvListaDetalle.RowHeadersVisible = false;
            this.dgvListaDetalle.Size = new System.Drawing.Size(489, 75);
            this.dgvListaDetalle.TabIndex = 11;
            // 
            // lblTituloDetalleVenta
            // 
            this.lblTituloDetalleVenta.AutoSize = true;
            this.lblTituloDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleVenta.Location = new System.Drawing.Point(3, 20);
            this.lblTituloDetalleVenta.Name = "lblTituloDetalleVenta";
            this.lblTituloDetalleVenta.Size = new System.Drawing.Size(186, 17);
            this.lblTituloDetalleVenta.TabIndex = 10;
            this.lblTituloDetalleVenta.Text = "Detalle de la venta Nro: ";
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(349, 316);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 17);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total: ";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(410, 306);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(99, 29);
            this.lblPrecioTotal.TabIndex = 20;
            this.lblPrecioTotal.Text = "$XXXX";
            // 
            // btnDescargarPDFDetalle
            // 
            this.btnDescargarPDFDetalle.Location = new System.Drawing.Point(420, 5);
            this.btnDescargarPDFDetalle.Name = "btnDescargarPDFDetalle";
            this.btnDescargarPDFDetalle.Size = new System.Drawing.Size(89, 26);
            this.btnDescargarPDFDetalle.TabIndex = 31;
            this.btnDescargarPDFDetalle.Text = "Descargar PDF";
            this.btnDescargarPDFDetalle.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(453, 53);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(89, 26);
            this.btnFiltrarPorFecha.TabIndex = 31;
            this.btnFiltrarPorFecha.Text = "Filtrar";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
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
            this.pnlnfoUsuario.Location = new System.Drawing.Point(1010, 5);
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
            this.pnlCardTotalVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalVentas.Controls.Add(this.lblCantTotalVentas);
            this.pnlCardTotalVentas.Controls.Add(this.lblTituloTotalVentas);
            this.pnlCardTotalVentas.Location = new System.Drawing.Point(12, 87);
            this.pnlCardTotalVentas.Name = "pnlCardTotalVentas";
            this.pnlCardTotalVentas.Size = new System.Drawing.Size(173, 67);
            this.pnlCardTotalVentas.TabIndex = 21;
            // 
            // lblCantTotalVentas
            // 
            this.lblCantTotalVentas.AutoSize = true;
            this.lblCantTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalVentas.Location = new System.Drawing.Point(19, 27);
            this.lblCantTotalVentas.Name = "lblCantTotalVentas";
            this.lblCantTotalVentas.Size = new System.Drawing.Size(46, 31);
            this.lblCantTotalVentas.TabIndex = 17;
            this.lblCantTotalVentas.Text = "10";
            // 
            // lblTituloTotalVentas
            // 
            this.lblTituloTotalVentas.AutoSize = true;
            this.lblTituloTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalVentas.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTotalVentas.Name = "lblTituloTotalVentas";
            this.lblTituloTotalVentas.Size = new System.Drawing.Size(67, 13);
            this.lblTituloTotalVentas.TabIndex = 17;
            this.lblTituloTotalVentas.Text = "Total Ventas";
            // 
            // GestionVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 561);
            this.Controls.Add(this.pnlCardTotalVentas);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlContenedorDetallesVenta);
            this.Controls.Add(this.pnlContenedorHistorial);
            this.Name = "GestionVentasForm";
            this.Text = "GestionVentasForm";
            this.pnlContenedorHistorial.ResumeLayout(false);
            this.pnlContenedorHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            this.pnlContenedorDetallesVenta.ResumeLayout(false);
            this.pnlContenedorDetallesVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDetalle)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlCardTotalVentas.ResumeLayout(false);
            this.pnlCardTotalVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorHistorial;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnDescargarPDFHistoria;
        private System.Windows.Forms.Label lblFiltrarHasta;
        private System.Windows.Forms.Label lblFiltrarDesde;
        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.Label lblTituloHistorialVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedor;
        private System.Windows.Forms.DataGridViewButtonColumn colDetalles;
        private System.Windows.Forms.Panel pnlContenedorDetallesVenta;
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
        private System.Windows.Forms.Button btnDescargarPDFDetalle;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCardTotalVentas;
        private System.Windows.Forms.Label lblCantTotalVentas;
        private System.Windows.Forms.Label lblTituloTotalVentas;
    }
}