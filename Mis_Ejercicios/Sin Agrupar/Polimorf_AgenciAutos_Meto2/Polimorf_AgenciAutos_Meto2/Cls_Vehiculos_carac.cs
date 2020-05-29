using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_AgenciAutos_Meto2
{
    class Cls_Vehiculos_carac
    {
        protected int _num_motor;
        protected string _marca;
        protected int _year;
        protected decimal _precio;
        protected int _cant_pasaj;

        public int num_motor { get => _num_motor; set => _num_motor = value; }
        public string marca { get => _marca; set => _marca = value; }
        public int year { get => _year; set => _year = value; }
        public decimal precio { get => _precio; set => _precio = value; }
        //***Atributos heredados por autos y vagonetas
        public int cant_pasaj { get => _cant_pasaj; set => _cant_pasaj = value; }

        public virtual string mostrar_datos()
        {
            return "";
        }
    }
}
