namespace Excer6toContNum
{
    partial class frm_Excer6
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
            this.gpb_Numeros = new System.Windows.Forms.GroupBox();
            this.lbl_Introducir = new System.Windows.Forms.Label();
            this.txt_CantNum = new System.Windows.Forms.TextBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.gpb_Numeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Numeros
            // 
            this.gpb_Numeros.Controls.Add(this.btn_Iniciar);
            this.gpb_Numeros.Controls.Add(this.btn_Salir);
            this.gpb_Numeros.Controls.Add(this.btn_Mostrar);
            this.gpb_Numeros.Controls.Add(this.txt_CantNum);
            this.gpb_Numeros.Controls.Add(this.lbl_Introducir);
            this.gpb_Numeros.Location = new System.Drawing.Point(72, 34);
            this.gpb_Numeros.Name = "gpb_Numeros";
            this.gpb_Numeros.Size = new System.Drawing.Size(315, 187);
            this.gpb_Numeros.TabIndex = 0;
            this.gpb_Numeros.TabStop = false;
            this.gpb_Numeros.Text = "Introducir números";
            // 
            // lbl_Introducir
            // 
            this.lbl_Introducir.AutoSize = true;
            this.lbl_Introducir.Location = new System.Drawing.Point(58, 30);
            this.lbl_Introducir.Name = "lbl_Introducir";
            this.lbl_Introducir.Size = new System.Drawing.Size(203, 13);
            this.lbl_Introducir.TabIndex = 0;
            this.lbl_Introducir.Text = "Introducir cantidad de números a evaluar:";
            // 
            // txt_CantNum
            // 
            this.txt_CantNum.Location = new System.Drawing.Point(142, 46);
            this.txt_CantNum.Name = "txt_CantNum";
            this.txt_CantNum.Size = new System.Drawing.Size(50, 20);
            this.txt_CantNum.TabIndex = 1;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(61, 134);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 2;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(186, 134);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(130, 72);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar.TabIndex = 4;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // frm_Excer6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 348);
            this.Controls.Add(this.gpb_Numeros);
            this.Name = "frm_Excer6";
            this.Text = "Excercise 6";
            this.gpb_Numeros.ResumeLayout(false);
            this.gpb_Numeros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Numeros;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.TextBox txt_CantNum;
        private System.Windows.Forms.Label lbl_Introducir;
    }
}

