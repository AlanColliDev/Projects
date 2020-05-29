using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer4Password
{
    public partial class frm_Excercise4 : Form
    {
       
        
        public frm_Excercise4()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Password pass = new Password();
                pass.ShowDialog();
               
        }
            

        
    }
}
