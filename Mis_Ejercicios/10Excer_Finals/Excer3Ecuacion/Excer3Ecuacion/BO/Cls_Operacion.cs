using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer3Ecuacion.BO
{
    class Cls_Operacion
    {
        public double val_x { get; set; }
        public double val_y { get; set; }
        public double val_z { get; set; }
        

        public double Ecuacion_prro()
        {
            double resul = 0;

            resul = ((Math.Sqrt(3 * Math.Pow(val_x, 4) + 2 * (val_x * Math.Pow(val_y, 2) + val_z)) + 5 * Math.Pow(val_x, 2) * val_y) / ((3 + Math.Pow(val_x, 2) * Math.Pow(val_y, 2) * Math.Pow(val_z, 2))));
            return resul;

        }
    }
}
