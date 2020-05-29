namespace Excer5Nuevo_Salario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Aumento = new System.Windows.Forms.TextBox();
            this.txt_Sueldo_B = new System.Windows.Forms.TextBox();
            this.lbl_Aumento = new System.Windows.Forms.Label();
            this.lbl_Sueldo_B = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Nomina = new System.Windows.Forms.TextBox();
            this.lbl_Nomina = new System.Windows.Forms.Label();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Aumento);
            this.groupBox1.Controls.Add(this.txt_Sueldo_B);
            this.groupBox1.Controls.Add(this.lbl_Aumento);
            this.groupBox1.Controls.Add(this.lbl_Sueldo_B);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empleado";
            // 
            // txt_Aumento
            // 
            this.txt_Aumento.Enabled = false;
            this.txt_Aumento.Location = new System.Drawing.Point(102, 49);
            this.txt_Aumento.Name = "txt_Aumento";
            this.txt_Aumento.Size = new System.Drawing.Size(100, 20);
            this.txt_Aumento.TabIndex = 3;
            this.txt_Aumento.Text = "25%";
            this.txt_Aumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Sueldo_B
            // 
            this.txt_Sueldo_B.Location = new System.Drawing.Point(102, 19);
            this.txt_Sueldo_B.Name = "txt_Sueldo_B";
            this.txt_Sueldo_B.Size = new System.Drawing.Size(100, 20);
            this.txt_Sueldo_B.TabIndex = 2;
            this.txt_Sueldo_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Aumento
            // 
            this.lbl_Aumento.AutoSize = true;
            this.lbl_Aumento.Location = new System.Drawing.Point(32, 56);
            this.lbl_Aumento.Name = "lbl_Aumento";
            this.lbl_Aumento.Size = new System.Drawing.Size(55, 13);
            this.lbl_Aumento.TabIndex = 1;
            this.lbl_Aumento.Text = "Aumento: ";
            // 
            // lbl_Sueldo_B
            // 
            this.lbl_Sueldo_B.AutoSize = true;
            this.lbl_Sueldo_B.Location = new System.Drawing.Point(32, 28);
            this.lbl_Sueldo_B.Name = "lbl_Sueldo_B";
            this.lbl_Sueldo_B.Size = new System.Drawing.Size(69, 13);
            this.lbl_Sueldo_B.TabIndex = 0;
            this.lbl_Sueldo_B.Text = "Sueldo base:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Nomina);
            this.groupBox2.Controls.Add(this.lbl_Nomina);
            this.groupBox2.Location = new System.Drawing.Point(41, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 101);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo";
            // 
            // txt_Nomina
            // 
            this.txt_Nomina.Enabled = false;
            this.txt_Nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nomina.Location = new System.Drawing.Point(83, 37);
            this.txt_Nomina.Name = "txt_Nomina";
            this.txt_Nomina.Size = new System.Drawing.Size(100, 20);
            this.txt_Nomina.TabIndex = 3;
            this.txt_Nomina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Nomina
            // 
            this.lbl_Nomina.AutoSize = true;
            this.lbl_Nomina.Location = new System.Drawing.Point(13, 44);
            this.lbl_Nomina.Name = "lbl_Nomina";
            this.lbl_Nomina.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nomina.TabIndex = 2;
            this.lbl_Nomina.Text = "Nomina: ";
            // 
            // btn_Generar
            // 
            this.btn_Generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Generar.Image")));
            this.btn_Generar.Location = new System.Drawing.Point(57, 251);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(75, 23);
            this.btn_Generar.TabIndex = 1;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(166, 251);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 2;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(109, 296);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 331);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Aumento;
        private System.Windows.Forms.TextBox txt_Sueldo_B;
        private System.Windows.Forms.Label lbl_Aumento;
        private System.Windows.Forms.Label lbl_Sueldo_B;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Nomina;
        private System.Windows.Forms.Label lbl_Nomina;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Salir;
    }
}

