namespace Sueldo_Hora
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
            this.lbl_HorasTrab = new System.Windows.Forms.Label();
            this.lbl_PagoHora = new System.Windows.Forms.Label();
            this.gpb_CalcularSueldo = new System.Windows.Forms.GroupBox();
            this.txt_HorasTrab = new System.Windows.Forms.TextBox();
            this.txt_PagoHora = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.gpb_CalcularSueldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_HorasTrab
            // 
            this.lbl_HorasTrab.AutoSize = true;
            this.lbl_HorasTrab.Location = new System.Drawing.Point(6, 34);
            this.lbl_HorasTrab.Name = "lbl_HorasTrab";
            this.lbl_HorasTrab.Size = new System.Drawing.Size(90, 13);
            this.lbl_HorasTrab.TabIndex = 0;
            this.lbl_HorasTrab.Text = "Horas trabajadas:";
            // 
            // lbl_PagoHora
            // 
            this.lbl_PagoHora.AutoSize = true;
            this.lbl_PagoHora.Location = new System.Drawing.Point(19, 62);
            this.lbl_PagoHora.Name = "lbl_PagoHora";
            this.lbl_PagoHora.Size = new System.Drawing.Size(77, 13);
            this.lbl_PagoHora.TabIndex = 1;
            this.lbl_PagoHora.Text = "Pago por hora:";
            // 
            // gpb_CalcularSueldo
            // 
            this.gpb_CalcularSueldo.Controls.Add(this.txt_PagoHora);
            this.gpb_CalcularSueldo.Controls.Add(this.txt_HorasTrab);
            this.gpb_CalcularSueldo.Controls.Add(this.lbl_HorasTrab);
            this.gpb_CalcularSueldo.Controls.Add(this.lbl_PagoHora);
            this.gpb_CalcularSueldo.Location = new System.Drawing.Point(41, 23);
            this.gpb_CalcularSueldo.Name = "gpb_CalcularSueldo";
            this.gpb_CalcularSueldo.Size = new System.Drawing.Size(223, 95);
            this.gpb_CalcularSueldo.TabIndex = 2;
            this.gpb_CalcularSueldo.TabStop = false;
            this.gpb_CalcularSueldo.Text = "Clacular Sueldo";
            // 
            // txt_HorasTrab
            // 
            this.txt_HorasTrab.Location = new System.Drawing.Point(102, 31);
            this.txt_HorasTrab.Name = "txt_HorasTrab";
            this.txt_HorasTrab.Size = new System.Drawing.Size(100, 20);
            this.txt_HorasTrab.TabIndex = 2;
            // 
            // txt_PagoHora
            // 
            this.txt_PagoHora.Location = new System.Drawing.Point(102, 59);
            this.txt_PagoHora.Name = "txt_PagoHora";
            this.txt_PagoHora.Size = new System.Drawing.Size(100, 20);
            this.txt_PagoHora.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(62, 140);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(112, 169);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(168, 140);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 5;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 301);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.gpb_CalcularSueldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpb_CalcularSueldo.ResumeLayout(false);
            this.gpb_CalcularSueldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_HorasTrab;
        private System.Windows.Forms.Label lbl_PagoHora;
        private System.Windows.Forms.GroupBox gpb_CalcularSueldo;
        private System.Windows.Forms.TextBox txt_PagoHora;
        private System.Windows.Forms.TextBox txt_HorasTrab;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Nuevo;
    }
}

