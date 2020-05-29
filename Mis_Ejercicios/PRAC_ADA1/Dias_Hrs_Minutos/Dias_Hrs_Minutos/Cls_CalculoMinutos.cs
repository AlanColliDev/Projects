using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_Hrs_Minutos
{
    class Cls_CalculoMinutos
    {
        public int minutos { get; set; }
        public int dias { get; set; }
        public int hrs { get; set; }
        public int time_min { get; set; }
        public int var { get; set; }


        public void calc_min()
        {
            if (time_min / 1440 != 0)
                dias = time_min / 1440;
                var = time_min % 1440;
                hrs = var / 60;
                minutos = var % 60;
         
        }
       

    }
}
