namespace CapaPresentacion
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.btnIniciarRolGerenteComercial = new System.Windows.Forms.Button();
            this.btnIniciarRolCajero = new System.Windows.Forms.Button();
            this.btnIniciarRolVendedor = new System.Windows.Forms.Button();
            this.btnIniciarRolAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(156, 54);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(277, 29);
            this.lblTituloLogin.TabIndex = 5;
            this.lblTituloLogin.Text = "Menu de Acceso por Rol";
            // 
            // btnIniciarRolGerenteComercial
            // 
            this.btnIniciarRolGerenteComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarRolGerenteComercial.Image = global::CapaPresentacion.Properties.Resources.icono_gerente_comercial;
            this.btnIniciarRolGerenteComercial.Location = new System.Drawing.Point(313, 110);
            this.btnIniciarRolGerenteComercial.Name = "btnIniciarRolGerenteComercial";
            this.btnIniciarRolGerenteComercial.Size = new System.Drawing.Size(177, 110);
            this.btnIniciarRolGerenteComercial.TabIndex = 3;
            this.btnIniciarRolGerenteComercial.Text = "Gerente Comercial";
            this.btnIniciarRolGerenteComercial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciarRolGerenteComercial.UseVisualStyleBackColor = true;
            this.btnIniciarRolGerenteComercial.Click += new System.EventHandler(this.btnIniciarRolGerenteComercial_Click);
            // 
            // btnIniciarRolCajero
            // 
            this.btnIniciarRolCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarRolCajero.Image = global::CapaPresentacion.Properties.Resources.icono_cajero;
            this.btnIniciarRolCajero.Location = new System.Drawing.Point(84, 260);
            this.btnIniciarRolCajero.Name = "btnIniciarRolCajero";
            this.btnIniciarRolCajero.Size = new System.Drawing.Size(177, 110);
            this.btnIniciarRolCajero.TabIndex = 2;
            this.btnIniciarRolCajero.Text = "Cajero";
            this.btnIniciarRolCajero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciarRolCajero.UseVisualStyleBackColor = true;
            // 
            // btnIniciarRolVendedor
            // 
            this.btnIniciarRolVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarRolVendedor.Image = global::CapaPresentacion.Properties.Resources.icono_vendedor;
            this.btnIniciarRolVendedor.Location = new System.Drawing.Point(313, 260);
            this.btnIniciarRolVendedor.Name = "btnIniciarRolVendedor";
            this.btnIniciarRolVendedor.Size = new System.Drawing.Size(177, 110);
            this.btnIniciarRolVendedor.TabIndex = 1;
            this.btnIniciarRolVendedor.Text = "Vendedor";
            this.btnIniciarRolVendedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciarRolVendedor.UseVisualStyleBackColor = true;
            // 
            // btnIniciarRolAdministrador
            // 
            this.btnIniciarRolAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarRolAdministrador.Image = global::CapaPresentacion.Properties.Resources.icono_administrador;
            this.btnIniciarRolAdministrador.Location = new System.Drawing.Point(84, 110);
            this.btnIniciarRolAdministrador.Name = "btnIniciarRolAdministrador";
            this.btnIniciarRolAdministrador.Size = new System.Drawing.Size(177, 110);
            this.btnIniciarRolAdministrador.TabIndex = 0;
            this.btnIniciarRolAdministrador.Text = "Administrador";
            this.btnIniciarRolAdministrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciarRolAdministrador.UseVisualStyleBackColor = true;
            this.btnIniciarRolAdministrador.Click += new System.EventHandler(this.btnIniciarRolAdministrador_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.btnIniciarRolGerenteComercial);
            this.Controls.Add(this.btnIniciarRolCajero);
            this.Controls.Add(this.btnIniciarRolVendedor);
            this.Controls.Add(this.btnIniciarRolAdministrador);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarRolAdministrador;
        private System.Windows.Forms.Button btnIniciarRolVendedor;
        private System.Windows.Forms.Button btnIniciarRolCajero;
        private System.Windows.Forms.Button btnIniciarRolGerenteComercial;
        private System.Windows.Forms.Label lblTituloLogin;
    }
}

