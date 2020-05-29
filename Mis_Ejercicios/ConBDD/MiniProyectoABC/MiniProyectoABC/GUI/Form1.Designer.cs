namespace MiniProyectoABC
{
    partial class frm_menu
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
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Alumno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::MiniProyectoABC.Properties.Resources.ajustes;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(134, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "Configuración";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Alumno
            // 
            this.btn_Alumno.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Alumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Alumno.Image = global::MiniProyectoABC.Properties.Resources.equipo_1_;
            this.btn_Alumno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Alumno.Location = new System.Drawing.Point(11, 125);
            this.btn_Alumno.Name = "btn_Alumno";
            this.btn_Alumno.Size = new System.Drawing.Size(117, 97);
            this.btn_Alumno.TabIndex = 2;
            this.btn_Alumno.Text = "Alumno";
            this.btn_Alumno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Alumno.UseVisualStyleBackColor = false;
            this.btn_Alumno.Click += new System.EventHandler(this.btn_Alumno_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::MiniProyectoABC.Properties.Resources.laptop;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(193, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prestamo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::MiniProyectoABC.Properties.Resources.analitica_3_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(11, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "Producto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 240);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Alumno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Alumno;
        private System.Windows.Forms.Button button4;
    }
}

