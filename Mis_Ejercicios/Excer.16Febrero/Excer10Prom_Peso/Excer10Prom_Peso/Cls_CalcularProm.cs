using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer10Prom_Peso
{
    class Cls_CalcularProm
    {
        public int cant_per { get; set; }
        public int edad { get; set; }
        public double peso { get; set; }
        public Cls_CalcularProm()
        {
            cant_per = 0;
            edad = 0;
            peso = 0;
        }

        int cont_niños = 0;
        int cont_jovenes = 0;
        int cont_adultos = 0;
        int cont_viejos = 0;
        double acum_niño = 0, acum_viejos = 0, acum_jovenes = 0, acum_adultos = 0;

        public void Calc_Cont_y_Acum()
        {
            if (edad > 0 && edad < 13)
            {
                cont_niños += 1;
                acum_niño += peso;
            }
            else if (edad >= 3 && edad <= 29)
            {
                cont_jovenes += 1;
                acum_jovenes += peso;
            }
            else if (edad > 29 && edad <= 59)
            {
                cont_adultos += 1;
                acum_adultos += peso;
            }
            else if (edad >= 60)
            {
                cont_viejos += 1;
                acum_viejos += peso;
            }
        }

        public double prom_niños()
        {
            double prom = 0;
                prom = acum_niño / cont_niños;
            return prom;
        }
        public double prom_jovenes()
        {
            double prom = 0;
                prom = acum_jovenes / cont_jovenes;
            return prom;
        }
        public double prom_adultos()
        {
            double prom = 0; 
                prom = acum_adultos / cont_adultos;
            return prom;
        }
        public double prom_viejos()
        {
            double prom = 0;
                prom = acum_viejos / cont_viejos;
            return prom;
        }
    }
}
