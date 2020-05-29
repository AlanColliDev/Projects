using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDigitos
{
    public partial class Form1 : Form
    {
        Cls_Operaciones oper = new Cls_Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            oper.num = Convert.ToInt16(txt_Num.Text);

         

            MessageBox.Show("El resultado es: " + oper.sumando());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
