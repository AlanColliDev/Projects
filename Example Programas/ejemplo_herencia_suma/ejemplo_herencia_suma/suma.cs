using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_herencia_suma
{
    class suma:Clsnumeroscs
    {
        public int sumares { get; set; } //este es un método que posteriormente se usará

        public suma(int n1,int n2)
        {
            num1 = n1;
            num2 = n2;

        }

        public int calcula_suma()
        {
            sumares = num1 + num2;
            return sumares;
        }
    }
}
