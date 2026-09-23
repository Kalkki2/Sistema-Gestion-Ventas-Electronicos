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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBuscarPorCodONombre = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnFiltrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscarProveedor = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlContenedorCluentes = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvListaClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloListaClientes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlContenedorFiltros.SuspendLayout();
            this.pnlContenedorCluentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
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
            this.pnlContenedorFiltros.Controls.Add(this.btnFiltrar);
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarProveedor);
            this.pnlContenedorFiltros.Controls.Add(this.guna2ComboBox1);
            this.pnlContenedorFiltros.Controls.Add(this.guna2ComboBox2);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarProveedor);
            this.pnlContenedorFiltros.Controls.Add(this.label2);
            this.pnlContenedorFiltros.Controls.Add(this.label3);
            this.pnlContenedorFiltros.Controls.Add(this.label4);
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
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.BorderRadius = 5;
            this.btnFiltrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltrar.FillColor = System.Drawing.Color.Silver;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Image = global::CapaPresentacion.Properties.Resources.icono_filtro;
            this.btnFiltrar.Location = new System.Drawing.Point(618, 65);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(71, 27);
            this.btnFiltrar.TabIndex = 45;
            this.btnFiltrar.Text = "Filtrar";
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
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.ItemHeight = 21;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Todos"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(479, 65);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(118, 27);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 24;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ComboBox2.BorderRadius = 5;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox2.ItemHeight = 21;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Todos"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(355, 65);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(118, 27);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 22;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marca";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria ";
            // 
            // pnlContenedorCluentes
            // 
            this.pnlContenedorCluentes.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorCluentes.BorderRadius = 8;
            this.pnlContenedorCluentes.BorderThickness = 1;
            this.pnlContenedorCluentes.Controls.Add(this.dgvListaClientes);
            this.pnlContenedorCluentes.Controls.Add(this.lblTituloListaClientes);
            this.pnlContenedorCluentes.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCluentes.Location = new System.Drawing.Point(12, 163);
            this.pnlContenedorCluentes.Name = "pnlContenedorCluentes";
            this.pnlContenedorCluentes.Size = new System.Drawing.Size(707, 254);
            this.pnlContenedorCluentes.TabIndex = 84;
            // 
            // dgvListaClientes
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCliente,
            this.colDni,
            this.dataGridViewTextBoxColumn1,
            this.colApellido,
            this.colEstado});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaClientes.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvListaClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListaClientes.Location = new System.Drawing.Point(4, 34);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.RowHeadersVisible = false;
            this.dgvListaClientes.RowTemplate.Height = 23;
            this.dgvListaClientes.Size = new System.Drawing.Size(700, 214);
            this.dgvListaClientes.TabIndex = 7;
            this.dgvListaClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvListaClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaClientes.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvListaClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaClientes.ThemeStyle.RowsStyle.Height = 23;
            this.dgvListaClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // colNroCliente
            // 
            this.colNroCliente.HeaderText = "CUIT";
            this.colNroCliente.Name = "colNroCliente";
            // 
            // colDni
            // 
            this.colDni.HeaderText = "Nombre";
            this.colDni.Name = "colDni";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Marca";
            this.colApellido.Name = "colApellido";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Seleccionar";
            this.colEstado.Name = "colEstado";
            this.colEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblTituloListaClientes
            // 
            this.lblTituloListaClientes.AutoSize = true;
            this.lblTituloListaClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaClientes.ForeColor = System.Drawing.Color.Black;
            this.lblTituloListaClientes.Location = new System.Drawing.Point(3, 15);
            this.lblTituloListaClientes.Name = "lblTituloListaClientes";
            this.lblTituloListaClientes.Size = new System.Drawing.Size(139, 16);
            this.lblTituloListaClientes.TabIndex = 6;
            this.lblTituloListaClientes.Text = "Lista de productos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 85;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlContenedorCluentes);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BuscarProveedorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProveedorForm";
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.pnlContenedorCluentes.ResumeLayout(false);
            this.pnlContenedorCluentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBuscarPorCodONombre;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private Guna.UI2.WinForms.Guna2Button btnFiltrar;
        private Guna.UI2.WinForms.Guna2Button btnBuscarProveedor;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedorCluentes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewButtonColumn colEstado;
        private System.Windows.Forms.Label lblTituloListaClientes;
        private System.Windows.Forms.Button button1;
    }
}