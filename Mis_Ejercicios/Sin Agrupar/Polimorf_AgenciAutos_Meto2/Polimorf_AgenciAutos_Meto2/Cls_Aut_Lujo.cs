using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_AgenciAutos_Meto2
{
    class Cls_Aut_Lujo:Cls_Vehiculos_carac
    {
        public override string mostrar_datos()
        {
            string devol = "N° Identificador del motor: " + _num_motor + "\nMarca: "+_marca + "\nAño: "+_year + "\nPrecio: "+_precio+ "\nCantidad máxima de pasajeros: "+ _cant_pasaj;
            return devol;
        }
    }
}
