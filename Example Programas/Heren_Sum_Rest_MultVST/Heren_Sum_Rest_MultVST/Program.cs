using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heren_Sum_Rest_MultVST
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Introduzca el valor uno: ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el valor dos: ");
            int val2 = Convert.ToInt32(Console.ReadLine());

            Cls_Suma sum = new Cls_Suma();
            Cls_division div = new Cls_division();
            Cls_resta restt = new Cls_resta();
            Cls_Multiplicacion mulp = new Cls_Multiplicacion();

            int sumat = sum.sumando();
            int restaa = restt.restando();
            int multip = mulp.multiplic();
            int divis = div.Devidiendo();

            Console.WriteLine("El resultado de la suma es: " + sumat) ;
            Console.WriteLine("El resultado de la resta es: " + restaa);
            Console.WriteLine("El resultado de la multiplicación es: " + multip);
            Console.WriteLine("El resultado de la división es: " + divis);

            Console.Write("Clic en enter papu . . . ");
            Console.ReadKey(true);
        }
    }
}
