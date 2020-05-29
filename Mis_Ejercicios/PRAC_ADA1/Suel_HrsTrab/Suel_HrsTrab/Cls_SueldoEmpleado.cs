using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suel_HrsTrab
{
    class Cls_SueldoEmpleado
    {
        public int h_trab { get; set; }
        public int prec_xh { get; set; }
        public int suel_f { get; set; }

        public int Calculo_Sueldo()
        {
            suel_f = prec_xh * h_trab;
            return suel_f;
        }
    }
}
