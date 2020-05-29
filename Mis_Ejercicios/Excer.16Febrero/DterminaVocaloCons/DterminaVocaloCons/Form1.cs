using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DterminaVocaloCons
{
    public partial class frm_Ver : Form
    {
        Cls_Leras letter = new Cls_Leras();
        public frm_Ver()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            string let = letter.Letra;

            let = txt_Letra.Text;

            if (let == "a" || let == "A" || let == "e" || let == "E" || let == "i" || let == "I" || let == "o" || let == "O" || let == "u" || let == "U")
            {
                txt_Aviso.Text = "La letra es vocal";
            }
            else
            {
                if (let != "a" && let != "e" && let != "i" && let != "o" && let != "u")
                {
                    txt_Aviso.Text = "La letra es consonante";
                }
                
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Aviso.Clear();
            txt_Letra.Clear();
        }
    }
}
