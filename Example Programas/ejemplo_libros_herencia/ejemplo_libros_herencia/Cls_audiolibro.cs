using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_libros_herencia
{
    class Cls_audiolibro : Cls_libros
    {
        //propiedad exclusiva de la clase audiolibro
        //atributo publico convertido en propiedad
        public decimal duracion { get; set; }

        //constructor
        public Cls_audiolibro(){
        }
    }
}
