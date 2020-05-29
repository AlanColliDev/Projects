namespace Excer4Rbt_Calc
{
    partial class frm_Excer4
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
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.lbl_Num2 = new System.Windows.Forms.Label();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.gpb_Operacion = new System.Windows.Forms.GroupBox();
            this.rbt_Multi = new System.Windows.Forms.RadioButton();
            this.rbt_Dividir = new System.Windows.Forms.RadioButton();
            this.rbt_Restar = new System.Windows.Forms.RadioButton();
            this.rbt_Sumar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Respu = new System.Windows.Forms.TextBox();
            this.gpb_Operacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num1.Location = new System.Drawing.Point(25, 35);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(78, 16);
            this.lbl_Num1.TabIndex = 0;
            this.lbl_Num1.Text = "Número 1:";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(109, 32);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(63, 20);
            this.txt_Num1.TabIndex = 1;
            // 
            // lbl_Num2
            // 
            this.lbl_Num2.AutoSize = true;
            this.lbl_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num2.Location = new System.Drawing.Point(200, 35);
            this.lbl_Num2.Name = "lbl_Num2";
            this.lbl_Num2.Size = new System.Drawing.Size(78, 16);
            this.lbl_Num2.TabIndex = 2;
            this.lbl_Num2.Text = "Número 2:";
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(284, 31);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(63, 20);
            this.txt_Num2.TabIndex = 3;
            // 
            // gpb_Operacion
            // 
            this.gpb_Operacion.Controls.Add(this.rbt_Multi);
            this.gpb_Operacion.Controls.Add(this.rbt_Dividir);
            this.gpb_Operacion.Controls.Add(this.rbt_Restar);
            this.gpb_Operacion.Controls.Add(this.rbt_Sumar);
            this.gpb_Operacion.Location = new System.Drawing.Point(109, 72);
            this.gpb_Operacion.Name = "gpb_Operacion";
            this.gpb_Operacion.Size = new System.Drawing.Size(180, 151);
            this.gpb_Operacion.TabIndex = 4;
            this.gpb_Operacion.TabStop = false;
            this.gpb_Operacion.Text = "OPERACIÓN";
            // 
            // rbt_Multi
            // 
            this.rbt_Multi.AutoSize = true;
            this.rbt_Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Multi.Location = new System.Drawing.Point(14, 113);
            this.rbt_Multi.Name = "rbt_Multi";
            this.rbt_Multi.Size = new System.Drawing.Size(103, 22);
            this.rbt_Multi.TabIndex = 5;
            this.rbt_Multi.TabStop = true;
            this.rbt_Multi.Text = "Multiplicar";
            this.rbt_Multi.UseVisualStyleBackColor = true;
            this.rbt_Multi.CheckedChanged += new System.EventHandler(this.rbt_Multi_CheckedChanged);
            // 
            // rbt_Dividir
            // 
            this.rbt_Dividir.AutoSize = true;
            this.rbt_Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Dividir.Location = new System.Drawing.Point(14, 85);
            this.rbt_Dividir.Name = "rbt_Dividir";
            this.rbt_Dividir.Size = new System.Drawing.Size(73, 22);
            this.rbt_Dividir.TabIndex = 2;
            this.rbt_Dividir.TabStop = true;
            this.rbt_Dividir.Text = "Dividir";
            this.rbt_Dividir.UseVisualStyleBackColor = true;
            this.rbt_Dividir.CheckedChanged += new System.EventHandler(this.rbt_Dividir_CheckedChanged);
            // 
            // rbt_Restar
            // 
            this.rbt_Restar.AutoSize = true;
            this.rbt_Restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Restar.Location = new System.Drawing.Point(14, 57);
            this.rbt_Restar.Name = "rbt_Restar";
            this.rbt_Restar.Size = new System.Drawing.Size(76, 22);
            this.rbt_Restar.TabIndex = 1;
            this.rbt_Restar.TabStop = true;
            this.rbt_Restar.Text = "Restar";
            this.rbt_Restar.UseVisualStyleBackColor = true;
            this.rbt_Restar.CheckedChanged += new System.EventHandler(this.rbt_Restar_CheckedChanged);
            // 
            // rbt_Sumar
            // 
            this.rbt_Sumar.AutoSize = true;
            this.rbt_Sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Sumar.Location = new System.Drawing.Point(15, 29);
            this.rbt_Sumar.Name = "rbt_Sumar";
            this.rbt_Sumar.Size = new System.Drawing.Size(75, 22);
            this.rbt_Sumar.TabIndex = 0;
            this.rbt_Sumar.TabStop = true;
            this.rbt_Sumar.Text = "Sumar";
            this.rbt_Sumar.UseVisualStyleBackColor = true;
            this.rbt_Sumar.CheckedChanged += new System.EventHandler(this.rbt_Sumar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Respuesta:";
            // 
            // txt_Respu
            // 
            this.txt_Respu.Location = new System.Drawing.Point(232, 246);
            this.txt_Respu.Name = "txt_Respu";
            this.txt_Respu.Size = new System.Drawing.Size(63, 20);
            this.txt_Respu.TabIndex = 6;
            // 
            // frm_Excer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 309);
            this.Controls.Add(this.txt_Respu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpb_Operacion);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.lbl_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Num1);
            this.Name = "frm_Excer4";
            this.Text = "Ejercicio 4";
            this.gpb_Operacion.ResumeLayout(false);
            this.gpb_Operacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.Label lbl_Num2;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.GroupBox gpb_Operacion;
        private System.Windows.Forms.RadioButton rbt_Multi;
        private System.Windows.Forms.RadioButton rbt_Dividir;
        private System.Windows.Forms.RadioButton rbt_Restar;
        private System.Windows.Forms.RadioButton rbt_Sumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Respu;
    }
}

