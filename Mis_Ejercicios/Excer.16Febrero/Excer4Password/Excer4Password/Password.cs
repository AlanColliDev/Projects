using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer4Password
{
    public partial class Password : Form
    {
        Cls_LoginPass login = new Cls_LoginPass();
        int cont = 1;
        public Password()
        {
            InitializeComponent();
            btn_Salir.Enabled = false;
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            while (cont <= 3)
            {
                login.password = this.txt_Pass.Text;
                if (cont <= 2 && login.Verif_Pass() == false)
                {
                    MessageBox.Show("La contraseña es errónea, intente nuavemente . ");
                    txt_Pass.Clear();
                }
                else if (login.Verif_Pass() == true)
                {
                    Application.Exit();
                }
               
                if (cont == 3)
                {
                    MessageBox.Show("Has fallado 3 veces consecutivas, intenta más tarde.");
                    txt_Pass.Enabled = false;
                    btn_Verificar.Enabled = false;
                    btn_Salir.Enabled = true;

                }
               
                cont++;
                break;
            }


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
