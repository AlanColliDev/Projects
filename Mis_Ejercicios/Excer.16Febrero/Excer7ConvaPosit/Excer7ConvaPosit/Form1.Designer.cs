namespace Excer7ConvaPosit
{
    partial class frm_Conver
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
            this.gpb_IntroducirNum = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.ltb_NumConv = new System.Windows.Forms.ListBox();
            this.lbl_IntroducirNum = new System.Windows.Forms.Label();
            this.gpb_IntroducirNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_IntroducirNum
            // 
            this.gpb_IntroducirNum.Controls.Add(this.btn_Limpiar);
            this.gpb_IntroducirNum.Controls.Add(this.btn_Salir);
            this.gpb_IntroducirNum.Controls.Add(this.btn_Iniciar);
            this.gpb_IntroducirNum.Controls.Add(this.ltb_NumConv);
            this.gpb_IntroducirNum.Controls.Add(this.lbl_IntroducirNum);
            this.gpb_IntroducirNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpb_IntroducirNum.Location = new System.Drawing.Point(74, 39);
            this.gpb_IntroducirNum.Name = "gpb_IntroducirNum";
            this.gpb_IntroducirNum.Size = new System.Drawing.Size(311, 345);
            this.gpb_IntroducirNum.TabIndex = 0;
            this.gpb_IntroducirNum.TabStop = false;
            this.gpb_IntroducirNum.Text = "Introducir Números";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(219, 235);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(219, 187);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar.Location = new System.Drawing.Point(103, 94);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(111, 44);
            this.btn_Iniciar.TabIndex = 4;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // ltb_NumConv
            // 
            this.ltb_NumConv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltb_NumConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_NumConv.FormattingEnabled = true;
            this.ltb_NumConv.ItemHeight = 16;
            this.ltb_NumConv.Location = new System.Drawing.Point(115, 144);
            this.ltb_NumConv.Name = "ltb_NumConv";
            this.ltb_NumConv.Size = new System.Drawing.Size(89, 162);
            this.ltb_NumConv.TabIndex = 2;
            // 
            // lbl_IntroducirNum
            // 
            this.lbl_IntroducirNum.AutoSize = true;
            this.lbl_IntroducirNum.Location = new System.Drawing.Point(15, 55);
            this.lbl_IntroducirNum.Name = "lbl_IntroducirNum";
            this.lbl_IntroducirNum.Size = new System.Drawing.Size(279, 13);
            this.lbl_IntroducirNum.TabIndex = 1;
            this.lbl_IntroducirNum.Text = "Este programa convierte 15 valores negativos a positivos.";
            // 
            // frm_Conver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 437);
            this.Controls.Add(this.gpb_IntroducirNum);
            this.Name = "frm_Conver";
            this.Text = "De Negativo a Positivo";
            this.Load += new System.EventHandler(this.frm_Conver_Load);
            this.gpb_IntroducirNum.ResumeLayout(false);
            this.gpb_IntroducirNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_IntroducirNum;
        private System.Windows.Forms.ListBox ltb_NumConv;
        private System.Windows.Forms.Label lbl_IntroducirNum;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}

