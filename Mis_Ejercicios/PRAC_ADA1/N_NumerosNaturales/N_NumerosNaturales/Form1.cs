using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_NumerosNaturales
{
    public partial class frm_Calculo : Form
    {
        Cls_Num_Nat nnum = new Cls_Num_Nat();
        public frm_Calculo()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            nnum.num_nat = Convert.ToInt32(txt_NumNat.Text);

            MessageBox.Show("La suma de los primeros " + nnum.num_nat + " números naturales es: " + nnum.sumatoria());
        }
    }
}
