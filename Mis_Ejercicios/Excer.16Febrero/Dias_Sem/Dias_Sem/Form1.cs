using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dias_Sem
{
    public partial class Form1 : Form
    {
        Cls_DiasSemana diasem = new Cls_DiasSemana();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Verificar_Click(object sender, EventArgs e)
        {
            diasem.inicial = txt_Inicial.Text;

            txt_DiaCorr.Text = diasem.Conver_Ini();

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_DiaCorr.Clear();
            txt_Inicial.Clear();
        }
    }
}
