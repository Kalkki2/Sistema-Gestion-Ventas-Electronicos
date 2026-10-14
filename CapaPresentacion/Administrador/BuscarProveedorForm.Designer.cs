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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBuscarPorCodONombre = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnBuscarProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContenedorCluentes = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvListaProveedores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloListaProveedores = new System.Windows.Forms.Label();
            this.colNroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlContenedorFiltros.SuspendLayout();
            this.pnlContenedorCluentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPorCodONombre
            // 
            this.lblBuscarPorCodONombre.AutoSize = true;
            this.lblBuscarPorCodONombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCodONombre.Location = new System.Drawing.Point(6, 45);
            this.lblBuscarPorCodONombre.Name = "lblBuscarPorCodONombre";
            this.lblBuscarPorCodONombre.Size = new System.Drawing.Size(182, 17);
            this.lblBuscarPorCodONombre.TabIndex = 21;
            this.lblBuscarPorCodONombre.Text = "Buscar por CUIT o Nombre:";
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorCodONombre);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarProveedor);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarProveedor);
            this.pnlContenedorFiltros.Controls.Add(this.label3);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(12, 12);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.Radius = 5;
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowDepth = 25;
            this.pnlContenedorFiltros.ShadowShift = 3;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(707, 127);
            this.pnlContenedorFiltros.TabIndex = 44;
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
            this.btnBuscarProveedor.Location = new System.Drawing.Point(252, 65);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(71, 27);
            this.btnBuscarProveedor.TabIndex = 44;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
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
            this.txtBuscarProveedor.Location = new System.Drawing.Point(4, 65);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.PlaceholderText = "";
            this.txtBuscarProveedor.SelectedText = "";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(242, 27);
            this.txtBuscarProveedor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filtrar por:";
            // 
            // pnlContenedorCluentes
            // 
            this.pnlContenedorCluentes.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorCluentes.BorderRadius = 8;
            this.pnlContenedorCluentes.BorderThickness = 1;
            this.pnlContenedorCluentes.Controls.Add(this.dgvListaProveedores);
            this.pnlContenedorCluentes.Controls.Add(this.lblTituloListaProveedores);
            this.pnlContenedorCluentes.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCluentes.Location = new System.Drawing.Point(12, 163);
            this.pnlContenedorCluentes.Name = "pnlContenedorCluentes";
            this.pnlContenedorCluentes.Size = new System.Drawing.Size(707, 254);
            this.pnlContenedorCluentes.TabIndex = 84;
            // 
            // dgvListaProveedores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCuit,
            this.colNombre,
            this.colCorreo,
            this.colTelefono,
            this.dataGridViewButtonColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaProveedores.Location = new System.Drawing.Point(9, 40);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.RowHeadersVisible = false;
            this.dgvListaProveedores.RowTemplate.Height = 23;
            this.dgvListaProveedores.Size = new System.Drawing.Size(680, 214);
            this.dgvListaProveedores.TabIndex = 8;
            this.dgvListaProveedores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaProveedores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
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
            this.colCuit.HeaderText = "CUIT";
            this.colCuit.Name = "colCuit";
            // 
            // colNombre
            // 
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
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Seleccionar";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // BuscarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
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
        private Guna.UI2.WinForms.Guna2Button btnBuscarProveedor;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}