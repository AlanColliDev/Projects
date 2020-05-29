namespace Excer2Libros_ChkList
{
    partial class frm_Excer2
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
            this.gpb_Libros = new System.Windows.Forms.GroupBox();
            this.chk_Oracle = new System.Windows.Forms.CheckBox();
            this.chk_Java = new System.Windows.Forms.CheckBox();
            this.chk_Android = new System.Windows.Forms.CheckBox();
            this.chk_CSharp = new System.Windows.Forms.CheckBox();
            this.chk_Node = new System.Windows.Forms.CheckBox();
            this.lbl_NumLib = new System.Windows.Forms.Label();
            this.txt_NumLib = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Costo = new System.Windows.Forms.Label();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.lbl_Signo = new System.Windows.Forms.Label();
            this.gpb_Libros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Libros
            // 
            this.gpb_Libros.Controls.Add(this.chk_Node);
            this.gpb_Libros.Controls.Add(this.chk_CSharp);
            this.gpb_Libros.Controls.Add(this.chk_Android);
            this.gpb_Libros.Controls.Add(this.chk_Java);
            this.gpb_Libros.Controls.Add(this.chk_Oracle);
            this.gpb_Libros.Location = new System.Drawing.Point(26, 49);
            this.gpb_Libros.Name = "gpb_Libros";
            this.gpb_Libros.Size = new System.Drawing.Size(199, 158);
            this.gpb_Libros.TabIndex = 0;
            this.gpb_Libros.TabStop = false;
            this.gpb_Libros.Text = "Libros";
            // 
            // chk_Oracle
            // 
            this.chk_Oracle.AutoSize = true;
            this.chk_Oracle.Location = new System.Drawing.Point(17, 29);
            this.chk_Oracle.Name = "chk_Oracle";
            this.chk_Oracle.Size = new System.Drawing.Size(84, 17);
            this.chk_Oracle.TabIndex = 0;
            this.chk_Oracle.Text = "Oracle $250";
            this.chk_Oracle.UseVisualStyleBackColor = true;
            // 
            // chk_Java
            // 
            this.chk_Java.AutoSize = true;
            this.chk_Java.Location = new System.Drawing.Point(17, 52);
            this.chk_Java.Name = "chk_Java";
            this.chk_Java.Size = new System.Drawing.Size(76, 17);
            this.chk_Java.TabIndex = 1;
            this.chk_Java.Text = "Java $150";
            this.chk_Java.UseVisualStyleBackColor = true;
            // 
            // chk_Android
            // 
            this.chk_Android.AutoSize = true;
            this.chk_Android.Location = new System.Drawing.Point(17, 102);
            this.chk_Android.Name = "chk_Android";
            this.chk_Android.Size = new System.Drawing.Size(89, 17);
            this.chk_Android.TabIndex = 2;
            this.chk_Android.Text = "Android $150";
            this.chk_Android.UseVisualStyleBackColor = true;
            // 
            // chk_CSharp
            // 
            this.chk_CSharp.AutoSize = true;
            this.chk_CSharp.Location = new System.Drawing.Point(17, 79);
            this.chk_CSharp.Name = "chk_CSharp";
            this.chk_CSharp.Size = new System.Drawing.Size(67, 17);
            this.chk_CSharp.TabIndex = 3;
            this.chk_CSharp.Text = "C# $300";
            this.chk_CSharp.UseVisualStyleBackColor = true;
            // 
            // chk_Node
            // 
            this.chk_Node.AutoSize = true;
            this.chk_Node.Location = new System.Drawing.Point(17, 125);
            this.chk_Node.Name = "chk_Node";
            this.chk_Node.Size = new System.Drawing.Size(89, 17);
            this.chk_Node.TabIndex = 4;
            this.chk_Node.Text = "Node.js $160";
            this.chk_Node.UseVisualStyleBackColor = true;
            // 
            // lbl_NumLib
            // 
            this.lbl_NumLib.AutoSize = true;
            this.lbl_NumLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumLib.Location = new System.Drawing.Point(235, 55);
            this.lbl_NumLib.Name = "lbl_NumLib";
            this.lbl_NumLib.Size = new System.Drawing.Size(191, 31);
            this.lbl_NumLib.TabIndex = 5;
            this.lbl_NumLib.Text = "Número Libros";
            // 
            // txt_NumLib
            // 
            this.txt_NumLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumLib.Location = new System.Drawing.Point(241, 89);
            this.txt_NumLib.Name = "txt_NumLib";
            this.txt_NumLib.Size = new System.Drawing.Size(90, 29);
            this.txt_NumLib.TabIndex = 6;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.AutoSize = true;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(241, 153);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(295, 50);
            this.btn_Calcular.TabIndex = 7;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Costo
            // 
            this.lbl_Costo.AutoSize = true;
            this.lbl_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Costo.Location = new System.Drawing.Point(450, 55);
            this.lbl_Costo.Name = "lbl_Costo";
            this.lbl_Costo.Size = new System.Drawing.Size(86, 31);
            this.lbl_Costo.TabIndex = 8;
            this.lbl_Costo.Text = "Costo";
            // 
            // txt_Costo
            // 
            this.txt_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Costo.Location = new System.Drawing.Point(462, 89);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Size = new System.Drawing.Size(74, 29);
            this.txt_Costo.TabIndex = 9;
            // 
            // lbl_Signo
            // 
            this.lbl_Signo.AutoSize = true;
            this.lbl_Signo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signo.Location = new System.Drawing.Point(436, 92);
            this.lbl_Signo.Name = "lbl_Signo";
            this.lbl_Signo.Size = new System.Drawing.Size(20, 24);
            this.lbl_Signo.TabIndex = 10;
            this.lbl_Signo.Text = "$";
            // 
            // frm_Excer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 291);
            this.Controls.Add(this.lbl_Signo);
            this.Controls.Add(this.txt_Costo);
            this.Controls.Add(this.lbl_Costo);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_NumLib);
            this.Controls.Add(this.lbl_NumLib);
            this.Controls.Add(this.gpb_Libros);
            this.Name = "frm_Excer2";
            this.Text = "Excercise 2";
            this.gpb_Libros.ResumeLayout(false);
            this.gpb_Libros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Libros;
        private System.Windows.Forms.CheckBox chk_Node;
        private System.Windows.Forms.CheckBox chk_CSharp;
        private System.Windows.Forms.CheckBox chk_Android;
        private System.Windows.Forms.CheckBox chk_Java;
        private System.Windows.Forms.CheckBox chk_Oracle;
        private System.Windows.Forms.Label lbl_NumLib;
        private System.Windows.Forms.TextBox txt_NumLib;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Costo;
        private System.Windows.Forms.TextBox txt_Costo;
        private System.Windows.Forms.Label lbl_Signo;
    }
}

