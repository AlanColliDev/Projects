using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monto_Descuento
{
    class Cls_CalculoMonto
    {
        public double val_monto { get; set; }
        public double descuen { get; set; }
        public double mon_fin { get; set; }
        public double oper_mon()
        {
            if (val_monto > 100)
            {
                descuen = val_monto * .10;
                mon_fin = val_monto - descuen;

            }
            else
            {
                descuen = val_monto * .02;
                mon_fin = val_monto - descuen;
            }
            return mon_fin;
        }

    }
}
