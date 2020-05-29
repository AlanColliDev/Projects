namespace SumaDigitos
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
            this.lbl_Num = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.frm_Calculo = new System.Windows.Forms.GroupBox();
            this.frm_Calculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Location = new System.Drawing.Point(32, 24);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(50, 13);
            this.lbl_Num.TabIndex = 0;
            this.lbl_Num.Text = "Número: ";
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(88, 21);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(51, 20);
            this.txt_Num.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(16, 58);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(115, 58);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Calculo
            // 
            this.frm_Calculo.Controls.Add(this.btn_Salir);
            this.frm_Calculo.Controls.Add(this.lbl_Num);
            this.frm_Calculo.Controls.Add(this.btn_Calcular);
            this.frm_Calculo.Controls.Add(this.txt_Num);
            this.frm_Calculo.Location = new System.Drawing.Point(28, 58);
            this.frm_Calculo.Name = "frm_Calculo";
            this.frm_Calculo.Size = new System.Drawing.Size(206, 103);
            this.frm_Calculo.TabIndex = 4;
            this.frm_Calculo.TabStop = false;
            this.frm_Calculo.Text = "Calculo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.frm_Calculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.frm_Calculo.ResumeLayout(false);
            this.frm_Calculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox frm_Calculo;
    }
}

