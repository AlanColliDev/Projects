namespace Dias_Sem
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Inicial = new System.Windows.Forms.TextBox();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.txt_DiaCorr = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Instruccion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicial:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Nuevo);
            this.groupBox1.Controls.Add(this.btn_Verificar);
            this.groupBox1.Controls.Add(this.txt_Inicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite una letra:";
            // 
            // txt_Inicial
            // 
            this.txt_Inicial.Location = new System.Drawing.Point(101, 31);
            this.txt_Inicial.Name = "txt_Inicial";
            this.txt_Inicial.Size = new System.Drawing.Size(39, 20);
            this.txt_Inicial.TabIndex = 1;
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Location = new System.Drawing.Point(20, 71);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Verificar.TabIndex = 2;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(110, 71);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // txt_DiaCorr
            // 
            this.txt_DiaCorr.Enabled = false;
            this.txt_DiaCorr.Location = new System.Drawing.Point(86, 177);
            this.txt_DiaCorr.Multiline = true;
            this.txt_DiaCorr.Name = "txt_DiaCorr";
            this.txt_DiaCorr.Size = new System.Drawing.Size(117, 48);
            this.txt_DiaCorr.TabIndex = 2;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(110, 248);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Instruccion
            // 
            this.lbl_Instruccion.AutoSize = true;
            this.lbl_Instruccion.Location = new System.Drawing.Point(14, 22);
            this.lbl_Instruccion.Name = "lbl_Instruccion";
            this.lbl_Instruccion.Size = new System.Drawing.Size(309, 13);
            this.lbl_Instruccion.TabIndex = 4;
            this.lbl_Instruccion.Text = "Introduzca una inicial de un dia de la semana (x para Miércoles).";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 326);
            this.Controls.Add(this.lbl_Instruccion);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_DiaCorr);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.TextBox txt_Inicial;
        private System.Windows.Forms.TextBox txt_DiaCorr;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Instruccion;
    }
}

