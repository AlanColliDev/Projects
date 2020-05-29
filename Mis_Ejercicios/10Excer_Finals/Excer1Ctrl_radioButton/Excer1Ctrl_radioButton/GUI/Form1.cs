using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Excer1Ctrl_radioButton
{
   
    public partial class frm_excer1 : Form
    {
        Cls_Operaciones oper = new Cls_Operaciones();
        public frm_excer1()
        {
            InitializeComponent();
            rbt_cincuenta.Checked = false;
            rbt_diez.Checked = false;
            rbt_veinte.Checked = false;
               
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            oper.suel_mensual = Convert.ToDouble(txt_SueldoMensual.Text);
            oper.bonificacion = Convert.ToDouble(txt_Incentivo.Text);

            if (rbt_diez.Checked == true)
            {
                txt_SueldoNeto.Text = Convert.ToString(oper.Bonif_uno());
            }
            else if (rbt_veinte.Checked == true)
            {
                txt_SueldoNeto.Text = Convert.ToString(oper.Bonif_dos());
            }
            else if(rbt_cincuenta.Checked == true)
            {
                txt_SueldoNeto.Text = Convert.ToString(oper.Bonif_tres());
            }
        }
    }
}
