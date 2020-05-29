using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer4Calc_Año_Nacimiento
{
    public partial class frm_Calcular_Edad : Form
    {
        public frm_Calcular_Edad()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Cls_Calculo_Fecha calcdate = new Cls_Calculo_Fecha();

            calcdate.año_act = Convert.ToInt32(txt_Año.Text);
            calcdate.edad = Convert.ToInt32(txt_Edad.Text);

            txt_Año_Nac.Text = Convert.ToString(calcdate.Calcular_Edad());




        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Año.Clear();
            txt_Edad.Clear();
            txt_Año_Nac.Clear();
        }
    }
}
