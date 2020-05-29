using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer5Nuevo_Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            Cls_CalcNomina nom = new Cls_CalcNomina();

            //guardo los datos de los textbox en mis atributos/variables
            nom.sal_ini = Convert.ToDouble(txt_Sueldo_B.Text);
            

            txt_Nomina.Text = Convert.ToString(nom.Calc_Nomina());
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Sueldo_B.Clear();
            txt_Nomina.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
