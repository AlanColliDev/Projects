namespace Excer4Calc_Año_Nacimiento
{
    partial class frm_Calcular_Edad
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
            this.gpb_Datos = new System.Windows.Forms.GroupBox();
            this.gpb_Resultado = new System.Windows.Forms.GroupBox();
            this.lbl_Año_Actual = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Año = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.lbl_Fecha_Nac = new System.Windows.Forms.Label();
            this.txt_Año_Nac = new System.Windows.Forms.TextBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_Datos.SuspendLayout();
            this.gpb_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.Controls.Add(this.txt_Edad);
            this.gpb_Datos.Controls.Add(this.txt_Año);
            this.gpb_Datos.Controls.Add(this.lbl_Edad);
            this.gpb_Datos.Controls.Add(this.lbl_Año_Actual);
            this.gpb_Datos.Location = new System.Drawing.Point(43, 12);
            this.gpb_Datos.Name = "gpb_Datos";
            this.gpb_Datos.Size = new System.Drawing.Size(200, 100);
            this.gpb_Datos.TabIndex = 0;
            this.gpb_Datos.TabStop = false;
            this.gpb_Datos.Text = "Datos ";
            // 
            // gpb_Resultado
            // 
            this.gpb_Resultado.Controls.Add(this.txt_Año_Nac);
            this.gpb_Resultado.Controls.Add(this.lbl_Fecha_Nac);
            this.gpb_Resultado.Location = new System.Drawing.Point(43, 118);
            this.gpb_Resultado.Name = "gpb_Resultado";
            this.gpb_Resultado.Size = new System.Drawing.Size(200, 72);
            this.gpb_Resultado.TabIndex = 1;
            this.gpb_Resultado.TabStop = false;
            this.gpb_Resultado.Text = "Resultado";
            // 
            // lbl_Año_Actual
            // 
            this.lbl_Año_Actual.AutoSize = true;
            this.lbl_Año_Actual.Location = new System.Drawing.Point(20, 29);
            this.lbl_Año_Actual.Name = "lbl_Año_Actual";
            this.lbl_Año_Actual.Size = new System.Drawing.Size(62, 13);
            this.lbl_Año_Actual.TabIndex = 0;
            this.lbl_Año_Actual.Text = "Año Actual:";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(20, 59);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(35, 13);
            this.lbl_Edad.TabIndex = 1;
            this.lbl_Edad.Text = "Edad:";
            // 
            // txt_Año
            // 
            this.txt_Año.Location = new System.Drawing.Point(88, 22);
            this.txt_Año.Name = "txt_Año";
            this.txt_Año.Size = new System.Drawing.Size(68, 20);
            this.txt_Año.TabIndex = 2;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(88, 52);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(46, 20);
            this.txt_Edad.TabIndex = 3;
            // 
            // lbl_Fecha_Nac
            // 
            this.lbl_Fecha_Nac.AutoSize = true;
            this.lbl_Fecha_Nac.Location = new System.Drawing.Point(36, 29);
            this.lbl_Fecha_Nac.Name = "lbl_Fecha_Nac";
            this.lbl_Fecha_Nac.Size = new System.Drawing.Size(130, 13);
            this.lbl_Fecha_Nac.TabIndex = 0;
            this.lbl_Fecha_Nac.Text = "Su año de nacimiento es: ";
            // 
            // txt_Año_Nac
            // 
            this.txt_Año_Nac.Enabled = false;
            this.txt_Año_Nac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Año_Nac.Location = new System.Drawing.Point(56, 46);
            this.txt_Año_Nac.Name = "txt_Año_Nac";
            this.txt_Año_Nac.Size = new System.Drawing.Size(100, 20);
            this.txt_Año_Nac.TabIndex = 1;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(168, 208);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 2;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(43, 208);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(102, 249);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Calcular_Edad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 327);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.gpb_Resultado);
            this.Controls.Add(this.gpb_Datos);
            this.Name = "frm_Calcular_Edad";
            this.Text = "Calcular Edad";
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            this.gpb_Resultado.ResumeLayout(false);
            this.gpb_Resultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Datos;
        private System.Windows.Forms.GroupBox gpb_Resultado;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Año;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Año_Actual;
        private System.Windows.Forms.TextBox txt_Año_Nac;
        private System.Windows.Forms.Label lbl_Fecha_Nac;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salir;
    }
}

