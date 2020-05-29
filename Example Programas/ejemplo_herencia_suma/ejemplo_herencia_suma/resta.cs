using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_herencia_suma
{
    class resta:Clsnumeroscs
    {
        public int restares { get; set; }

        public resta(int n1,int n2)
        {
            //aqui le estoy asignando valores a las variables heredadas de mi clase padre
            //posteriormente gracias al set and get esos valores se iran sustituyndo con los
            //valores que el usuario inttroduzca mediante el teclado
            num1 = n1;
            num2 = n2;
        }

        public int calcular_resta()
        {
            restares = num1 - num2;
            return restares;
        }
    }
}
