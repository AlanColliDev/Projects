namespace Ejercicio10
{
    partial class frm_Piano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Piano));
            this.pnl_Teclado = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_Teclado
            // 
            this.pnl_Teclado.Location = new System.Drawing.Point(13, 13);
            this.pnl_Teclado.Name = "pnl_Teclado";
            this.pnl_Teclado.Size = new System.Drawing.Size(380, 397);
            this.pnl_Teclado.TabIndex = 0;
            // 
            // frm_Piano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 422);
            this.Controls.Add(this.pnl_Teclado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frm_Piano";
            this.Text = "Excer_10";
            this.Load += new System.EventHandler(this.frm_Piano_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Teclado;
    }
}

