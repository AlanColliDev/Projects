using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Hora
{
    class Cls_SueldoCalc
    {
        public double suel_hora{ get; set; }
        public int horas { get; set; }
        public double sal_fin =0;

        public double proc_sueldo()
        {
            int h_extra = 0;
            double pago_h = 0;
            if (horas > 40)
            {
                h_extra = horas - 40;
                pago_h = (suel_hora * .50 + suel_hora) * h_extra;
                sal_fin = suel_hora * 40 + pago_h;
            }
            else
            {
                sal_fin = suel_hora * horas;

            }
            return sal_fin;
        }
    }
}
