using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio10.BO;

namespace Ejercicio10
{
    public partial class frm_Piano : Form
    {
        public frm_Piano()
        {
            InitializeComponent();
        }

        private void frm_Piano_Load(object sender, EventArgs e)
        {
            String[] Negras = { "C#", "D#", "_", "F#", "G#", "A#" };
            String[] Blancas = { "C", "D", "E", "F", "G", "A", "B" };
            Cls_Conversion Mipiano = new Cls_Conversion();
            Mipiano.CrearTeclasNegras(Negras, pnl_Teclado);
            Mipiano.CrearTeclasBlancas(Blancas, pnl_Teclado);
        }

        
    }
}
