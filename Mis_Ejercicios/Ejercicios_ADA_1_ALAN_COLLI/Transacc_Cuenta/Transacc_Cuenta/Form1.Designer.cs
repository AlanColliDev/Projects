namespace Transacc_Cuenta
{
    partial class Form1
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
            this.Cuenta = new System.Windows.Forms.GroupBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Depo = new System.Windows.Forms.Button();
            this.btn_Retiro = new System.Windows.Forms.Button();
            this.txt_Mensj = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.Cuenta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cuenta
            // 
            this.Cuenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cuenta.Controls.Add(this.txt_Cantidad);
            this.Cuenta.Controls.Add(this.lbl_Cantidad);
            this.Cuenta.Controls.Add(this.txt_Saldo);
            this.Cuenta.Controls.Add(this.lbl_Saldo);
            this.Cuenta.Location = new System.Drawing.Point(100, 24);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Size = new System.Drawing.Size(307, 115);
            this.Cuenta.TabIndex = 0;
            this.Cuenta.TabStop = false;
            this.Cuenta.Text = "Cuenta";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(135, 28);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(84, 20);
            this.txt_Cantidad.TabIndex = 3;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(77, 35);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(52, 13);
            this.lbl_Cantidad.TabIndex = 2;
            this.lbl_Cantidad.Text = "Cantidad:";
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Enabled = false;
            this.txt_Saldo.Location = new System.Drawing.Point(135, 79);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(84, 20);
            this.txt_Saldo.TabIndex = 1;
            this.txt_Saldo.Text = "0";
            this.txt_Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Location = new System.Drawing.Point(77, 86);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(63, 13);
            this.lbl_Saldo.TabIndex = 0;
            this.lbl_Saldo.Text = "Saldo total: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btn_Salir);
            this.groupBox2.Controls.Add(this.txt_Mensj);
            this.groupBox2.Controls.Add(this.btn_Depo);
            this.groupBox2.Controls.Add(this.btn_Retiro);
            this.groupBox2.Location = new System.Drawing.Point(100, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tansacciones";
            // 
            // btn_Depo
            // 
            this.btn_Depo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Depo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Depo.Location = new System.Drawing.Point(163, 31);
            this.btn_Depo.Name = "btn_Depo";
            this.btn_Depo.Size = new System.Drawing.Size(71, 35);
            this.btn_Depo.TabIndex = 1;
            this.btn_Depo.Text = "Depósito";
            this.btn_Depo.UseVisualStyleBackColor = false;
            this.btn_Depo.Click += new System.EventHandler(this.btn_Depo_Click);
            // 
            // btn_Retiro
            // 
            this.btn_Retiro.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Retiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Retiro.Location = new System.Drawing.Point(63, 31);
            this.btn_Retiro.Name = "btn_Retiro";
            this.btn_Retiro.Size = new System.Drawing.Size(66, 36);
            this.btn_Retiro.TabIndex = 0;
            this.btn_Retiro.Text = "Retiro";
            this.btn_Retiro.UseVisualStyleBackColor = false;
            this.btn_Retiro.Click += new System.EventHandler(this.btn_Retiro_Click);
            // 
            // txt_Mensj
            // 
            this.txt_Mensj.Enabled = false;
            this.txt_Mensj.Location = new System.Drawing.Point(0, 73);
            this.txt_Mensj.Name = "txt_Mensj";
            this.txt_Mensj.Size = new System.Drawing.Size(299, 20);
            this.txt_Mensj.TabIndex = 2;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(116, 112);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(70, 35);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cuenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Cuenta.ResumeLayout(false);
            this.Cuenta.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Cuenta;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Depo;
        private System.Windows.Forms.Button btn_Retiro;
        private System.Windows.Forms.TextBox txt_Mensj;
        private System.Windows.Forms.Button btn_Salir;
    }
}

