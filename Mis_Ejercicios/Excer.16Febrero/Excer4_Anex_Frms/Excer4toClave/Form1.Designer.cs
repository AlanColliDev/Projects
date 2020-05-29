namespace Excer4toClave
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Comprobar = new System.Windows.Forms.Button();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Comprobar);
            this.groupBox1.Controls.Add(this.lbl_Clave);
            this.groupBox1.Controls.Add(this.txt_Clave);
            this.groupBox1.Location = new System.Drawing.Point(39, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clave de producto";
            // 
            // btn_Comprobar
            // 
            this.btn_Comprobar.Location = new System.Drawing.Point(94, 85);
            this.btn_Comprobar.Name = "btn_Comprobar";
            this.btn_Comprobar.Size = new System.Drawing.Size(75, 23);
            this.btn_Comprobar.TabIndex = 2;
            this.btn_Comprobar.Text = "Comprobar";
            this.btn_Comprobar.UseVisualStyleBackColor = true;
            this.btn_Comprobar.Click += new System.EventHandler(this.btn_Comprobar_Click);
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Location = new System.Drawing.Point(29, 39);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(80, 13);
            this.lbl_Clave.TabIndex = 1;
            this.lbl_Clave.Text = "Digite la clave: ";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(115, 36);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(100, 20);
            this.txt_Clave.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 288);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Excercise 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Comprobar;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.TextBox txt_Clave;
    }
}

