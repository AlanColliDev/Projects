namespace N_NumerosNaturales
{
    partial class frm_Calculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_SumaNumNat = new System.Windows.Forms.GroupBox();
            this.txt_NumNat = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_SumaNumNat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca indice de números a sumar: ";
            // 
            // gpb_SumaNumNat
            // 
            this.gpb_SumaNumNat.Controls.Add(this.btn_Salir);
            this.gpb_SumaNumNat.Controls.Add(this.btn_Iniciar);
            this.gpb_SumaNumNat.Controls.Add(this.txt_NumNat);
            this.gpb_SumaNumNat.Controls.Add(this.label1);
            this.gpb_SumaNumNat.Location = new System.Drawing.Point(12, 12);
            this.gpb_SumaNumNat.Name = "gpb_SumaNumNat";
            this.gpb_SumaNumNat.Size = new System.Drawing.Size(260, 167);
            this.gpb_SumaNumNat.TabIndex = 1;
            this.gpb_SumaNumNat.TabStop = false;
            this.gpb_SumaNumNat.Text = "Calculo";
            // 
            // txt_NumNat
            // 
            this.txt_NumNat.Location = new System.Drawing.Point(98, 48);
            this.txt_NumNat.Name = "txt_NumNat";
            this.txt_NumNat.Size = new System.Drawing.Size(41, 20);
            this.txt_NumNat.TabIndex = 1;
            this.txt_NumNat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(35, 88);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar.TabIndex = 2;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(129, 88);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gpb_SumaNumNat);
            this.Name = "frm_Calculo";
            this.Text = "Suma de numeros";
            this.gpb_SumaNumNat.ResumeLayout(false);
            this.gpb_SumaNumNat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_SumaNumNat;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.TextBox txt_NumNat;
    }
}

