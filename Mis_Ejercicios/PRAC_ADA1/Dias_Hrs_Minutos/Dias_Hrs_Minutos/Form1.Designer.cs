namespace Dias_Hrs_Minutos
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
            this.lbl_TiempoMinutos = new System.Windows.Forms.Label();
            this.txt_TimeMinutos = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TiempoMinutos
            // 
            this.lbl_TiempoMinutos.AutoSize = true;
            this.lbl_TiempoMinutos.Location = new System.Drawing.Point(43, 73);
            this.lbl_TiempoMinutos.Name = "lbl_TiempoMinutos";
            this.lbl_TiempoMinutos.Size = new System.Drawing.Size(99, 13);
            this.lbl_TiempoMinutos.TabIndex = 0;
            this.lbl_TiempoMinutos.Text = "Tiempo en minutos:";
            // 
            // txt_TimeMinutos
            // 
            this.txt_TimeMinutos.Location = new System.Drawing.Point(148, 70);
            this.txt_TimeMinutos.Name = "txt_TimeMinutos";
            this.txt_TimeMinutos.Size = new System.Drawing.Size(100, 20);
            this.txt_TimeMinutos.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(46, 117);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(148, 117);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 299);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_TimeMinutos);
            this.Controls.Add(this.lbl_TiempoMinutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TiempoMinutos;
        private System.Windows.Forms.TextBox txt_TimeMinutos;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salir;
    }
}

