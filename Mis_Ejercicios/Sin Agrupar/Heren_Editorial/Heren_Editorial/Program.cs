using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heren_Editorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "", title_m = "";
            double time = 0, prec = 0;
            int num_pag = 0;

            do
            {
                Console.Write("Elija el tipo de libro que agregará AudioLibro/ADL o Libro_impreso/PrintLibro: ");
                string book_type = (Console.ReadLine());
                Console.Write("Introduzca el titulo del libro: ");
                title_m = (Console.ReadLine());
                Console.Write("Introduzca el precio del libro: ");
                prec = Convert.ToDouble(Console.ReadLine());
                switch(book_type)
                {
                    case "AudioLibro": case "ADL":
                        Console.Write("Introduzca el tiempo de reproducción: ");
                        time = Convert.ToDouble(Console.ReadLine());
                        Cls_AudioLibro audy = new Cls_AudioLibro(title_m,prec);
                        Console.Clear();
                        //***AQUI MOSTRARÉ LOS DATOS
                        Console.WriteLine();
                        Console.Write(audy.mostrar_datos(time));
                        break;

                    case "PrintLibro": case "Libro_impreso":
                        Console.Write("Introduzca el número de páginas: ");
                        num_pag = Convert.ToInt16(Console.ReadLine());
                        Cls_PrintLibro prnt = new Cls_PrintLibro(title_m, prec);
                        Console.Write(prnt.mostrar_datos(num_pag));
                        break;
                }

                Console.Write("¿Agregará un nuevo libro?: ");
                resp=(Console.ReadLine());
            } while (resp == "Si" || resp == "si");
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
