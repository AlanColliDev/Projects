using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_NumerosNaturales
{
    class Cls_Num_Nat
    {
        public int num_nat { get; set; }

        public int sumatoria()
        {
            int suma = 0;
            for (int cont = 1; cont <= num_nat; cont++)
            {
                suma = suma + cont;
            }
            return suma;
        }
    }
}
