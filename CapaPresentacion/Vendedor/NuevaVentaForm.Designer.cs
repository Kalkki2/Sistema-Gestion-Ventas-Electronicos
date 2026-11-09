namespace CapaPresentacion.Vendedor
{
    partial class NuevaVentaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtNomYApeCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDniCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarItemVenta = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadCompra = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.lblBuscarPorNombreOCorreo = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContenedorCatalogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMontoAjuste = new System.Windows.Forms.Label();
            this.lblTituloAjuste = new System.Windows.Forms.Label();
            this.lblSubtotalVenta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFiltroMetodoPago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFiltrarMetodoPago = new System.Windows.Forms.Label();
            this.btnCancelarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvListaProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTituloCatlogoProductos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlContenedorFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCompra)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlContenedorCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.txtNomYApeCliente);
            this.pnlContenedorFiltros.Controls.Add(this.txtDniCliente);
            this.pnlContenedorFiltros.Controls.Add(this.txtPrecioProducto);
            this.pnlContenedorFiltros.Controls.Add(this.txtNombreProducto);
            this.pnlContenedorFiltros.Controls.Add(this.btnLimpiar);
            this.pnlContenedorFiltros.Controls.Add(this.btnAgregarItemVenta);
            this.pnlContenedorFiltros.Controls.Add(this.label5);
            this.pnlContenedorFiltros.Controls.Add(this.label6);
            this.pnlContenedorFiltros.Controls.Add(this.label3);
            this.pnlContenedorFiltros.Controls.Add(this.label4);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarCliente);
            this.pnlContenedorFiltros.Controls.Add(this.label2);
            this.pnlContenedorFiltros.Controls.Add(this.label1);
            this.pnlContenedorFiltros.Controls.Add(this.txtCantidadCompra);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarProducto);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorNombreOCorreo);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(15, 81);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowShift = 3;
            this.pnlContenedorFiltros.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(357, 480);
            this.pnlContenedorFiltros.TabIndex = 62;
            // 
            // txtNomYApeCliente
            // 
            this.txtNomYApeCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtNomYApeCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtNomYApeCliente.BorderRadius = 6;
            this.txtNomYApeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomYApeCliente.DefaultText = "";
            this.txtNomYApeCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomYApeCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomYApeCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomYApeCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomYApeCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomYApeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomYApeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomYApeCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomYApeCliente.Location = new System.Drawing.Point(12, 52);
            this.txtNomYApeCliente.MaxLength = 13;
            this.txtNomYApeCliente.Name = "txtNomYApeCliente";
            this.txtNomYApeCliente.PlaceholderText = "";
            this.txtNomYApeCliente.ReadOnly = true;
            this.txtNomYApeCliente.SelectedText = "";
            this.txtNomYApeCliente.Size = new System.Drawing.Size(240, 27);
            this.txtNomYApeCliente.TabIndex = 119;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtDniCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtDniCliente.BorderRadius = 6;
            this.txtDniCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDniCliente.DefaultText = "";
            this.txtDniCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDniCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDniCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDniCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDniCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCliente.ForeColor = System.Drawing.Color.Black;
            this.txtDniCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDniCliente.Location = new System.Drawing.Point(12, 102);
            this.txtDniCliente.MaxLength = 13;
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.PlaceholderText = "";
            this.txtDniCliente.ReadOnly = true;
            this.txtDniCliente.SelectedText = "";
            this.txtDniCliente.Size = new System.Drawing.Size(240, 27);
            this.txtDniCliente.TabIndex = 118;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecioProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtPrecioProducto.BorderRadius = 6;
            this.txtPrecioProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioProducto.DefaultText = "";
            this.txtPrecioProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.ForeColor = System.Drawing.Color.Black;
            this.txtPrecioProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioProducto.Location = new System.Drawing.Point(12, 262);
            this.txtPrecioProducto.MaxLength = 13;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.PlaceholderText = "";
            this.txtPrecioProducto.ReadOnly = true;
            this.txtPrecioProducto.SelectedText = "";
            this.txtPrecioProducto.Size = new System.Drawing.Size(240, 27);
            this.txtPrecioProducto.TabIndex = 117;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreProducto.BorderRadius = 6;
            this.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.DefaultText = "";
            this.txtNombreProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.txtNombreProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(12, 198);
            this.txtNombreProducto.MaxLength = 13;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PlaceholderText = "";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(240, 27);
            this.txtNombreProducto.TabIndex = 116;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BorderRadius = 5;
            this.btnLimpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiar.FillColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(68, 433);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 35);
            this.btnLimpiar.TabIndex = 59;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnAgregarItemVenta
            // 
            this.btnAgregarItemVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarItemVenta.BorderRadius = 5;
            this.btnAgregarItemVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarItemVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarItemVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarItemVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarItemVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAgregarItemVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItemVenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarItemVenta.Location = new System.Drawing.Point(200, 433);
            this.btnAgregarItemVenta.Name = "btnAgregarItemVenta";
            this.btnAgregarItemVenta.Size = new System.Drawing.Size(140, 35);
            this.btnAgregarItemVenta.TabIndex = 58;
            this.btnAgregarItemVenta.Text = "Agregar Producto";
            this.btnAgregarItemVenta.Click += new System.EventHandler(this.btnAgregarItemVenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Datos del producto:";
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(269, 52);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(71, 27);
            this.btnBuscarCliente.TabIndex = 52;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre Y Apellido:";
            // 
            // txtCantidadCompra
            // 
            this.txtCantidadCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadCompra.Location = new System.Drawing.Point(12, 324);
            this.txtCantidadCompra.Name = "txtCantidadCompra";
            this.txtCantidadCompra.ReadOnly = true;
            this.txtCantidadCompra.Size = new System.Drawing.Size(120, 26);
            this.txtCantidadCompra.TabIndex = 46;
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(269, 198);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(71, 27);
            this.btnBuscarProducto.TabIndex = 45;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblBuscarPorNombreOCorreo
            // 
            this.lblBuscarPorNombreOCorreo.AutoSize = true;
            this.lblBuscarPorNombreOCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorNombreOCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorNombreOCorreo.Location = new System.Drawing.Point(9, 11);
            this.lblBuscarPorNombreOCorreo.Name = "lblBuscarPorNombreOCorreo";
            this.lblBuscarPorNombreOCorreo.Size = new System.Drawing.Size(117, 17);
            this.lblBuscarPorNombreOCorreo.TabIndex = 22;
            this.lblBuscarPorNombreOCorreo.Text = "Datos del cliente:";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-3, -2);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1179, 64);
            this.pnlEncabezado.TabIndex = 63;
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
            this.lblTitulo.Size = new System.Drawing.Size(149, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Nueva Venta";
            // 
            // pnlContenedorCatalogo
            // 
            this.pnlContenedorCatalogo.BorderColor = System.Drawing.Color.DimGray;
            this.pnlContenedorCatalogo.BorderThickness = 1;
            this.pnlContenedorCatalogo.Controls.Add(this.lblMontoAjuste);
            this.pnlContenedorCatalogo.Controls.Add(this.lblTituloAjuste);
            this.pnlContenedorCatalogo.Controls.Add(this.lblSubtotalVenta);
            this.pnlContenedorCatalogo.Controls.Add(this.label8);
            this.pnlContenedorCatalogo.Controls.Add(this.cmbFiltroMetodoPago);
            this.pnlContenedorCatalogo.Controls.Add(this.lblFiltrarMetodoPago);
            this.pnlContenedorCatalogo.Controls.Add(this.btnCancelarVenta);
            this.pnlContenedorCatalogo.Controls.Add(this.btnConfirmarVenta);
            this.pnlContenedorCatalogo.Controls.Add(this.lblTotalVenta);
            this.pnlContenedorCatalogo.Controls.Add(this.label16);
            this.pnlContenedorCatalogo.Controls.Add(this.dgvListaProductos);
            this.pnlContenedorCatalogo.Controls.Add(this.lblTituloCatlogoProductos);
            this.pnlContenedorCatalogo.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCatalogo.Location = new System.Drawing.Point(378, 81);
            this.pnlContenedorCatalogo.Name = "pnlContenedorCatalogo";
            this.pnlContenedorCatalogo.Size = new System.Drawing.Size(772, 480);
            this.pnlContenedorCatalogo.TabIndex = 64;
            // 
            // lblMontoAjuste
            // 
            this.lblMontoAjuste.AutoSize = true;
            this.lblMontoAjuste.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAjuste.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMontoAjuste.Location = new System.Drawing.Point(670, 375);
            this.lblMontoAjuste.Name = "lblMontoAjuste";
            this.lblMontoAjuste.Size = new System.Drawing.Size(73, 17);
            this.lblMontoAjuste.TabIndex = 67;
            this.lblMontoAjuste.Text = "- $250, 00";
            // 
            // lblTituloAjuste
            // 
            this.lblTituloAjuste.AutoSize = true;
            this.lblTituloAjuste.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAjuste.ForeColor = System.Drawing.Color.Red;
            this.lblTituloAjuste.Location = new System.Drawing.Point(457, 375);
            this.lblTituloAjuste.Name = "lblTituloAjuste";
            this.lblTituloAjuste.Size = new System.Drawing.Size(176, 17);
            this.lblTituloAjuste.TabIndex = 66;
            this.lblTituloAjuste.Text = "Descuento Efectivo(10%): ";
            // 
            // lblSubtotalVenta
            // 
            this.lblSubtotalVenta.AutoSize = true;
            this.lblSubtotalVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalVenta.Location = new System.Drawing.Point(667, 346);
            this.lblSubtotalVenta.Name = "lblSubtotalVenta";
            this.lblSubtotalVenta.Size = new System.Drawing.Size(76, 17);
            this.lblSubtotalVenta.TabIndex = 65;
            this.lblSubtotalVenta.Text = "$2.500, 00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(593, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Total: ";
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
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.cmbFiltroMetodoPago.Location = new System.Drawing.Point(229, 375);
            this.cmbFiltroMetodoPago.Name = "cmbFiltroMetodoPago";
            this.cmbFiltroMetodoPago.Size = new System.Drawing.Size(150, 27);
            this.cmbFiltroMetodoPago.StartIndex = 0;
            this.cmbFiltroMetodoPago.TabIndex = 61;
            this.cmbFiltroMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroMetodoPago_SelectedIndexChanged);
            // 
            // lblFiltrarMetodoPago
            // 
            this.lblFiltrarMetodoPago.AutoSize = true;
            this.lblFiltrarMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarMetodoPago.Location = new System.Drawing.Point(226, 355);
            this.lblFiltrarMetodoPago.Name = "lblFiltrarMetodoPago";
            this.lblFiltrarMetodoPago.Size = new System.Drawing.Size(92, 17);
            this.lblFiltrarMetodoPago.TabIndex = 60;
            this.lblFiltrarMetodoPago.Text = "Metodo Pago";
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarVenta.BorderRadius = 3;
            this.btnCancelarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelarVenta.FillColor = System.Drawing.Color.Red;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenta.Location = new System.Drawing.Point(8, 433);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(100, 35);
            this.btnCancelarVenta.TabIndex = 60;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarVenta.BorderRadius = 3;
            this.btnConfirmarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmarVenta.FillColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarVenta.Location = new System.Drawing.Point(589, 433);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(161, 35);
            this.btnConfirmarVenta.TabIndex = 63;
            this.btnConfirmarVenta.Text = "CONFIRMAR VENTA";
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.ForeColor = System.Drawing.Color.Black;
            this.lblTotalVenta.Location = new System.Drawing.Point(669, 401);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(77, 24);
            this.lblTotalVenta.TabIndex = 62;
            this.lblTotalVenta.Text = "$ 2.250";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(499, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 16);
            this.label16.TabIndex = 61;
            this.label16.Text = "TOTAL A PAGAR :";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaProductos.ColumnHeadersHeight = 33;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductoId,
            this.colNroItem,
            this.colCodigo,
            this.colProducto,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubtotal,
            this.colEditar,
            this.colEliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaProductos.Location = new System.Drawing.Point(8, 44);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersVisible = false;
            this.dgvListaProductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProductos.RowTemplate.Height = 25;
            this.dgvListaProductos.Size = new System.Drawing.Size(758, 289);
            this.dgvListaProductos.TabIndex = 7;
            this.dgvListaProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvListaProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaProductos.ThemeStyle.HeaderStyle.Height = 33;
            this.dgvListaProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProductos.ThemeStyle.RowsStyle.Height = 25;
            this.dgvListaProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellContentClick);
            // 
            // lblTituloCatlogoProductos
            // 
            this.lblTituloCatlogoProductos.AutoSize = true;
            this.lblTituloCatlogoProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCatlogoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCatlogoProductos.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCatlogoProductos.Location = new System.Drawing.Point(5, 15);
            this.lblTituloCatlogoProductos.Name = "lblTituloCatlogoProductos";
            this.lblTituloCatlogoProductos.Size = new System.Drawing.Size(114, 16);
            this.lblTituloCatlogoProductos.TabIndex = 6;
            this.lblTituloCatlogoProductos.Text = "Items de Venta:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colProductoId
            // 
            this.colProductoId.HeaderText = "id";
            this.colProductoId.Name = "colProductoId";
            this.colProductoId.Visible = false;
            // 
            // colNroItem
            // 
            this.colNroItem.FillWeight = 50F;
            this.colNroItem.HeaderText = "NroItem";
            this.colNroItem.Name = "colNroItem";
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 70F;
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 150F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 90F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.FillWeight = 120F;
            this.colPrecioUnitario.HeaderText = "Precio Unitario ($)";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal ($)";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // colEditar
            // 
            this.colEditar.FillWeight = 50F;
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Image = global::CapaPresentacion.Properties.Resources.icono_editar;
            this.colEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEditar.Name = "colEditar";
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEliminar
            // 
            this.colEliminar.FillWeight = 65F;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Image = global::CapaPresentacion.Properties.Resources.icono_eliminar;
            this.colEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NuevaVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 561);
            this.Controls.Add(this.pnlContenedorCatalogo);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Name = "NuevaVentaForm";
            this.Text = "NuevaVentaForm";
            this.Load += new System.EventHandler(this.NuevaVentaForm_Load);
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadCompra)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlContenedorCatalogo.ResumeLayout(false);
            this.pnlContenedorCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2Button btnBuscarProducto;
        private System.Windows.Forms.Label lblBuscarPorNombreOCorreo;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown txtCantidadCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorCatalogo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaProductos;
        private System.Windows.Forms.Label lblTituloCatlogoProductos;
        private Guna.UI2.WinForms.Guna2Button btnLimpiar;
        private Guna.UI2.WinForms.Guna2Button btnAgregarItemVenta;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btnCancelarVenta;
        private Guna.UI2.WinForms.Guna2Button btnConfirmarVenta;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroMetodoPago;
        private System.Windows.Forms.Label lblFiltrarMetodoPago;
        private System.Windows.Forms.Label lblSubtotalVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMontoAjuste;
        private System.Windows.Forms.Label lblTituloAjuste;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtNomYApeCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtDniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colEliminar;
    }
}