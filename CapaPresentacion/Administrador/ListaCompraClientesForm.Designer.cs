namespace CapaPresentacion.Administrador
{
    partial class ListaCompraClientesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvComprasCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.colNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerDetalle = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprasCliente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvComprasCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprasCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprasCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComprasCliente.ColumnHeadersHeight = 25;
            this.dgvComprasCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroVenta,
            this.colFechaVenta,
            this.colVendedor,
            this.colMetodoPago,
            this.colTotal,
            this.colVerDetalle});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprasCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComprasCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvComprasCliente.Location = new System.Drawing.Point(3, 124);
            this.dgvComprasCliente.Name = "dgvComprasCliente";
            this.dgvComprasCliente.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComprasCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComprasCliente.RowTemplate.Height = 25;
            this.dgvComprasCliente.Size = new System.Drawing.Size(876, 307);
            this.dgvComprasCliente.TabIndex = 8;
            this.dgvComprasCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvComprasCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.dgvComprasCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComprasCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComprasCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComprasCliente.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvComprasCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvComprasCliente.ThemeStyle.RowsStyle.Height = 25;
            this.dgvComprasCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvComprasCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprasCliente_CellContentClick);
            this.dgvComprasCliente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvComprasCliente_CellFormatting);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(9, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(155, 16);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Compras del Cliente: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI del Ciente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total de compras: ";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCliente.Location = new System.Drawing.Point(170, 34);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(84, 16);
            this.lblNombreCliente.TabIndex = 12;
            this.lblNombreCliente.Text = "Juan Perez";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.ForeColor = System.Drawing.Color.Black;
            this.lblDniCliente.Location = new System.Drawing.Point(170, 63);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(71, 16);
            this.lblDniCliente.TabIndex = 13;
            this.lblDniCliente.Text = "11111111";
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompras.ForeColor = System.Drawing.Color.Black;
            this.lblTotalCompras.Location = new System.Drawing.Point(170, 93);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(43, 16);
            this.lblTotalCompras.TabIndex = 14;
            this.lblTotalCompras.Text = "$0.00";
            // 
            // colNroVenta
            // 
            this.colNroVenta.HeaderText = "Nro Venta";
            this.colNroVenta.Name = "colNroVenta";
            // 
            // colFechaVenta
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFechaVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFechaVenta.FillWeight = 70F;
            this.colFechaVenta.HeaderText = "Fecha Venta";
            this.colFechaVenta.Name = "colFechaVenta";
            // 
            // colVendedor
            // 
            this.colVendedor.HeaderText = "Vendedor";
            this.colVendedor.Name = "colVendedor";
            // 
            // colMetodoPago
            // 
            this.colMetodoPago.HeaderText = "Metodo Pago";
            this.colMetodoPago.Name = "colMetodoPago";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colVerDetalle
            // 
            this.colVerDetalle.HeaderText = "Ver Detalle";
            this.colVerDetalle.Name = "colVerDetalle";
            this.colVerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVerDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ListaCompraClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 466);
            this.Controls.Add(this.lblTotalCompras);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvComprasCliente);
            this.Name = "ListaCompraClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaCompraClientesForm";
            this.Load += new System.EventHandler(this.ListaCompraClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvComprasCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewImageColumn colVerDetalle;
    }
}