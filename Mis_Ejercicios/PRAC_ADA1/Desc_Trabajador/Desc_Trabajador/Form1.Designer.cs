namespace Desc_Trabajador
{
    partial class frm_Claculo_Sueldo
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
            this.lbl_SueldoBase = new System.Windows.Forms.Label();
            this.txt_SueldoBase = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_SuelNeto = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_SuelNeto = new System.Windows.Forms.TextBox();
            this.gpb_Sueldo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_Sueldo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SueldoBase
            // 
            this.lbl_SueldoBase.AutoSize = true;
            this.lbl_SueldoBase.Location = new System.Drawing.Point(7, 22);
            this.lbl_SueldoBase.Name = "lbl_SueldoBase";
            this.lbl_SueldoBase.Size = new System.Drawing.Size(72, 13);
            this.lbl_SueldoBase.TabIndex = 0;
            this.lbl_SueldoBase.Text = "Sueldo base: ";
            // 
            // txt_SueldoBase
            // 
            this.txt_SueldoBase.Location = new System.Drawing.Point(74, 19);
            this.txt_SueldoBase.Name = "txt_SueldoBase";
            this.txt_SueldoBase.Size = new System.Drawing.Size(100, 20);
            this.txt_SueldoBase.TabIndex = 1;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Location = new System.Drawing.Point(17, 33);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(62, 13);
            this.lbl_Desc.TabIndex = 2;
            this.lbl_Desc.Text = "Descuento:";
            // 
            // lbl_SuelNeto
            // 
            this.lbl_SuelNeto.AutoSize = true;
            this.lbl_SuelNeto.Location = new System.Drawing.Point(17, 66);
            this.lbl_SuelNeto.Name = "lbl_SuelNeto";
            this.lbl_SuelNeto.Size = new System.Drawing.Size(70, 13);
            this.lbl_SuelNeto.TabIndex = 3;
            this.lbl_SuelNeto.Text = "Sueldo neto: ";
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(84, 30);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(100, 20);
            this.txt_Desc.TabIndex = 4;
            // 
            // txt_SuelNeto
            // 
            this.txt_SuelNeto.Location = new System.Drawing.Point(84, 63);
            this.txt_SuelNeto.Name = "txt_SuelNeto";
            this.txt_SuelNeto.Size = new System.Drawing.Size(100, 20);
            this.txt_SuelNeto.TabIndex = 5;
            // 
            // gpb_Sueldo
            // 
            this.gpb_Sueldo.Controls.Add(this.txt_Desc);
            this.gpb_Sueldo.Controls.Add(this.txt_SuelNeto);
            this.gpb_Sueldo.Controls.Add(this.lbl_Desc);
            this.gpb_Sueldo.Controls.Add(this.lbl_SuelNeto);
            this.gpb_Sueldo.Location = new System.Drawing.Point(34, 81);
            this.gpb_Sueldo.Name = "gpb_Sueldo";
            this.gpb_Sueldo.Size = new System.Drawing.Size(200, 100);
            this.gpb_Sueldo.TabIndex = 6;
            this.gpb_Sueldo.TabStop = false;
            this.gpb_Sueldo.Text = "Calculo de Sueldo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SueldoBase);
            this.groupBox1.Controls.Add(this.lbl_SueldoBase);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 48);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca datos: ";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(34, 200);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(143, 200);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Claculo_Sueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_Sueldo);
            this.Name = "frm_Claculo_Sueldo";
            this.Text = "Calculo de Sueldo";
            this.gpb_Sueldo.ResumeLayout(false);
            this.gpb_Sueldo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_SueldoBase;
        private System.Windows.Forms.TextBox txt_SueldoBase;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_SuelNeto;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_SuelNeto;
        private System.Windows.Forms.GroupBox gpb_Sueldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Salir;
    }
}

