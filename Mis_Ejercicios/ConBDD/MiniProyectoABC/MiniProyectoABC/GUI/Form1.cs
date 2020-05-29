using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProyectoABC.GUI;

namespace MiniProyectoABC
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_configuracion B1 = new frm_configuracion();
            B1.Show();
            this.Hide();


        }

        private void btn_Alumno_Click(object sender, EventArgs e)
        {
            frm_Alumno alum = new frm_Alumno();
            alum.Show();
            this.Hide();
        }
    }
}
