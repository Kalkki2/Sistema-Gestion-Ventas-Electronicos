namespace CapaPresentacion.Administrador
{
    partial class GestionProveedoresForm
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
            this.pnlCardTotalProveedores = new System.Windows.Forms.Panel();
            this.lblCantTotalProveedores = new System.Windows.Forms.Label();
            this.lblTituloTotalProveedores = new System.Windows.Forms.Label();
            this.pnlContenedorCatalogo = new System.Windows.Forms.Panel();
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.pnlFormularioProducto = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCardTotalProveedores.SuspendLayout();
            this.pnlContenedorCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.pnlFormularioProducto.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCardTotalProveedores
            // 
            this.pnlCardTotalProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalProveedores.Controls.Add(this.lblCantTotalProveedores);
            this.pnlCardTotalProveedores.Controls.Add(this.lblTituloTotalProveedores);
            this.pnlCardTotalProveedores.Location = new System.Drawing.Point(281, 91);
            this.pnlCardTotalProveedores.Name = "pnlCardTotalProveedores";
            this.pnlCardTotalProveedores.Size = new System.Drawing.Size(173, 67);
            this.pnlCardTotalProveedores.TabIndex = 21;
            // 
            // lblCantTotalProveedores
            // 
            this.lblCantTotalProveedores.AutoSize = true;
            this.lblCantTotalProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalProveedores.Location = new System.Drawing.Point(19, 27);
            this.lblCantTotalProveedores.Name = "lblCantTotalProveedores";
            this.lblCantTotalProveedores.Size = new System.Drawing.Size(46, 31);
            this.lblCantTotalProveedores.TabIndex = 17;
            this.lblCantTotalProveedores.Text = "10";
            // 
            // lblTituloTotalProveedores
            // 
            this.lblTituloTotalProveedores.AutoSize = true;
            this.lblTituloTotalProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalProveedores.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTotalProveedores.Name = "lblTituloTotalProveedores";
            this.lblTituloTotalProveedores.Size = new System.Drawing.Size(94, 13);
            this.lblTituloTotalProveedores.TabIndex = 17;
            this.lblTituloTotalProveedores.Text = "Total Proveedores";
            // 
            // pnlContenedorCatalogo
            // 
            this.pnlContenedorCatalogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedorCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorCatalogo.Controls.Add(this.dgvListaProveedores);
            this.pnlContenedorCatalogo.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorCatalogo.Controls.Add(this.txtBuscarProveedor);
            this.pnlContenedorCatalogo.Controls.Add(this.lblFiltroEstado);
            this.pnlContenedorCatalogo.Controls.Add(this.cmbFiltroEstado);
            this.pnlContenedorCatalogo.Controls.Add(this.lblListaProveedores);
            this.pnlContenedorCatalogo.Location = new System.Drawing.Point(281, 184);
            this.pnlContenedorCatalogo.Name = "pnlContenedorCatalogo";
            this.pnlContenedorCatalogo.Size = new System.Drawing.Size(875, 369);
            this.pnlContenedorCatalogo.TabIndex = 20;
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCorreo,
            this.colTelefono,
            this.colEstado,
            this.colEditar,
            this.colEliminar});
            this.dgvListaProveedores.Location = new System.Drawing.Point(3, 97);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.RowHeadersVisible = false;
            this.dgvListaProveedores.Size = new System.Drawing.Size(687, 63);
            this.dgvListaProveedores.TabIndex = 17;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "CUIT";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 80;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Width = 125;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 125;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "Editar";
            this.colEditar.Name = "colEditar";
            this.colEditar.Width = 65;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Width = 65;
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(313, 62);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(73, 17);
            this.lblFiltrarPor.TabIndex = 16;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(6, 56);
            this.txtBuscarProveedor.Multiline = true;
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(277, 27);
            this.txtBuscarProveedor.TabIndex = 11;
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEstado.Location = new System.Drawing.Point(389, 36);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(52, 17);
            this.lblFiltroEstado.TabIndex = 11;
            this.lblFiltroEstado.Text = "Estado";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(392, 59);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(152, 24);
            this.cmbFiltroEstado.TabIndex = 11;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.Location = new System.Drawing.Point(3, 9);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(162, 17);
            this.lblListaProveedores.TabIndex = 9;
            this.lblListaProveedores.Text = "Lista de proveedores";
            // 
            // pnlFormularioProducto
            // 
            this.pnlFormularioProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFormularioProducto.Controls.Add(this.txtTelefono);
            this.pnlFormularioProducto.Controls.Add(this.txtCorreo);
            this.pnlFormularioProducto.Controls.Add(this.lblEstado);
            this.pnlFormularioProducto.Controls.Add(this.cmbEstado);
            this.pnlFormularioProducto.Controls.Add(this.btnCancelar);
            this.pnlFormularioProducto.Controls.Add(this.btnAgregar);
            this.pnlFormularioProducto.Controls.Add(this.lblTelefono);
            this.pnlFormularioProducto.Controls.Add(this.lblCorreo);
            this.pnlFormularioProducto.Controls.Add(this.txtNombre);
            this.pnlFormularioProducto.Controls.Add(this.lblNombre);
            this.pnlFormularioProducto.Controls.Add(this.txtCuit);
            this.pnlFormularioProducto.Controls.Add(this.lblCuit);
            this.pnlFormularioProducto.Location = new System.Drawing.Point(12, 91);
            this.pnlFormularioProducto.Name = "pnlFormularioProducto";
            this.pnlFormularioProducto.Size = new System.Drawing.Size(263, 467);
            this.pnlFormularioProducto.TabIndex = 19;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(21, 252);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(222, 25);
            this.txtTelefono.TabIndex = 21;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(21, 182);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(222, 25);
            this.txtCorreo.TabIndex = 20;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(21, 298);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(21, 318);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(222, 24);
            this.cmbEstado.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(21, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 34);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 423);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 34);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(19, 223);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(18, 154);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(134, 17);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo Electronico *";
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
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(22, 117);
            this.txtCuit.Multiline = true;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(222, 25);
            this.txtCuit.TabIndex = 1;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(19, 93);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(48, 17);
            this.lblCuit.TabIndex = 0;
            this.lblCuit.Text = "CUIT *";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-3, -2);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1222, 64);
            this.pnlEncabezado.TabIndex = 22;
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
            this.lblTitulo.Size = new System.Drawing.Size(265, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gestion de proveedores";
            // 
            // GestionProveedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 561);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlCardTotalProveedores);
            this.Controls.Add(this.pnlContenedorCatalogo);
            this.Controls.Add(this.pnlFormularioProducto);
            this.Name = "GestionProveedoresForm";
            this.Text = "GestionProveedoresForm";
            this.pnlCardTotalProveedores.ResumeLayout(false);
            this.pnlCardTotalProveedores.PerformLayout();
            this.pnlContenedorCatalogo.ResumeLayout(false);
            this.pnlContenedorCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.pnlFormularioProducto.ResumeLayout(false);
            this.pnlFormularioProducto.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardTotalProveedores;
        private System.Windows.Forms.Label lblCantTotalProveedores;
        private System.Windows.Forms.Label lblTituloTotalProveedores;
        private System.Windows.Forms.Panel pnlContenedorCatalogo;
        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.Panel pnlFormularioProducto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlnfoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
    }
}