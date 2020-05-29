using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_libros_herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            char salir = 'n';
            //método 1 sin volver los atributos protegidos como propiedad
            //solo lo declaro no se llama al contructor porque aún no se solicita al usuario los datos por lo tanto lo pongo null y necesito los datos para enviarlos al constructor
            Cls_libroimpreso objlib_imp = null;

            //método2 atributos protegidos convertidos a propiedad
            Cls_audiolibro objaudio = new Cls_audiolibro();
           
            do
            {
                Console.WriteLine("*******Menú***********");
                Console.WriteLine("1.-Agregar Libro Impreso\n2.-Mostrar Libro Impreso\n3.-Modificar Libro Impreso \n4.-Agregar AudioLibro\n5.-Mostrar Audio Libro\n6.-Modificar Audio Libro");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        //método 1 con valores en el constructor
                        //Guardar                        
                        Console.WriteLine("Ingrese el título del libro");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Ingrese precio del libro");
                        decimal precio = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese el número de páginas");
                        int numpaginas = Convert.ToInt32(Console.ReadLine());
                        //inicializa con el contructor
                        objlib_imp = new Cls_libroimpreso(titulo,precio,numpaginas);
                        Console.Clear();


                        break;
                    case 2:
                        //método 1 mostrar datos con un método
                        if (objlib_imp != null)
                        {
                            Console.WriteLine(objlib_imp.devuelve_datos());

                        }
                        else
                        {
                            Console.WriteLine("Aún no ha realizado captura de datos.....");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar.....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //método 1 modificar con un método
                        if (objlib_imp != null)
                        {
                            Console.WriteLine("Ingrese el título del libro");
                            titulo = Console.ReadLine();
                            Console.WriteLine("Ingrese precio del libro");
                            precio = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Ingrese el número de páginas");
                            numpaginas = Convert.ToInt32(Console.ReadLine());
                            //modifico por medio de un método
                            objlib_imp.modifica_datos(titulo, precio, numpaginas);
                           
                        }
                        else
                        {
                            Console.WriteLine("Aún no ha realizado captura de datos.....");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar.....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        //método 2 sin inicializar con el constructor GUARDAR
                        Console.WriteLine("Ingrese el título del libro");
                        objaudio.Titulo = Console.ReadLine();
                        Console.WriteLine("Ingrese precio del libro");
                        objaudio.Precio = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese la duración del audio del libro");
                        objaudio.duracion = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 5:
                        //método 2 sin inicializar con el constructor MOSTRAR
                        Console.WriteLine("El título del libro es "+objaudio.Titulo);
                        Console.WriteLine("precio del audio libro es " + objaudio.Precio);
                        Console.WriteLine("La duración del audiolibro es " + objaudio.duracion);
                        Console.WriteLine("Presione cualquier tecla para continuar.....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                         Console.WriteLine("Ingrese el título del libro");
                        objaudio.Titulo = Console.ReadLine();
                        Console.WriteLine("Ingrese precio del libro");
                        objaudio.Precio = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese la duración del audio del libro");
                        objaudio.duracion = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (salir == 'n');
        }
    }
}
