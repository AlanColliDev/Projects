using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_polimorfismo_prog2
{
    class Cls_resta:Cls_operaciones
    {
        public Cls_resta(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        public override int hacer_operacion()
        {
            int resta = num1 - num2;
            return resta;
        }
    }
}
