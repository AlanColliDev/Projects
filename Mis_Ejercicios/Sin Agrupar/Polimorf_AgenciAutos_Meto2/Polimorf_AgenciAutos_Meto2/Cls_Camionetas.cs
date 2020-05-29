using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_AgenciAutos_Meto2
{
    class Cls_Camionetas:Cls_Vehiculos_carac
    {
        public int ejes { get; set; }
        public int rodadas { get; set; }
        public Decimal kg_max { get; set; }
        public override string mostrar_datos()
        {
            string devolv = "N° Identificador del motor: " + _num_motor + "\nMarca: " + _marca + "\nAño: " + _year + "\nPrecio: " + _precio + "\nNúmero de ejes: " + ejes + "\nNúmero de rodadas: " + rodadas + "\nCapacidad de carga en Kg: " + kg_max;
            return devolv;
        }
    }
}
