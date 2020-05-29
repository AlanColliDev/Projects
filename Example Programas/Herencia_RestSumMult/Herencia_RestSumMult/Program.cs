using System;

namespace Herencia_RestSumMult
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Introduzca el tipo de valores con los que se realizarán las operaciones: \n1.- Enteros/Int \n2.-Con decimal/Decimal:");
			Console.Write("Su respuesta: ");
			string res=(Console.ReadLine());
			
			
			
			Console.Write("Introduzca el valor uno: ");
			int val1=Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduzca el valor dos: ");
			int val2=Convert.ToInt32(Console.ReadLine());
			
			Cls_Numeros oper = new Cls_Numeros(val1,val2);
			

			
			Console.Write("Clic en enter papu . . . ");
			Console.ReadKey(true);
		}
	}
}