using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer3Convertir_a_pulgadas
{
    public partial class frm_Conversión : Form
    {
        public frm_Conversión()
        {
            InitializeComponent();
        }

        private void btn_Convertir_Click(object sender, EventArgs e)
        {
            Cls_OperacionesConv conver = new Cls_OperacionesConv();

            conver.centimetros = Convert.ToDouble(txt_Cantidadcm.Text);

            double pulg_cant = conver.Conv_Pulgadas();

            txt_Pulgadas.Text = Convert.ToString(pulg_cant); 
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_Cantidadcm.Clear();
            txt_Pulgadas.Clear();
        }
    }
}
