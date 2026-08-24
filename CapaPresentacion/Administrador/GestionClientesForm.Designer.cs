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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCardTotalClientes = new System.Windows.Forms.Panel();
            this.lblCantTotalClientes = new System.Windows.Forms.Label();
            this.lblTituloTotalCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlContenedorListaCliente = new System.Windows.Forms.Panel();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.lblOrdenarPor = new System.Windows.Forms.Label();
            this.txtFiltrarPorDNI = new System.Windows.Forms.TextBox();
            this.lblCantidadCompra = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.colNroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacturado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompras = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloListaClientes = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCardTotalClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContenedorListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCardTotalClientes
            // 
            this.pnlCardTotalClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalClientes.Controls.Add(this.lblCantTotalClientes);
            this.pnlCardTotalClientes.Controls.Add(this.lblTituloTotalCliente);
            this.pnlCardTotalClientes.Location = new System.Drawing.Point(322, 121);
            this.pnlCardTotalClientes.Name = "pnlCardTotalClientes";
            this.pnlCardTotalClientes.Size = new System.Drawing.Size(173, 67);
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
            this.lblTituloTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalCliente.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTotalCliente.Name = "lblTituloTotalCliente";
            this.lblTituloTotalCliente.Size = new System.Drawing.Size(70, 13);
            this.lblTituloTotalCliente.TabIndex = 17;
            this.lblTituloTotalCliente.Text = "Total clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 399);
            this.panel1.TabIndex = 24;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(22, 294);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(222, 27);
            this.txtDireccion.TabIndex = 25;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(19, 274);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 17);
            this.lblDireccion.TabIndex = 24;
            this.lblDireccion.Text = "Direccion*";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 228);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(222, 27);
            this.txtTelefono.TabIndex = 23;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(27, 208);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 17);
            this.lblTelefono.TabIndex = 22;
            this.lblTelefono.Text = "Telefono *";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(22, 169);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(222, 27);
            this.txtDni.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 34);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Eliminar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(19, 149);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 17);
            this.lblDNI.TabIndex = 20;
            this.lblDNI.Text = "DNI *";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(139, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 34);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Agregar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 47);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre *";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(22, 107);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(222, 25);
            this.txtApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(19, 83);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 17);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido *";
            // 
            // pnlContenedorListaCliente
            // 
            this.pnlContenedorListaCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedorListaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorListaCliente.Controls.Add(this.btnFiltrarPorFecha);
            this.pnlContenedorListaCliente.Controls.Add(this.lblOrdenarPor);
            this.pnlContenedorListaCliente.Controls.Add(this.txtFiltrarPorDNI);
            this.pnlContenedorListaCliente.Controls.Add(this.lblCantidadCompra);
            this.pnlContenedorListaCliente.Controls.Add(this.comboBox2);
            this.pnlContenedorListaCliente.Controls.Add(this.dgvListaCliente);
            this.pnlContenedorListaCliente.Controls.Add(this.lblTituloListaClientes);
            this.pnlContenedorListaCliente.Location = new System.Drawing.Point(318, 209);
            this.pnlContenedorListaCliente.Name = "pnlContenedorListaCliente";
            this.pnlContenedorListaCliente.Size = new System.Drawing.Size(884, 311);
            this.pnlContenedorListaCliente.TabIndex = 23;
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(586, 59);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(89, 26);
            this.btnFiltrarPorFecha.TabIndex = 33;
            this.btnFiltrarPorFecha.Text = "Filtrar";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPor.Location = new System.Drawing.Point(313, 64);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(90, 17);
            this.lblOrdenarPor.TabIndex = 32;
            this.lblOrdenarPor.Text = "Ordenar por:";
            // 
            // txtFiltrarPorDNI
            // 
            this.txtFiltrarPorDNI.Location = new System.Drawing.Point(6, 54);
            this.txtFiltrarPorDNI.Multiline = true;
            this.txtFiltrarPorDNI.Name = "txtFiltrarPorDNI";
            this.txtFiltrarPorDNI.Size = new System.Drawing.Size(277, 27);
            this.txtFiltrarPorDNI.TabIndex = 29;
            // 
            // lblCantidadCompra
            // 
            this.lblCantidadCompra.AutoSize = true;
            this.lblCantidadCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCompra.Location = new System.Drawing.Point(406, 41);
            this.lblCantidadCompra.Name = "lblCantidadCompra";
            this.lblCantidadCompra.Size = new System.Drawing.Size(122, 17);
            this.lblCantidadCompra.TabIndex = 30;
            this.lblCantidadCompra.Text = "Cantidad compras";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(409, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCliente,
            this.colDni,
            this.colApellido,
            this.colNombre,
            this.colTelefono,
            this.colDireccion,
            this.colFacturado,
            this.colCompras});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaCliente.Location = new System.Drawing.Point(3, 101);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.RowHeadersVisible = false;
            this.dgvListaCliente.Size = new System.Drawing.Size(876, 75);
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
            // colFacturado
            // 
            this.colFacturado.HeaderText = "Facturado";
            this.colFacturado.Name = "colFacturado";
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
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1219, 64);
            this.pnlEncabezado.TabIndex = 26;
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
            this.lblTitulo.Size = new System.Drawing.Size(216, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gestion de clientes";
            // 
            // GestionClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 561);
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel pnlContenedorListaCliente;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
        private System.Windows.Forms.Label lblOrdenarPor;
        private System.Windows.Forms.TextBox txtFiltrarPorDNI;
        private System.Windows.Forms.Label lblCantidadCompra;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacturado;
        private System.Windows.Forms.DataGridViewButtonColumn colCompras;
        private System.Windows.Forms.Label lblTituloListaClientes;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
    }
}