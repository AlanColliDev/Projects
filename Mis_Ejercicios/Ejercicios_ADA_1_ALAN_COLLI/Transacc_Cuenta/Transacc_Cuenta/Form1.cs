using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transacc_Cuenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Retiro_Click(object sender, EventArgs e)
        {
            Cls_Transacciones objo = new Cls_Transacciones();

            objo.valor_usu = Convert.ToInt32(txt_Cantidad.Text);
            objo.saldo = Convert.ToInt32(txt_Saldo.Text);

            
            if (objo.saldo >= objo.valor_usu)
            {
                int sal_tot = objo.met_retiro();

                txt_Saldo.Text = Convert.ToString(sal_tot);
            }
            else
            {
                
                txt_Mensj.Text = objo.mensj_main();
                
            }
            
        }

        private void btn_Depo_Click(object sender, EventArgs e)
        {
            txt_Mensj.Clear();
            Cls_Transacciones obtr = new Cls_Transacciones();
            obtr.valor_usu = Convert.ToInt32(txt_Cantidad.Text);
            obtr.saldo = Convert.ToInt32(txt_Saldo.Text);

            int sal_fin = obtr.met_deposito();

            txt_Saldo.Text = Convert.ToString(sal_fin);



        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
