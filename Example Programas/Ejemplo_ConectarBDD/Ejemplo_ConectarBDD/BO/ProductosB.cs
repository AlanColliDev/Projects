using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_ConectarBDD.BO
{
    class ProductosB
    {
        private int id;
        private string clave;
        private string descripcion;
        private string nombre;
        private double precio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
