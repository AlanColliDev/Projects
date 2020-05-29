using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias_Aprob
{
    class Cls_Notas
    {
        public int total_aprobadas { get; set; }
        public int total_reprobadas { get; set; }
        public double suma_aprobadas { get; set; }
        public double suma_reprobadas { get; set; }
        public Cls_Notas()
        {
            total_aprobadas = 0;
            total_reprobadas = 0;
            suma_aprobadas = 0;
            suma_reprobadas = 0;
        }

        public void analizar_nota(double calif)
        {
            if (calif < 7)
            {
                total_reprobadas++;
                suma_reprobadas = suma_reprobadas + calif;
            }
            else
            {
                total_aprobadas++;
                suma_aprobadas = suma_aprobadas + calif;
            }
            
        }
        public double devuelve_promgral()
        {
            double prom_gral = (suma_aprobadas + suma_reprobadas) / (total_aprobadas + total_reprobadas);
            return prom_gral;
        }
        public double prom_reprob()
        {
            double promrep = 0;
            if(total_reprobadas > 0)
            {
                promrep = suma_reprobadas / total_reprobadas;
            }
            return promrep;
        }
        public double prom_aprob()
        {
            double promaprob = 0;
            if (total_aprobadas > 0)
            {
                promaprob = suma_aprobadas / total_aprobadas;
            }
                
            return promaprob;
        }
    }
       
    
}
