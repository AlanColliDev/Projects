using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dias_Hrs_Minutos
{
    public partial class Form1 : Form
    {
        Cls_CalculoMinutos minu = new Cls_CalculoMinutos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            minu.time_min = Convert.ToInt32(txt_TimeMinutos.Text);

            
            MessageBox.Show("Dias: " + minu.dias + "\nHoras: " + minu.hrs + "\nMinutos: " + minu.minutos);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
