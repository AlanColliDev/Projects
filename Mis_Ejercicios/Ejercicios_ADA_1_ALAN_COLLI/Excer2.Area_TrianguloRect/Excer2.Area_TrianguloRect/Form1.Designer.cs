namespace Excer2.Area_TrianguloRect
{
    partial class frm_Calculador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Area = new System.Windows.Forms.Button();
            this.btn_Perimetro = new System.Windows.Forms.Button();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.txt_Base = new System.Windows.Forms.TextBox();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.lbl_Base = new System.Windows.Forms.Label();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.txt_Perimetro = new System.Windows.Forms.TextBox();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.lbl_Perimetro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Area);
            this.groupBox1.Controls.Add(this.btn_Perimetro);
            this.groupBox1.Controls.Add(this.txt_Altura);
            this.groupBox1.Controls.Add(this.txt_Base);
            this.groupBox1.Controls.Add(this.lbl_Altura);
            this.groupBox1.Controls.Add(this.lbl_Base);
            this.groupBox1.Location = new System.Drawing.Point(48, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triángulo Rectángulo";
            // 
            // btn_Area
            // 
            this.btn_Area.Location = new System.Drawing.Point(61, 111);
            this.btn_Area.Name = "btn_Area";
            this.btn_Area.Size = new System.Drawing.Size(75, 23);
            this.btn_Area.TabIndex = 6;
            this.btn_Area.Text = "Area";
            this.btn_Area.UseVisualStyleBackColor = true;
            this.btn_Area.Click += new System.EventHandler(this.btn_Area_Click);
            // 
            // btn_Perimetro
            // 
            this.btn_Perimetro.Location = new System.Drawing.Point(162, 111);
            this.btn_Perimetro.Name = "btn_Perimetro";
            this.btn_Perimetro.Size = new System.Drawing.Size(75, 23);
            this.btn_Perimetro.TabIndex = 5;
            this.btn_Perimetro.Text = "Permietro";
            this.btn_Perimetro.UseVisualStyleBackColor = true;
            this.btn_Perimetro.Click += new System.EventHandler(this.btn_Perimetro_Click);
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(98, 68);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(52, 20);
            this.txt_Altura.TabIndex = 4;
            // 
            // txt_Base
            // 
            this.txt_Base.Location = new System.Drawing.Point(98, 37);
            this.txt_Base.Name = "txt_Base";
            this.txt_Base.Size = new System.Drawing.Size(52, 20);
            this.txt_Base.TabIndex = 3;
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Location = new System.Drawing.Point(58, 71);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(40, 13);
            this.lbl_Altura.TabIndex = 2;
            this.lbl_Altura.Text = "Altura: ";
            // 
            // lbl_Base
            // 
            this.lbl_Base.AutoSize = true;
            this.lbl_Base.Location = new System.Drawing.Point(58, 44);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(34, 13);
            this.lbl_Base.TabIndex = 1;
            this.lbl_Base.Text = "Base:";
            // 
            // txt_Area
            // 
            this.txt_Area.Enabled = false;
            this.txt_Area.Location = new System.Drawing.Point(142, 19);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(49, 20);
            this.txt_Area.TabIndex = 0;
            // 
            // txt_Perimetro
            // 
            this.txt_Perimetro.Enabled = false;
            this.txt_Perimetro.Location = new System.Drawing.Point(142, 54);
            this.txt_Perimetro.Name = "txt_Perimetro";
            this.txt_Perimetro.Size = new System.Drawing.Size(51, 20);
            this.txt_Perimetro.TabIndex = 1;
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(41, 22);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(76, 13);
            this.lbl_Area.TabIndex = 2;
            this.lbl_Area.Text = "El Area es de: ";
            // 
            // lbl_Perimetro
            // 
            this.lbl_Perimetro.AutoSize = true;
            this.lbl_Perimetro.Location = new System.Drawing.Point(41, 57);
            this.lbl_Perimetro.Name = "lbl_Perimetro";
            this.lbl_Perimetro.Size = new System.Drawing.Size(95, 13);
            this.lbl_Perimetro.TabIndex = 3;
            this.lbl_Perimetro.Text = "El Perimetro es de:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Salir);
            this.groupBox2.Controls.Add(this.lbl_Perimetro);
            this.groupBox2.Controls.Add(this.lbl_Area);
            this.groupBox2.Controls.Add(this.txt_Perimetro);
            this.groupBox2.Controls.Add(this.txt_Area);
            this.groupBox2.Location = new System.Drawing.Point(68, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(92, 93);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Calculador";
            this.Text = "Calculador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Area;
        private System.Windows.Forms.Button btn_Perimetro;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.TextBox txt_Base;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.Label lbl_Base;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.TextBox txt_Perimetro;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Label lbl_Perimetro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Salir;
    }
}

