using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer6toContNum
{
    class Cls_Verificacion
    {
        public int positivos { get; set; }
        public int negativos { get; set; }
        public int neutros { get; set; }

        public Cls_Verificacion()
        {
            positivos = 0;
            negativos = 0;
            neutros = 0;
        }

        public void evaluacion_num(int num)
        {
            if (num > 0)
            {
                positivos += 1;
            }
            else 
            {
                if (num == 0)
                {
                    neutros += 1;
                }
                else if (num < 0)
                {
                    negativos += 1;
                } 
            }
            
                    
            

            
                

        }
    }
}

