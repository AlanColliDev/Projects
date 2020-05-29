using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaDigitos
{
    class Cls_Operaciones
    {
        public int num { get; set; }
        
        public int sumando()
        {
            int suma_f = 0;
            int residuo = 0;

            while (num > 10)
            {
                residuo = num % 10;
                num = num / 10;
                suma_f = residuo + num;
                
            }
            
            return suma_f;

        }
    }
}
