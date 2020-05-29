using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_AprobReprob
{
    public partial class Form1 : Form
    {
       
        Cls_Acum_Promedios flash = new Cls_Acum_Promedios();
        int num_reprob = 0, cont = 0;
        int num_aprob = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            flash.num_calif = Convert.ToInt32(txt_NumCalif.Text);
            flash.calif = Convert.ToInt32(txt_Calif.Text);

            
            while(cont<=flash.num_calif)
            {
                
                    num_reprob = flash.Calc_Reprob();

                
                    num_aprob = flash.Calc_Aprob();
                
                    cont++;
            }
           
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("El total de notas aprobadas es de: " + num_aprob + "\nEl total de notas reprobadas es: " + num_reprob);
        }

        private void txt_NumCalif_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
