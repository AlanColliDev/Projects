namespace Excer3Ecuacion
{
    partial class frm_Excer4
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
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.lbl_Z = new System.Windows.Forms.Label();
            this.txt_ValX = new System.Windows.Forms.TextBox();
            this.txt_ValY = new System.Windows.Forms.TextBox();
            this.txt_ValZ = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Location = new System.Drawing.Point(113, 68);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(15, 13);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "X";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Y.Location = new System.Drawing.Point(113, 96);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(15, 13);
            this.lbl_Y.TabIndex = 1;
            this.lbl_Y.Text = "Y";
            // 
            // lbl_Z
            // 
            this.lbl_Z.AutoSize = true;
            this.lbl_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Z.Location = new System.Drawing.Point(113, 127);
            this.lbl_Z.Name = "lbl_Z";
            this.lbl_Z.Size = new System.Drawing.Size(15, 13);
            this.lbl_Z.TabIndex = 2;
            this.lbl_Z.Text = "Z";
            // 
            // txt_ValX
            // 
            this.txt_ValX.Location = new System.Drawing.Point(134, 61);
            this.txt_ValX.Name = "txt_ValX";
            this.txt_ValX.Size = new System.Drawing.Size(100, 20);
            this.txt_ValX.TabIndex = 3;
            // 
            // txt_ValY
            // 
            this.txt_ValY.Location = new System.Drawing.Point(134, 89);
            this.txt_ValY.Name = "txt_ValY";
            this.txt_ValY.Size = new System.Drawing.Size(100, 20);
            this.txt_ValY.TabIndex = 4;
            // 
            // txt_ValZ
            // 
            this.txt_ValZ.Location = new System.Drawing.Point(134, 124);
            this.txt_ValZ.Name = "txt_ValZ";
            this.txt_ValZ.Size = new System.Drawing.Size(100, 20);
            this.txt_ValZ.TabIndex = 5;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(288, 101);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(79, 16);
            this.lbl_Resultado.TabIndex = 6;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.Location = new System.Drawing.Point(280, 120);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(100, 24);
            this.txt_Resultado.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.AutoSize = true;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(280, 55);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(96, 34);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_Excer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 322);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_ValZ);
            this.Controls.Add(this.txt_ValY);
            this.Controls.Add(this.txt_ValX);
            this.Controls.Add(this.lbl_Z);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_x);
            this.Name = "frm_Excer4";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.Label lbl_Z;
        private System.Windows.Forms.TextBox txt_ValX;
        private System.Windows.Forms.TextBox txt_ValY;
        private System.Windows.Forms.TextBox txt_ValZ;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

