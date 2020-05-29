using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundosMinutos
{
    public partial class Form1 : Form
    {
        Cls_CalculoSegundos segu = new Cls_CalculoSegundos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            segu.time_seg = Convert.ToInt32(txt_TimeSeg.Text);
            double time = segu.calc_segundos();
            MessageBox.Show("El tiempo restante es: " + time + "\nPara " + segu.min + "minuto(s).");
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
