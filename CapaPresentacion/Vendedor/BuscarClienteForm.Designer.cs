namespace CapaPresentacion.Vendedor
{
    partial class BuscarClienteForm
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
            this.pnlContenedorCluentes = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvListaClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTituloListaClientes = new System.Windows.Forms.Label();
            this.pnlContenedorFiltros = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnBuscarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBuscarPorNombreOCorreo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContenedorCluentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.pnlContenedorFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorCluentes
            // 
            this.pnlContenedorCluentes.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlContenedorCluentes.BorderRadius = 8;
            this.pnlContenedorCluentes.BorderThickness = 1;
            this.pnlContenedorCluentes.Controls.Add(this.dgvListaClientes);
            this.pnlContenedorCluentes.Controls.Add(this.lblTituloListaClientes);
            this.pnlContenedorCluentes.FillColor = System.Drawing.Color.Transparent;
            this.pnlContenedorCluentes.Location = new System.Drawing.Point(12, 154);
            this.pnlContenedorCluentes.Name = "pnlContenedorCluentes";
            this.pnlContenedorCluentes.Size = new System.Drawing.Size(707, 275);
            this.pnlContenedorCluentes.TabIndex = 85;
            // 
            // dgvListaClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroCliente,
            this.colDni,
            this.colNombre,
            this.colApellido,
            this.colTelefono,
            this.colDireccion,
            this.colEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaClientes.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.colNroCliente.HeaderText = "Nro Cliente";
            this.colNroCliente.Name = "colNroCliente";
            // 
            // colDni
            // 
            this.colDni.HeaderText = "Nombre";
            this.colDni.Name = "colDni";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Apellido";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "DNI";
            this.colApellido.Name = "colApellido";
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
            this.lblTituloListaClientes.Size = new System.Drawing.Size(126, 16);
            this.lblTituloListaClientes.TabIndex = 6;
            this.lblTituloListaClientes.Text = "Lista de Clientes:";
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedorFiltros.Controls.Add(this.btnBuscarCliente);
            this.pnlContenedorFiltros.Controls.Add(this.txtBuscarCliente);
            this.pnlContenedorFiltros.Controls.Add(this.lblBuscarPorNombreOCorreo);
            this.pnlContenedorFiltros.Controls.Add(this.label3);
            this.pnlContenedorFiltros.FillColor = System.Drawing.Color.White;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(12, 21);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.Radius = 5;
            this.pnlContenedorFiltros.ShadowColor = System.Drawing.Color.Black;
            this.pnlContenedorFiltros.ShadowDepth = 25;
            this.pnlContenedorFiltros.ShadowShift = 3;
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(366, 127);
            this.pnlContenedorFiltros.TabIndex = 84;
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(271, 65);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(71, 27);
            this.btnBuscarCliente.TabIndex = 48;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarCliente.BorderRadius = 5;
            this.txtBuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCliente.DefaultText = "";
            this.txtBuscarCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.Location = new System.Drawing.Point(9, 65);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PlaceholderText = "";
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.Size = new System.Drawing.Size(257, 27);
            this.txtBuscarCliente.TabIndex = 46;
            // 
            // lblBuscarPorNombreOCorreo
            // 
            this.lblBuscarPorNombreOCorreo.AutoSize = true;
            this.lblBuscarPorNombreOCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarPorNombreOCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorNombreOCorreo.Location = new System.Drawing.Point(6, 45);
            this.lblBuscarPorNombreOCorreo.Name = "lblBuscarPorNombreOCorreo";
            this.lblBuscarPorNombreOCorreo.Size = new System.Drawing.Size(242, 17);
            this.lblBuscarPorNombreOCorreo.TabIndex = 47;
            this.lblBuscarPorNombreOCorreo.Text = "Buscar por DNI , Nombre o Telefono:";
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
            // BuscarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.pnlContenedorCluentes);
            this.Controls.Add(this.pnlContenedorFiltros);
            this.Name = "BuscarClienteForm";
            this.Text = "BuscarCliente";
            this.pnlContenedorCluentes.ResumeLayout(false);
            this.pnlContenedorCluentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlContenedorCluentes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListaClientes;
        private System.Windows.Forms.Label lblTituloListaClientes;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlContenedorFiltros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewButtonColumn colEstado;
        private Guna.UI2.WinForms.Guna2Button btnBuscarCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscarPorNombreOCorreo;
    }
}