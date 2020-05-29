using System;

namespace ExampleSett
{
	class Program
	{
		public static void Main(string[] args)
		{
			char salir = 'n';
                
            Cls_persona ob = new Cls_persona("");

            do
            {
                Console.Write
                    ("******Menú*******");
                Console.WriteLine("\n1.-Agregar Datos \n2.- Actualizar nombre \n3.-Mostrar nombre \n4.- Actualizar apellido \n5.-Mostrar Apellido \n6.-Actualizar apellido materno \n7.-Mostrar apellido materno \n8.-actualizar edad \n9.-mostrar edad \n10.- actualizar estatura \n11.-mostrar estatura \n12.- actualizar peso \n13.-mostrar peso \n14.- cambiar nombre, apellido paterno, apellido materno \n15.-cambiar estatura, peso \n16.- Salir");
                
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                	case 1:
                		Console.WriteLine("Ingrese el nombre: ");
                		ob.nombre=Console.ReadLine();
                		Console.WriteLine("Ingresa el apellido paterno: ");
                		ob.apellidopaterno=Console.ReadLine();
                		Console.WriteLine("Ingresa el apellido materno: ");
                		ob.apellidomaterno=Console.ReadLine();
                		Console.WriteLine("Ingresa la edad: ");
                		ob.edad=Convert.ToInt32(Console.ReadLine());
                		Console.WriteLine("Ingresa la estatura: ");
                		ob.estatura=Convert.ToDecimal(Console.ReadLine());
                		Console.WriteLine("Ingresa la peso: ");
                		ob.peso=Convert.ToDecimal(Console.ReadLine());
                			Console.Clear();//sirve para limpiar la pantalla y no tener que estar pulsando enter repetiamente
                		break;
                	case 2:
                		Console.WriteLine("Ingrese el nuevo nombre: ");
                		ob.nombre=Console.ReadLine();
                		Console.Clear();
                		break;
                	case 3:
                		Console.WriteLine("El nombre es: "+ob.nombre);
                		Console.WriteLine("Presione cualquier tecla para continuar: ");
                		Console.ReadKey();
                		Console.Clear();
                		break;
                	case 4:
                		Console.WriteLine("Ingrese el nuevo apellido paterno: ");
                		ob.apellidopaterno=Console.ReadLine();
                		Console.Clear();
                		break;
                	case 5:
                		Console.WriteLine("El apellido es :"+ob.apellidopaterno);
                		Console.ReadKey();
                		Console.Clear();	
                		break;
                	case 6:
                		Console.WriteLine("Ingrese el nuevo apellido materno: ");
                		ob.apellidomaterno=Console.ReadLine();
                		Console.Clear();
                		break;
                	case 7:
                		Console.WriteLine("El apellido es :"+ob.apellidomaterno);
                		Console.ReadKey();
                		Console.Clear();
                		break;
                	case 8: 
                		Console.WriteLine("Ingrese la nueva edad: ");
                		ob.edad=Convert.ToInt32(Console.ReadLine());
                		Console.Clear();
                		break;
                	case 9:
                		Console.WriteLine("La edad es :"+ob.edad);
                		Console.ReadKey();
                		Console.Clear();
                		break;
                	case 10: 
                		Console.WriteLine("Ingrese la nueva estatura: ");
                		ob.estatura=Convert.ToDecimal(Console.ReadLine());
                		Console.Clear();
                		break;
                	case 11:
                		Console.WriteLine("La edad es :"+ob.estatura);
                		Console.ReadKey();
                		Console.Clear();
                		break;
                	case 12: 
                		Console.WriteLine("Ingrese el nuevo peso: ");
                		ob.peso=Convert.ToDecimal(Console.ReadLine());
                		Console.Clear();
                		break;
                	case 13:
                		Console.WriteLine("El peso es :"+ob.peso);
                		Console.ReadKey();
                		Console.Clear();
                		break;
                	case 14:
                		Console.WriteLine("Ingrese el nuevo nombre: ");
                		string nom=Console.ReadLine();
                		Console.WriteLine("Ingrese el nuevo apellido paterno: ");
                		string ap_pat=Console.ReadLine();
                		Console.WriteLine("Ingrese el nuevo apellido materno: ");
                		string ap_mat=Console.ReadLine();
                		ob.cambiardatos(nom, ap_pat, ap_mat);
                		Console.Clear();
                		break;
                	case 15:
                		Console.WriteLine("Ingrese la edad: ");
                		int age=Convert.ToInt32(Console.ReadLine());
                		Console.WriteLine("Ingrese el nuevo peso: ");
                		decimal kilos =Convert.ToDecimal(Console.ReadLine());
                		Console.WriteLine("Ingrese la nueva estatura: ");
                		decimal altura=Convert.ToDecimal(Console.ReadLine());
                		ob.cambiardatos(age,kilos,altura);
                		Console.Clear();
                		break;
                	
                	default:
                        Environment.Exit(0);
                        break;
                }
            } while (salir == 'n');

            Console.ReadKey(false);

        }
		}
	}
