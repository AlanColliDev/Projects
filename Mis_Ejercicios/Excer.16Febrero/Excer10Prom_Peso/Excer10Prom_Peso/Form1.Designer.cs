namespace Excer10Prom_Peso
{
    partial class frm_Ejercicio10
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
            this.gpb_Introducir = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CantidadP = new System.Windows.Forms.TextBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_Introducir.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Introducir
            // 
            this.gpb_Introducir.Controls.Add(this.btn_Salir);
            this.gpb_Introducir.Controls.Add(this.btn_Mostrar);
            this.gpb_Introducir.Controls.Add(this.btn_Enviar);
            this.gpb_Introducir.Controls.Add(this.txt_CantidadP);
            this.gpb_Introducir.Controls.Add(this.label1);
            this.gpb_Introducir.Location = new System.Drawing.Point(28, 22);
            this.gpb_Introducir.Name = "gpb_Introducir";
            this.gpb_Introducir.Size = new System.Drawing.Size(258, 169);
            this.gpb_Introducir.TabIndex = 0;
            this.gpb_Introducir.TabStop = false;
            this.gpb_Introducir.Text = "Introducir Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de personas evaluadas:";
            // 
            // txt_CantidadP
            // 
            this.txt_CantidadP.Location = new System.Drawing.Point(93, 50);
            this.txt_CantidadP.Name = "txt_CantidadP";
            this.txt_CantidadP.Size = new System.Drawing.Size(50, 20);
            this.txt_CantidadP.TabIndex = 2;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(80, 90);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 3;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(24, 119);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 4;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(134, 119);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_Ejercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 264);
            this.Controls.Add(this.gpb_Introducir);
            this.Name = "frm_Ejercicio10";
            this.Text = "Excercise 10";
            this.gpb_Introducir.ResumeLayout(false);
            this.gpb_Introducir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Introducir;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.TextBox txt_CantidadP;
        private System.Windows.Forms.Label label1;
    }
}

