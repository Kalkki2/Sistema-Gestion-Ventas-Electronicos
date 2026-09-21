namespace CapaPresentacion.Administrador
{
    partial class DetalleCompra
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnGenerarComprobante = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorClienteComprador = new System.Windows.Forms.Label();
            this.lblValorDniComprador = new System.Windows.Forms.Label();
            this.lblDniComprador = new System.Windows.Forms.Label();
            this.lblValorHoraCompra = new System.Windows.Forms.Label();
            this.lblValorFechaCompra = new System.Windows.Forms.Label();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.lblValorNroCompra = new System.Windows.Forms.Label();
            this.lblNroCompra = new System.Windows.Forms.Label();
            this.lblTiqueFactura = new System.Windows.Forms.Label();
            this.dgvDetalleCompra = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Cliente: ";
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
            this.btnGenerarComprobante.Location = new System.Drawing.Point(280, 532);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(180, 33);
            this.btnGenerarComprobante.TabIndex = 62;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "$XXXXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Efectivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Forma pago: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Pereira, Luciana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Vendedor: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "22222222";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "DNI: ";
            // 
            // lblValorClienteComprador
            // 
            this.lblValorClienteComprador.AutoSize = true;
            this.lblValorClienteComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorClienteComprador.Location = new System.Drawing.Point(311, 104);
            this.lblValorClienteComprador.Name = "lblValorClienteComprador";
            this.lblValorClienteComprador.Size = new System.Drawing.Size(77, 16);
            this.lblValorClienteComprador.TabIndex = 53;
            this.lblValorClienteComprador.Text = "Perez, Juan";
            // 
            // lblValorDniComprador
            // 
            this.lblValorDniComprador.AutoSize = true;
            this.lblValorDniComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDniComprador.Location = new System.Drawing.Point(311, 79);
            this.lblValorDniComprador.Name = "lblValorDniComprador";
            this.lblValorDniComprador.Size = new System.Drawing.Size(63, 16);
            this.lblValorDniComprador.TabIndex = 52;
            this.lblValorDniComprador.Text = "11111111";
            // 
            // lblDniComprador
            // 
            this.lblDniComprador.AutoSize = true;
            this.lblDniComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniComprador.Location = new System.Drawing.Point(23, 79);
            this.lblDniComprador.Name = "lblDniComprador";
            this.lblDniComprador.Size = new System.Drawing.Size(36, 16);
            this.lblDniComprador.TabIndex = 51;
            this.lblDniComprador.Text = "DNI: ";
            // 
            // lblValorHoraCompra
            // 
            this.lblValorHoraCompra.AutoSize = true;
            this.lblValorHoraCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHoraCompra.Location = new System.Drawing.Point(388, 44);
            this.lblValorHoraCompra.Name = "lblValorHoraCompra";
            this.lblValorHoraCompra.Size = new System.Drawing.Size(55, 16);
            this.lblValorHoraCompra.TabIndex = 50;
            this.lblValorHoraCompra.Text = "09:04:47";
            // 
            // lblValorFechaCompra
            // 
            this.lblValorFechaCompra.AutoSize = true;
            this.lblValorFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFechaCompra.Location = new System.Drawing.Point(311, 44);
            this.lblValorFechaCompra.Name = "lblValorFechaCompra";
            this.lblValorFechaCompra.Size = new System.Drawing.Size(71, 16);
            this.lblValorFechaCompra.TabIndex = 49;
            this.lblValorFechaCompra.Text = "11/08/2026";
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCompra.Location = new System.Drawing.Point(22, 44);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(94, 16);
            this.lblFechaCompra.TabIndex = 48;
            this.lblFechaCompra.Text = "Fecha y Hora: ";
            // 
            // lblValorNroCompra
            // 
            this.lblValorNroCompra.AutoSize = true;
            this.lblValorNroCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorNroCompra.Location = new System.Drawing.Point(311, 28);
            this.lblValorNroCompra.Name = "lblValorNroCompra";
            this.lblValorNroCompra.Size = new System.Drawing.Size(91, 16);
            this.lblValorNroCompra.TabIndex = 47;
            this.lblValorNroCompra.Text = "000000000344";
            // 
            // lblNroCompra
            // 
            this.lblNroCompra.AutoSize = true;
            this.lblNroCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCompra.Location = new System.Drawing.Point(22, 27);
            this.lblNroCompra.Name = "lblNroCompra";
            this.lblNroCompra.Size = new System.Drawing.Size(84, 16);
            this.lblNroCompra.TabIndex = 46;
            this.lblNroCompra.Text = "Nro compra: ";
            // 
            // lblTiqueFactura
            // 
            this.lblTiqueFactura.AutoSize = true;
            this.lblTiqueFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblTiqueFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiqueFactura.Location = new System.Drawing.Point(16, 11);
            this.lblTiqueFactura.Name = "lblTiqueFactura";
            this.lblTiqueFactura.Size = new System.Drawing.Size(154, 16);
            this.lblTiqueFactura.TabIndex = 45;
            this.lblTiqueFactura.Text = "TIQUE FACTURA \"B\"";
            // 
            // dgvDetalleCompra
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleCompra.Location = new System.Drawing.Point(12, 176);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.RowHeadersVisible = false;
            this.dgvDetalleCompra.RowTemplate.Height = 23;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(450, 307);
            this.dgvDetalleCompra.TabIndex = 44;
            this.dgvDetalleCompra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleCompra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvDetalleCompra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleCompra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleCompra.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDetalleCompra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleCompra.ThemeStyle.RowsStyle.Height = 23;
            this.dgvDetalleCompra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 575);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblValorClienteComprador);
            this.Controls.Add(this.lblValorDniComprador);
            this.Controls.Add(this.lblDniComprador);
            this.Controls.Add(this.lblValorHoraCompra);
            this.Controls.Add(this.lblValorFechaCompra);
            this.Controls.Add(this.lblFechaCompra);
            this.Controls.Add(this.lblValorNroCompra);
            this.Controls.Add(this.lblNroCompra);
            this.Controls.Add(this.lblTiqueFactura);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Name = "DetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnGenerarComprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorClienteComprador;
        private System.Windows.Forms.Label lblValorDniComprador;
        private System.Windows.Forms.Label lblDniComprador;
        private System.Windows.Forms.Label lblValorHoraCompra;
        private System.Windows.Forms.Label lblValorFechaCompra;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.Label lblValorNroCompra;
        private System.Windows.Forms.Label lblNroCompra;
        private System.Windows.Forms.Label lblTiqueFactura;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}