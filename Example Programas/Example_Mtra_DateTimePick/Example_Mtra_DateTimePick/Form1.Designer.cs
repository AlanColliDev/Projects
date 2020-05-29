namespace Example_Mtra_DateTimePick
{
    partial class frm_ejemplo
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
            this.chk_Recursador = new System.Windows.Forms.CheckBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_ApMat = new System.Windows.Forms.TextBox();
            this.txt_ApPat = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Datos
            // 
            this.gpb_Datos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gpb_Datos.Controls.Add(this.chk_Recursador);
            this.gpb_Datos.Controls.Add(this.dtp_Fecha);
            this.gpb_Datos.Controls.Add(this.txt_ApMat);
            this.gpb_Datos.Controls.Add(this.txt_ApPat);
            this.gpb_Datos.Controls.Add(this.txt_Nombre);
            this.gpb_Datos.Controls.Add(this.label4);
            this.gpb_Datos.Controls.Add(this.label3);
            this.gpb_Datos.Controls.Add(this.label2);
            this.gpb_Datos.Controls.Add(this.label1);
            this.gpb_Datos.Location = new System.Drawing.Point(12, 12);
            this.gpb_Datos.Name = "gpb_Datos";
            this.gpb_Datos.Size = new System.Drawing.Size(474, 182);
            this.gpb_Datos.TabIndex = 0;
            this.gpb_Datos.TabStop = false;
            this.gpb_Datos.Text = "Datos Alumno";
            // 
            // chk_Recursador
            // 
            this.chk_Recursador.AutoSize = true;
            this.chk_Recursador.Location = new System.Drawing.Point(285, 143);
            this.chk_Recursador.Name = "chk_Recursador";
            this.chk_Recursador.Size = new System.Drawing.Size(81, 17);
            this.chk_Recursador.TabIndex = 8;
            this.chk_Recursador.Text = "Recursador";
            this.chk_Recursador.UseVisualStyleBackColor = true;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(166, 107);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha.TabIndex = 7;
            this.dtp_Fecha.ValueChanged += new System.EventHandler(this.dtp_Fecha_ValueChanged);
            // 
            // txt_ApMat
            // 
            this.txt_ApMat.Location = new System.Drawing.Point(166, 81);
            this.txt_ApMat.Name = "txt_ApMat";
            this.txt_ApMat.Size = new System.Drawing.Size(182, 20);
            this.txt_ApMat.TabIndex = 6;
            // 
            // txt_ApPat
            // 
            this.txt_ApPat.Location = new System.Drawing.Point(166, 55);
            this.txt_ApPat.Name = "txt_ApPat";
            this.txt_ApPat.Size = new System.Drawing.Size(182, 20);
            this.txt_ApPat.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(166, 29);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(182, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Guardar.Location = new System.Drawing.Point(38, 200);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Mostrar.Location = new System.Drawing.Point(134, 200);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 8;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(38, 242);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 9;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(134, 242);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_ejemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 347);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.gpb_Datos);
            this.Name = "frm_ejemplo";
            this.Text = "Form1";
            this.gpb_Datos.ResumeLayout(false);
            this.gpb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Datos;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_ApMat;
        private System.Windows.Forms.TextBox txt_ApPat;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.CheckBox chk_Recursador;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Salir;
    }
}

