using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer2.Area_TrianguloRect
{
    public partial class frm_Calculador : Form
    {
        public frm_Calculador()
        {
            InitializeComponent();
        }

        private void btn_Area_Click(object sender, EventArgs e)
        {
            Cls_Operaciones areaop = new Cls_Operaciones();

            areaop.altura_t = Convert.ToInt32(txt_Altura.Text);
            areaop.base_t = Convert.ToInt32(txt_Base.Text);

            double area_m = areaop.Calc_Area();

            txt_Area.Text = Convert.ToString(area_m);
        }

      
        private void btn_Perimetro_Click(object sender, EventArgs e)
        {
            Cls_Operaciones perime = new Cls_Operaciones();

            perime.altura_t = Convert.ToInt32(txt_Altura.Text);
            perime.base_t = Convert.ToInt32(txt_Base.Text);

            double perimetroe_m = perime.Calc_Perimetro();

            txt_Perimetro.Text = Convert.ToString(perimetroe_m);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
