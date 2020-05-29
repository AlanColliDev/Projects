namespace Excer6Dado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Excer6));
            this.btn_LanzarD = new System.Windows.Forms.Button();
            this.dgv_MostarDatos = new System.Windows.Forms.DataGridView();
            this.pic_Dado2 = new System.Windows.Forms.PictureBox();
            this.pic_Dado1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LanzarD
            // 
            this.btn_LanzarD.AutoSize = true;
            this.btn_LanzarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LanzarD.Location = new System.Drawing.Point(262, 188);
            this.btn_LanzarD.Name = "btn_LanzarD";
            this.btn_LanzarD.Size = new System.Drawing.Size(94, 25);
            this.btn_LanzarD.TabIndex = 0;
            this.btn_LanzarD.Text = "Lanzar Dados";
            this.btn_LanzarD.UseVisualStyleBackColor = true;
            this.btn_LanzarD.Click += new System.EventHandler(this.btn_LanzarD_Click);
            // 
            // dgv_MostarDatos
            // 
            this.dgv_MostarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MostarDatos.Location = new System.Drawing.Point(108, 228);
            this.dgv_MostarDatos.Name = "dgv_MostarDatos";
            this.dgv_MostarDatos.Size = new System.Drawing.Size(407, 119);
            this.dgv_MostarDatos.TabIndex = 3;
            // 
            // pic_Dado2
            // 
            this.pic_Dado2.Image = ((System.Drawing.Image)(resources.GetObject("pic_Dado2.Image")));
            this.pic_Dado2.Location = new System.Drawing.Point(365, 39);
            this.pic_Dado2.Name = "pic_Dado2";
            this.pic_Dado2.Size = new System.Drawing.Size(135, 128);
            this.pic_Dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Dado2.TabIndex = 4;
            this.pic_Dado2.TabStop = false;
            // 
            // pic_Dado1
            // 
            this.pic_Dado1.Image = ((System.Drawing.Image)(resources.GetObject("pic_Dado1.Image")));
            this.pic_Dado1.Location = new System.Drawing.Point(124, 39);
            this.pic_Dado1.Name = "pic_Dado1";
            this.pic_Dado1.Size = new System.Drawing.Size(135, 128);
            this.pic_Dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Dado1.TabIndex = 1;
            this.pic_Dado1.TabStop = false;
            // 
            // frm_Excer6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 374);
            this.Controls.Add(this.pic_Dado2);
            this.Controls.Add(this.dgv_MostarDatos);
            this.Controls.Add(this.pic_Dado1);
            this.Controls.Add(this.btn_LanzarD);
            this.Name = "frm_Excer6";
            this.Text = "Ejercicio 6";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Dado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LanzarD;
        private System.Windows.Forms.PictureBox pic_Dado1;
        private System.Windows.Forms.DataGridView dgv_MostarDatos;
        private System.Windows.Forms.PictureBox pic_Dado2;
    }
}

