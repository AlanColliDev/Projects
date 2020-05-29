using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer1_Sistema_Desc
{
    class Cls_CalculoDescuento
    {
        public double monto { get; set; }
        public double descuento = 0;
        public double total_fin { get; set; }
       
        public double desc_verde()
        {
            descuento = monto * .10;
            return descuento;
        }
        public double desc_rojo()
        {
            descuento = monto * .30;
            return descuento;
        }
        public double desc_azul()
        {
            descuento = monto * .40;
            return descuento;
        }
        public double desc_amarillo()
        {
            descuento = monto * .60;
            return descuento;
        }
        public double desc_morado()
        {
            descuento = monto * .80;
            return descuento;
        }
        public double desc_blanco()
        {
            descuento = monto * 1;
            return descuento;
        }
    }
}
