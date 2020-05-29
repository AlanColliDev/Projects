using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer5Nuevo_Salario
{
    class Cls_CalcNomina
    {
        public double sal_ini { get; set; }
        public double aumento;
        public double sal_fin { get; set; }

        public double Calc_Nomina()
        {
            aumento = sal_ini * .25;
            sal_fin = sal_ini + aumento;
            return sal_fin;
        }
    }
}
