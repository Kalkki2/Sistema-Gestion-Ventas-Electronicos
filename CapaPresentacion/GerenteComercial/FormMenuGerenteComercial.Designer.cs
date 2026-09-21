namespace CapaPresentacion.GerenteComercial
{
    partial class FormMenuGerenteComercial
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
            this.pnlMenuAdministrador = new System.Windows.Forms.Panel();
            this.btnMenuItemReporte = new System.Windows.Forms.Button();
            this.btnMenuItemSalir = new System.Windows.Forms.Button();
            this.btnMenuItemInforme = new System.Windows.Forms.Button();
            this.pnlMenuAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuAdministrador
            // 
            this.pnlMenuAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlMenuAdministrador.Controls.Add(this.btnMenuItemReporte);
            this.pnlMenuAdministrador.Controls.Add(this.btnMenuItemSalir);
            this.pnlMenuAdministrador.Controls.Add(this.btnMenuItemInforme);
            this.pnlMenuAdministrador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuAdministrador.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuAdministrador.Name = "pnlMenuAdministrador";
            this.pnlMenuAdministrador.Size = new System.Drawing.Size(185, 561);
            this.pnlMenuAdministrador.TabIndex = 2;
            // 
            // btnMenuItemReporte
            // 
            this.btnMenuItemReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuItemReporte.FlatAppearance.BorderSize = 0;
            this.btnMenuItemReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnMenuItemReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItemReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuItemReporte.ForeColor = System.Drawing.Color.White;
            this.btnMenuItemReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItemReporte.Location = new System.Drawing.Point(3, 162);
            this.btnMenuItemReporte.Name = "btnMenuItemReporte";
            this.btnMenuItemReporte.Size = new System.Drawing.Size(182, 45);
            this.btnMenuItemReporte.TabIndex = 6;
            this.btnMenuItemReporte.Text = "Reportes";
            this.btnMenuItemReporte.UseVisualStyleBackColor = false;
            this.btnMenuItemReporte.Click += new System.EventHandler(this.btnMenuItemReporte_Click);
            // 
            // btnMenuItemSalir
            // 
            this.btnMenuItemSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuItemSalir.FlatAppearance.BorderSize = 0;
            this.btnMenuItemSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnMenuItemSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItemSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuItemSalir.ForeColor = System.Drawing.Color.White;
            this.btnMenuItemSalir.Image = global::CapaPresentacion.Properties.Resources.icono_salir;
            this.btnMenuItemSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItemSalir.Location = new System.Drawing.Point(-3, 600);
            this.btnMenuItemSalir.Name = "btnMenuItemSalir";
            this.btnMenuItemSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuItemSalir.Size = new System.Drawing.Size(188, 45);
            this.btnMenuItemSalir.TabIndex = 5;
            this.btnMenuItemSalir.Text = "Salir";
            this.btnMenuItemSalir.UseVisualStyleBackColor = false;
            this.btnMenuItemSalir.Click += new System.EventHandler(this.btnMenuItemSalir_Click);
            // 
            // btnMenuItemInforme
            // 
            this.btnMenuItemInforme.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuItemInforme.FlatAppearance.BorderSize = 0;
            this.btnMenuItemInforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnMenuItemInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItemInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuItemInforme.ForeColor = System.Drawing.Color.White;
            this.btnMenuItemInforme.Image = global::CapaPresentacion.Properties.Resources.icono_blanco_graficos_informe;
            this.btnMenuItemInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItemInforme.Location = new System.Drawing.Point(3, 96);
            this.btnMenuItemInforme.Name = "btnMenuItemInforme";
            this.btnMenuItemInforme.Size = new System.Drawing.Size(182, 45);
            this.btnMenuItemInforme.TabIndex = 1;
            this.btnMenuItemInforme.Text = "Informe";
            this.btnMenuItemInforme.UseVisualStyleBackColor = false;
            this.btnMenuItemInforme.Click += new System.EventHandler(this.btnMenuItemInforme_Click);
            // 
            // FormMenuGerenteComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 561);
            this.Controls.Add(this.pnlMenuAdministrador);
            this.IsMdiContainer = true;
            this.Name = "FormMenuGerenteComercial";
            this.Text = "FormMenuGerenteComercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenuAdministrador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuAdministrador;
        private System.Windows.Forms.Button btnMenuItemInforme;
        private System.Windows.Forms.Button btnMenuItemSalir;
        private System.Windows.Forms.Button btnMenuItemReporte;
    }
}