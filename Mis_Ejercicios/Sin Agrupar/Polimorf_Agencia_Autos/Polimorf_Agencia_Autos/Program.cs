using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_Agencia_Autos
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "", type_auto="";


            Cls_AutosLujo objluj = null;
            Cls_Auto_Comp objcomp = null;
            Cls_Camionetas camion = null;
            Cls_Vagonetas vago = null;
            do
            {
                Console.Write("¿Qué tipo de vehículo desea administrar? \n1.-Auto de lujo/ AutLujo, \n2.-Auto compacto/AutComp, \n3.-Camioneta, \n4.-Vagoneta \nRespuesta: ");
                type_auto = (Console.ReadLine());
                //***EN ESTE APARTADO ESTOY PIDIENDO LOS ATRRIB EN COMÚN 
                Console.Write("Introduzca el número de serie del motor: ");
                int numser = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca la marca del vehículo: ");
                string brand = (Console.ReadLine());
                Console.Write("Introduzca el año del vehículo ");
                int año_main = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduzca el precio del vehículo: ");
                decimal prec_main = Convert.ToDecimal(Console.ReadLine());
                //***Ahora evaluaré la opción elegida por el usuario, es decir el tipo de vehículo
                    switch (type_auto)
                    {
                        case "Auto de lujo": case "AutLujo":
                        Console.Write("Introduzca la capacidad máxima de pasajeros");
                        int cap = Convert.ToInt32(Console.ReadLine());
                        objluj = new Cls_AutosLujo(numser,brand,año_main,prec_main, cap);
                        Console.WriteLine(objluj.mostrar_datos());
                        
                            break;
                       
                        //***CADA TIPO DE AUTO YA TIENE SUS PARÁMETROS ENVIADOS Y RECIBIDOS EN SU DEBIDO CONSTRUCTOR
                        case "Auto compacto": case "AutComp":
                        Console.Write("Introduzca la capacidad máxima de pasajeros");
                        int capac = Convert.ToInt32(Console.ReadLine());
                        objcomp = new Cls_Auto_Comp(numser, brand, año_main, prec_main, capac);
                        Console.WriteLine(objcomp.mostrar_datos());

                        break;

                        case "Camioneta":
                        Console.Write("Introduce la capacidad máxima de carga (en kg) que soporta el vehículo: ");
                        decimal carga_mx = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduzca la cantidad de ejes: ");
                        int ejes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduzca la cantidad de rodadas: ");
                        int rodadas = Convert.ToInt32(Console.ReadLine());
                        camion = new Cls_Camionetas(numser, brand, año_main, prec_main, carga_mx, ejes, rodadas);
                        Console.WriteLine(camion.mostrar_datos());
                        break;

                        case "Vagoneta":
                        Console.Write("Introduzca la capacidad máxima de pasajeros: ");
                        int capac_mx = Convert.ToInt32(Console.ReadLine());
                        vago = new Cls_Vagonetas(numser, brand, año_main, prec_main, capac_mx);
                        Console.Clear();
                        Console.WriteLine(vago.mostrar_datos());

                        break;
                }


                Console.Write("¿Desea administrar otro vehículo?");
                resp = (Console.ReadLine());
            } while (resp=="Si" || resp=="si");
            Console.Write("Press anykey to continue...");
            Console.ReadKey(true);
        }
    }
}
