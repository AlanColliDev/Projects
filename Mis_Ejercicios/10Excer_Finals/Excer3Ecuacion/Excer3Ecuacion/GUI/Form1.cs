using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excer3Ecuacion.BO;

namespace Excer3Ecuacion
{
    
    public partial class frm_Excer4 : Form
    {
        Cls_Operacion oper = new Cls_Operacion();
        public frm_Excer4()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            oper.val_x = Convert.ToDouble(txt_ValX.Text);
            oper.val_y = Convert.ToDouble(txt_ValY.Text);
            oper.val_z = Convert.ToDouble(txt_ValZ.Text);

            txt_Resultado.Text = oper.Ecuacion_prro().ToString();
        }
    }
}
