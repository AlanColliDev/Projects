using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_AprobReprob
{
    class Cls_Acum_Promedios
    {
        public int num_calif { get; set; }
        public int calif { get; set; }
        public int acum_aprob = 0, promedio_n =0;
        public int acum_reprob = 0;
        

            public int Calc_Aprob()
            {
                 for (int cont =1; cont<=num_calif; cont++)
                    {
                        acum_reprob = acum_reprob + 1;
                        
                    }
            return acum_reprob;
        }

        public int Calc_Reprob()
        {
            acum_aprob = acum_aprob + 1;
            return acum_reprob;
            }
                
            
        
       
    }
}
