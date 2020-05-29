using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer3Convertir_a_pulgadas
{
    class Cls_OperacionesConv
    {
        public double centimetros { get; set; }
        public double pulgadas { get; set; }

        public double Conv_Pulgadas()//método que llevará a cabo la conversión a pulgadas
        {
            pulgadas = centimetros * 2.54;
            return pulgadas;
        }


    }
}
