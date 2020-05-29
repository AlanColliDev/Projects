namespace Promedio_AprobReprob
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
            this.lbl_Calificacion = new System.Windows.Forms.Label();
            this.lbl_NumCal = new System.Windows.Forms.Label();
            this.gpb_CapturarDate = new System.Windows.Forms.GroupBox();
            this.txt_NumCalif = new System.Windows.Forms.TextBox();
            this.txt_Calif = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_CapturarDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Calificacion
            // 
            this.lbl_Calificacion.AutoSize = true;
            this.lbl_Calificacion.Location = new System.Drawing.Point(40, 71);
            this.lbl_Calificacion.Name = "lbl_Calificacion";
            this.lbl_Calificacion.Size = new System.Drawing.Size(64, 13);
            this.lbl_Calificacion.TabIndex = 0;
            this.lbl_Calificacion.Text = "Calificacion:";
            // 
            // lbl_NumCal
            // 
            this.lbl_NumCal.AutoSize = true;
            this.lbl_NumCal.Location = new System.Drawing.Point(12, 38);
            this.lbl_NumCal.Name = "lbl_NumCal";
            this.lbl_NumCal.Size = new System.Drawing.Size(92, 13);
            this.lbl_NumCal.TabIndex = 1;
            this.lbl_NumCal.Text = "N° calificaciones: ";
            // 
            // gpb_CapturarDate
            // 
            this.gpb_CapturarDate.Controls.Add(this.txt_NumCalif);
            this.gpb_CapturarDate.Controls.Add(this.txt_Calif);
            this.gpb_CapturarDate.Controls.Add(this.lbl_NumCal);
            this.gpb_CapturarDate.Controls.Add(this.lbl_Calificacion);
            this.gpb_CapturarDate.Location = new System.Drawing.Point(16, 23);
            this.gpb_CapturarDate.Name = "gpb_CapturarDate";
            this.gpb_CapturarDate.Size = new System.Drawing.Size(256, 130);
            this.gpb_CapturarDate.TabIndex = 2;
            this.gpb_CapturarDate.TabStop = false;
            this.gpb_CapturarDate.Text = "Capturar Datos";
            // 
            // txt_NumCalif
            // 
            this.txt_NumCalif.Location = new System.Drawing.Point(110, 35);
            this.txt_NumCalif.Name = "txt_NumCalif";
            this.txt_NumCalif.Size = new System.Drawing.Size(60, 20);
            this.txt_NumCalif.TabIndex = 3;
            this.txt_NumCalif.TextChanged += new System.EventHandler(this.txt_NumCalif_TextChanged);
            // 
            // txt_Calif
            // 
            this.txt_Calif.Location = new System.Drawing.Point(110, 68);
            this.txt_Calif.Name = "txt_Calif";
            this.txt_Calif.Size = new System.Drawing.Size(60, 20);
            this.txt_Calif.TabIndex = 2;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(78, 169);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(118, 25);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar calificación";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(37, 214);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 5;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(147, 214);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.gpb_CapturarDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpb_CapturarDate.ResumeLayout(false);
            this.gpb_CapturarDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Calificacion;
        private System.Windows.Forms.Label lbl_NumCal;
        private System.Windows.Forms.GroupBox gpb_CapturarDate;
        private System.Windows.Forms.TextBox txt_NumCalif;
        private System.Windows.Forms.TextBox txt_Calif;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Salir;
    }
}

