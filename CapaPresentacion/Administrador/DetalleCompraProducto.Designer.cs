namespace CapaPresentacion.Administrador
{
    partial class DetalleCompraProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalleItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalComprados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCuitProveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblDniResponsable = new System.Windows.Forms.Label();
            this.lblDniComprador = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerarComprobante = new Guna.UI2.WinForms.Guna2Button();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleItems
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colCantidad,
            this.colCostoUnitario,
            this.colSubtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleItems.Location = new System.Drawing.Point(6, 183);
            this.dgvDetalleItems.Name = "dgvDetalleItems";
            this.dgvDetalleItems.RowHeadersVisible = false;
            this.dgvDetalleItems.RowTemplate.Height = 23;
            this.dgvDetalleItems.Size = new System.Drawing.Size(503, 309);
            this.dgvDetalleItems.TabIndex = 9;
            this.dgvDetalleItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvDetalleItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleItems.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDetalleItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleItems.ThemeStyle.RowsStyle.Height = 23;
            this.dgvDetalleItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(7, 32);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(208, 17);
            this.lblNroFactura.TabIndex = 19;
            this.lblNroFactura.Text = "Detalle de la compra: XXXX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Proveedor: ";
            // 
            // lblTotalComprados
            // 
            this.lblTotalComprados.AutoSize = true;
            this.lblTotalComprados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComprados.Location = new System.Drawing.Point(302, 145);
            this.lblTotalComprados.Name = "lblTotalComprados";
            this.lblTotalComprados.Size = new System.Drawing.Size(21, 16);
            this.lblTotalComprados.TabIndex = 55;
            this.lblTotalComprados.Text = "34";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Total Comprados: ";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(302, 69);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(132, 16);
            this.lblResponsable.TabIndex = 53;
            this.lblResponsable.Text = "Lombardo, Guillermo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Responsable: ";
            // 
            // lblCuitProveedor
            // 
            this.lblCuitProveedor.AutoSize = true;
            this.lblCuitProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuitProveedor.Location = new System.Drawing.Point(302, 130);
            this.lblCuitProveedor.Name = "lblCuitProveedor";
            this.lblCuitProveedor.Size = new System.Drawing.Size(63, 16);
            this.lblCuitProveedor.TabIndex = 51;
            this.lblCuitProveedor.Text = "22222222";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "CUIT: ";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(302, 113);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(77, 16);
            this.lblProveedor.TabIndex = 49;
            this.lblProveedor.Text = "Perez, Juan";
            // 
            // lblDniResponsable
            // 
            this.lblDniResponsable.AutoSize = true;
            this.lblDniResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniResponsable.Location = new System.Drawing.Point(302, 88);
            this.lblDniResponsable.Name = "lblDniResponsable";
            this.lblDniResponsable.Size = new System.Drawing.Size(63, 16);
            this.lblDniResponsable.TabIndex = 48;
            this.lblDniResponsable.Text = "11111111";
            // 
            // lblDniComprador
            // 
            this.lblDniComprador.AutoSize = true;
            this.lblDniComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniComprador.Location = new System.Drawing.Point(14, 88);
            this.lblDniComprador.Name = "lblDniComprador";
            this.lblDniComprador.Size = new System.Drawing.Size(36, 16);
            this.lblDniComprador.TabIndex = 47;
            this.lblDniComprador.Text = "DNI: ";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(302, 53);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(71, 16);
            this.lblFechaHora.TabIndex = 45;
            this.lblFechaHora.Text = "21/04/2026";
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCompra.Location = new System.Drawing.Point(13, 53);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(94, 16);
            this.lblFechaCompra.TabIndex = 44;
            this.lblFechaCompra.Text = "Fecha y Hora: ";
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeneral.Location = new System.Drawing.Point(418, 495);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(91, 20);
            this.lblTotalGeneral.TabIndex = 58;
            this.lblTotalGeneral.Text = "$XXXXXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "TOTAL:";
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarComprobante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGenerarComprobante.BorderRadius = 5;
            this.btnGenerarComprobante.BorderThickness = 1;
            this.btnGenerarComprobante.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarComprobante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarComprobante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarComprobante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarComprobante.FillColor = System.Drawing.Color.Transparent;
            this.btnGenerarComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarComprobante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGenerarComprobante.Location = new System.Drawing.Point(329, 541);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(180, 33);
            this.btnGenerarComprobante.TabIndex = 59;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            this.btnGenerarComprobante.Click += new System.EventHandler(this.btnGenerarComprobante_Click);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad ";
            this.colCantidad.Name = "colCantidad";
            // 
            // colCostoUnitario
            // 
            this.colCostoUnitario.HeaderText = "Costo Unitario";
            this.colCostoUnitario.Name = "colCostoUnitario";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // DetalleCompraProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 575);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.lblTotalGeneral);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalComprados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCuitProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblDniResponsable);
            this.Controls.Add(this.lblDniComprador);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblFechaCompra);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.dgvDetalleItems);
            this.Name = "DetalleCompraProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleCompraProducto";
            this.Load += new System.EventHandler(this.DetalleCompraProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleItems;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalComprados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCuitProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblDniResponsable;
        private System.Windows.Forms.Label lblDniComprador;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnGenerarComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}