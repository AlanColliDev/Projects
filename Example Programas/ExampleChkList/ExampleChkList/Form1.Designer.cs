namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.rbt_Genero = new System.Windows.Forms.RadioButton();
            this.rbt_GeneroF = new System.Windows.Forms.RadioButton();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_GeneroF);
            this.groupBox1.Controls.Add(this.rbt_Genero);
            this.groupBox1.Controls.Add(this.lbl_Genero);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_Edad);
            this.groupBox1.Controls.Add(this.lbl_Edad);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Location = new System.Drawing.Point(31, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Persona";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(18, 33);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(18, 67);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(35, 13);
            this.lbl_Edad.TabIndex = 1;
            this.lbl_Edad.Text = "Edad:";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(71, 60);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(73, 20);
            this.txt_Edad.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(71, 26);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(211, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(18, 101);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(45, 13);
            this.lbl_Genero.TabIndex = 4;
            this.lbl_Genero.Text = "Género:";
            // 
            // rbt_Genero
            // 
            this.rbt_Genero.AutoSize = true;
            this.rbt_Genero.Location = new System.Drawing.Point(71, 97);
            this.rbt_Genero.Name = "rbt_Genero";
            this.rbt_Genero.Size = new System.Drawing.Size(73, 17);
            this.rbt_Genero.TabIndex = 5;
            this.rbt_Genero.TabStop = true;
            this.rbt_Genero.Text = "Masculino";
            this.rbt_Genero.UseVisualStyleBackColor = true;
            // 
            // rbt_GeneroF
            // 
            this.rbt_GeneroF.AutoSize = true;
            this.rbt_GeneroF.Location = new System.Drawing.Point(150, 97);
            this.rbt_GeneroF.Name = "rbt_GeneroF";
            this.rbt_GeneroF.Size = new System.Drawing.Size(71, 17);
            this.rbt_GeneroF.TabIndex = 6;
            this.rbt_GeneroF.TabStop = true;
            this.rbt_GeneroF.Text = "Femenino";
            this.rbt_GeneroF.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(31, 182);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(127, 182);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 2;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 285);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_GeneroF;
        private System.Windows.Forms.RadioButton rbt_Genero;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Mostrar;
    }
}

