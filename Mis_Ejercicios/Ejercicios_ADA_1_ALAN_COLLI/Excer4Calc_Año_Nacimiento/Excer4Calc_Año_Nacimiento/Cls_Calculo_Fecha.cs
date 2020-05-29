using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer4Calc_Año_Nacimiento
{
    class Cls_Calculo_Fecha
    {
        public int edad { get; set; }
        public int año_nac { get;set; }
        public int año_act { get; set; }

        public int Calcular_Edad()
        {
            año_nac = año_act - edad;
            return año_nac;
        }
    }
}
