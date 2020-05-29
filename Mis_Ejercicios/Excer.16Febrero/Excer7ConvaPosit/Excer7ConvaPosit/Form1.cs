using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer7ConvaPosit
{
    public partial class frm_Conver : Form
    {
        Cls_Conversion conv = new Cls_Conversion();
        int num_pos = 0;
        
        public frm_Conver()
        {
            InitializeComponent();
            
                        
        }
        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            ltb_NumConv.Visible = true;

            for (int cont = 1; cont <= 15; cont++)
            {
                conv.num = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Introduzca el número negativo: ", "Capturar Números"));
                num_pos = conv.Conver_Positivo();
                if (conv.num > 0)
                {
                    MessageBox.Show("El número tiene que ser negativo.");
                    conv.num = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Introduzca el número negativo: ", "Capturar Números"));
                    num_pos = conv.Conver_Positivo();
                }
                else if (cont == 15)
                {
                    MessageBox.Show("La conversión ha finalizado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                    ltb_NumConv.Items.Add(num_pos);
                
                
                

            }

            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            ltb_NumConv.Items.Clear();
        }

        private void frm_Conver_Load(object sender, EventArgs e)
        {

        }
    }
}
