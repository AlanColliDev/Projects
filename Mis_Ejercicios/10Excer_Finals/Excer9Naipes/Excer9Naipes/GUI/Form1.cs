using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Excer9Naipes
{
    public partial class frm_Excer9 : Form
    {
        Cls_Cartas usecard = new Cls_Cartas();
        Random valor = new Random();
        int num_card = 0;
        
        
        public frm_Excer9()
        {
            
            
            InitializeComponent();
           
            Random valor = new Random();
        }

        private void pic_Card1_Click(object sender, EventArgs e) 
        {
            num_card = usecard.card_1;
            usecard.Cambia_Usu(pic_CardUsu, num_card);
            usecard.Asiga_Card_PC(pic_CardPC, valor);
            usecard.Eval_Ganador(num_card, lbl_UsuTurn, lbl_PcTurn);

        }

        private void pic_Card2_Click(object sender, EventArgs e)
        {
            num_card = usecard.card_2;
            usecard.Cambia_Usu(pic_CardUsu, num_card);
            usecard.Asiga_Card_PC(pic_CardPC, valor);
            usecard.Eval_Ganador(num_card, lbl_UsuTurn, lbl_PcTurn);
        }

        private void pic_Card3_Click(object sender, EventArgs e)
        {
            num_card = usecard.card_3;
            usecard.Cambia_Usu(pic_CardUsu, num_card);
            usecard.Asiga_Card_PC(pic_CardPC, valor);
            usecard.Eval_Ganador(num_card, lbl_UsuTurn, lbl_PcTurn);
        }
        private void pic_Card5_Click(object sender, EventArgs e)
        {
            num_card = usecard.card_4;
            usecard.Cambia_Usu(pic_CardUsu, num_card);
            usecard.Asiga_Card_PC(pic_CardPC, valor);
            usecard.Eval_Ganador(num_card, lbl_UsuTurn, lbl_PcTurn);
        }

        private void pic_Card6_Click(object sender, EventArgs e)
        {
            num_card = usecard.card_5;
            usecard.Cambia_Usu(pic_CardUsu, num_card);
            usecard.Asiga_Card_PC(pic_CardPC, valor);
            usecard.Eval_Ganador(num_card, lbl_UsuTurn, lbl_PcTurn);
        }
    }
}
