using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_libros_herencia
{
    class Cls_libroimpreso:Cls_libros
    {
        //propiedad exclusiva de la clase libroimpreso
        //atributo publico convertido en propiedad
        public int numpaginas { get; set; }

        //utilizo el constructor para inicializar
        public Cls_libroimpreso(string tit,decimal preciolib,int nump)
        {
            titulo = tit;
            precio=preciolib;
            numpaginas = nump;
        }

        //método que devuelve los atributos del objeto en un string
        public string devuelve_datos()
        {
            string datos = "Titulo: " + titulo + "\nPrecio:" + precio+"\nNúmero de páginas: "+numpaginas;
            return datos;
        }

        public void modifica_datos(string tit, decimal preciolib, int nump)//es modifica datos porque está resiviendo los atributos que digitó el usuario en el main
        {
            titulo = tit;
            precio = preciolib;
            numpaginas = nump;
        }
    }
}
