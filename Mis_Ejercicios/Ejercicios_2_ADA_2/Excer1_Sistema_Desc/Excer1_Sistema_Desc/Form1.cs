using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer1_Sistema_Desc
{
    public partial class frm_SistemaDescuento : Form
    {
        Cls_CalculoDescuento desc = new Cls_CalculoDescuento();
        public frm_SistemaDescuento()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double desc_f = 0;
            desc.monto = Convert.ToDouble(txt_Monto.Text);
            if (rbt_Verde.Checked == true)
            {
                desc_f = desc.desc_verde();
                desc.total_fin = desc.monto - desc_f;
            }
            else
            {
                if (rbt_Rojo.Checked == true)
                {
                    desc_f = desc.desc_rojo();
                    desc.total_fin = desc.monto - desc_f;
                }
                else
                {
                    if (rbt_Azul.Checked == true)
                    {
                        desc_f = desc.desc_azul();
                        desc.total_fin = desc.monto - desc_f;
                    }
                    else
                    {
                        if (rbt_Amarillo.Checked == true)
                        {
                            desc_f = desc.desc_amarillo();
                            desc.total_fin = desc.monto - desc_f;
                        }
                        else
                        {
                            if (rbt_Morado.Checked == true)
                            {
                                desc_f = desc.desc_morado();
                                desc.total_fin = desc.monto - desc_f;
                            }
                            else
                            {
                                desc_f = desc.desc_blanco();
                                desc.total_fin = desc.monto - desc_f;
                            }
                        }
                    }
                }
            }

            txt_Desc.Text = Convert.ToString(desc_f);
            txt_TotalPagar.Text = Convert.ToString(desc.total_fin);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Monto.Clear();
            txt_TotalPagar.Clear();
            rbt_Amarillo.Checked = false;
            rbt_Azul.Checked = false;
            rbt_Morado.Checked = false;
            rbt_Rojo.Checked = false;
            rbt_Blanco.Checked = false;
            rbt_Verde.Checked = false;
        }
    }
}
