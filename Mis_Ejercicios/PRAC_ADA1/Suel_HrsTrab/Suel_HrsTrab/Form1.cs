using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suel_HrsTrab
{
    public partial class frm_CalcularSueldo : Form
    {
        Cls_SueldoEmpleado suel = new Cls_SueldoEmpleado();
        public frm_CalcularSueldo()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Htrab.Clear();
            txt_PrecxH.Clear();
            txt_Sueldo.Clear();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            suel.h_trab = Convert.ToInt32(txt_Htrab.Text);
            suel.prec_xh = Convert.ToInt32(txt_PrecxH.Text);

            txt_Sueldo.Text = Convert.ToString(suel.Calculo_Sueldo());
        }
    }
}
