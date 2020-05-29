using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exa_Herencia
{
    public partial class Form1 : Form
    {
        Cls_Cliente clien = new Cls_Cliente();
        Cls_Vendedor vendor = new Cls_Vendedor();
        public Form1()
        {
            cbo_Tipo.Items.Add("Cliente");
            cbo_Tipo.Items.Add("Vendedor");

            InitializeComponent();
            cbo_Tipo.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selecc = cbo_Tipo.SelectedIndex
        }
    }
}
