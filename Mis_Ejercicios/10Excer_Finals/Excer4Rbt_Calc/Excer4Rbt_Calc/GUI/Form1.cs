using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excer4Rbt_Calc.BO;

namespace Excer4Rbt_Calc
{
    public partial class frm_Excer4 : Form
    {
        Cls_Operaciones oper = new Cls_Operaciones();
        public frm_Excer4()
        {
            InitializeComponent();

        }

        private void rbt_Sumar_CheckedChanged(object sender, EventArgs e)
        {
            oper.num1 = Convert.ToInt32(txt_Num1.Text);
            oper.num2 = Convert.ToInt32(txt_Num2.Text);

            txt_Respu.Text = oper.Suma().ToString();
        }

        private void rbt_Restar_CheckedChanged(object sender, EventArgs e)
        {
            oper.num1 = Convert.ToInt32(txt_Num1.Text);
            oper.num2 = Convert.ToInt32(txt_Num2.Text);
            
            txt_Respu.Text = oper.Resta().ToString();
        }

        private void rbt_Dividir_CheckedChanged(object sender, EventArgs e)
        {
            oper.num1 = Convert.ToInt32(txt_Num1.Text);
            oper.num2 = Convert.ToInt32(txt_Num2.Text);
            txt_Respu.Text = oper.Division().ToString();
        }

        private void rbt_Multi_CheckedChanged(object sender, EventArgs e)
        {
            oper.num1 = Convert.ToInt32(txt_Num1.Text);
            oper.num2 = Convert.ToInt32(txt_Num2.Text);
            txt_Respu.Text = oper.Multiplicacion().ToString();
        }
    }
}
