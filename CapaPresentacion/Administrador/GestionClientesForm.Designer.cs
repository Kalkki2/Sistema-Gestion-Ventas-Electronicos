namespace CapaPresentacion.Administrador
{
    partial class GestionClientesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCardTotalClientes = new System.Windows.Forms.Panel();
            this.lblCantTotalClientes = new System.Windows.Forms.Label();
            this.lblTituloTotalCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInformacionDelCliente = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlContenedorListaCliente = new System.Windows.Forms.Panel();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.colNroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCompras = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloListaClientes = new System.Windows.Forms.Label();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.txtFiltrarPorDNI = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuscarPorDniONombre = new System.Windows.Forms.Label();
            this.pnlCardTotalClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContenedorListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCardTotalClientes
            // 
            this.pnlCardTotalClientes.BackColor = System.Drawing.Color.White;
            this.pnlCardTotalClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalClientes.Controls.Add(this.lblCantTotalClientes);
            this.pnlCardTotalClientes.Controls.Add(this.lblTituloTotalCliente);
            this.pnlCardTotalClientes.Location = new System.Drawing.Point(529, 77);
            this.pnlCardTotalClientes.Name = "pnlCardTotalClientes";
            this.pnlCardTotalClientes.Size = new System.Drawing.Size(187, 75);
            this.pnlCardTotalClientes.TabIndex = 25;
            // 
            // lblCantTotalClientes
            // 
            this.lblCantTotalClientes.AutoSize = true;
            this.lblCantTotalClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalClientes.Location = new System.Drawing.Point(19, 27);
            this.lblCantTotalClientes.Name = "lblCantTotalClientes";
            this.lblCantTotalClientes.Size = new System.Drawing.Size(46, 31);
            this.lblCantTotalClientes.TabIndex = 17;
            this.lblCantTotalClientes.Text = "10";
            // 
            // lblTituloTotalCliente
            // 
            this.lblTituloTotalCliente.AutoSize = true;
            this.lblTituloTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloTotalCliente.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTotalCliente.Name = "lblTituloTotalCliente";
            this.lblTituloTotalCliente.Size = new System.Drawing.Size(93, 15);
            this.lblTituloTotalCliente.TabIndex = 17;
            this.lblTituloTotalCliente.Text = "Total clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblInformacionDelCliente);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.btnActualizarCliente);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 264);
            this.panel1.TabIndex = 24;
            // 
            // lblInformacionDelCliente
            // 
            this.lblInformacionDelCliente.AutoSize = true;
            this.lblInformacionDelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionDelCliente.Location = new System.Drawing.Point(9, 9);
            this.lblInformacionDelCliente.Name = "lblInformacionDelCliente";
            this.lblInformacionDelCliente.Size = new System.Drawing.Size(171, 16);
            this.lblInformacionDelCliente.TabIndex = 29;
            this.lblInformacionDelCliente.Text = "Informacion del clientes";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(247, 145);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(222, 27);
            this.txtDireccion.TabIndex = 25;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(244, 125);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 17);
            this.lblDireccion.TabIndex = 24;
            this.lblDireccion.Text = "Direccion*";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(247, 79);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(222, 27);
            this.txtTelefono.TabIndex = 23;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(252, 59);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 17);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono *";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(12, 198);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(222, 27);
            this.txtDni.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(253, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 34);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(9, 178);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 17);
            this.lblDNI.TabIndex = 20;
            this.lblDNI.Text = "DNI *";
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Location = new System.Drawing.Point(364, 198);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(89, 34);
            this.btnActualizarCliente.TabIndex = 16;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 76);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre *";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(12, 136);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(222, 25);
            this.txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(9, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 17);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido *";
            // 
            // pnlContenedorListaCliente
            // 
            this.pnlContenedorListaCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedorListaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorListaCliente.Controls.Add(this.dgvListaCliente);
            this.pnlContenedorListaCliente.Controls.Add(this.lblTituloListaClientes);
            this.pnlContenedorListaCliente.Location = new System.Drawing.Point(24, 346);
            this.pnlContenedorListaCliente.Name = "pnlContenedorListaCliente";
            this.pnlContenedorListaCliente.Size = new System.Drawing.Size(881, 203);
            this.pnlContenedorListaCliente.TabIndex = 23;
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCliente,
            this.colDni,
            this.colApellido,
            this.colNombre,
            this.colTelefono,
            this.colDireccion,
            this.colEditar,
            this.colCompras});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaCliente.Location = new System.Drawing.Point(3, 101);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.RowHeadersVisible = false;
            this.dgvListaCliente.Size = new System.Drawing.Size(873, 75);
            this.dgvListaCliente.TabIndex = 1;
            // 
            // colNroCliente
            // 
            this.colNroCliente.HeaderText = "Nro Cliente";
            this.colNroCliente.Name = "colNroCliente";
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Width = 150;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Name = "colEditar";
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colCompras
            // 
            this.colCompras.HeaderText = "Ver compras";
            this.colCompras.Name = "colCompras";
            this.colCompras.Width = 120;
            // 
            // lblTituloListaClientes
            // 
            this.lblTituloListaClientes.AutoSize = true;
            this.lblTituloListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaClientes.Location = new System.Drawing.Point(3, 9);
            this.lblTituloListaClientes.Name = "lblTituloListaClientes";
            this.lblTituloListaClientes.Size = new System.Drawing.Size(106, 17);
            this.lblTituloListaClientes.TabIndex = 9;
            this.lblTituloListaClientes.Text = "Lista Clientes";
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(191, 144);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(89, 26);
            this.btnFiltrarPorFecha.TabIndex = 33;
            this.btnFiltrarPorFecha.Text = "Filtrar";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // txtFiltrarPorDNI
            // 
            this.txtFiltrarPorDNI.Location = new System.Drawing.Point(3, 51);
            this.txtFiltrarPorDNI.Multiline = true;
            this.txtFiltrarPorDNI.Name = "txtFiltrarPorDNI";
            this.txtFiltrarPorDNI.Size = new System.Drawing.Size(277, 27);
            this.txtFiltrarPorDNI.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 24);
            this.comboBox2.TabIndex = 31;
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
            this.pnlEncabezado.TabIndex = 26;
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
            this.lblTitulo.Size = new System.Drawing.Size(216, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gestion de clientes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBuscarPorDniONombre);
            this.panel2.Controls.Add(this.txtFiltrarPorDNI);
            this.panel2.Controls.Add(this.btnFiltrarPorFecha);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Location = new System.Drawing.Point(529, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 178);
            this.panel2.TabIndex = 27;
            // 
            // lblBuscarPorDniONombre
            // 
            this.lblBuscarPorDniONombre.AutoSize = true;
            this.lblBuscarPorDniONombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorDniONombre.Location = new System.Drawing.Point(3, 31);
            this.lblBuscarPorDniONombre.Name = "lblBuscarPorDniONombre";
            this.lblBuscarPorDniONombre.Size = new System.Drawing.Size(174, 17);
            this.lblBuscarPorDniONombre.TabIndex = 34;
            this.lblBuscarPorDniONombre.Text = "Buscar por DNI o Nombre:";
            // 
            // GestionClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlCardTotalClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlContenedorListaCliente);
            this.Name = "GestionClientesForm";
            this.Text = "GestionClientesForm";
            this.pnlCardTotalClientes.ResumeLayout(false);
            this.pnlCardTotalClientes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContenedorListaCliente.ResumeLayout(false);
            this.pnlContenedorListaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardTotalClientes;
        private System.Windows.Forms.Label lblCantTotalClientes;
        private System.Windows.Forms.Label lblTituloTotalCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel pnlContenedorListaCliente;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
        private System.Windows.Forms.TextBox txtFiltrarPorDNI;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.Label lblTituloListaClientes;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colCompras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInformacionDelCliente;
        private System.Windows.Forms.Label lblBuscarPorDniONombre;
    }
}