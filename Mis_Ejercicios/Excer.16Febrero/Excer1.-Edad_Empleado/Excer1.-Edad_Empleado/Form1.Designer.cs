namespace Excer1._Edad_Empleado
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
            this.lbl_IntroducirEdad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.txt_CantEmple = new System.Windows.Forms.TextBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IntroducirEdad
            // 
            this.lbl_IntroducirEdad.AutoSize = true;
            this.lbl_IntroducirEdad.Location = new System.Drawing.Point(23, 41);
            this.lbl_IntroducirEdad.Name = "lbl_IntroducirEdad";
            this.lbl_IntroducirEdad.Size = new System.Drawing.Size(121, 13);
            this.lbl_IntroducirEdad.TabIndex = 0;
            this.lbl_IntroducirEdad.Text = "Cantidad de empleados:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Salir);
            this.groupBox1.Controls.Add(this.btn_Nuevo);
            this.groupBox1.Controls.Add(this.btn_Mostrar);
            this.groupBox1.Controls.Add(this.btn_Enviar);
            this.groupBox1.Controls.Add(this.txt_CantEmple);
            this.groupBox1.Controls.Add(this.lbl_IntroducirEdad);
            this.groupBox1.Location = new System.Drawing.Point(46, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introducir Datos";
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.AutoSize = true;
            this.btn_Mostrar.Location = new System.Drawing.Point(61, 91);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(83, 23);
            this.btn_Mostrar.TabIndex = 3;
            this.btn_Mostrar.Text = "Mostrar Datos";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(213, 36);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 2;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // txt_CantEmple
            // 
            this.txt_CantEmple.Location = new System.Drawing.Point(159, 38);
            this.txt_CantEmple.Name = "txt_CantEmple";
            this.txt_CantEmple.Size = new System.Drawing.Size(39, 20);
            this.txt_CantEmple.TabIndex = 1;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.AutoSize = true;
            this.btn_Nuevo.Location = new System.Drawing.Point(187, 91);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(83, 23);
            this.btn_Nuevo.TabIndex = 4;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.AutoSize = true;
            this.btn_Salir.Location = new System.Drawing.Point(124, 138);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(83, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 325);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_IntroducirEdad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.TextBox txt_CantEmple;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Nuevo;
    }
}

