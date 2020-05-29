using System;

namespace Gest_EmpresaAgro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string men = "", tipo="",pais_natt="", nom_prod="";
            int prod_cod=0, lot_prod=0, cod_super=0;
            double temp = 0, temp2=0;

            Cls_Frescos objfr = null;
            Cls_Refrigerados refri = null;
            Cls_Congelados conge = null;

                    do
                    {
                       Console.Write("Elija el tipo de producto que gestionará: Frescos, Refrigerados, Congelados: ");
                       tipo = (Console.ReadLine());
                       Console.Write("Introduzca el nombre del producto: ");
                       nom_prod = (Console.ReadLine());
                       Console.Write("Introduzca el código del producto: ");
                       prod_cod = Convert.ToInt32(Console.ReadLine());
                       Console.Write("Introduzca el Lote del producto: ");
                       lot_prod = Convert.ToInt32(Console.ReadLine());
                       Console.Write("Introduzca el país de origen del producto: ");
                       pais_natt = (Console.ReadLine());

                        switch (tipo)
                            {
                                case "Frescos":
                            
                                   
                                    objfr = new Cls_Frescos(nom_prod, prod_cod, lot_prod, pais_natt);
                                    Console.WriteLine("***Los datos del producto son***");

                                    Console.WriteLine("Nombre: "+ objfr.devol());
                                    Console.WriteLine("Código: " + objfr.codd());
                                    Console.WriteLine("Lote: " + objfr.lotee());
                                    Console.WriteLine("País Origen: " + objfr.dev_pais());
                                    break;

                                case "Refrigerados":
                                    Console.Write("Introduzca el código de organismo de supervisión alimentaria: ");
                                    cod_super = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Temperatura de mantenimiento recomendada: ");
                                    temp2 = Convert.ToInt32(Console.ReadLine());
                                    refri= new Cls_Refrigerados(nom_prod, prod_cod, lot_prod, pais_natt,temp2);
                        //aqui mostraré los datos
                                    Console.WriteLine("***Los datos del producto son***");
                                    Console.WriteLine("Nombre: " + refri.devol());
                                    Console.WriteLine("Código: " + refri.codd());
                                    Console.WriteLine("Lote: " + refri.lotee());
                                    Console.WriteLine("País Origen: " + refri.dev_pais());
                                    Console.WriteLine("Temperatura de mantenimiento recomendada: " + refri.temperat());
                                    Console.WriteLine("Código de organismo de supervisión alimentaria: " + cod_super);
                                    break;

                                case "Congelados":
                                    Console.Write("Temperatura de mantenimiento recomendada: ");
                                    temp = Convert.ToInt32(Console.ReadLine());
                                    conge = new Cls_Congelados(nom_prod, prod_cod, lot_prod, pais_natt, temp);
                                    Console.WriteLine("***Los datos del producto son***");
                                    Console.WriteLine("Nombre: " + conge.devol());
                                    Console.WriteLine("Código: " + conge.codd());
                                    Console.WriteLine("Lote: " + conge.lotee());
                                    Console.WriteLine("País Origen: " + conge.dev_pais());
                                    Console.WriteLine("Temperatura de mantenimiento recomendada: " + conge.temperat());
                                    break;

                            }
                    Console.Write("¿Desea agregar otro producto?: ");
                    men=(Console.ReadLine());
                    } while (men == "Si" || men == "si") ;
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey(true);
        }
    }
}
