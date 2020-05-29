using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer2.Area_TrianguloRect
{
    class Cls_Operaciones
    {
        public int base_t { get; set; }
        public int altura_t { get; set; }

        public double Calc_Area()
        {
            double area = (base_t * altura_t) / 2;
            return area;
        }
        public double Calc_Perimetro()
        {
            double perimetro = base_t + altura_t + Math.Sqrt(base_t + altura_t);
            return perimetro;
        }
    }
}
