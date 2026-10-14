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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlnfoUsuario = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblFiltraEstado = new System.Windows.Forms.Label();
            this.lblFiltraPerfil = new System.Windows.Forms.Label();
            this.lblBuscarPorDniOCorreo = new System.Windows.Forms.Label();
            this.lblCantTotalUsuarios = new System.Windows.Forms.Label();
            this.lblTituloTotalUsuarios = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cmbFiltroPerfil = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFiltroEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlContenedorUsuarios = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvListaUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTituloListaUsuarios = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNuevoUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCardTotalUsuarios = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportarPDF = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportarEXCEL = new Guna.UI2.WinForms.Guna2Button();
            this.btnFiltrarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarUsuario = new Guna.UI2.WinForms.Guna2Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnlEncabezado.SuspendLayout();
            this.pnlnfoUsuario.SuspendLayout();
            this.pnlContenedorFiltros.SuspendLayout();
            this.pnlContenedorUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlCardTotalUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.Location = new System.Drawing.Point(15, 93);
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
            this.lblFiltraEstado.Location = new System.Drawing.Point(135, 110);
            this.lblFiltraEstado.Name = "lblFiltraEstado";
            this.lblFiltraEstado.Size = new System.Drawing.Size(52, 17);
            this.lblFiltraEstado.TabIndex = 12;
            this.lblFiltraEstado.Text = "Estado";
            // 
            // lblFiltraPerfil
            // 
            this.lblFiltraPerfil.AutoSize = true;
            this.lblFiltraPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltraPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltraPerfil.Location = new System.Drawing.Point(15, 110);
            this.lblFiltraPerfil.Name = "lblFiltraPerfil";
            this.lblFiltraPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblFiltraPerfil.TabIndex = 11;
            this.lblFiltraPerfil.Text = "Perfil";
            // 
            // lblBuscarPorDniOCorreo
            // 
            this.lblBuscarPorDniOCorreo.AutoSize = true;
            this.lblBuscarPorDniOCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorDniOCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorDniOCorreo.Location = new System.Drawing.Point(7, 36);
            this.lblBuscarPorDniOCorreo.Name = "lblBuscarPorDniOCorreo";
            this.lblBuscarPorDniOCorreo.Size = new System.Drawing.Size(167, 17);
            this.lblBuscarPorDniOCorreo.TabIndex = 22;
            this.lblBuscarPorDniOCorreo.Text = "Buscar por DNI o Correo:";
            // 
            // lblCantTotalUsuarios
            // 
            this.lblCantTotalUsuarios.AutoSize = true;
            this.lblCantTotalUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblCantTotalUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.lblCantTotalUsuarios.Location = new System.Drawing.Point(36, 36);
            this.lblCantTotalUsuarios.Name = "lblCantTotalUsuarios";
            this.lblCantTotalUsuarios.Size = new System.Drawing.Size(40, 42);
            this.lblCantTotalUsuarios.TabIndex = 19;
            this.lblCantTotalUsuarios.Text = "0";
            // 
            // lblTituloTotalUsuarios
            // 
            this.lblTituloTotalUsuarios.AutoSize = true;
            this.lblTituloTotalUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloTotalUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblTituloTotalUsuarios.Location = new System.Drawing.Point(3, 10);
            this.lblTituloTotalUsuarios.Name = "lblTituloTotalUsuarios";
            this.lblTituloTotalUsuarios.Size = new System.Drawing.Size(113, 16);
            this.lblTituloTotalUsuarios.TabIndex = 5;
            this.lblTituloTotalUsuarios.Text = "Total Usuarios:";
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrarUsuario);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarUsuario);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroPerfil);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarUsuario);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltraEstado);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroEstado);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltrarPor);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorDniOCorreo);
            this.pnlContenedorFiltros.Controls.Add(this.lblFiltraPerfil);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(17, 85);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowShift = 4;
            this.pnlContenedorFiltros.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(558, 170);
            this.pnlContenedorFiltros.TabIndex = 54;
            // 
            // cmbFiltroPerfil
            // 
            this.cmbFiltroPerfil.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroPerfil.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbFiltroPerfil.BorderRadius = 5;
            this.cmbFiltroPerfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroPerfil.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroPerfil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFiltroPerfil.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPerfil.ItemHeight = 21;
            this.cmbFiltroPerfil.Items.AddRange(new object[] {
            "Todos",
            "Administrador",
            "Gerente Comercial",
            "Vendedor"});
            this.cmbFiltroPerfil.Location = new System.Drawing.Point(14, 130);
            this.cmbFiltroPerfil.Name = "cmbFiltroPerfil";
            this.cmbFiltroPerfil.Size = new System.Drawing.Size(118, 27);
            this.cmbFiltroPerfil.StartIndex = 0;
            this.cmbFiltroPerfil.TabIndex = 23;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarUsuario.BorderRadius = 5;
            this.txtBuscarUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarUsuario.DefaultText = "";
            this.txtBuscarUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarUsuario.Location = new System.Drawing.Point(10, 56);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.PlaceholderText = "";
            this.txtBuscarUsuario.SelectedText = "";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(242, 27);
            this.txtBuscarUsuario.TabIndex = 0;
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroEstado.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbFiltroEstado.BorderRadius = 5;
            this.cmbFiltroEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFiltroEstado.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroEstado.ItemHeight = 21;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(138, 130);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(121, 27);
            this.cmbFiltroEstado.StartIndex = 0;
            this.cmbFiltroEstado.TabIndex = 1;
            // 
            // pnlContenedorUsuarios
            // 
            this.pnlContenedorUsuarios.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorUsuarios.BorderRadius = 8;
            this.pnlContenedorUsuarios.BorderThickness = 1;
            this.pnlContenedorUsuarios.Controls.Add(this.btnExportarPDF);
            this.pnlContenedorUsuarios.Controls.Add(this.btnExportarEXCEL);
            this.pnlContenedorUsuarios.Controls.Add(this.dgvListaUsuarios);
            this.pnlContenedorUsuarios.Controls.Add(this.lblTituloListaUsuarios);
            this.pnlContenedorUsuarios.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorUsuarios.Location = new System.Drawing.Point(9, 281);
            this.pnlContenedorUsuarios.Name = "pnlContenedorUsuarios";
            this.pnlContenedorUsuarios.Size = new System.Drawing.Size(1149, 350);
            this.pnlContenedorUsuarios.TabIndex = 55;
            // 
            // dgvListaUsuarios
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaUsuarios.ColumnHeadersHeight = 30;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaUsuarios.Location = new System.Drawing.Point(3, 47);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.RowHeadersVisible = false;
            this.dgvListaUsuarios.RowTemplate.Height = 25;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(1139, 300);
            this.dgvListaUsuarios.TabIndex = 7;
            this.dgvListaUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvListaUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaUsuarios.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvListaUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaUsuarios.ThemeStyle.RowsStyle.Height = 25;
            this.dgvListaUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellContentClick);
            this.dgvListaUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaUsuarios_CellFormatting);
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
            this.colEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEditar.Name = "colEditar";
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblTituloListaUsuarios
            // 
            this.lblTituloListaUsuarios.AutoSize = true;
            this.lblTituloListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblTituloListaUsuarios.Location = new System.Drawing.Point(5, 15);
            this.lblTituloListaUsuarios.Name = "lblTituloListaUsuarios";
            this.lblTituloListaUsuarios.Size = new System.Drawing.Size(129, 16);
            this.lblTituloListaUsuarios.TabIndex = 6;
            this.lblTituloListaUsuarios.Text = "Lista de usuarios:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoUsuario.BorderRadius = 5;
            this.btnNuevoUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevoUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevoUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevoUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(1012, 240);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(146, 35);
            this.btnNuevoUsuario.TabIndex = 58;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // pnlCardTotalUsuarios
            // 
            this.pnlCardTotalUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardTotalUsuarios.Controls.Add(this.pictureBox1);
            this.pnlCardTotalUsuarios.Controls.Add(this.lblCantTotalUsuarios);
            this.pnlCardTotalUsuarios.Controls.Add(this.lblTituloTotalUsuarios);
            this.pnlCardTotalUsuarios.FillColor = System.Drawing.Color.White;
            this.pnlCardTotalUsuarios.Location = new System.Drawing.Point(606, 85);
            this.pnlCardTotalUsuarios.Name = "pnlCardTotalUsuarios";
            this.pnlCardTotalUsuarios.ShadowColor = System.Drawing.Color.Black;
            this.pnlCardTotalUsuarios.ShadowShift = 4;
            this.pnlCardTotalUsuarios.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlCardTotalUsuarios.Size = new System.Drawing.Size(186, 91);
            this.pnlCardTotalUsuarios.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.icono_usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(113, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
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
            this.btnExportarPDF.Location = new System.Drawing.Point(873, 8);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(125, 35);
            this.btnExportarPDF.TabIndex = 10;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
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
            this.btnExportarEXCEL.Location = new System.Drawing.Point(1013, 8);
            this.btnExportarEXCEL.Name = "btnExportarEXCEL";
            this.btnExportarEXCEL.Size = new System.Drawing.Size(125, 35);
            this.btnExportarEXCEL.TabIndex = 9;
            this.btnExportarEXCEL.Text = "Exportar Excel";
            // 
            // btnFiltrarUsuario
            // 
            this.btnFiltrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarUsuario.BorderRadius = 5;
            this.btnFiltrarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltrarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltrarUsuario.FillColor = System.Drawing.Color.Silver;
            this.btnFiltrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnFiltrarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrarUsuario.Image = global::CapaPresentacion.Properties.Resources.icono_filtro;
            this.btnFiltrarUsuario.Location = new System.Drawing.Point(265, 130);
            this.btnFiltrarUsuario.Name = "btnFiltrarUsuario";
            this.btnFiltrarUsuario.Size = new System.Drawing.Size(71, 27);
            this.btnFiltrarUsuario.TabIndex = 46;
            this.btnFiltrarUsuario.Text = "Filtrar";
            this.btnFiltrarUsuario.Click += new System.EventHandler(this.btnFiltrarUsuario_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuario.BorderRadius = 5;
            this.btnBuscarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarUsuario.FillColor = System.Drawing.Color.Silver;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.Image = global::CapaPresentacion.Properties.Resources.icono_lupa;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(258, 56);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(71, 27);
            this.btnBuscarUsuario.TabIndex = 45;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
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
            this.Controls.Add(this.pnlCardTotalUsuarios);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.pnlContenedorUsuarios);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "GestionUsuariosForm";
            this.Text = "GestionUsuariosForm";
            this.Load += new System.EventHandler(this.GestionUsuariosForm_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlnfoUsuario.ResumeLayout(false);
            this.pnlnfoUsuario.PerformLayout();
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.pnlContenedorUsuarios.ResumeLayout(false);
            this.pnlContenedorUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlCardTotalUsuarios.ResumeLayout(false);
            this.pnlCardTotalUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblFiltraEstado;
        private System.Windows.Forms.Label lblFiltraPerfil;
        private System.Windows.Forms.Label lblBuscarPorDniOCorreo;
        private System.Windows.Forms.Label lblCantTotalUsuarios;
        private System.Windows.Forms.Label lblTituloTotalUsuarios;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroPerfil;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroEstado;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnExportarPDF;
        private Guna.UI2.WinForms.Guna2Button btnExportarEXCEL;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Label lblTituloListaUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnBuscarUsuario;
        private Guna.UI2.WinForms.Guna2Button btnFiltrarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnNuevoUsuario;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCardTotalUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}