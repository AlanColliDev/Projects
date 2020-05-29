using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer1._Edad_Empleado
{
    class Cls_AgeEmpresa
    {

        public int cant_jovenes { get; set; }
        public int cant_maduros { get; set; }
        public int cant_mayores { get; set; }
        public Cls_AgeEmpresa()
        {
            cant_mayores = 0;
            cant_jovenes = 0;
            cant_maduros = 0;
        }

        public void comprobar_edades(int age)
        {
            if (age <= 22)
            {
                cant_jovenes += 1;
            }
            else if (age > 22 && age <= 50)
            {
                cant_maduros += 1;
            }
            else if (age>50)
            {
                cant_mayores += 1;
            }
                
        }
        public void nuevos_datos()
        {
            cant_mayores = 0;
            cant_jovenes = 0;
            cant_maduros = 0;
        }
    }
}
