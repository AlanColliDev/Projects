using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desc_Trabajador
{
    class Cls_Sueldo_Empleado
    {
        public double suel_base { get; set; }
        public double desc = 0;
        public double suel_neto=0;

        public double calculo_sueldo()
        {
            double bono = 0;
            if (suel_base <= 1000)
            {
                desc = suel_base * .10;
                suel_neto = suel_base - desc;
            }
            else
            {
                if (suel_base > 1000 && suel_base <= 2000)
                {
                    bono = suel_base * .5;
                    suel_neto = suel_base + bono;
                }
            }
            return suel_neto;
        }
    }
}
