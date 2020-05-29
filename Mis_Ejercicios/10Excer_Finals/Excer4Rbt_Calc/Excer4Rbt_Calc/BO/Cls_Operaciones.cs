using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer4Rbt_Calc.BO
{
    class Cls_Operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int resul { get; set; }
        public Cls_Operaciones()
        {
            num1 = 0;
            num2 = 0;
            resul= 0;
        }

        public int Suma()
        {
            resul = num1 + num2;
            return resul;
        }
        public int Resta()
        {
            resul = num1 - num2;
            return resul;
        }
        public double Division()
        {
            resul = num1 / num2;
            return resul;
        }
        public int Multiplicacion()
        {
            resul = num1 * num2;
            return resul;
        }
    }
}
