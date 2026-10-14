namespace CapaPresentacion.Administrador
{
    partial class NuevaCompraForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorDetalleVenta = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblItemsCompra = new System.Windows.Forms.Label();
            this.btnGenerarCompra = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFormularioCliente = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtMarcaCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCategoriaCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMargenVenta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadCompra = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtProductoCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreoProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnAgregarItemProducto = new Guna.UI2.WinForms.Guna2Button();
            this.txtProveedorCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTituloInformacionUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvItemsCompra = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMargenVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscarProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.txtNroFactura = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            this.pnlContenedorDetalleVenta.SuspendLayout();
            this.pnlFormularioCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargenVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-2, -2);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1222, 64);
            this.pnlEncabezado.TabIndex = 68;
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
            this.lblTitulo.Size = new System.Drawing.Size(171, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Nueva Compra";
            // 
            // pnlContenedorDetalleVenta
            // 
            this.pnlContenedorDetalleVenta.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorDetalleVenta.BorderRadius = 8;
            this.pnlContenedorDetalleVenta.BorderThickness = 1;
            this.pnlContenedorDetalleVenta.Controls.Add(this.dgvItemsCompra);
            this.pnlContenedorDetalleVenta.Controls.Add(this.lblItemsCompra);
            this.pnlContenedorDetalleVenta.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorDetalleVenta.Location = new System.Drawing.Point(12, 399);
            this.pnlContenedorDetalleVenta.Name = "pnlContenedorDetalleVenta";
            this.pnlContenedorDetalleVenta.Size = new System.Drawing.Size(801, 198);
            this.pnlContenedorDetalleVenta.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(838, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "TOTAL: ";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(903, 360);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(91, 20);
            this.lblTotalCompra.TabIndex = 43;
            this.lblTotalCompra.Text = "$XXXXXX";
            // 
            // lblItemsCompra
            // 
            this.lblItemsCompra.AutoSize = true;
            this.lblItemsCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCompra.Location = new System.Drawing.Point(7, 10);
            this.lblItemsCompra.Name = "lblItemsCompra";
            this.lblItemsCompra.Size = new System.Drawing.Size(145, 17);
            this.lblItemsCompra.TabIndex = 42;
            this.lblItemsCompra.Text = "Items de la compra";
            // 
            // btnGenerarCompra
            // 
            this.btnGenerarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarCompra.BorderRadius = 10;
            this.btnGenerarCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarCompra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnGenerarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCompra.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCompra.Location = new System.Drawing.Point(867, 451);
            this.btnGenerarCompra.Name = "btnGenerarCompra";
            this.btnGenerarCompra.Size = new System.Drawing.Size(144, 35);
            this.btnGenerarCompra.TabIndex = 41;
            this.btnGenerarCompra.Text = "Generar Compra";
            this.btnGenerarCompra.Click += new System.EventHandler(this.btnGenerarCompra_Click);
            // 
            // pnlFormularioCliente
            // 
            this.pnlFormularioCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormularioCliente.Controls.Add(this.txtNroFactura);
            this.pnlFormularioCliente.Controls.Add(this.label9);
            this.pnlFormularioCliente.Controls.Add(this.txtMarcaCompra);
            this.pnlFormularioCliente.Controls.Add(this.txtCategoriaCompra);
            this.pnlFormularioCliente.Controls.Add(this.txtPrecioVenta);
            this.pnlFormularioCliente.Controls.Add(this.label8);
            this.pnlFormularioCliente.Controls.Add(this.label7);
            this.pnlFormularioCliente.Controls.Add(this.txtMargenVenta);
            this.pnlFormularioCliente.Controls.Add(this.label1);
            this.pnlFormularioCliente.Controls.Add(this.txtCantidadCompra);
            this.pnlFormularioCliente.Controls.Add(this.btnBuscarProveedor);
            this.pnlFormularioCliente.Controls.Add(this.btnBuscarProducto);
            this.pnlFormularioCliente.Controls.Add(this.txtPrecioCompra);
            this.pnlFormularioCliente.Controls.Add(this.label2);
            this.pnlFormularioCliente.Controls.Add(this.btnCancelar);
            this.pnlFormularioCliente.Controls.Add(this.txtProductoCompra);
            this.pnlFormularioCliente.Controls.Add(this.label3);
            this.pnlFormularioCliente.Controls.Add(this.label4);
            this.pnlFormularioCliente.Controls.Add(this.label5);
            this.pnlFormularioCliente.Controls.Add(this.txtTelefonoProveedor);
            this.pnlFormularioCliente.Controls.Add(this.lblTelefono);
            this.pnlFormularioCliente.Controls.Add(this.txtCorreoProveedor);
            this.pnlFormularioCliente.Controls.Add(this.lblCorreo);
            this.pnlFormularioCliente.Controls.Add(this.btnAgregarItemProducto);
            this.pnlFormularioCliente.Controls.Add(this.txtProveedorCompra);
            this.pnlFormularioCliente.Controls.Add(this.lblTituloInformacionUsuario);
            this.pnlFormularioCliente.Controls.Add(this.label6);
            this.pnlFormularioCliente.Controls.Add(this.lblCantidad);
            this.pnlFormularioCliente.FillColor = System.Drawing.Color.White;
            this.pnlFormularioCliente.Location = new System.Drawing.Point(12, 85);
            this.pnlFormularioCliente.Name = "pnlFormularioCliente";
            this.pnlFormularioCliente.Radius = 5;
            this.pnlFormularioCliente.ShadowColor = System.Drawing.Color.Black;
            this.pnlFormularioCliente.ShadowDepth = 25;
            this.pnlFormularioCliente.ShadowShift = 3;
            this.pnlFormularioCliente.Size = new System.Drawing.Size(819, 308);
            this.pnlFormularioCliente.TabIndex = 69;
            // 
            // txtMarcaCompra
            // 
            this.txtMarcaCompra.BackColor = System.Drawing.Color.Transparent;
            this.txtMarcaCompra.BorderColor = System.Drawing.Color.LightGray;
            this.txtMarcaCompra.BorderRadius = 6;
            this.txtMarcaCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarcaCompra.DefaultText = "";
            this.txtMarcaCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMarcaCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMarcaCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarcaCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarcaCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarcaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaCompra.ForeColor = System.Drawing.Color.Black;
            this.txtMarcaCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarcaCompra.Location = new System.Drawing.Point(270, 225);
            this.txtMarcaCompra.Name = "txtMarcaCompra";
            this.txtMarcaCompra.PlaceholderText = "";
            this.txtMarcaCompra.ReadOnly = true;
            this.txtMarcaCompra.SelectedText = "";
            this.txtMarcaCompra.Size = new System.Drawing.Size(185, 27);
            this.txtMarcaCompra.TabIndex = 113;
            // 
            // txtCategoriaCompra
            // 
            this.txtCategoriaCompra.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoriaCompra.BorderColor = System.Drawing.Color.LightGray;
            this.txtCategoriaCompra.BorderRadius = 6;
            this.txtCategoriaCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoriaCompra.DefaultText = "";
            this.txtCategoriaCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoriaCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoriaCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoriaCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoriaCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoriaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaCompra.ForeColor = System.Drawing.Color.Black;
            this.txtCategoriaCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoriaCompra.Location = new System.Drawing.Point(270, 176);
            this.txtCategoriaCompra.Name = "txtCategoriaCompra";
            this.txtCategoriaCompra.PlaceholderText = "";
            this.txtCategoriaCompra.ReadOnly = true;
            this.txtCategoriaCompra.SelectedText = "";
            this.txtCategoriaCompra.Size = new System.Drawing.Size(185, 27);
            this.txtCategoriaCompra.TabIndex = 112;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecioVenta.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioVenta.BorderRadius = 6;
            this.txtPrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioVenta.DefaultText = "";
            this.txtPrecioVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioVenta.Location = new System.Drawing.Point(674, 199);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PlaceholderText = "";
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.Size = new System.Drawing.Size(113, 27);
            this.txtPrecioVenta.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 110;
            this.label8.Text = "Precio Venta: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(793, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 109;
            this.label7.Text = "%";
            // 
            // txtMargenVenta
            // 
            this.txtMargenVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenVenta.Location = new System.Drawing.Point(674, 167);
            this.txtMargenVenta.Name = "txtMargenVenta";
            this.txtMargenVenta.ReadOnly = true;
            this.txtMargenVenta.Size = new System.Drawing.Size(113, 26);
            this.txtMargenVenta.TabIndex = 108;
            this.txtMargenVenta.ValueChanged += new System.EventHandler(this.txtMargenVenta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "Margen %: ";
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCompra.Location = new System.Drawing.Point(557, 135);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.Size = new System.Drawing.Size(111, 26);
            this.txtCantidadCompra.TabIndex = 106;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecioCompra.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioCompra.BorderRadius = 6;
            this.txtPrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioCompra.DefaultText = "";
            this.txtPrecioCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioCompra.Location = new System.Drawing.Point(674, 135);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PlaceholderText = "";
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.Size = new System.Drawing.Size(113, 27);
            this.txtPrecioCompra.TabIndex = 102;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "Precio: ";
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
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(553, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 100;
            this.btnCancelar.Text = "Cancelar";
            // 
            // txtProductoCompra
            // 
            this.txtProductoCompra.BackColor = System.Drawing.Color.Transparent;
            this.txtProductoCompra.BorderColor = System.Drawing.Color.LightGray;
            this.txtProductoCompra.BorderRadius = 6;
            this.txtProductoCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductoCompra.DefaultText = "";
            this.txtProductoCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductoCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductoCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductoCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductoCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoCompra.ForeColor = System.Drawing.Color.Black;
            this.txtProductoCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductoCompra.Location = new System.Drawing.Point(270, 125);
            this.txtProductoCompra.Name = "txtProductoCompra";
            this.txtProductoCompra.PlaceholderText = "";
            this.txtProductoCompra.ReadOnly = true;
            this.txtProductoCompra.SelectedText = "";
            this.txtProductoCompra.Size = new System.Drawing.Size(185, 27);
            this.txtProductoCompra.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 96;
            this.label3.Text = "Producto: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "Marca: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 93;
            this.label5.Text = "Categoria:";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefonoProveedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTelefonoProveedor.BorderRadius = 6;
            this.txtTelefonoProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoProveedor.DefaultText = "";
            this.txtTelefonoProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefonoProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefonoProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefonoProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefonoProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefonoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(0, 245);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.PlaceholderText = "";
            this.txtTelefonoProveedor.ReadOnly = true;
            this.txtTelefonoProveedor.SelectedText = "";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(185, 27);
            this.txtTelefonoProveedor.TabIndex = 91;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(1, 225);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 17);
            this.lblTelefono.TabIndex = 90;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreoProveedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCorreoProveedor.BorderRadius = 6;
            this.txtCorreoProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoProveedor.DefaultText = "";
            this.txtCorreoProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreoProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreoProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreoProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreoProveedor.Location = new System.Drawing.Point(0, 186);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.PlaceholderText = "";
            this.txtCorreoProveedor.ReadOnly = true;
            this.txtCorreoProveedor.SelectedText = "";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(185, 27);
            this.txtCorreoProveedor.TabIndex = 89;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(1, 166);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 17);
            this.lblCorreo.TabIndex = 88;
            this.lblCorreo.Text = "Correo: ";
            // 
            // btnAgregarItemProducto
            // 
            this.btnAgregarItemProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarItemProducto.BorderRadius = 10;
            this.btnAgregarItemProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarItemProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarItemProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarItemProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarItemProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAgregarItemProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItemProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarItemProducto.Location = new System.Drawing.Point(674, 234);
            this.btnAgregarItemProducto.Name = "btnAgregarItemProducto";
            this.btnAgregarItemProducto.Size = new System.Drawing.Size(118, 35);
            this.btnAgregarItemProducto.TabIndex = 87;
            this.btnAgregarItemProducto.Text = "Agregar Item";
            this.btnAgregarItemProducto.Click += new System.EventHandler(this.btnAgregarItemProducto_Click);
            // 
            // txtProveedorCompra
            // 
            this.txtProveedorCompra.BackColor = System.Drawing.Color.Transparent;
            this.txtProveedorCompra.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProveedorCompra.BorderRadius = 6;
            this.txtProveedorCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedorCompra.DefaultText = "";
            this.txtProveedorCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProveedorCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProveedorCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedorCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedorCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedorCompra.ForeColor = System.Drawing.Color.Black;
            this.txtProveedorCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedorCompra.Location = new System.Drawing.Point(0, 126);
            this.txtProveedorCompra.Name = "txtProveedorCompra";
            this.txtProveedorCompra.PlaceholderText = "";
            this.txtProveedorCompra.ReadOnly = true;
            this.txtProveedorCompra.SelectedText = "";
            this.txtProveedorCompra.Size = new System.Drawing.Size(185, 27);
            this.txtProveedorCompra.TabIndex = 85;
            // 
            // lblTituloInformacionUsuario
            // 
            this.lblTituloInformacionUsuario.AutoSize = true;
            this.lblTituloInformacionUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloInformacionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformacionUsuario.Location = new System.Drawing.Point(16, 11);
            this.lblTituloInformacionUsuario.Name = "lblTituloInformacionUsuario";
            this.lblTituloInformacionUsuario.Size = new System.Drawing.Size(178, 16);
            this.lblTituloInformacionUsuario.TabIndex = 84;
            this.lblTituloInformacionUsuario.Text = "Informacion del producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 82;
            this.label6.Text = "Proveedor: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(556, 115);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 17);
            this.lblCantidad.TabIndex = 83;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // dgvItemsCompra
            // 
            this.dgvItemsCompra.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvItemsCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItemsCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductoId,
            this.colNroItem,
            this.colProducto,
            this.colCantidad,
            this.colCostoUnitario,
            this.colMargenVenta,
            this.colPrecioVenta,
            this.colSubtotal,
            this.colEditar,
            this.colEliminar});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemsCompra.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItemsCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvItemsCompra.Location = new System.Drawing.Point(3, 30);
            this.dgvItemsCompra.Name = "dgvItemsCompra";
            this.dgvItemsCompra.RowHeadersVisible = false;
            this.dgvItemsCompra.RowTemplate.Height = 23;
            this.dgvItemsCompra.Size = new System.Drawing.Size(795, 154);
            this.dgvItemsCompra.TabIndex = 45;
            this.dgvItemsCompra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvItemsCompra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvItemsCompra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItemsCompra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemsCompra.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvItemsCompra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItemsCompra.ThemeStyle.RowsStyle.Height = 23;
            this.dgvItemsCompra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvItemsCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsCompra_CellContentClick);
            // 
            // colProductoId
            // 
            this.colProductoId.HeaderText = "ID";
            this.colProductoId.Name = "colProductoId";
            // 
            // colNroItem
            // 
            this.colNroItem.HeaderText = "NroItem";
            this.colNroItem.Name = "colNroItem";
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
            // colCostoUnitario
            // 
            this.colCostoUnitario.HeaderText = "Costo Unitario";
            this.colCostoUnitario.Name = "colCostoUnitario";
            // 
            // colMargenVenta
            // 
            this.colMargenVenta.HeaderText = "%Margen";
            this.colMargenVenta.Name = "colMargenVenta";
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.HeaderText = "Precio Venta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Name = "colEditar";
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProveedor.BorderRadius = 5;
            this.btnBuscarProveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarProveedor.FillColor = System.Drawing.Color.Silver;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.Image = global::CapaPresentacion.Properties.Resources.icono_lupa;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(191, 126);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(71, 27);
            this.btnBuscarProveedor.TabIndex = 105;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(463, 126);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(71, 27);
            this.btnBuscarProducto.TabIndex = 104;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // picUsuario
            // 
            this.picUsuario.Location = new System.Drawing.Point(3, 5);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(43, 42);
            this.picUsuario.TabIndex = 3;
            this.picUsuario.TabStop = false;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.BackColor = System.Drawing.Color.Transparent;
            this.txtNroFactura.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNroFactura.BorderRadius = 6;
            this.txtNroFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNroFactura.DefaultText = "";
            this.txtNroFactura.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNroFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNroFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNroFactura.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNroFactura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroFactura.ForeColor = System.Drawing.Color.Black;
            this.txtNroFactura.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNroFactura.Location = new System.Drawing.Point(110, 59);
            this.txtNroFactura.MaxLength = 13;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.PlaceholderText = "";
            this.txtNroFactura.SelectedText = "";
            this.txtNroFactura.Size = new System.Drawing.Size(185, 27);
            this.txtNroFactura.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 114;
            this.label9.Text = "Nº de Factura: ";
            // 
            // NuevaCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 561);
            this.Controls.Add(this.pnlContenedorDetalleVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGenerarCompra);
            this.Controls.Add(this.pnlFormularioCliente);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "NuevaCompraForm";
            this.Text = "NuevaCompraForm";
            this.Load += new System.EventHandler(this.NuevaCompraForm_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            this.pnlContenedorDetalleVenta.ResumeLayout(false);
            this.pnlContenedorDetalleVenta.PerformLayout();
            this.pnlFormularioCliente.ResumeLayout(false);
            this.pnlFormularioCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargenVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorDetalleVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblItemsCompra;

        private Guna.UI2.WinForms.Guna2Button btnGenerarCompra;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlFormularioCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtMarcaCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoriaCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtMargenVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCantidadCompra;
        private Guna.UI2.WinForms.Guna2Button btnBuscarProveedor;
        private Guna.UI2.WinForms.Guna2Button btnBuscarProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtProductoCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreoProveedor;
        private System.Windows.Forms.Label lblCorreo;
        private Guna.UI2.WinForms.Guna2Button btnAgregarItemProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtProveedorCompra;
        private System.Windows.Forms.Label lblTituloInformacionUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantidad;
        private Guna.UI2.WinForms.Guna2DataGridView dgvItemsCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMargenVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtNroFactura;
        private System.Windows.Forms.Label label9;
    }
}