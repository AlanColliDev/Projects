using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excer6Dado.Properties;


namespace Excer6Dado.BO
{
    class Cls_Dados
    {
   
        public int num_lanz { get; set; }

        public void Lanzamiento(Random lanz)
        {
            num_lanz = lanz.Next(6)+1;//gracias al random, me dará un valor aleatorio entre uno y 6.
        }
        public int ObtenNum()
        {
            return num_lanz;
        }

        //aqui voy a evaluar el numero del dado en el swtich y posteriormente mostrara la imagen que corresponda.
        public void Mostrar(PictureBox pic)
        {
            //la imagen del dado corresponde al numero del caso.
            switch(num_lanz)
            {
                case 1:
                    pic.Image = Excer6Dado.Properties.Resources.uno; 
                    break;
                case 2:
                    pic.Image = Excer6Dado.Properties.Resources.dos;
                    break;
                case 3:
                    pic.Image = Excer6Dado.Properties.Resources.tres;
                    break;
                case 4:
                    pic.Image = Excer6Dado.Properties.Resources.cuatro;
                    break;
                case 5:
                    pic.Image = Excer6Dado.Properties.Resources.cinco;
                    break;
                case 6:
                    pic.Image = Excer6Dado.Properties.Resources.seis;
                    break;

            }
        }
    }
}
