using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo_ConectarBDD.GUI;

namespace Ejemplo_ConectarBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            ProdGUI produ = new ProdGUI();
            produ.Show();
            //si quiero que la ventana principl de cierre cuando abra la nueva escribo esta sentencia
            //this.Hide();

        }
    }
}
