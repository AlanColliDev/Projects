using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excer5ListBox.BO;

namespace Excer5ListBox
{
    public partial class frm_Excer4 : Form
    {
        Cls_Libros add = new Cls_Libros();
        public frm_Excer4()
        {
            InitializeComponent();
            ltb_Libros.Items.Add(add.libro1);
            ltb_Libros.Items.Add(add.libro2);
            ltb_Libros.Items.Add(add.libro3);
            ltb_Libros.Items.Add(add.libro4);
            ltb_Libros.Items.Add(add.libro5);
            ltb_Libros.Items.Add(add.libro6);
            ltb_Libros.Items.Add(add.libro7);
            ltb_Libros.Items.Add(add.libro8);
            ltb_Libros.Items.Add(add.libro10);


        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            add.Mover_Izquierda(ltb_Libros, ltb_LibrosComprar);
            
        }

        private void Mandar_Click(object sender, EventArgs e)
        {
            add.Mover_Derecha(ltb_Libros, ltb_LibrosComprar);
        }
    }
}
