using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monto_Descuento
{
    public partial class Form1 : Form
    {
        Cls_CalculoMonto mon = new Cls_CalculoMonto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            mon.val_monto = Convert.ToDouble(txt_Monto.Text);

            MessageBox.Show("El monto con descuento aplicado es de: $" + mon.oper_mon() + "\nEl descuento es de: $" + mon.descuen);
        }
    }
}
