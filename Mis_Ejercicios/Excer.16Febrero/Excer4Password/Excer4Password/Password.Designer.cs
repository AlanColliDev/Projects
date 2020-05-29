namespace Excer4Password
{
    partial class Password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.gpb_Login = new System.Windows.Forms.GroupBox();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(92, 58);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 1;
            // 
            // gpb_Login
            // 
            this.gpb_Login.Controls.Add(this.btn_Salir);
            this.gpb_Login.Controls.Add(this.btn_Verificar);
            this.gpb_Login.Controls.Add(this.txt_Pass);
            this.gpb_Login.Controls.Add(this.label1);
            this.gpb_Login.Location = new System.Drawing.Point(34, 26);
            this.gpb_Login.Name = "gpb_Login";
            this.gpb_Login.Size = new System.Drawing.Size(273, 166);
            this.gpb_Login.TabIndex = 2;
            this.gpb_Login.TabStop = false;
            this.gpb_Login.Text = "Login";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.Location = new System.Drawing.Point(51, 108);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Verificar.TabIndex = 2;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.UseVisualStyleBackColor = true;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(148, 108);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 295);
            this.Controls.Add(this.gpb_Login);
            this.Name = "Password";
            this.Text = "Password";
            this.gpb_Login.ResumeLayout(false);
            this.gpb_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.GroupBox gpb_Login;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.Button btn_Salir;
    }
}