namespace Excer5ListBox
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
            this.ltb_Libros = new System.Windows.Forms.ListBox();
            this.ltb_LibrosComprar = new System.Windows.Forms.ListBox();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Mandar = new System.Windows.Forms.Button();
            this.Libros = new System.Windows.Forms.Label();
            this.lbl_Comprar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltb_Libros
            // 
            this.ltb_Libros.FormattingEnabled = true;
            this.ltb_Libros.Items.AddRange(new object[] {
            " "});
            this.ltb_Libros.Location = new System.Drawing.Point(50, 60);
            this.ltb_Libros.Name = "ltb_Libros";
            this.ltb_Libros.Size = new System.Drawing.Size(203, 251);
            this.ltb_Libros.TabIndex = 0;
            // 
            // ltb_LibrosComprar
            // 
            this.ltb_LibrosComprar.FormattingEnabled = true;
            this.ltb_LibrosComprar.Items.AddRange(new object[] {
            " "});
            this.ltb_LibrosComprar.Location = new System.Drawing.Point(340, 60);
            this.ltb_LibrosComprar.Name = "ltb_LibrosComprar";
            this.ltb_LibrosComprar.Size = new System.Drawing.Size(215, 186);
            this.ltb_LibrosComprar.TabIndex = 1;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(259, 116);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Regresar.TabIndex = 2;
            this.btn_Regresar.Text = "< < <";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_Mandar
            // 
            this.btn_Mandar.Location = new System.Drawing.Point(259, 145);
            this.btn_Mandar.Name = "btn_Mandar";
            this.btn_Mandar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mandar.TabIndex = 3;
            this.btn_Mandar.Text = "> > >";
            this.btn_Mandar.UseVisualStyleBackColor = true;
            this.btn_Mandar.Click += new System.EventHandler(this.Mandar_Click);
            // 
            // Libros
            // 
            this.Libros.AutoSize = true;
            this.Libros.Location = new System.Drawing.Point(47, 44);
            this.Libros.Name = "Libros";
            this.Libros.Size = new System.Drawing.Size(35, 13);
            this.Libros.TabIndex = 4;
            this.Libros.Text = "Libros";
            // 
            // lbl_Comprar
            // 
            this.lbl_Comprar.AutoSize = true;
            this.lbl_Comprar.Location = new System.Drawing.Point(347, 44);
            this.lbl_Comprar.Name = "lbl_Comprar";
            this.lbl_Comprar.Size = new System.Drawing.Size(94, 13);
            this.lbl_Comprar.TabIndex = 5;
            this.lbl_Comprar.Text = "Libros por comprar";
            // 
            // frm_Excer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 459);
            this.Controls.Add(this.lbl_Comprar);
            this.Controls.Add(this.Libros);
            this.Controls.Add(this.btn_Mandar);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.ltb_LibrosComprar);
            this.Controls.Add(this.ltb_Libros);
            this.Name = "frm_Excer4";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Libros;
        private System.Windows.Forms.ListBox ltb_LibrosComprar;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Mandar;
        private System.Windows.Forms.Label Libros;
        private System.Windows.Forms.Label lbl_Comprar;
    }
}

