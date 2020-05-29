using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desc_Trabajador
{
    public partial class frm_Claculo_Sueldo : Form
    {
        Cls_Sueldo_Empleado calc = new Cls_Sueldo_Empleado();
        public frm_Claculo_Sueldo()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            calc.suel_base = Convert.ToDouble(txt_SueldoBase.Text);
            double suel_f = calc.calculo_sueldo();

            txt_Desc.Text = Convert.ToString(calc.desc);
            txt_SuelNeto.Text = Convert.ToString(suel_f);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
