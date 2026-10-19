namespace CapaPresentacion.Administrador
{
    partial class DetalleVenta
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnGenerarComprobante = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblApeYNomVendedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApeYNomCliente = new System.Windows.Forms.Label();
            this.lblDniVendedor = new System.Windows.Forms.Label();
            this.lblDniComprador = new System.Windows.Forms.Label();
            this.lblValorFechaHora = new System.Windows.Forms.Label();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.lblValorNroVenta = new System.Windows.Forms.Label();
            this.lblNroCompra = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblTextoAjuste = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMontoAjuste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
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
            this.btnGenerarComprobante.Location = new System.Drawing.Point(282, 543);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(180, 33);
            this.btnGenerarComprobante.TabIndex = 62;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(371, 520);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(91, 20);
            this.lblTotalAPagar.TabIndex = 61;
            this.lblTotalAPagar.Text = "$XXXXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "TOTAL:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Location = new System.Drawing.Point(311, 136);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(55, 16);
            this.lblFormaPago.TabIndex = 59;
            this.lblFormaPago.Text = "Efectivo";
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
            // lblApeYNomVendedor
            // 
            this.lblApeYNomVendedor.AutoSize = true;
            this.lblApeYNomVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeYNomVendedor.Location = new System.Drawing.Point(311, 60);
            this.lblApeYNomVendedor.Name = "lblApeYNomVendedor";
            this.lblApeYNomVendedor.Size = new System.Drawing.Size(104, 16);
            this.lblApeYNomVendedor.TabIndex = 57;
            this.lblApeYNomVendedor.Text = "Pereira, Luciana";
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
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(311, 121);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(63, 16);
            this.lblDniCliente.TabIndex = 55;
            this.lblDniCliente.Text = "22222222";
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
            // lblApeYNomCliente
            // 
            this.lblApeYNomCliente.AutoSize = true;
            this.lblApeYNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeYNomCliente.Location = new System.Drawing.Point(311, 104);
            this.lblApeYNomCliente.Name = "lblApeYNomCliente";
            this.lblApeYNomCliente.Size = new System.Drawing.Size(77, 16);
            this.lblApeYNomCliente.TabIndex = 53;
            this.lblApeYNomCliente.Text = "Perez, Juan";
            // 
            // lblDniVendedor
            // 
            this.lblDniVendedor.AutoSize = true;
            this.lblDniVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniVendedor.Location = new System.Drawing.Point(311, 79);
            this.lblDniVendedor.Name = "lblDniVendedor";
            this.lblDniVendedor.Size = new System.Drawing.Size(63, 16);
            this.lblDniVendedor.TabIndex = 52;
            this.lblDniVendedor.Text = "11111111";
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
            // lblValorFechaHora
            // 
            this.lblValorFechaHora.AutoSize = true;
            this.lblValorFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFechaHora.Location = new System.Drawing.Point(311, 44);
            this.lblValorFechaHora.Name = "lblValorFechaHora";
            this.lblValorFechaHora.Size = new System.Drawing.Size(71, 16);
            this.lblValorFechaHora.TabIndex = 49;
            this.lblValorFechaHora.Text = "11/08/2026";
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
            // lblValorNroVenta
            // 
            this.lblValorNroVenta.AutoSize = true;
            this.lblValorNroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorNroVenta.Location = new System.Drawing.Point(311, 28);
            this.lblValorNroVenta.Name = "lblValorNroVenta";
            this.lblValorNroVenta.Size = new System.Drawing.Size(91, 16);
            this.lblValorNroVenta.TabIndex = 47;
            this.lblValorNroVenta.Text = "000000000344";
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
            // dgvDetalleVenta
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleVenta.Location = new System.Drawing.Point(12, 176);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.RowTemplate.Height = 23;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(450, 307);
            this.dgvDetalleVenta.TabIndex = 44;
            this.dgvDetalleVenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.Height = 23;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "TOTAL A PAGAR:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Ajuste";
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.AutoSize = true;
            this.lblTotalBruto.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBruto.Location = new System.Drawing.Point(371, 482);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(91, 20);
            this.lblTotalBruto.TabIndex = 66;
            this.lblTotalBruto.Text = "$XXXXXX";
            // 
            // lblTextoAjuste
            // 
            this.lblTextoAjuste.AutoSize = true;
            this.lblTextoAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAjuste.Location = new System.Drawing.Point(62, 508);
            this.lblTextoAjuste.Name = "lblTextoAjuste";
            this.lblTextoAjuste.Size = new System.Drawing.Size(72, 16);
            this.lblTextoAjuste.TabIndex = 67;
            this.lblTextoAjuste.Text = "Descuento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(140, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 68;
            this.label12.Text = "%10";
            // 
            // lblMontoAjuste
            // 
            this.lblMontoAjuste.AutoSize = true;
            this.lblMontoAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAjuste.Location = new System.Drawing.Point(410, 502);
            this.lblMontoAjuste.Name = "lblMontoAjuste";
            this.lblMontoAjuste.Size = new System.Drawing.Size(46, 16);
            this.lblMontoAjuste.TabIndex = 69;
            this.lblMontoAjuste.Text = "- XXXX";
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 575);
            this.Controls.Add(this.lblMontoAjuste);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTextoAjuste);
            this.Controls.Add(this.lblTotalBruto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblApeYNomVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApeYNomCliente);
            this.Controls.Add(this.lblDniVendedor);
            this.Controls.Add(this.lblDniComprador);
            this.Controls.Add(this.lblValorFechaHora);
            this.Controls.Add(this.lblFechaCompra);
            this.Controls.Add(this.lblValorNroVenta);
            this.Controls.Add(this.lblNroCompra);
            this.Controls.Add(this.dgvDetalleVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleCompra";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnGenerarComprobante;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblApeYNomVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApeYNomCliente;
        private System.Windows.Forms.Label lblDniVendedor;
        private System.Windows.Forms.Label lblDniComprador;
        private System.Windows.Forms.Label lblValorFechaHora;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.Label lblValorNroVenta;
        private System.Windows.Forms.Label lblNroCompra;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblTextoAjuste;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMontoAjuste;
    }
}