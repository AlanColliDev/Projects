namespace Materias_Aprob
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CantNotas = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_VerResul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de notas a evaluar:";
            // 
            // txt_CantNotas
            // 
            this.txt_CantNotas.Location = new System.Drawing.Point(202, 30);
            this.txt_CantNotas.Name = "txt_CantNotas";
            this.txt_CantNotas.Size = new System.Drawing.Size(52, 20);
            this.txt_CantNotas.TabIndex = 1;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(278, 28);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar.TabIndex = 2;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_VerResul
            // 
            this.btn_VerResul.AutoSize = true;
            this.btn_VerResul.Location = new System.Drawing.Point(184, 84);
            this.btn_VerResul.Name = "btn_VerResul";
            this.btn_VerResul.Size = new System.Drawing.Size(84, 23);
            this.btn_VerResul.TabIndex = 3;
            this.btn_VerResul.Text = "Ver resultados";
            this.btn_VerResul.UseVisualStyleBackColor = true;
            this.btn_VerResul.Click += new System.EventHandler(this.btn_VerResul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 132);
            this.Controls.Add(this.btn_VerResul);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.txt_CantNotas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CantNotas;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_VerResul;
    }
}

