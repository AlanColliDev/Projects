namespace Excer7ListBoxProd
{
    partial class frm_Excer7
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
            this.ltb_Codigos = new System.Windows.Forms.ListBox();
            this.pic_ImageProd = new System.Windows.Forms.PictureBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_NomProd = new System.Windows.Forms.Label();
            this.txt_NomProd = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Libros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImageProd)).BeginInit();
            this.SuspendLayout();
            // 
            // ltb_Codigos
            // 
            this.ltb_Codigos.FormattingEnabled = true;
            this.ltb_Codigos.Items.AddRange(new object[] {
            ""});
            this.ltb_Codigos.Location = new System.Drawing.Point(95, 71);
            this.ltb_Codigos.Name = "ltb_Codigos";
            this.ltb_Codigos.Size = new System.Drawing.Size(66, 199);
            this.ltb_Codigos.TabIndex = 0;
            this.ltb_Codigos.SelectedIndexChanged += new System.EventHandler(this.ltb_Codigos_SelectedIndexChanged);
            // 
            // pic_ImageProd
            // 
            this.pic_ImageProd.Image = global::Excer7ListBoxProd.Properties.Resources.uno;
            this.pic_ImageProd.Location = new System.Drawing.Point(400, 39);
            this.pic_ImageProd.Name = "pic_ImageProd";
            this.pic_ImageProd.Size = new System.Drawing.Size(232, 231);
            this.pic_ImageProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImageProd.TabIndex = 1;
            this.pic_ImageProd.TabStop = false;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(282, 76);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 2;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(233, 79);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Codigo.TabIndex = 3;
            this.lbl_Codigo.Text = "Código:";
            // 
            // lbl_NomProd
            // 
            this.lbl_NomProd.AutoSize = true;
            this.lbl_NomProd.Location = new System.Drawing.Point(167, 140);
            this.lbl_NomProd.Name = "lbl_NomProd";
            this.lbl_NomProd.Size = new System.Drawing.Size(109, 13);
            this.lbl_NomProd.TabIndex = 5;
            this.lbl_NomProd.Text = "Nombre del producto:";
            // 
            // txt_NomProd
            // 
            this.txt_NomProd.Location = new System.Drawing.Point(282, 137);
            this.txt_NomProd.Name = "txt_NomProd";
            this.txt_NomProd.Size = new System.Drawing.Size(100, 20);
            this.txt_NomProd.TabIndex = 4;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(233, 198);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_Precio.TabIndex = 7;
            this.lbl_Precio.Text = "Precio:";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(282, 195);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 6;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(233, 253);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cantidad.TabIndex = 9;
            this.lbl_Cantidad.Text = "Precio:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(282, 250);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 8;
            // 
            // lbl_Libros
            // 
            this.lbl_Libros.AutoSize = true;
            this.lbl_Libros.Location = new System.Drawing.Point(92, 55);
            this.lbl_Libros.Name = "lbl_Libros";
            this.lbl_Libros.Size = new System.Drawing.Size(35, 13);
            this.lbl_Libros.TabIndex = 10;
            this.lbl_Libros.Text = "Libros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Excer7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Libros);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.lbl_NomProd);
            this.Controls.Add(this.txt_NomProd);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.pic_ImageProd);
            this.Controls.Add(this.ltb_Codigos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Excer7";
            this.Text = "Ejercicio 7";
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImageProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Codigos;
        private System.Windows.Forms.PictureBox pic_ImageProd;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_NomProd;
        private System.Windows.Forms.TextBox txt_NomProd;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lbl_Libros;
        private System.Windows.Forms.Button button1;
    }
}

