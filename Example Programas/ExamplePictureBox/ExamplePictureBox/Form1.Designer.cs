namespace ExamplePictureBox
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
            this.pic_Proyecto = new System.Windows.Forms.PictureBox();
            this.pic_Carpeta = new System.Windows.Forms.PictureBox();
            this.pic_Recurso = new System.Windows.Forms.PictureBox();
            this.pic_Seleccionar = new System.Windows.Forms.PictureBox();
            this.btn_Recurso = new System.Windows.Forms.Button();
            this.btn_DdesdeProyecto = new System.Windows.Forms.Button();
            this.btn_Carpeta = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Proyecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carpeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Recurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Seleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Proyecto
            // 
            this.pic_Proyecto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_Proyecto.Location = new System.Drawing.Point(102, 12);
            this.pic_Proyecto.Name = "pic_Proyecto";
            this.pic_Proyecto.Size = new System.Drawing.Size(163, 162);
            this.pic_Proyecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Proyecto.TabIndex = 0;
            this.pic_Proyecto.TabStop = false;
            // 
            // pic_Carpeta
            // 
            this.pic_Carpeta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pic_Carpeta.Location = new System.Drawing.Point(312, 12);
            this.pic_Carpeta.Name = "pic_Carpeta";
            this.pic_Carpeta.Size = new System.Drawing.Size(163, 162);
            this.pic_Carpeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Carpeta.TabIndex = 1;
            this.pic_Carpeta.TabStop = false;
            // 
            // pic_Recurso
            // 
            this.pic_Recurso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pic_Recurso.Location = new System.Drawing.Point(102, 209);
            this.pic_Recurso.Name = "pic_Recurso";
            this.pic_Recurso.Size = new System.Drawing.Size(163, 162);
            this.pic_Recurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Recurso.TabIndex = 2;
            this.pic_Recurso.TabStop = false;
            // 
            // pic_Seleccionar
            // 
            this.pic_Seleccionar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_Seleccionar.Location = new System.Drawing.Point(312, 209);
            this.pic_Seleccionar.Name = "pic_Seleccionar";
            this.pic_Seleccionar.Size = new System.Drawing.Size(163, 162);
            this.pic_Seleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Seleccionar.TabIndex = 3;
            this.pic_Seleccionar.TabStop = false;
            // 
            // btn_Recurso
            // 
            this.btn_Recurso.AutoSize = true;
            this.btn_Recurso.Location = new System.Drawing.Point(123, 377);
            this.btn_Recurso.Name = "btn_Recurso";
            this.btn_Recurso.Size = new System.Drawing.Size(118, 23);
            this.btn_Recurso.TabIndex = 4;
            this.btn_Recurso.Text = "Cargar desde recurso";
            this.btn_Recurso.UseVisualStyleBackColor = true;
            this.btn_Recurso.Click += new System.EventHandler(this.btn_Recurso_Click);
            // 
            // btn_DdesdeProyecto
            // 
            this.btn_DdesdeProyecto.AutoSize = true;
            this.btn_DdesdeProyecto.Location = new System.Drawing.Point(123, 180);
            this.btn_DdesdeProyecto.Name = "btn_DdesdeProyecto";
            this.btn_DdesdeProyecto.Size = new System.Drawing.Size(124, 23);
            this.btn_DdesdeProyecto.TabIndex = 5;
            this.btn_DdesdeProyecto.Text = "Cargar desde proyecto";
            this.btn_DdesdeProyecto.UseVisualStyleBackColor = true;
            this.btn_DdesdeProyecto.Click += new System.EventHandler(this.btn_DdesdeProyecto_Click);
            // 
            // btn_Carpeta
            // 
            this.btn_Carpeta.AutoSize = true;
            this.btn_Carpeta.Location = new System.Drawing.Point(335, 180);
            this.btn_Carpeta.Name = "btn_Carpeta";
            this.btn_Carpeta.Size = new System.Drawing.Size(119, 23);
            this.btn_Carpeta.TabIndex = 6;
            this.btn_Carpeta.Text = "Cargar desde carpeta";
            this.btn_Carpeta.UseVisualStyleBackColor = true;
            this.btn_Carpeta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.AutoSize = true;
            this.btn_Seleccionar.Location = new System.Drawing.Point(335, 377);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(112, 23);
            this.btn_Seleccionar.TabIndex = 7;
            this.btn_Seleccionar.Text = "Seleccionar imagen";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(589, 439);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.btn_Carpeta);
            this.Controls.Add(this.btn_DdesdeProyecto);
            this.Controls.Add(this.btn_Recurso);
            this.Controls.Add(this.pic_Seleccionar);
            this.Controls.Add(this.pic_Recurso);
            this.Controls.Add(this.pic_Carpeta);
            this.Controls.Add(this.pic_Proyecto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Proyecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carpeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Recurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Seleccionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Proyecto;
        private System.Windows.Forms.PictureBox pic_Carpeta;
        private System.Windows.Forms.PictureBox pic_Recurso;
        private System.Windows.Forms.PictureBox pic_Seleccionar;
        private System.Windows.Forms.Button btn_Recurso;
        private System.Windows.Forms.Button btn_DdesdeProyecto;
        private System.Windows.Forms.Button btn_Carpeta;
        private System.Windows.Forms.Button btn_Seleccionar;
    }
}

