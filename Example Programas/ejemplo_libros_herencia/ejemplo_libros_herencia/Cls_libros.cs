using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_libros_herencia
{
    class Cls_libros
    {
        //atributos comunes protegidos para método 1
        protected string titulo;
        protected decimal precio;

        //necesario para método 2
        //convierto los atributos protegidos en propiedades para que tengan el comportamiento de un atributo publico
        public string Titulo { get => titulo; set => titulo = value; }

        public decimal Precio { get => precio; set => precio = value; }
    }
}
