using System;

namespace ExampleSett
{

	public class Cls_persona
	{
		public Cls_persona()
		{
		}
	public string nombre { get; set; }
        public string apellidopaterno
        { get; set; }
        public string apellidomaterno
        { get; set; }
        public int edad { get; set; }
        public decimal estatura { get; set; }

        public decimal peso { get; set; }

        public Cls_persona(string nom)
        {
            nombre = nom;
        }

        public void cambiardatos(string nom, string apepat, string apemat)
        {
            nombre = nom;
            apellidopaterno= apepat;
            apellidomaterno = apemat;
        }

        public void cambiardatos(int edadper, decimal estper, decimal pesoper)
        {
            edad = edadper;
            estatura = estper;
            peso = pesoper; //el this hace referencia al atributo, y el otro es e
        }
	}
}
