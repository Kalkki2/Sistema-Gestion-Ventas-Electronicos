namespace CapaPresentacion.Administrador
{
    partial class BuscarProveedorForm
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
            this.lblBuscarPorCodONombre = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtBuscarProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlContenedorCluentes = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvListaProveedores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTituloListaProveedores = new System.Windows.Forms.Label();
            this.colNroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbFiltroCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros.SuspendLayout();
            this.pnlContenedorCluentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPorCodONombre
            // 
            this.lblBuscarPorCodONombre.AutoSize = true;
            this.lblBuscarPorCodONombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCodONombre.Location = new System.Drawing.Point(17, 50);
            this.lblBuscarPorCodONombre.Name = "lblBuscarPorCodONombre";
            this.lblBuscarPorCodONombre.Size = new System.Drawing.Size(175, 17);
            this.lblBuscarPorCodONombre.TabIndex = 21;
            this.lblBuscarPorCodONombre.Text = "Buscar por CUIT o Correo:";
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.label1);
            this.pnlContenedorFiltros.Controls.Add(this.cmbFiltroCategoria);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorCodONombre);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarProveedor);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(12, 12);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowDepth = 25;
            this.pnlContenedorFiltros.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(491, 127);
            this.pnlContenedorFiltros.TabIndex = 44;
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProveedor.BorderRadius = 5;
            this.txtBuscarProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProveedor.DefaultText = "";
            this.txtBuscarProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBuscarProveedor.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProveedor.IconLeft = global::CapaPresentacion.Properties.Resources.icono_lupa;
            this.txtBuscarProveedor.Location = new System.Drawing.Point(15, 70);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.PlaceholderText = "";
            this.txtBuscarProveedor.SelectedText = "";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(242, 27);
            this.txtBuscarProveedor.TabIndex = 0;
            this.txtBuscarProveedor.TextChanged += new System.EventHandler(this.txtBuscarProveedor_TextChanged);
            // 
            // pnlContenedorCluentes
            // 
            this.pnlContenedorCluentes.BorderColor = System.Drawing.Color.DimGray;
            this.pnlContenedorCluentes.BorderThickness = 1;
            this.pnlContenedorCluentes.Controls.Add(this.dgvListaProveedores);
            this.pnlContenedorCluentes.Controls.Add(this.lblTituloListaProveedores);
            this.pnlContenedorCluentes.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCluentes.Location = new System.Drawing.Point(12, 163);
            this.pnlContenedorCluentes.Name = "pnlContenedorCluentes";
            this.pnlContenedorCluentes.Size = new System.Drawing.Size(707, 265);
            this.pnlContenedorCluentes.TabIndex = 84;
            // 
            // dgvListaProveedores
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCuit,
            this.colNombre,
            this.colCorreo,
            this.colTelefono,
            this.btnSeleccionar});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProveedores.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaProveedores.Location = new System.Drawing.Point(9, 40);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.RowHeadersVisible = false;
            this.dgvListaProveedores.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProveedores.RowTemplate.Height = 23;
            this.dgvListaProveedores.Size = new System.Drawing.Size(695, 214);
            this.dgvListaProveedores.TabIndex = 8;
            this.dgvListaProveedores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProveedores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvListaProveedores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListaProveedores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProveedores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaProveedores.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvListaProveedores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProveedores.ThemeStyle.RowsStyle.Height = 23;
            this.dgvListaProveedores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvListaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedores_CellContentClick);
            // 
            // colCuit
            // 
            this.colCuit.FillWeight = 60F;
            this.colCuit.HeaderText = "CUIT";
            this.colCuit.Name = "colCuit";
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 160F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 55F;
            this.btnSeleccionar.HeaderText = "Seleccionar";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblTituloListaProveedores
            // 
            this.lblTituloListaProveedores.AutoSize = true;
            this.lblTituloListaProveedores.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaProveedores.ForeColor = System.Drawing.Color.Black;
            this.lblTituloListaProveedores.Location = new System.Drawing.Point(3, 15);
            this.lblTituloListaProveedores.Name = "lblTituloListaProveedores";
            this.lblTituloListaProveedores.Size = new System.Drawing.Size(159, 16);
            this.lblTituloListaProveedores.TabIndex = 6;
            this.lblTituloListaProveedores.Text = "Lista de proveedores:";
            // 
            // colNroCliente
            // 
            this.colNroCliente.HeaderText = "CUIT";
            this.colNroCliente.Name = "colNroCliente";
            this.colNroCliente.Width = 140;
            // 
            // colDni
            // 
            this.colDni.HeaderText = "Nombre";
            this.colDni.Name = "colDni";
            this.colDni.Width = 140;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Marca";
            this.colApellido.Name = "colApellido";
            this.colApellido.Width = 140;
            // 
            // colSeleccionar
            // 
            this.colSeleccionar.HeaderText = "Seleccionar";
            this.colSeleccionar.Name = "colSeleccionar";
            this.colSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSeleccionar.Width = 140;
            // 
            // cmbFiltroCategoria
            // 
            this.cmbFiltroCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltroCategoria.BorderColor = System.Drawing.Color.DarkGray;
            this.cmbFiltroCategoria.BorderRadius = 5;
            this.cmbFiltroCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbFiltroCategoria.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroCategoria.ItemHeight = 21;
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(307, 70);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(141, 27);
            this.cmbFiltroCategoria.StartIndex = 0;
            this.cmbFiltroCategoria.TabIndex = 23;
            this.cmbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Categoria:";
            // 
            // BuscarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenedorCluentes);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BuscarProveedorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProveedorForm";
            this.Load += new System.EventHandler(this.BuscarProveedorForm_Load);
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.pnlContenedorCluentes.ResumeLayout(false);
            this.pnlContenedorCluentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBuscarPorCodONombre;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProveedor;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorCluentes;
        private System.Windows.Forms.Label lblTituloListaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewButtonColumn colSeleccionar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewImageColumn btnSeleccionar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.Label label1;
    }
}