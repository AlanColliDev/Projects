using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_polimorfismo_prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un primer número");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe un segundo número");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Cls_suma objsuma = new Cls_suma(n1, n2);
            Console.WriteLine("la suma es "+objsuma.hacer_operacion());

            Cls_resta objresta = new Cls_resta(n1, n2);
            Console.WriteLine("la resta es " + objresta.hacer_operacion());

            Console.ReadKey();
        }
    }
}
