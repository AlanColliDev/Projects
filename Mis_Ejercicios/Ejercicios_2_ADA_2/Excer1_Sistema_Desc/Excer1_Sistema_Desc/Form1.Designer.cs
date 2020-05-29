namespace Excer1_Sistema_Desc
{
    partial class frm_SistemaDescuento
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
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_Verde = new System.Windows.Forms.RadioButton();
            this.rbt_Rojo = new System.Windows.Forms.RadioButton();
            this.rbt_Azul = new System.Windows.Forms.RadioButton();
            this.rbt_Amarillo = new System.Windows.Forms.RadioButton();
            this.rbt_Morado = new System.Windows.Forms.RadioButton();
            this.rbt_Blanco = new System.Windows.Forms.RadioButton();
            this.lbl_TotalPagar = new System.Windows.Forms.Label();
            this.txt_TotalPagar = new System.Windows.Forms.TextBox();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.btn_Calular = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(109, 38);
            this.lbl_Monto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(93, 13);
            this.lbl_Monto.TabIndex = 0;
            this.lbl_Monto.Text = "Monto de compra:";
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Location = new System.Drawing.Point(81, 239);
            this.lbl_Descuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(62, 13);
            this.lbl_Descuento.TabIndex = 1;
            this.lbl_Descuento.Text = "Descuento:";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(209, 31);
            this.txt_Monto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(100, 20);
            this.txt_Monto.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_Verde);
            this.groupBox1.Controls.Add(this.rbt_Rojo);
            this.groupBox1.Controls.Add(this.rbt_Azul);
            this.groupBox1.Controls.Add(this.rbt_Amarillo);
            this.groupBox1.Controls.Add(this.rbt_Morado);
            this.groupBox1.Controls.Add(this.rbt_Blanco);
            this.groupBox1.Location = new System.Drawing.Point(62, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(318, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color de Tarjeta";
            // 
            // rbt_Verde
            // 
            this.rbt_Verde.AutoSize = true;
            this.rbt_Verde.Location = new System.Drawing.Point(73, 36);
            this.rbt_Verde.Name = "rbt_Verde";
            this.rbt_Verde.Size = new System.Drawing.Size(53, 17);
            this.rbt_Verde.TabIndex = 4;
            this.rbt_Verde.TabStop = true;
            this.rbt_Verde.Text = "Verde";
            this.rbt_Verde.UseVisualStyleBackColor = true;
            // 
            // rbt_Rojo
            // 
            this.rbt_Rojo.AutoSize = true;
            this.rbt_Rojo.Location = new System.Drawing.Point(73, 70);
            this.rbt_Rojo.Name = "rbt_Rojo";
            this.rbt_Rojo.Size = new System.Drawing.Size(47, 17);
            this.rbt_Rojo.TabIndex = 5;
            this.rbt_Rojo.TabStop = true;
            this.rbt_Rojo.Text = "Rojo";
            this.rbt_Rojo.UseVisualStyleBackColor = true;
            // 
            // rbt_Azul
            // 
            this.rbt_Azul.AutoSize = true;
            this.rbt_Azul.Location = new System.Drawing.Point(73, 105);
            this.rbt_Azul.Name = "rbt_Azul";
            this.rbt_Azul.Size = new System.Drawing.Size(45, 17);
            this.rbt_Azul.TabIndex = 6;
            this.rbt_Azul.TabStop = true;
            this.rbt_Azul.Text = "Azul";
            this.rbt_Azul.UseVisualStyleBackColor = true;
            // 
            // rbt_Amarillo
            // 
            this.rbt_Amarillo.AutoSize = true;
            this.rbt_Amarillo.Location = new System.Drawing.Point(186, 36);
            this.rbt_Amarillo.Name = "rbt_Amarillo";
            this.rbt_Amarillo.Size = new System.Drawing.Size(61, 17);
            this.rbt_Amarillo.TabIndex = 7;
            this.rbt_Amarillo.TabStop = true;
            this.rbt_Amarillo.Text = "Amarillo";
            this.rbt_Amarillo.UseVisualStyleBackColor = true;
            // 
            // rbt_Morado
            // 
            this.rbt_Morado.AutoSize = true;
            this.rbt_Morado.Location = new System.Drawing.Point(186, 70);
            this.rbt_Morado.Name = "rbt_Morado";
            this.rbt_Morado.Size = new System.Drawing.Size(61, 17);
            this.rbt_Morado.TabIndex = 8;
            this.rbt_Morado.TabStop = true;
            this.rbt_Morado.Text = "Morado";
            this.rbt_Morado.UseVisualStyleBackColor = true;
            // 
            // rbt_Blanco
            // 
            this.rbt_Blanco.AutoSize = true;
            this.rbt_Blanco.Location = new System.Drawing.Point(186, 105);
            this.rbt_Blanco.Name = "rbt_Blanco";
            this.rbt_Blanco.Size = new System.Drawing.Size(58, 17);
            this.rbt_Blanco.TabIndex = 9;
            this.rbt_Blanco.TabStop = true;
            this.rbt_Blanco.Text = "Blanco";
            this.rbt_Blanco.UseVisualStyleBackColor = true;
            this.rbt_Blanco.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // lbl_TotalPagar
            // 
            this.lbl_TotalPagar.AutoSize = true;
            this.lbl_TotalPagar.Location = new System.Drawing.Point(73, 273);
            this.lbl_TotalPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalPagar.Name = "lbl_TotalPagar";
            this.lbl_TotalPagar.Size = new System.Drawing.Size(82, 13);
            this.lbl_TotalPagar.TabIndex = 4;
            this.lbl_TotalPagar.Text = "Total a pagar $:";
            // 
            // txt_TotalPagar
            // 
            this.txt_TotalPagar.Enabled = false;
            this.txt_TotalPagar.Location = new System.Drawing.Point(162, 270);
            this.txt_TotalPagar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TotalPagar.Name = "txt_TotalPagar";
            this.txt_TotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalPagar.TabIndex = 5;
            this.txt_TotalPagar.Text = "0";
            this.txt_TotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Desc
            // 
            this.txt_Desc.Enabled = false;
            this.txt_Desc.Location = new System.Drawing.Point(162, 232);
            this.txt_Desc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(100, 20);
            this.txt_Desc.TabIndex = 6;
            this.txt_Desc.Text = "0";
            this.txt_Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Calular
            // 
            this.btn_Calular.Location = new System.Drawing.Point(288, 229);
            this.btn_Calular.Name = "btn_Calular";
            this.btn_Calular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calular.TabIndex = 7;
            this.btn_Calular.Text = "Calcular";
            this.btn_Calular.UseVisualStyleBackColor = true;
            this.btn_Calular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(288, 270);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 8;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(386, 248);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // frm_SistemaDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 302);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Calular);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_TotalPagar);
            this.Controls.Add(this.lbl_TotalPagar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.lbl_Monto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_SistemaDescuento";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sistema de Descuento";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_Verde;
        private System.Windows.Forms.RadioButton rbt_Rojo;
        private System.Windows.Forms.RadioButton rbt_Azul;
        private System.Windows.Forms.RadioButton rbt_Amarillo;
        private System.Windows.Forms.RadioButton rbt_Morado;
        private System.Windows.Forms.RadioButton rbt_Blanco;
        private System.Windows.Forms.Label lbl_TotalPagar;
        private System.Windows.Forms.TextBox txt_TotalPagar;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.Button btn_Calular;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Salir;
    }
}

