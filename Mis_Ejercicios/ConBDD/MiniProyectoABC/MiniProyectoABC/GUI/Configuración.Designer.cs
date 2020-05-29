namespace MiniProyectoABC.GUI
{
    partial class frm_configuracion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.dgv_Mostrar = new System.Windows.Forms.DataGridView();
            this.txt_Division = new System.Windows.Forms.TextBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_EliminarCat = new System.Windows.Forms.Button();
            this.btn_ActualizarCat = new System.Windows.Forms.Button();
            this.btn_GuardarCat = new System.Windows.Forms.Button();
            this.btn_NuevoCat = new System.Windows.Forms.Button();
            this.dgv_MostrarCat = new System.Windows.Forms.DataGridView();
            this.txt_Cat = new System.Windows.Forms.TextBox();
            this.txt_IdCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_EliminarM = new System.Windows.Forms.Button();
            this.btn_ActualizarM = new System.Windows.Forms.Button();
            this.btn_GuardarM = new System.Windows.Forms.Button();
            this.btn_NuevoM = new System.Windows.Forms.Button();
            this.dgv_Marca = new System.Windows.Forms.DataGridView();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_IdMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostrarCat)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marca)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Eliminar);
            this.tabPage1.Controls.Add(this.btn_Actualizar);
            this.tabPage1.Controls.Add(this.btn_Guardar);
            this.tabPage1.Controls.Add(this.btn_Nuevo);
            this.tabPage1.Controls.Add(this.dgv_Mostrar);
            this.tabPage1.Controls.Add(this.txt_Division);
            this.tabPage1.Controls.Add(this.txt_Clave);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Divisiones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Image = global::MiniProyectoABC.Properties.Resources.basura;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(333, 104);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(101, 39);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Image = global::MiniProyectoABC.Properties.Resources.comprobar;
            this.btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Actualizar.Location = new System.Drawing.Point(226, 104);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(101, 39);
            this.btn_Actualizar.TabIndex = 7;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Image = global::MiniProyectoABC.Properties.Resources.guardar;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(124, 104);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(96, 39);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Image = global::MiniProyectoABC.Properties.Resources.lapiz;
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(22, 104);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(96, 39);
            this.btn_Nuevo.TabIndex = 5;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // dgv_Mostrar
            // 
            this.dgv_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mostrar.Location = new System.Drawing.Point(22, 149);
            this.dgv_Mostrar.Name = "dgv_Mostrar";
            this.dgv_Mostrar.Size = new System.Drawing.Size(412, 119);
            this.dgv_Mostrar.TabIndex = 4;
            this.dgv_Mostrar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarRegistro_CellMouseClick);
            // 
            // txt_Division
            // 
            this.txt_Division.Location = new System.Drawing.Point(22, 78);
            this.txt_Division.Name = "txt_Division";
            this.txt_Division.Size = new System.Drawing.Size(208, 20);
            this.txt_Division.TabIndex = 3;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Enabled = false;
            this.txt_Clave.Location = new System.Drawing.Point(22, 39);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(70, 20);
            this.txt_Clave.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "División";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_EliminarCat);
            this.tabPage2.Controls.Add(this.btn_ActualizarCat);
            this.tabPage2.Controls.Add(this.btn_GuardarCat);
            this.tabPage2.Controls.Add(this.btn_NuevoCat);
            this.tabPage2.Controls.Add(this.dgv_MostrarCat);
            this.tabPage2.Controls.Add(this.txt_Cat);
            this.tabPage2.Controls.Add(this.txt_IdCat);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarCat
            // 
            this.btn_EliminarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_EliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarCat.Image = global::MiniProyectoABC.Properties.Resources.basura;
            this.btn_EliminarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarCat.Location = new System.Drawing.Point(334, 94);
            this.btn_EliminarCat.Name = "btn_EliminarCat";
            this.btn_EliminarCat.Size = new System.Drawing.Size(101, 39);
            this.btn_EliminarCat.TabIndex = 17;
            this.btn_EliminarCat.Text = "Eliminar";
            this.btn_EliminarCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarCat.UseVisualStyleBackColor = true;
            this.btn_EliminarCat.Click += new System.EventHandler(this.btn_EliminarCat_Click);
            // 
            // btn_ActualizarCat
            // 
            this.btn_ActualizarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_ActualizarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarCat.Image = global::MiniProyectoABC.Properties.Resources.comprobar;
            this.btn_ActualizarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ActualizarCat.Location = new System.Drawing.Point(227, 94);
            this.btn_ActualizarCat.Name = "btn_ActualizarCat";
            this.btn_ActualizarCat.Size = new System.Drawing.Size(101, 39);
            this.btn_ActualizarCat.TabIndex = 16;
            this.btn_ActualizarCat.Text = "Actualizar";
            this.btn_ActualizarCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ActualizarCat.UseVisualStyleBackColor = true;
            this.btn_ActualizarCat.Click += new System.EventHandler(this.btn_ActualizarCat_Click);
            // 
            // btn_GuardarCat
            // 
            this.btn_GuardarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_GuardarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarCat.Image = global::MiniProyectoABC.Properties.Resources.guardar;
            this.btn_GuardarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarCat.Location = new System.Drawing.Point(125, 94);
            this.btn_GuardarCat.Name = "btn_GuardarCat";
            this.btn_GuardarCat.Size = new System.Drawing.Size(96, 39);
            this.btn_GuardarCat.TabIndex = 15;
            this.btn_GuardarCat.Text = "Guardar";
            this.btn_GuardarCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarCat.UseVisualStyleBackColor = true;
            this.btn_GuardarCat.Click += new System.EventHandler(this.btn_GuardarCat_Click);
            // 
            // btn_NuevoCat
            // 
            this.btn_NuevoCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_NuevoCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoCat.Image = global::MiniProyectoABC.Properties.Resources.lapiz;
            this.btn_NuevoCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoCat.Location = new System.Drawing.Point(23, 94);
            this.btn_NuevoCat.Name = "btn_NuevoCat";
            this.btn_NuevoCat.Size = new System.Drawing.Size(96, 39);
            this.btn_NuevoCat.TabIndex = 14;
            this.btn_NuevoCat.Text = "Nuevo";
            this.btn_NuevoCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NuevoCat.UseVisualStyleBackColor = true;
            this.btn_NuevoCat.Click += new System.EventHandler(this.btn_NuevoCat_Click);
            // 
            // dgv_MostrarCat
            // 
            this.dgv_MostrarCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MostrarCat.Location = new System.Drawing.Point(23, 139);
            this.dgv_MostrarCat.Name = "dgv_MostrarCat";
            this.dgv_MostrarCat.Size = new System.Drawing.Size(412, 119);
            this.dgv_MostrarCat.TabIndex = 13;
            this.dgv_MostrarCat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarRegistroCat);
            // 
            // txt_Cat
            // 
            this.txt_Cat.Location = new System.Drawing.Point(23, 68);
            this.txt_Cat.Name = "txt_Cat";
            this.txt_Cat.Size = new System.Drawing.Size(208, 20);
            this.txt_Cat.TabIndex = 12;
            // 
            // txt_IdCat
            // 
            this.txt_IdCat.Enabled = false;
            this.txt_IdCat.Location = new System.Drawing.Point(23, 29);
            this.txt_IdCat.Name = "txt_IdCat";
            this.txt_IdCat.Size = new System.Drawing.Size(70, 20);
            this.txt_IdCat.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clave";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_EliminarM);
            this.tabPage3.Controls.Add(this.btn_ActualizarM);
            this.tabPage3.Controls.Add(this.btn_GuardarM);
            this.tabPage3.Controls.Add(this.btn_NuevoM);
            this.tabPage3.Controls.Add(this.dgv_Marca);
            this.tabPage3.Controls.Add(this.txt_Marca);
            this.tabPage3.Controls.Add(this.txt_IdMarca);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(465, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Marca";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarM
            // 
            this.btn_EliminarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_EliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarM.Image = global::MiniProyectoABC.Properties.Resources.basura;
            this.btn_EliminarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarM.Location = new System.Drawing.Point(329, 96);
            this.btn_EliminarM.Name = "btn_EliminarM";
            this.btn_EliminarM.Size = new System.Drawing.Size(101, 39);
            this.btn_EliminarM.TabIndex = 17;
            this.btn_EliminarM.Text = "Eliminar";
            this.btn_EliminarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarM.UseVisualStyleBackColor = true;
            this.btn_EliminarM.Click += new System.EventHandler(this.btn_EliminarM_Click);
            // 
            // btn_ActualizarM
            // 
            this.btn_ActualizarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_ActualizarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarM.Image = global::MiniProyectoABC.Properties.Resources.comprobar;
            this.btn_ActualizarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ActualizarM.Location = new System.Drawing.Point(222, 96);
            this.btn_ActualizarM.Name = "btn_ActualizarM";
            this.btn_ActualizarM.Size = new System.Drawing.Size(101, 39);
            this.btn_ActualizarM.TabIndex = 16;
            this.btn_ActualizarM.Text = "Actualizar";
            this.btn_ActualizarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ActualizarM.UseVisualStyleBackColor = true;
            this.btn_ActualizarM.Click += new System.EventHandler(this.btn_ActualizarM_Click);
            // 
            // btn_GuardarM
            // 
            this.btn_GuardarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_GuardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarM.Image = global::MiniProyectoABC.Properties.Resources.guardar;
            this.btn_GuardarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarM.Location = new System.Drawing.Point(120, 96);
            this.btn_GuardarM.Name = "btn_GuardarM";
            this.btn_GuardarM.Size = new System.Drawing.Size(96, 39);
            this.btn_GuardarM.TabIndex = 15;
            this.btn_GuardarM.Text = "Guardar";
            this.btn_GuardarM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarM.UseVisualStyleBackColor = true;
            this.btn_GuardarM.Click += new System.EventHandler(this.btn_GuardarM_Click);
            // 
            // btn_NuevoM
            // 
            this.btn_NuevoM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_NuevoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoM.Image = global::MiniProyectoABC.Properties.Resources.lapiz;
            this.btn_NuevoM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoM.Location = new System.Drawing.Point(18, 96);
            this.btn_NuevoM.Name = "btn_NuevoM";
            this.btn_NuevoM.Size = new System.Drawing.Size(96, 39);
            this.btn_NuevoM.TabIndex = 14;
            this.btn_NuevoM.Text = "Nuevo";
            this.btn_NuevoM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NuevoM.UseVisualStyleBackColor = true;
            this.btn_NuevoM.Click += new System.EventHandler(this.btn_NuevoM_Click);
            // 
            // dgv_Marca
            // 
            this.dgv_Marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marca.Location = new System.Drawing.Point(18, 141);
            this.dgv_Marca.Name = "dgv_Marca";
            this.dgv_Marca.Size = new System.Drawing.Size(412, 119);
            this.dgv_Marca.TabIndex = 13;
            this.dgv_Marca.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarRegistroMarca);
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(18, 70);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(208, 20);
            this.txt_Marca.TabIndex = 12;
            // 
            // txt_IdMarca
            // 
            this.txt_IdMarca.Enabled = false;
            this.txt_IdMarca.Location = new System.Drawing.Point(18, 31);
            this.txt_IdMarca.Name = "txt_IdMarca";
            this.txt_IdMarca.Size = new System.Drawing.Size(70, 20);
            this.txt_IdMarca.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marca del Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clave";
            // 
            // frm_configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(481, 336);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_configuracion_FormClosed);
            this.Load += new System.EventHandler(this.Configuración_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MostrarCat)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView dgv_Mostrar;
        private System.Windows.Forms.TextBox txt_Division;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_EliminarCat;
        private System.Windows.Forms.Button btn_ActualizarCat;
        private System.Windows.Forms.Button btn_GuardarCat;
        private System.Windows.Forms.Button btn_NuevoCat;
        private System.Windows.Forms.DataGridView dgv_MostrarCat;
        private System.Windows.Forms.TextBox txt_Cat;
        private System.Windows.Forms.TextBox txt_IdCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_EliminarM;
        private System.Windows.Forms.Button btn_ActualizarM;
        private System.Windows.Forms.Button btn_GuardarM;
        private System.Windows.Forms.Button btn_NuevoM;
        private System.Windows.Forms.DataGridView dgv_Marca;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_IdMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}