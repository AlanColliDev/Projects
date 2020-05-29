namespace Example_NCapas
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
            this.lbl_Título = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.gpb_DateGrales = new System.Windows.Forms.GroupBox();
            this.tbc_Dates = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.mtxt_NumPaginas = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Num_Paginas = new System.Windows.Forms.Label();
            this.txt_Editorial = new System.Windows.Forms.TextBox();
            this.lbl_Editorial = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpb_DateGrales.SuspendLayout();
            this.tbc_Dates.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Location = new System.Drawing.Point(26, 38);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(38, 13);
            this.lbl_Título.TabIndex = 1;
            this.lbl_Título.Text = "Título:";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(26, 70);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_Precio.TabIndex = 2;
            this.lbl_Precio.Text = "Precio:";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(70, 35);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(247, 20);
            this.txt_Title.TabIndex = 3;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(70, 67);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 4;
            // 
            // gpb_DateGrales
            // 
            this.gpb_DateGrales.Controls.Add(this.txt_Title);
            this.gpb_DateGrales.Controls.Add(this.txt_Precio);
            this.gpb_DateGrales.Controls.Add(this.lbl_Título);
            this.gpb_DateGrales.Controls.Add(this.lbl_Precio);
            this.gpb_DateGrales.Location = new System.Drawing.Point(85, 35);
            this.gpb_DateGrales.Name = "gpb_DateGrales";
            this.gpb_DateGrales.Size = new System.Drawing.Size(373, 162);
            this.gpb_DateGrales.TabIndex = 5;
            this.gpb_DateGrales.TabStop = false;
            this.gpb_DateGrales.Text = "Datos Generales";
            // 
            // tbc_Dates
            // 
            this.tbc_Dates.Controls.Add(this.tabPage1);
            this.tbc_Dates.Controls.Add(this.tabPage2);
            this.tbc_Dates.Location = new System.Drawing.Point(85, 227);
            this.tbc_Dates.Name = "tbc_Dates";
            this.tbc_Dates.SelectedIndex = 0;
            this.tbc_Dates.Size = new System.Drawing.Size(373, 165);
            this.tbc_Dates.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Mostrar);
            this.tabPage1.Controls.Add(this.btn_Agregar);
            this.tabPage1.Controls.Add(this.mtxt_NumPaginas);
            this.tabPage1.Controls.Add(this.lbl_Num_Paginas);
            this.tabPage1.Controls.Add(this.txt_Editorial);
            this.tabPage1.Controls.Add(this.lbl_Editorial);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Libro Impreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(154, 110);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 8;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(238, 65);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "AgregarPrint";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // mtxt_NumPaginas
            // 
            this.mtxt_NumPaginas.Location = new System.Drawing.Point(119, 67);
            this.mtxt_NumPaginas.Mask = "999";
            this.mtxt_NumPaginas.Name = "mtxt_NumPaginas";
            this.mtxt_NumPaginas.Size = new System.Drawing.Size(110, 20);
            this.mtxt_NumPaginas.TabIndex = 6;
            this.mtxt_NumPaginas.ValidatingType = typeof(int);
            // 
            // lbl_Num_Paginas
            // 
            this.lbl_Num_Paginas.AutoSize = true;
            this.lbl_Num_Paginas.Location = new System.Drawing.Point(22, 70);
            this.lbl_Num_Paginas.Name = "lbl_Num_Paginas";
            this.lbl_Num_Paginas.Size = new System.Drawing.Size(91, 13);
            this.lbl_Num_Paginas.TabIndex = 5;
            this.lbl_Num_Paginas.Text = "Num. de Páginas:";
            // 
            // txt_Editorial
            // 
            this.txt_Editorial.Location = new System.Drawing.Point(77, 31);
            this.txt_Editorial.Name = "txt_Editorial";
            this.txt_Editorial.Size = new System.Drawing.Size(236, 20);
            this.txt_Editorial.TabIndex = 4;
            // 
            // lbl_Editorial
            // 
            this.lbl_Editorial.AutoSize = true;
            this.lbl_Editorial.Location = new System.Drawing.Point(24, 34);
            this.lbl_Editorial.Name = "lbl_Editorial";
            this.lbl_Editorial.Size = new System.Drawing.Size(47, 13);
            this.lbl_Editorial.TabIndex = 2;
            this.lbl_Editorial.Text = "Editorial:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AudioLibro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 431);
            this.Controls.Add(this.tbc_Dates);
            this.Controls.Add(this.gpb_DateGrales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpb_DateGrales.ResumeLayout(false);
            this.gpb_DateGrales.PerformLayout();
            this.tbc_Dates.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.GroupBox gpb_DateGrales;
        private System.Windows.Forms.TabControl tbc_Dates;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.MaskedTextBox mtxt_NumPaginas;
        private System.Windows.Forms.Label lbl_Num_Paginas;
        private System.Windows.Forms.TextBox txt_Editorial;
        private System.Windows.Forms.Label lbl_Editorial;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

