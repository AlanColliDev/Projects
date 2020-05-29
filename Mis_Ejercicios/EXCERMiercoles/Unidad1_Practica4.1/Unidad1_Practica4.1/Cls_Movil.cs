using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1_Practica4._1
{
    class Cls_Movil
    {
        protected string _color;
        protected string _tamaño;
        protected string _compañia;
        protected string _informacion;
        protected double _precio;

        public string color { get => _color; set => _color = value; }
        public string tamaño { get => _tamaño; set => _tamaño = value; }
        public string compañia { get => _compañia; set => _compañia = value; }
        public string informacion { get => _informacion; set => _informacion = value; }
        public double precio { get => _precio; set => _precio = value; }

       
    }
}
