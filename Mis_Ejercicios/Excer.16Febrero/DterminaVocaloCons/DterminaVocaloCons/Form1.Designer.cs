namespace DterminaVocaloCons
{
    partial class frm_Ver
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
            this.lbl_Letra = new System.Windows.Forms.Label();
            this.txt_Letra = new System.Windows.Forms.TextBox();
            this.gbp_Añadir = new System.Windows.Forms.GroupBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.txt_Aviso = new System.Windows.Forms.TextBox();
            this.gbp_Añadir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Letra
            // 
            this.lbl_Letra.AutoSize = true;
            this.lbl_Letra.Location = new System.Drawing.Point(15, 31);
            this.lbl_Letra.Name = "lbl_Letra";
            this.lbl_Letra.Size = new System.Drawing.Size(34, 13);
            this.lbl_Letra.TabIndex = 0;
            this.lbl_Letra.Text = "Letra:";
            // 
            // txt_Letra
            // 
            this.txt_Letra.Location = new System.Drawing.Point(56, 28);
            this.txt_Letra.Name = "txt_Letra";
            this.txt_Letra.Size = new System.Drawing.Size(100, 20);
            this.txt_Letra.TabIndex = 1;
            // 
            // gbp_Añadir
            // 
            this.gbp_Añadir.Controls.Add(this.btn_Nuevo);
            this.gbp_Añadir.Controls.Add(this.btn_Enviar);
            this.gbp_Añadir.Controls.Add(this.lbl_Letra);
            this.gbp_Añadir.Controls.Add(this.txt_Letra);
            this.gbp_Añadir.Location = new System.Drawing.Point(40, 27);
            this.gbp_Añadir.Name = "gbp_Añadir";
            this.gbp_Añadir.Size = new System.Drawing.Size(200, 113);
            this.gbp_Añadir.TabIndex = 2;
            this.gbp_Añadir.TabStop = false;
            this.gbp_Añadir.Text = "Introduzca una letra:";
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(18, 73);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 2;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(108, 73);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // txt_Aviso
            // 
            this.txt_Aviso.Enabled = false;
            this.txt_Aviso.Location = new System.Drawing.Point(80, 158);
            this.txt_Aviso.Multiline = true;
            this.txt_Aviso.Name = "txt_Aviso";
            this.txt_Aviso.Size = new System.Drawing.Size(125, 44);
            this.txt_Aviso.TabIndex = 3;
            // 
            // frm_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txt_Aviso);
            this.Controls.Add(this.gbp_Añadir);
            this.Name = "frm_Ver";
            this.Text = "Verificacion de letra";
            this.gbp_Añadir.ResumeLayout(false);
            this.gbp_Añadir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Letra;
        private System.Windows.Forms.TextBox txt_Letra;
        private System.Windows.Forms.GroupBox gbp_Añadir;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.TextBox txt_Aviso;
    }
}

