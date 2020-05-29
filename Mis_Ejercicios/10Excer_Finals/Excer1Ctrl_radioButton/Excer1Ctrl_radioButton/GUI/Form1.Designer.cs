namespace Excer1Ctrl_radioButton
{
    partial class frm_excer1
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
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.lbl_Incentivo = new System.Windows.Forms.Label();
            this.txt_SueldoMensual = new System.Windows.Forms.TextBox();
            this.txt_Incentivo = new System.Windows.Forms.TextBox();
            this.gpb_Bonificacion = new System.Windows.Forms.GroupBox();
            this.rbt_cincuenta = new System.Windows.Forms.RadioButton();
            this.rbt_veinte = new System.Windows.Forms.RadioButton();
            this.rbt_diez = new System.Windows.Forms.RadioButton();
            this.lbl_SueldoNeto = new System.Windows.Forms.Label();
            this.txt_SueldoNeto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.gpb_Bonificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Location = new System.Drawing.Point(52, 41);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Sueldo.TabIndex = 0;
            this.lbl_Sueldo.Text = "Sueldo:";
            // 
            // lbl_Incentivo
            // 
            this.lbl_Incentivo.AutoSize = true;
            this.lbl_Incentivo.Location = new System.Drawing.Point(52, 99);
            this.lbl_Incentivo.Name = "lbl_Incentivo";
            this.lbl_Incentivo.Size = new System.Drawing.Size(54, 13);
            this.lbl_Incentivo.TabIndex = 1;
            this.lbl_Incentivo.Text = "Incentivo:";
            // 
            // txt_SueldoMensual
            // 
            this.txt_SueldoMensual.Location = new System.Drawing.Point(55, 57);
            this.txt_SueldoMensual.Name = "txt_SueldoMensual";
            this.txt_SueldoMensual.Size = new System.Drawing.Size(100, 20);
            this.txt_SueldoMensual.TabIndex = 2;
            // 
            // txt_Incentivo
            // 
            this.txt_Incentivo.Location = new System.Drawing.Point(55, 115);
            this.txt_Incentivo.Name = "txt_Incentivo";
            this.txt_Incentivo.Size = new System.Drawing.Size(100, 20);
            this.txt_Incentivo.TabIndex = 3;
            // 
            // gpb_Bonificacion
            // 
            this.gpb_Bonificacion.Controls.Add(this.rbt_cincuenta);
            this.gpb_Bonificacion.Controls.Add(this.rbt_veinte);
            this.gpb_Bonificacion.Controls.Add(this.rbt_diez);
            this.gpb_Bonificacion.Location = new System.Drawing.Point(179, 49);
            this.gpb_Bonificacion.Name = "gpb_Bonificacion";
            this.gpb_Bonificacion.Size = new System.Drawing.Size(94, 105);
            this.gpb_Bonificacion.TabIndex = 4;
            this.gpb_Bonificacion.TabStop = false;
            this.gpb_Bonificacion.Text = "Bonificación";
            // 
            // rbt_cincuenta
            // 
            this.rbt_cincuenta.AutoSize = true;
            this.rbt_cincuenta.Location = new System.Drawing.Point(6, 73);
            this.rbt_cincuenta.Name = "rbt_cincuenta";
            this.rbt_cincuenta.Size = new System.Drawing.Size(45, 17);
            this.rbt_cincuenta.TabIndex = 2;
            this.rbt_cincuenta.TabStop = true;
            this.rbt_cincuenta.Text = "50%";
            this.rbt_cincuenta.UseVisualStyleBackColor = true;
            // 
            // rbt_veinte
            // 
            this.rbt_veinte.AutoSize = true;
            this.rbt_veinte.Location = new System.Drawing.Point(6, 46);
            this.rbt_veinte.Name = "rbt_veinte";
            this.rbt_veinte.Size = new System.Drawing.Size(45, 17);
            this.rbt_veinte.TabIndex = 1;
            this.rbt_veinte.TabStop = true;
            this.rbt_veinte.Text = "20%";
            this.rbt_veinte.UseVisualStyleBackColor = true;
            // 
            // rbt_diez
            // 
            this.rbt_diez.AutoSize = true;
            this.rbt_diez.Location = new System.Drawing.Point(6, 19);
            this.rbt_diez.Name = "rbt_diez";
            this.rbt_diez.Size = new System.Drawing.Size(45, 17);
            this.rbt_diez.TabIndex = 0;
            this.rbt_diez.TabStop = true;
            this.rbt_diez.Text = "10%";
            this.rbt_diez.UseVisualStyleBackColor = true;
            // 
            // lbl_SueldoNeto
            // 
            this.lbl_SueldoNeto.AutoSize = true;
            this.lbl_SueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoNeto.Location = new System.Drawing.Point(279, 31);
            this.lbl_SueldoNeto.Name = "lbl_SueldoNeto";
            this.lbl_SueldoNeto.Size = new System.Drawing.Size(163, 31);
            this.lbl_SueldoNeto.TabIndex = 5;
            this.lbl_SueldoNeto.Text = "Sueldo Neto";
            // 
            // txt_SueldoNeto
            // 
            this.txt_SueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SueldoNeto.Location = new System.Drawing.Point(327, 65);
            this.txt_SueldoNeto.Name = "txt_SueldoNeto";
            this.txt_SueldoNeto.Size = new System.Drawing.Size(100, 31);
            this.txt_SueldoNeto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "$";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.AutoSize = true;
            this.btn_Calcular.Location = new System.Drawing.Point(295, 107);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(132, 47);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular Sueldo neto";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // frm_excer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 184);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SueldoNeto);
            this.Controls.Add(this.lbl_SueldoNeto);
            this.Controls.Add(this.gpb_Bonificacion);
            this.Controls.Add(this.txt_Incentivo);
            this.Controls.Add(this.txt_SueldoMensual);
            this.Controls.Add(this.lbl_Incentivo);
            this.Controls.Add(this.lbl_Sueldo);
            this.Name = "frm_excer1";
            this.Text = "Excercise 1";
            this.gpb_Bonificacion.ResumeLayout(false);
            this.gpb_Bonificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Label lbl_Incentivo;
        private System.Windows.Forms.TextBox txt_SueldoMensual;
        private System.Windows.Forms.TextBox txt_Incentivo;
        private System.Windows.Forms.GroupBox gpb_Bonificacion;
        private System.Windows.Forms.RadioButton rbt_cincuenta;
        private System.Windows.Forms.RadioButton rbt_veinte;
        private System.Windows.Forms.RadioButton rbt_diez;
        private System.Windows.Forms.Label lbl_SueldoNeto;
        private System.Windows.Forms.TextBox txt_SueldoNeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

