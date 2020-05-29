using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer4toClave
{
    public partial class Form1 : Form
    {
        Cls_Comprobacion verif = new Cls_Comprobacion();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Comprobar_Click(object sender, EventArgs e)
        {
            verif.clave = txt_Clave.Text;

            bool flag = verif.Verif_clave();

            if (verif.comprobar() <= 3)
            {
                if (flag == true)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Clave errónea, intente nuevamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ha fallado 3 veces consecutivas, intente más tarde");

            }

        }

       
    }
}
