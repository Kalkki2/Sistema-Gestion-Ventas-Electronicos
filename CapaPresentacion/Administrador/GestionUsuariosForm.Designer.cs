namespace CapaPresentacion.Administrador
{
    partial class GestionUsuariosForm
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTituloListaUsusarios = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltraEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblFiltraPerfil = new System.Windows.Forms.Label();
            this.cmbFiltroPerfil = new System.Windows.Forms.ComboBox();
            this.lblBuscarPorDniOCorreo = new System.Windows.Forms.Label();
            this.pnlFormularioUsuario = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTituloInformacionUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnAgregarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.txtRepetirContrasenia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRepetirContrasenia = new System.Windows.Forms.Label();
            this.txtBuscarUsusario = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlCardTotalUsuarios = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCantTotalUsuarios = new System.Windows.Forms.Label();
            this.lblTituloTotalUsuarios = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContenedorUsuarios = new Guna.UI2.WinForms.Guna2Panel();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlCOntenedorFiltros = new Guna.UI2.WinForms.Guna2Panel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.pnlFormularioUsuario.SuspendLayout();
            this.pnlCardTotalUsuarios.SuspendLayout();
            this.pnlContenedorUsuarios.SuspendLayout();
            this.pnlCOntenedorFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncabezado.Controls.Add(this.pnlnfoUsuario);
            this.pnlEncabezado.Controls.Add(this.lblFecha);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(-3, -2);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1219, 65);
            this.pnlEncabezado.TabIndex = 14;
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
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 29);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gestion de usuarios";
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDni,
            this.colNombre,
            this.colApellido,
            this.colCorreo,
            this.colTelefono,
            this.colDireccion,
            this.colPerfil,
            this.colEstado,
            this.colFechaAlta,
            this.colEditar,
            this.colEliminar});
            this.dgvListaUsuarios.Location = new System.Drawing.Point(13, 29);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.RowHeadersVisible = false;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(1098, 63);
            this.dgvListaUsuarios.TabIndex = 17;
            // 
            // lblTituloListaUsusarios
            // 
            this.lblTituloListaUsusarios.AutoSize = true;
            this.lblTituloListaUsusarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaUsusarios.Location = new System.Drawing.Point(10, 9);
            this.lblTituloListaUsusarios.Name = "lblTituloListaUsusarios";
            this.lblTituloListaUsusarios.Size = new System.Drawing.Size(133, 17);
            this.lblTituloListaUsusarios.TabIndex = 9;
            this.lblTituloListaUsusarios.Text = "Lista de usuarios";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(12, 82);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(73, 17);
            this.lblFiltrarPor.TabIndex = 16;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // lblFiltraEstado
            // 
            this.lblFiltraEstado.AutoSize = true;
            this.lblFiltraEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltraEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraEstado.Location = new System.Drawing.Point(182, 103);
            this.lblFiltraEstado.Name = "lblFiltraEstado";
            this.lblFiltraEstado.Size = new System.Drawing.Size(52, 17);
            this.lblFiltraEstado.TabIndex = 12;
            this.lblFiltraEstado.Text = "Estado";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.BackColor = System.Drawing.Color.White;
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(185, 126);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(152, 24);
            this.cmbFiltroEstado.TabIndex = 13;
            // 
            // lblFiltraPerfil
            // 
            this.lblFiltraPerfil.AutoSize = true;
            this.lblFiltraPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltraPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraPerfil.Location = new System.Drawing.Point(12, 108);
            this.lblFiltraPerfil.Name = "lblFiltraPerfil";
            this.lblFiltraPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblFiltraPerfil.TabIndex = 11;
            this.lblFiltraPerfil.Text = "Perfil";
            // 
            // cmbFiltroPerfil
            // 
            this.cmbFiltroPerfil.BackColor = System.Drawing.Color.White;
            this.cmbFiltroPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroPerfil.FormattingEnabled = true;
            this.cmbFiltroPerfil.Items.AddRange(new object[] {
            "Dueño",
            "Administrador",
            "Vendedor",
            "Cajero"});
            this.cmbFiltroPerfil.Location = new System.Drawing.Point(12, 126);
            this.cmbFiltroPerfil.Name = "cmbFiltroPerfil";
            this.cmbFiltroPerfil.Size = new System.Drawing.Size(152, 24);
            this.cmbFiltroPerfil.TabIndex = 11;
            // 
            // lblBuscarPorDniOCorreo
            // 
            this.lblBuscarPorDniOCorreo.AutoSize = true;
            this.lblBuscarPorDniOCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorDniOCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorDniOCorreo.Location = new System.Drawing.Point(9, 20);
            this.lblBuscarPorDniOCorreo.Name = "lblBuscarPorDniOCorreo";
            this.lblBuscarPorDniOCorreo.Size = new System.Drawing.Size(167, 17);
            this.lblBuscarPorDniOCorreo.TabIndex = 22;
            this.lblBuscarPorDniOCorreo.Text = "Buscar por DNI o Correo:";
            // 
            // pnlFormularioUsuario
            // 
            this.pnlFormularioUsuario.BorderRadius = 15;
            this.pnlFormularioUsuario.Controls.Add(this.btnCancelar);
            this.pnlFormularioUsuario.Controls.Add(this.txtRepetirContrasenia);
            this.pnlFormularioUsuario.Controls.Add(this.lblRepetirContrasenia);
            this.pnlFormularioUsuario.Controls.Add(this.lblPerfil);
            this.pnlFormularioUsuario.Controls.Add(this.cmbPerfil);
            this.pnlFormularioUsuario.Controls.Add(this.txtContrasenia);
            this.pnlFormularioUsuario.Controls.Add(this.lblContrasenia);
            this.pnlFormularioUsuario.Controls.Add(this.txtDireccion);
            this.pnlFormularioUsuario.Controls.Add(this.lblDireccion);
            this.pnlFormularioUsuario.Controls.Add(this.txtTelefono);
            this.pnlFormularioUsuario.Controls.Add(this.lblTelefono);
            this.pnlFormularioUsuario.Controls.Add(this.txtCorreo);
            this.pnlFormularioUsuario.Controls.Add(this.lblCorreo);
            this.pnlFormularioUsuario.Controls.Add(this.txtDni);
            this.pnlFormularioUsuario.Controls.Add(this.lblDni);
            this.pnlFormularioUsuario.Controls.Add(this.lblTituloInformacionUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.lblEstado);
            this.pnlFormularioUsuario.Controls.Add(this.txtApellido);
            this.pnlFormularioUsuario.Controls.Add(this.lblApellido);
            this.pnlFormularioUsuario.Controls.Add(this.lblNombre);
            this.pnlFormularioUsuario.Controls.Add(this.cmbEstado);
            this.pnlFormularioUsuario.Controls.Add(this.btnAgregarUsuario);
            this.pnlFormularioUsuario.Controls.Add(this.txtNombre);
            this.pnlFormularioUsuario.FillColor = System.Drawing.Color.Gainsboro;
            this.pnlFormularioUsuario.Location = new System.Drawing.Point(12, 69);
            this.pnlFormularioUsuario.Name = "pnlFormularioUsuario";
            this.pnlFormularioUsuario.Size = new System.Drawing.Size(551, 292);
            this.pnlFormularioUsuario.TabIndex = 23;
            // 
            // lblTituloInformacionUsuario
            // 
            this.lblTituloInformacionUsuario.AutoSize = true;
            this.lblTituloInformacionUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloInformacionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformacionUsuario.Location = new System.Drawing.Point(13, 10);
            this.lblTituloInformacionUsuario.Name = "lblTituloInformacionUsuario";
            this.lblTituloInformacionUsuario.Size = new System.Drawing.Size(168, 16);
            this.lblTituloInformacionUsuario.TabIndex = 42;
            this.lblTituloInformacionUsuario.Text = "Informacion del usuario";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(265, 189);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 17);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado: ";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.BorderColor = System.Drawing.Color.DimGray;
            this.txtApellido.BorderRadius = 5;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.Location = new System.Drawing.Point(16, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(225, 27);
            this.txtApellido.TabIndex = 30;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(13, 88);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 17);
            this.lblApellido.TabIndex = 29;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre: ";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "TecnoDistribuidora S.A.",
            "ElectroComponentes del Sur"});
            this.cmbEstado.Location = new System.Drawing.Point(268, 209);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(117, 24);
            this.cmbEstado.TabIndex = 27;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.BorderRadius = 5;
            this.btnAgregarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(424, 247);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(100, 35);
            this.btnAgregarUsuario.TabIndex = 26;
            this.btnAgregarUsuario.Text = "Agegar";
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombre.BorderRadius = 5;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(16, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(225, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.Transparent;
            this.txtDni.BorderColor = System.Drawing.Color.DimGray;
            this.txtDni.BorderRadius = 5;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.DefaultText = "";
            this.txtDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.Black;
            this.txtDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.Location = new System.Drawing.Point(16, 159);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(225, 27);
            this.txtDni.TabIndex = 44;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(13, 139);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(39, 17);
            this.lblDni.TabIndex = 43;
            this.lblDni.Text = "DNI: ";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BorderColor = System.Drawing.Color.DimGray;
            this.txtCorreo.BorderRadius = 5;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.Location = new System.Drawing.Point(16, 213);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.Size = new System.Drawing.Size(225, 27);
            this.txtCorreo.TabIndex = 46;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(13, 193);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 17);
            this.lblCorreo.TabIndex = 45;
            this.lblCorreo.Text = "Correo: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefono.BorderRadius = 5;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Location = new System.Drawing.Point(16, 262);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(225, 27);
            this.txtTelefono.TabIndex = 48;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(13, 242);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 17);
            this.lblTelefono.TabIndex = 47;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.txtContrasenia.BorderColor = System.Drawing.Color.DimGray;
            this.txtContrasenia.BorderRadius = 5;
            this.txtContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenia.DefaultText = "";
            this.txtContrasenia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasenia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasenia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.ForeColor = System.Drawing.Color.Black;
            this.txtContrasenia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenia.Location = new System.Drawing.Point(276, 88);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PlaceholderText = "";
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.Size = new System.Drawing.Size(225, 27);
            this.txtContrasenia.TabIndex = 52;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(273, 68);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(89, 17);
            this.lblContrasenia.TabIndex = 51;
            this.lblContrasenia.Text = "Contraseña: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.BorderColor = System.Drawing.Color.DimGray;
            this.txtDireccion.BorderRadius = 5;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Location = new System.Drawing.Point(276, 39);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(225, 27);
            this.txtDireccion.TabIndex = 50;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(273, 19);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 17);
            this.lblDireccion.TabIndex = 49;
            this.lblDireccion.Text = "Direccion: ";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(404, 193);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(48, 17);
            this.lblPerfil.TabIndex = 54;
            this.lblPerfil.Text = "Perfil: ";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.BackColor = System.Drawing.Color.White;
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "TecnoDistribuidora S.A.",
            "ElectroComponentes del Sur"});
            this.cmbPerfil.Location = new System.Drawing.Point(407, 213);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(117, 24);
            this.cmbPerfil.TabIndex = 53;
            // 
            // txtRepetirContrasenia
            // 
            this.txtRepetirContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.txtRepetirContrasenia.BorderColor = System.Drawing.Color.DimGray;
            this.txtRepetirContrasenia.BorderRadius = 5;
            this.txtRepetirContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepetirContrasenia.DefaultText = "";
            this.txtRepetirContrasenia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRepetirContrasenia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRepetirContrasenia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepetirContrasenia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepetirContrasenia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepetirContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirContrasenia.ForeColor = System.Drawing.Color.Black;
            this.txtRepetirContrasenia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRepetirContrasenia.Location = new System.Drawing.Point(276, 146);
            this.txtRepetirContrasenia.Name = "txtRepetirContrasenia";
            this.txtRepetirContrasenia.PlaceholderText = "";
            this.txtRepetirContrasenia.SelectedText = "";
            this.txtRepetirContrasenia.Size = new System.Drawing.Size(225, 27);
            this.txtRepetirContrasenia.TabIndex = 56;
            // 
            // lblRepetirContrasenia
            // 
            this.lblRepetirContrasenia.AutoSize = true;
            this.lblRepetirContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblRepetirContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirContrasenia.Location = new System.Drawing.Point(273, 126);
            this.lblRepetirContrasenia.Name = "lblRepetirContrasenia";
            this.lblRepetirContrasenia.Size = new System.Drawing.Size(139, 17);
            this.lblRepetirContrasenia.TabIndex = 55;
            this.lblRepetirContrasenia.Text = "Repetir Contraseña: ";
            // 
            // txtBuscarUsusario
            // 
            this.txtBuscarUsusario.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarUsusario.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscarUsusario.BorderRadius = 5;
            this.txtBuscarUsusario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarUsusario.DefaultText = "";
            this.txtBuscarUsusario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarUsusario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarUsusario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarUsusario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarUsusario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsusario.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarUsusario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsusario.Location = new System.Drawing.Point(9, 40);
            this.txtBuscarUsusario.Name = "txtBuscarUsusario";
            this.txtBuscarUsusario.PlaceholderText = "";
            this.txtBuscarUsusario.SelectedText = "";
            this.txtBuscarUsusario.Size = new System.Drawing.Size(225, 27);
            this.txtBuscarUsusario.TabIndex = 51;
            // 
            // pnlCardTotalUsuarios
            // 
            this.pnlCardTotalUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardTotalUsuarios.Controls.Add(this.lblCantTotalUsuarios);
            this.pnlCardTotalUsuarios.Controls.Add(this.lblTituloTotalUsuarios);
            this.pnlCardTotalUsuarios.FillColor = System.Drawing.Color.White;
            this.pnlCardTotalUsuarios.Location = new System.Drawing.Point(597, 69);
            this.pnlCardTotalUsuarios.Name = "pnlCardTotalUsuarios";
            this.pnlCardTotalUsuarios.Radius = 7;
            this.pnlCardTotalUsuarios.ShadowColor = System.Drawing.Color.Black;
            this.pnlCardTotalUsuarios.ShadowDepth = 50;
            this.pnlCardTotalUsuarios.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlCardTotalUsuarios.Size = new System.Drawing.Size(190, 86);
            this.pnlCardTotalUsuarios.TabIndex = 24;
            // 
            // lblCantTotalUsuarios
            // 
            this.lblCantTotalUsuarios.AutoSize = true;
            this.lblCantTotalUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalUsuarios.Location = new System.Drawing.Point(10, 36);
            this.lblCantTotalUsuarios.Name = "lblCantTotalUsuarios";
            this.lblCantTotalUsuarios.Size = new System.Drawing.Size(41, 29);
            this.lblCantTotalUsuarios.TabIndex = 18;
            this.lblCantTotalUsuarios.Text = "12";
            // 
            // lblTituloTotalUsuarios
            // 
            this.lblTituloTotalUsuarios.AutoSize = true;
            this.lblTituloTotalUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalUsuarios.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTituloTotalUsuarios.Location = new System.Drawing.Point(12, 14);
            this.lblTituloTotalUsuarios.Name = "lblTituloTotalUsuarios";
            this.lblTituloTotalUsuarios.Size = new System.Drawing.Size(104, 15);
            this.lblTituloTotalUsuarios.TabIndex = 19;
            this.lblTituloTotalUsuarios.Text = "Total Usuarios:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(276, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            // 
            // pnlContenedorUsuarios
            // 
            this.pnlContenedorUsuarios.BorderColor = System.Drawing.Color.Gray;
            this.pnlContenedorUsuarios.BorderRadius = 10;
            this.pnlContenedorUsuarios.BorderThickness = 1;
            this.pnlContenedorUsuarios.Controls.Add(this.dgvListaUsuarios);
            this.pnlContenedorUsuarios.Controls.Add(this.lblTituloListaUsusarios);
            this.pnlContenedorUsuarios.Location = new System.Drawing.Point(15, 367);
            this.pnlContenedorUsuarios.Name = "pnlContenedorUsuarios";
            this.pnlContenedorUsuarios.Size = new System.Drawing.Size(1143, 210);
            this.pnlContenedorUsuarios.TabIndex = 25;
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Width = 160;
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
            // 
            // colPerfil
            // 
            this.colPerfil.HeaderText = "Perfil";
            this.colPerfil.Name = "colPerfil";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
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
            // pnlCOntenedorFiltros
            // 
            this.pnlCOntenedorFiltros.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCOntenedorFiltros.BorderRadius = 10;
            this.pnlCOntenedorFiltros.Controls.Add(this.cmbFiltroEstado);
            this.pnlCOntenedorFiltros.Controls.Add(this.lblBuscarPorDniOCorreo);
            this.pnlCOntenedorFiltros.Controls.Add(this.txtBuscarUsusario);
            this.pnlCOntenedorFiltros.Controls.Add(this.lblFiltraEstado);
            this.pnlCOntenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlCOntenedorFiltros.Controls.Add(this.cmbFiltroPerfil);
            this.pnlCOntenedorFiltros.Controls.Add(this.lblFiltraPerfil);
            this.pnlCOntenedorFiltros.FillColor = System.Drawing.Color.Gainsboro;
            this.pnlCOntenedorFiltros.Location = new System.Drawing.Point(597, 177);
            this.pnlCOntenedorFiltros.Name = "pnlCOntenedorFiltros";
            this.pnlCOntenedorFiltros.Size = new System.Drawing.Size(340, 185);
            this.pnlCOntenedorFiltros.TabIndex = 52;
            // 
            // picUsuario
            // 
            this.picUsuario.Location = new System.Drawing.Point(3, 5);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(43, 42);
            this.picUsuario.TabIndex = 3;
            this.picUsuario.TabStop = false;
            // 
            // GestionUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 561);
            this.Controls.Add(this.pnlCOntenedorFiltros);
            this.Controls.Add(this.pnlContenedorUsuarios);
            this.Controls.Add(this.pnlCardTotalUsuarios);
            this.Controls.Add(this.pnlFormularioUsuario);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "GestionUsuariosForm";
            this.Text = "GestionUsuariosForm";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.pnlFormularioUsuario.ResumeLayout(false);
            this.pnlFormularioUsuario.PerformLayout();
            this.pnlCardTotalUsuarios.ResumeLayout(false);
            this.pnlCardTotalUsuarios.PerformLayout();
            this.pnlContenedorUsuarios.ResumeLayout(false);
            this.pnlContenedorUsuarios.PerformLayout();
            this.pnlCOntenedorFiltros.ResumeLayout(false);
            this.pnlCOntenedorFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltraEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Label lblFiltraPerfil;
        private System.Windows.Forms.ComboBox cmbFiltroPerfil;
        private System.Windows.Forms.Label lblTituloListaUsusarios;
        private System.Windows.Forms.Label lblBuscarPorDniOCorreo;
        private Guna.UI2.WinForms.Guna2Panel pnlFormularioUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblTituloInformacionUsuario;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbEstado;
        private Guna.UI2.WinForms.Guna2Button btnAgregarUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtRepetirContrasenia;
        private System.Windows.Forms.Label lblRepetirContrasenia;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarUsusario;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCardTotalUsuarios;
        private System.Windows.Forms.Label lblCantTotalUsuarios;
        private System.Windows.Forms.Label lblTituloTotalUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private Guna.UI2.WinForms.Guna2Panel pnlCOntenedorFiltros;
    }
}