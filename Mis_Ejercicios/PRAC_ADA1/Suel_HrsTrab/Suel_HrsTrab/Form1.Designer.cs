namespace Suel_HrsTrab
{
    partial class frm_CalcularSueldo
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
            this.lbl_Htrab = new System.Windows.Forms.Label();
            this.lbl_PrecxH = new System.Windows.Forms.Label();
            this.gpb_CalculoSueldo = new System.Windows.Forms.GroupBox();
            this.txt_Htrab = new System.Windows.Forms.TextBox();
            this.txt_PrecxH = new System.Windows.Forms.TextBox();
            this.frm_Nomina = new System.Windows.Forms.GroupBox();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.gpb_CalculoSueldo.SuspendLayout();
            this.frm_Nomina.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Htrab
            // 
            this.lbl_Htrab.AutoSize = true;
            this.lbl_Htrab.Location = new System.Drawing.Point(19, 26);
            this.lbl_Htrab.Name = "lbl_Htrab";
            this.lbl_Htrab.Size = new System.Drawing.Size(90, 13);
            this.lbl_Htrab.TabIndex = 0;
            this.lbl_Htrab.Text = "Horas trabajadas:";
            // 
            // lbl_PrecxH
            // 
            this.lbl_PrecxH.AutoSize = true;
            this.lbl_PrecxH.Location = new System.Drawing.Point(27, 57);
            this.lbl_PrecxH.Name = "lbl_PrecxH";
            this.lbl_PrecxH.Size = new System.Drawing.Size(82, 13);
            this.lbl_PrecxH.TabIndex = 1;
            this.lbl_PrecxH.Text = "Precio por hora:";
            // 
            // gpb_CalculoSueldo
            // 
            this.gpb_CalculoSueldo.Controls.Add(this.txt_PrecxH);
            this.gpb_CalculoSueldo.Controls.Add(this.txt_Htrab);
            this.gpb_CalculoSueldo.Controls.Add(this.lbl_Htrab);
            this.gpb_CalculoSueldo.Controls.Add(this.lbl_PrecxH);
            this.gpb_CalculoSueldo.Location = new System.Drawing.Point(31, 34);
            this.gpb_CalculoSueldo.Name = "gpb_CalculoSueldo";
            this.gpb_CalculoSueldo.Size = new System.Drawing.Size(221, 103);
            this.gpb_CalculoSueldo.TabIndex = 2;
            this.gpb_CalculoSueldo.TabStop = false;
            this.gpb_CalculoSueldo.Text = "Datos del Empleado";
            // 
            // txt_Htrab
            // 
            this.txt_Htrab.Location = new System.Drawing.Point(115, 23);
            this.txt_Htrab.Name = "txt_Htrab";
            this.txt_Htrab.Size = new System.Drawing.Size(66, 20);
            this.txt_Htrab.TabIndex = 2;
            this.txt_Htrab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PrecxH
            // 
            this.txt_PrecxH.Location = new System.Drawing.Point(115, 54);
            this.txt_PrecxH.Name = "txt_PrecxH";
            this.txt_PrecxH.Size = new System.Drawing.Size(66, 20);
            this.txt_PrecxH.TabIndex = 3;
            this.txt_PrecxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_Nomina
            // 
            this.frm_Nomina.Controls.Add(this.txt_Sueldo);
            this.frm_Nomina.Controls.Add(this.lbl_Sueldo);
            this.frm_Nomina.Location = new System.Drawing.Point(42, 143);
            this.frm_Nomina.Name = "frm_Nomina";
            this.frm_Nomina.Size = new System.Drawing.Size(196, 59);
            this.frm_Nomina.TabIndex = 4;
            this.frm_Nomina.TabStop = false;
            this.frm_Nomina.Text = "Nomina";
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Location = new System.Drawing.Point(35, 26);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Sueldo.TabIndex = 2;
            this.lbl_Sueldo.Text = "Sueldo:";
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Enabled = false;
            this.txt_Sueldo.Location = new System.Drawing.Point(84, 23);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(66, 20);
            this.txt_Sueldo.TabIndex = 4;
            this.txt_Sueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(39, 208);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(163, 208);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(103, 250);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 7;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // frm_CalcularSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 318);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.frm_Nomina);
            this.Controls.Add(this.gpb_CalculoSueldo);
            this.Name = "frm_CalcularSueldo";
            this.Text = "Sueldo Empleado";
            this.gpb_CalculoSueldo.ResumeLayout(false);
            this.gpb_CalculoSueldo.PerformLayout();
            this.frm_Nomina.ResumeLayout(false);
            this.frm_Nomina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Htrab;
        private System.Windows.Forms.Label lbl_PrecxH;
        private System.Windows.Forms.GroupBox gpb_CalculoSueldo;
        private System.Windows.Forms.TextBox txt_PrecxH;
        private System.Windows.Forms.TextBox txt_Htrab;
        private System.Windows.Forms.GroupBox frm_Nomina;
        private System.Windows.Forms.TextBox txt_Sueldo;
        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Nuevo;
    }
}

