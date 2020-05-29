using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_herencia_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro número");
            int n2 = Convert.ToInt32(Console.ReadLine());

            suma objsuma = new suma(n1, n2);
            resta objresta = new resta(n1,n2);

            Console.Write("La suma es :" + objsuma.calcula_suma());
            Console.Write("La resta es :" + objresta.calcular_resta());
            Console.ReadKey();
        }
    }
}
