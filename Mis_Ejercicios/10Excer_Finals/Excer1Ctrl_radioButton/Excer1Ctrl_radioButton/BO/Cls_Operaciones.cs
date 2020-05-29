using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer1Ctrl_radioButton
{
    class Cls_Operaciones
    {
        public double sueldo_neto { get; set; }
        public double suel_mensual { get; set; }
        public double bonificacion { get; set; }
        double bonif_uno = 0, bonif_dos = 0, bonif_tres=0;
  
        public double Bonif_uno()
        {
            bonif_uno = suel_mensual * .10;
            sueldo_neto = suel_mensual + bonificacion + bonif_uno;
            return sueldo_neto;

        }
        public double Bonif_dos()
        {
            bonif_dos = suel_mensual * .20;
            sueldo_neto = suel_mensual + bonificacion + bonif_dos;
            return sueldo_neto;

        }
        public double Bonif_tres()
        {
            bonif_tres = suel_mensual * .50;
            sueldo_neto = suel_mensual + bonificacion + bonif_tres;
            return sueldo_neto;

        }
    }
}
