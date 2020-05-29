using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo_Hora
{
    public partial class Form1 : Form
    {
        Cls_SueldoCalc suel = new Cls_SueldoCalc();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            suel.horas = Convert.ToInt32(txt_HorasTrab.Text);
            suel.suel_hora = Convert.ToDouble(txt_PagoHora.Text);

            MessageBox.Show("El salario neto es: $" + suel.proc_sueldo());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_HorasTrab.Clear();
            txt_PagoHora.Clear();
        }
    }
}
