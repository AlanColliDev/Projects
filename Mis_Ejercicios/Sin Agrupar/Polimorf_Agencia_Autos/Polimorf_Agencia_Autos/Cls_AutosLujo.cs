using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_Agencia_Autos
{
    class Cls_AutosLujo : Cls_carac_Auto
    {
        public Cls_AutosLujo(int num, string marca, int year, decimal costo, int cap_mx)
        {
            num_motor = num;
            marca_h = marca;
            fecha = year;
            precio = costo;
            cant_pasaj = cap_mx;
        }
        public override string mostrar_datos()
        {
            return "Número del motor: "+num_motor + "\nMarca: "+marca_h + "\nFecha: " + fecha + "\nPrecio: " + precio + "\nCantidad máxima de pasajeros: " + cant_pasaj;
        }
    }
}
