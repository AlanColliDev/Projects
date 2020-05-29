using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundosMinutos
{
    class Cls_CalculoSegundos
    {
        public int time_seg { get; set; }
        public int minutos { get; set; }
        double seg_res { get; set; }
        public double min { get; set; }

        public double calc_segundos()
        {

            minutos = time_seg / 60;
            min = minutos + 1;
            if (minutos != 0)
            {
                
                seg_res = 60 - time_seg % 60;
            }
          
            return seg_res;
        }

    
    }
}
