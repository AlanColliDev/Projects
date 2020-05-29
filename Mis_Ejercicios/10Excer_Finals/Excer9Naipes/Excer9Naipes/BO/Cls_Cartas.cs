using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer9Naipes
{
    class Cls_Cartas
    {
        public int card_1 { get; set; }
        public int card_2 { get; set; }
        public int card_3 { get; set; }
        public int card_4 { get; set; }
        public int card_5 { get; set; }
        public int card_Usu { get; set; }
        public int card_PC { get; set; }
        public int gan_usu { get; set; }
        public int gan_pc { get; set; }
        
        public Cls_Cartas()
        {
            card_1 = 2;
            card_2 = 3;
            card_3 = 4;
            card_4 = 5;
            card_5 = 6;
            gan_usu = 1;
            gan_pc = 1;
        }
        public void Asiga_Card_PC(PictureBox usu, Random valor)
        {
            int aleat = valor.Next(2,7);

            switch (aleat)//estoy evaluando el num aleatorio
            {
                case 2:
                    card_PC = aleat;
                    usu.Image = Properties.Resources.two;
                    break;
                case 3:
                    card_PC = aleat;
                    usu.Image = Properties.Resources.three;
                    break;
                case 4:
                    card_PC = aleat;
                    usu.Image = Properties.Resources.fourth;
                    break;
                case 5:
                    card_PC = aleat;
                    usu.Image = Properties.Resources.five;
                    break;
                case 6:
                    card_PC = aleat;
                    usu.Image = Properties.Resources.six;
                    break;
               
            }
           
        }

        public void Cambia_Usu(PictureBox usu, int card)
        {
            switch (card)
            {
                case 2:
                    
                    usu.Image = Properties.Resources.two;
                    break;
                case 3:
                    usu.Image = Properties.Resources.three;
                    break;
                case 4:
                    usu.Image = Properties.Resources.fourth;
                    break;
                case 5:
                    usu.Image = Properties.Resources.five;
                    break;
                case 6:
                    usu.Image = Properties.Resources.six;
                    break;
            }
        }
        public void Eval_Ganador(int card_num, Label usu, Label pc)
        {
            if (card_num > card_PC)
            {
                MessageBox.Show("HAS GANADO", "Naipes.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                usu.Text = Convert.ToString(gan_usu++);
            }
            else if (card_num == card_PC)
            {
                MessageBox.Show("EMPATE", "Naipes.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("HA GANADO LA PC", "Naipes.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                pc.Text = Convert.ToString(gan_pc++);
            }
        }
        
    }
}
