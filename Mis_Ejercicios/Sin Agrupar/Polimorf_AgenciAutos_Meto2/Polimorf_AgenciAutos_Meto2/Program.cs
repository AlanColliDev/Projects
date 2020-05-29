using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_AgenciAutos_Meto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            //***instancio los objetos con su clase y constructor correspondiente
            Cls_Aut_Compact comp = new Cls_Aut_Compact();
            Cls_Aut_Lujo lujo = new Cls_Aut_Lujo();
            Cls_Camionetas camn = new Cls_Camionetas();
            Cls_Vagoneta vagta = new Cls_Vagoneta();
            do
            {
                Console.Write("****Menú****");
                Console.Write("\n1.-Agregar Auto compacto\n2.-Mostrar Auto compacto\n3.-Modificar Auto compacto \n4.-Agregar Auto de lujo\n5.-Mostrar Auto de lujo\n6.-Modificar Auto de lujo\n7.-Agregar Camioneta\n8.-Mostrar Camioneta\n9.-Modificar Camioneta\n10.-Agregar Vagoneta\n11.-Mostrar Vagoneta\n12.-Modificar Vagoneta\nSu respuesta: ");
                int dec = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                

                switch (dec)
                {
                    case 1:
                        Console.WriteLine("****Agruegue datos de Autos Compactos****\nIntroduzca el número identificador del motor: ");
                        comp.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        comp.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        comp.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        comp.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce la cantidad de pasajeros soportados: ");
                        comp.cant_pasaj = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("****Se muestran datos de Autos Compactos****");
                        Console.WriteLine("El número identificador del motor es: " + comp.num_motor);
                        Console.WriteLine("La marca es: " + comp.marca);
                        Console.WriteLine("El año del vehículo es: " + comp.year);
                        Console.WriteLine("El precio es de: " + comp.precio);
                        Console.WriteLine("La cantidad de pasajeros soportados es de: " + comp.cant_pasaj);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("****Agruegue datos de Autos Compactos****\nIntroduzca el número identificador del motor: ");
                        comp.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        comp.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        comp.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        comp.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce la cantidad de pasajeros soportados: ");
                        comp.cant_pasaj = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                        //AUTOS DE LUJO
                    case 4:
                        Console.Write("****Agruegue datos de Autos de lujo****\nIntroduzca el número identificador del motor: ");
                        lujo.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        lujo.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        lujo.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        lujo.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce la cantidad de pasajeros soportados: ");
                        lujo.cant_pasaj = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("****Se muestran datos de Autos de Lujo****"+"\n"+lujo.mostrar_datos());
                        break;
                    case 6:
                        Console.Write("****Agruegue datos de Autos de lujo****\nIntroduzca el número identificador del motor: ");
                        lujo.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        lujo.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        lujo.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        lujo.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce la cantidad de pasajeros soportados: ");
                        lujo.cant_pasaj = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                        //CAMIONETAS
                    case 7:
                        Console.Write("****Agruegue datos de Camionetas****\nIntroduzca el número identificador del motor: ");
                        camn.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        camn.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        camn.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        camn.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce el número de ejes: ");
                        camn.ejes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el número de rodadas: ");
                        camn.rodadas = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el peso máximo soportado de la Camioneta: ");
                        camn.kg_max = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("****Se muestran datos de Camionetas****" + "\n" + camn.mostrar_datos());
                        break;
                    case 9:
                        Console.Write("****Agruegue datos de Camionetas****\nIntroduzca el número identificador del motor: ");
                        camn.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        camn.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        camn.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        camn.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce el número de ejes: ");
                        camn.ejes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el número de rodadas: ");
                        camn.rodadas = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el peso máximo soportado de la Camioneta: ");
                        camn.kg_max = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        break;
                        //VAGOENTAS
                    case 10:
                        Console.Write("****Agruegue datos de Vagoneta****\nIntroduzca el número identificador del motor: ");
                        vagta.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        vagta.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        vagta.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        vagta.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce la cantidad de pasajeros soportados: ");
                        vagta.cant_pasaj = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 11:
                        Console.WriteLine("****Se muestran datos de Vagonetas****" + "\n" + vagta.mostrar_datos());
                        break;
                    case 12:
                        Console.Write("****Agruegue datos de Vagoneta****\nIntroduzca el número identificador del motor: ");
                        vagta.num_motor = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce la marca del vehículo: ");
                        vagta.marca = Console.ReadLine();
                        Console.Write("Introduce el año del vehículo: ");
                        vagta.year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduce el precio del vehículo: ");
                        vagta.precio = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Introduce la cantidad de pasajeros soportados: ");
                        vagta.cant_pasaj = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        break;
                        default:
                        Environment.Exit(0);
                        break;
                }

                Console.Write("¿Desea regresar al menú anterior?: ");
                resp = Console.ReadLine();
                Console.Clear();
            } while (resp=="Si" || resp =="si");


            Console.Write("Press anykey to continue..");
            Console.ReadKey(true);
        }
    }
}
