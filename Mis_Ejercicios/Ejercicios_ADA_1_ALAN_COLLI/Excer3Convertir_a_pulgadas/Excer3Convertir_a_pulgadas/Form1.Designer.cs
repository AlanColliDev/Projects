namespace Excer3Convertir_a_pulgadas
{
    partial class frm_Conversión
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Conversión));
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.gpb_Convertidor = new System.Windows.Forms.GroupBox();
            this.txt_Cantidadcm = new System.Windows.Forms.TextBox();
            this.btn_Convertir = new System.Windows.Forms.Button();
            this.gpb_Resultado = new System.Windows.Forms.GroupBox();
            this.txt_Pulgadas = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad_P = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.gpb_Convertidor.SuspendLayout();
            this.gpb_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(15, 35);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(140, 13);
            this.lbl_Cantidad.TabIndex = 0;
            this.lbl_Cantidad.Text = "Cantidad en cm a convertir: ";
            // 
            // gpb_Convertidor
            // 
            this.gpb_Convertidor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpb_Convertidor.Controls.Add(this.btn_Convertir);
            this.gpb_Convertidor.Controls.Add(this.txt_Cantidadcm);
            this.gpb_Convertidor.Controls.Add(this.lbl_Cantidad);
            this.gpb_Convertidor.Location = new System.Drawing.Point(12, 22);
            this.gpb_Convertidor.Name = "gpb_Convertidor";
            this.gpb_Convertidor.Size = new System.Drawing.Size(241, 96);
            this.gpb_Convertidor.TabIndex = 1;
            this.gpb_Convertidor.TabStop = false;
            this.gpb_Convertidor.Text = "Convertidor";
            // 
            // txt_Cantidadcm
            // 
            this.txt_Cantidadcm.Location = new System.Drawing.Point(161, 28);
            this.txt_Cantidadcm.Name = "txt_Cantidadcm";
            this.txt_Cantidadcm.Size = new System.Drawing.Size(51, 20);
            this.txt_Cantidadcm.TabIndex = 1;
            // 
            // btn_Convertir
            // 
            this.btn_Convertir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Convertir.Image")));
            this.btn_Convertir.Location = new System.Drawing.Point(18, 61);
            this.btn_Convertir.Name = "btn_Convertir";
            this.btn_Convertir.Size = new System.Drawing.Size(75, 23);
            this.btn_Convertir.TabIndex = 2;
            this.btn_Convertir.Text = "Convertir";
            this.btn_Convertir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Convertir.UseVisualStyleBackColor = true;
            this.btn_Convertir.Click += new System.EventHandler(this.btn_Convertir_Click);
            // 
            // gpb_Resultado
            // 
            this.gpb_Resultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gpb_Resultado.Controls.Add(this.btn_nuevo);
            this.gpb_Resultado.Controls.Add(this.btn_Salir);
            this.gpb_Resultado.Controls.Add(this.lbl_Cantidad_P);
            this.gpb_Resultado.Controls.Add(this.txt_Pulgadas);
            this.gpb_Resultado.Location = new System.Drawing.Point(30, 124);
            this.gpb_Resultado.Name = "gpb_Resultado";
            this.gpb_Resultado.Size = new System.Drawing.Size(202, 89);
            this.gpb_Resultado.TabIndex = 2;
            this.gpb_Resultado.TabStop = false;
            this.gpb_Resultado.Text = "Resultados";
            // 
            // txt_Pulgadas
            // 
            this.txt_Pulgadas.Enabled = false;
            this.txt_Pulgadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pulgadas.Location = new System.Drawing.Point(125, 19);
            this.txt_Pulgadas.Name = "txt_Pulgadas";
            this.txt_Pulgadas.Size = new System.Drawing.Size(51, 20);
            this.txt_Pulgadas.TabIndex = 2;
            // 
            // lbl_Cantidad_P
            // 
            this.lbl_Cantidad_P.AutoSize = true;
            this.lbl_Cantidad_P.Location = new System.Drawing.Point(6, 26);
            this.lbl_Cantidad_P.Name = "lbl_Cantidad_P";
            this.lbl_Cantidad_P.Size = new System.Drawing.Size(113, 13);
            this.lbl_Cantidad_P.TabIndex = 3;
            this.lbl_Cantidad_P.Text = "Cantidad en pulgadas:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.AutoSize = true;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salir.Location = new System.Drawing.Point(119, 60);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo.Location = new System.Drawing.Point(18, 60);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 5;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // frm_Conversión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gpb_Resultado);
            this.Controls.Add(this.gpb_Convertidor);
            this.Name = "frm_Conversión";
            this.Text = "Conversión";
            this.gpb_Convertidor.ResumeLayout(false);
            this.gpb_Convertidor.PerformLayout();
            this.gpb_Resultado.ResumeLayout(false);
            this.gpb_Resultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.GroupBox gpb_Convertidor;
        private System.Windows.Forms.Button btn_Convertir;
        private System.Windows.Forms.TextBox txt_Cantidadcm;
        private System.Windows.Forms.GroupBox gpb_Resultado;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Cantidad_P;
        private System.Windows.Forms.TextBox txt_Pulgadas;
        private System.Windows.Forms.Button btn_nuevo;
    }
}

