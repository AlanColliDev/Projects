namespace Example_Mtra_Oper_Basic
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
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.lbl_Num2 = new System.Windows.Forms.Label();
            this.frm_Operaciones = new System.Windows.Forms.GroupBox();
            this.cbo_Oper = new System.Windows.Forms.ComboBox();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.frm_Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Location = new System.Drawing.Point(17, 28);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(56, 13);
            this.lbl_Num1.TabIndex = 0;
            this.lbl_Num1.Text = "Número 1:";
            // 
            // lbl_Num2
            // 
            this.lbl_Num2.AutoSize = true;
            this.lbl_Num2.Location = new System.Drawing.Point(17, 57);
            this.lbl_Num2.Name = "lbl_Num2";
            this.lbl_Num2.Size = new System.Drawing.Size(56, 13);
            this.lbl_Num2.TabIndex = 1;
            this.lbl_Num2.Text = "Número 2:";
            // 
            // frm_Operaciones
            // 
            this.frm_Operaciones.Controls.Add(this.btn_Salir);
            this.frm_Operaciones.Controls.Add(this.label1);
            this.frm_Operaciones.Controls.Add(this.btn_Limpiar);
            this.frm_Operaciones.Controls.Add(this.cbo_Oper);
            this.frm_Operaciones.Controls.Add(this.btn_Calcular);
            this.frm_Operaciones.Controls.Add(this.txt_Num2);
            this.frm_Operaciones.Controls.Add(this.txt_Num1);
            this.frm_Operaciones.Controls.Add(this.lbl_Num2);
            this.frm_Operaciones.Controls.Add(this.lbl_Num1);
            this.frm_Operaciones.Location = new System.Drawing.Point(23, 27);
            this.frm_Operaciones.Name = "frm_Operaciones";
            this.frm_Operaciones.Size = new System.Drawing.Size(360, 142);
            this.frm_Operaciones.TabIndex = 2;
            this.frm_Operaciones.TabStop = false;
            this.frm_Operaciones.Text = "Operaciones";
            // 
            // cbo_Oper
            // 
            this.cbo_Oper.FormattingEnabled = true;
            this.cbo_Oper.Location = new System.Drawing.Point(20, 103);
            this.cbo_Oper.Name = "cbo_Oper";
            this.cbo_Oper.Size = new System.Drawing.Size(121, 21);
            this.cbo_Oper.TabIndex = 2;
            this.cbo_Oper.SelectedIndexChanged += new System.EventHandler(this.cambiacbo);
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(79, 21);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(100, 20);
            this.txt_Num1.TabIndex = 2;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(79, 50);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 20);
            this.txt_Num2.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(270, 14);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 27);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(270, 53);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 27);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(270, 95);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(73, 27);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(41, 188);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(271, 63);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opciones";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(40, 172);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 5;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 385);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.frm_Operaciones);
            this.Controls.Add(this.txt_Descripcion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.frm_Operaciones.ResumeLayout(false);
            this.frm_Operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.Label lbl_Num2;
        private System.Windows.Forms.GroupBox frm_Operaciones;
        private System.Windows.Forms.ComboBox cbo_Oper;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Descripcion;
    }
}

