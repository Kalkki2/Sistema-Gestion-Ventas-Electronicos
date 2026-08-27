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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCardTotalUsuarios = new System.Windows.Forms.Panel();
            this.lblCantTotalUsuarios = new System.Windows.Forms.Label();
            this.lblTituloTotalUsuarios = new System.Windows.Forms.Label();
            this.pnlContenedorCatalogo = new System.Windows.Forms.Panel();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltrarEstado = new System.Windows.Forms.Label();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblFiltrarPerfil = new System.Windows.Forms.Label();
            this.cmbFiltroPerfil = new System.Windows.Forms.ComboBox();
            this.lblTituloListaUsusarios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRepetirContrasenia = new System.Windows.Forms.TextBox();
            this.lblRepetirContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlCardTotalUsuarios.SuspendLayout();
            this.pnlContenedorCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(224, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gestion de usuarios";
            // 
            // pnlCardTotalUsuarios
            // 
            this.pnlCardTotalUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardTotalUsuarios.Controls.Add(this.lblCantTotalUsuarios);
            this.pnlCardTotalUsuarios.Controls.Add(this.lblTituloTotalUsuarios);
            this.pnlCardTotalUsuarios.Location = new System.Drawing.Point(308, 92);
            this.pnlCardTotalUsuarios.Name = "pnlCardTotalUsuarios";
            this.pnlCardTotalUsuarios.Size = new System.Drawing.Size(173, 67);
            this.pnlCardTotalUsuarios.TabIndex = 17;
            // 
            // lblCantTotalUsuarios
            // 
            this.lblCantTotalUsuarios.AutoSize = true;
            this.lblCantTotalUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalUsuarios.Location = new System.Drawing.Point(19, 27);
            this.lblCantTotalUsuarios.Name = "lblCantTotalUsuarios";
            this.lblCantTotalUsuarios.Size = new System.Drawing.Size(46, 31);
            this.lblCantTotalUsuarios.TabIndex = 17;
            this.lblCantTotalUsuarios.Text = "10";
            // 
            // lblTituloTotalUsuarios
            // 
            this.lblTituloTotalUsuarios.AutoSize = true;
            this.lblTituloTotalUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTotalUsuarios.Name = "lblTituloTotalUsuarios";
            this.lblTituloTotalUsuarios.Size = new System.Drawing.Size(75, 13);
            this.lblTituloTotalUsuarios.TabIndex = 17;
            this.lblTituloTotalUsuarios.Text = "Total Usuarios";
            // 
            // pnlContenedorCatalogo
            // 
            this.pnlContenedorCatalogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContenedorCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorCatalogo.Controls.Add(this.dgvListaUsuarios);
            this.pnlContenedorCatalogo.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorCatalogo.Controls.Add(this.lblFiltrarEstado);
            this.pnlContenedorCatalogo.Controls.Add(this.cmbFiltroEstado);
            this.pnlContenedorCatalogo.Controls.Add(this.txtBuscarUsuario);
            this.pnlContenedorCatalogo.Controls.Add(this.lblFiltrarPerfil);
            this.pnlContenedorCatalogo.Controls.Add(this.cmbFiltroPerfil);
            this.pnlContenedorCatalogo.Controls.Add(this.lblTituloListaUsusarios);
            this.pnlContenedorCatalogo.Location = new System.Drawing.Point(308, 180);
            this.pnlContenedorCatalogo.Name = "pnlContenedorCatalogo";
            this.pnlContenedorCatalogo.Size = new System.Drawing.Size(863, 369);
            this.pnlContenedorCatalogo.TabIndex = 16;
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDni,
            this.colNombre,
            this.colApellido,
            this.colCorreo,
            this.colPerfil,
            this.colEstado,
            this.colEditar,
            this.colEliminar});
            this.dgvListaUsuarios.Location = new System.Drawing.Point(3, 97);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.RowHeadersVisible = false;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(854, 63);
            this.dgvListaUsuarios.TabIndex = 17;
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
            this.colNombre.Width = 130;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Width = 130;
            // 
            // colCorreo
            // 
            this.colCorreo.HeaderText = "Correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Width = 160;
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
            // lblFiltrarEstado
            // 
            this.lblFiltrarEstado.AutoSize = true;
            this.lblFiltrarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarEstado.Location = new System.Drawing.Point(547, 36);
            this.lblFiltrarEstado.Name = "lblFiltrarEstado";
            this.lblFiltrarEstado.Size = new System.Drawing.Size(52, 17);
            this.lblFiltrarEstado.TabIndex = 12;
            this.lblFiltrarEstado.Text = "Estado";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(550, 59);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(152, 24);
            this.cmbFiltroEstado.TabIndex = 13;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(6, 56);
            this.txtBuscarUsuario.Multiline = true;
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(277, 27);
            this.txtBuscarUsuario.TabIndex = 11;
            // 
            // lblFiltrarPerfil
            // 
            this.lblFiltrarPerfil.AutoSize = true;
            this.lblFiltrarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPerfil.Location = new System.Drawing.Point(389, 36);
            this.lblFiltrarPerfil.Name = "lblFiltrarPerfil";
            this.lblFiltrarPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblFiltrarPerfil.TabIndex = 11;
            this.lblFiltrarPerfil.Text = "Perfil";
            // 
            // cmbFiltroPerfil
            // 
            this.cmbFiltroPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroPerfil.FormattingEnabled = true;
            this.cmbFiltroPerfil.Items.AddRange(new object[] {
            "Dueño",
            "Administrador",
            "Vendedor",
            "Cajero"});
            this.cmbFiltroPerfil.Location = new System.Drawing.Point(392, 59);
            this.cmbFiltroPerfil.Name = "cmbFiltroPerfil";
            this.cmbFiltroPerfil.Size = new System.Drawing.Size(152, 24);
            this.cmbFiltroPerfil.TabIndex = 11;
            // 
            // lblTituloListaUsusarios
            // 
            this.lblTituloListaUsusarios.AutoSize = true;
            this.lblTituloListaUsusarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaUsusarios.Location = new System.Drawing.Point(12, 11);
            this.lblTituloListaUsusarios.Name = "lblTituloListaUsusarios";
            this.lblTituloListaUsusarios.Size = new System.Drawing.Size(133, 17);
            this.lblTituloListaUsusarios.TabIndex = 9;
            this.lblTituloListaUsusarios.Text = "Lista de usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtRepetirContrasenia);
            this.panel1.Controls.Add(this.lblRepetirContrasenia);
            this.panel1.Controls.Add(this.txtContrasenia);
            this.panel1.Controls.Add(this.lblContrasenia);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.lblPerfil);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.cmbPerfil);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Location = new System.Drawing.Point(7, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 462);
            this.panel1.TabIndex = 18;
            // 
            // txtRepetirContrasenia
            // 
            this.txtRepetirContrasenia.Location = new System.Drawing.Point(18, 327);
            this.txtRepetirContrasenia.Multiline = true;
            this.txtRepetirContrasenia.Name = "txtRepetirContrasenia";
            this.txtRepetirContrasenia.Size = new System.Drawing.Size(222, 25);
            this.txtRepetirContrasenia.TabIndex = 27;
            // 
            // lblRepetirContrasenia
            // 
            this.lblRepetirContrasenia.AutoSize = true;
            this.lblRepetirContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirContrasenia.Location = new System.Drawing.Point(15, 303);
            this.lblRepetirContrasenia.Name = "lblRepetirContrasenia";
            this.lblRepetirContrasenia.Size = new System.Drawing.Size(135, 17);
            this.lblRepetirContrasenia.TabIndex = 26;
            this.lblRepetirContrasenia.Text = "Repetir contrasrña *";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(18, 266);
            this.txtContrasenia.Multiline = true;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(222, 25);
            this.txtContrasenia.TabIndex = 25;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(15, 242);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(90, 17);
            this.lblContrasenia.TabIndex = 24;
            this.lblContrasenia.Text = "Contraseña *";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(139, 355);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(142, 375);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(102, 24);
            this.cmbEstado.TabIndex = 22;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(21, 155);
            this.txtDni.Multiline = true;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(222, 27);
            this.txtDni.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 419);
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
            this.lblDNI.Location = new System.Drawing.Point(18, 135);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 17);
            this.lblDNI.TabIndex = 20;
            this.lblDNI.Text = "DNI *";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(142, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 34);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Agregar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(15, 355);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblPerfil.TabIndex = 14;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(21, 217);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(222, 25);
            this.txtCorreo.TabIndex = 19;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Dueño",
            "Administrador",
            "Vendedor",
            "Cajero"});
            this.cmbPerfil.Location = new System.Drawing.Point(18, 375);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(102, 24);
            this.cmbPerfil.TabIndex = 13;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(18, 193);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(60, 17);
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "Correo *";
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
            // GestionUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCardTotalUsuarios);
            this.Controls.Add(this.pnlContenedorCatalogo);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "GestionUsuariosForm";
            this.Text = "GestionUsuariosForm";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlCardTotalUsuarios.ResumeLayout(false);
            this.pnlCardTotalUsuarios.PerformLayout();
            this.pnlContenedorCatalogo.ResumeLayout(false);
            this.pnlContenedorCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel pnlCardTotalUsuarios;
        private System.Windows.Forms.Label lblCantTotalUsuarios;
        private System.Windows.Forms.Label lblTituloTotalUsuarios;
        private System.Windows.Forms.Panel pnlContenedorCatalogo;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltrarEstado;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label lblFiltrarPerfil;
        private System.Windows.Forms.ComboBox cmbFiltroPerfil;
        private System.Windows.Forms.Label lblTituloListaUsusarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRepetirContrasenia;
        private System.Windows.Forms.Label lblRepetirContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}