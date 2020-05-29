namespace PrimerFormulario
{
    partial class Frm_Operaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Operaciones));
            this.grb_Captura_Num = new System.Windows.Forms.GroupBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.lbl_Num2 = new System.Windows.Forms.Label();
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.grb_Acciones = new System.Windows.Forms.GroupBox();
            this.btn_Multip = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn_Sumar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.grb_Captura_Num.SuspendLayout();
            this.grb_Acciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Captura_Num
            // 
            this.grb_Captura_Num.BackColor = System.Drawing.Color.Silver;
            this.grb_Captura_Num.Controls.Add(this.txt_Num2);
            this.grb_Captura_Num.Controls.Add(this.txt_Num1);
            this.grb_Captura_Num.Controls.Add(this.lbl_Num2);
            this.grb_Captura_Num.Controls.Add(this.lbl_Num1);
            this.grb_Captura_Num.Location = new System.Drawing.Point(151, 25);
            this.grb_Captura_Num.Name = "grb_Captura_Num";
            this.grb_Captura_Num.Size = new System.Drawing.Size(316, 145);
            this.grb_Captura_Num.TabIndex = 0;
            this.grb_Captura_Num.TabStop = false;
            this.grb_Captura_Num.Text = "Captura de Números";
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(92, 76);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 20);
            this.txt_Num2.TabIndex = 3;
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(92, 28);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(100, 20);
            this.txt_Num1.TabIndex = 2;
            // 
            // lbl_Num2
            // 
            this.lbl_Num2.AutoSize = true;
            this.lbl_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num2.Location = new System.Drawing.Point(29, 79);
            this.lbl_Num2.Name = "lbl_Num2";
            this.lbl_Num2.Size = new System.Drawing.Size(65, 13);
            this.lbl_Num2.TabIndex = 1;
            this.lbl_Num2.Text = "Número 2:";
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num1.Location = new System.Drawing.Point(29, 31);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(65, 13);
            this.lbl_Num1.TabIndex = 0;
            this.lbl_Num1.Text = "Número 1:";
            // 
            // grb_Acciones
            // 
            this.grb_Acciones.BackColor = System.Drawing.Color.Silver;
            this.grb_Acciones.Controls.Add(this.btn_Multip);
            this.grb_Acciones.Controls.Add(this.btn_div);
            this.grb_Acciones.Controls.Add(this.btn_Resta);
            this.grb_Acciones.Controls.Add(this.btn_Sumar);
            this.grb_Acciones.Location = new System.Drawing.Point(151, 176);
            this.grb_Acciones.Name = "grb_Acciones";
            this.grb_Acciones.Size = new System.Drawing.Size(315, 80);
            this.grb_Acciones.TabIndex = 1;
            this.grb_Acciones.TabStop = false;
            this.grb_Acciones.Text = "Acciones";
            // 
            // btn_Multip
            // 
            this.btn_Multip.AutoSize = true;
            this.btn_Multip.Image = ((System.Drawing.Image)(resources.GetObject("btn_Multip.Image")));
            this.btn_Multip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Multip.Location = new System.Drawing.Point(151, 19);
            this.btn_Multip.Name = "btn_Multip";
            this.btn_Multip.Size = new System.Drawing.Size(112, 23);
            this.btn_Multip.TabIndex = 4;
            this.btn_Multip.Text = "Multiplicación";
            this.btn_Multip.UseVisualStyleBackColor = true;
            this.btn_Multip.Click += new System.EventHandler(this.btn_Multip_Click);
            // 
            // btn_div
            // 
            this.btn_div.Image = ((System.Drawing.Image)(resources.GetObject("btn_div.Image")));
            this.btn_div.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_div.Location = new System.Drawing.Point(169, 48);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "División";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Resta.Image")));
            this.btn_Resta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Resta.Location = new System.Drawing.Point(46, 49);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(75, 23);
            this.btn_Resta.TabIndex = 2;
            this.btn_Resta.Text = "Resta";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // btn_Sumar
            // 
            this.btn_Sumar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sumar.Image")));
            this.btn_Sumar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Sumar.Location = new System.Drawing.Point(46, 19);
            this.btn_Sumar.Name = "btn_Sumar";
            this.btn_Sumar.Size = new System.Drawing.Size(75, 23);
            this.btn_Sumar.TabIndex = 0;
            this.btn_Sumar.Text = "Sumar";
            this.btn_Sumar.UseVisualStyleBackColor = true;
            this.btn_Sumar.Click += new System.EventHandler(this.btn_Sumar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txt_Resultado);
            this.groupBox1.Location = new System.Drawing.Point(152, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Enabled = false;
            this.txt_Resultado.Location = new System.Drawing.Point(102, 19);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_Resultado.TabIndex = 0;
            // 
            // Frm_Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(739, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_Acciones);
            this.Controls.Add(this.grb_Captura_Num);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frm_Operaciones";
            this.Text = "Operaciones";
            this.grb_Captura_Num.ResumeLayout(false);
            this.grb_Captura_Num.PerformLayout();
            this.grb_Acciones.ResumeLayout(false);
            this.grb_Acciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Captura_Num;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.Label lbl_Num2;
        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.GroupBox grb_Acciones;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_Sumar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn_Multip;
    }
}

