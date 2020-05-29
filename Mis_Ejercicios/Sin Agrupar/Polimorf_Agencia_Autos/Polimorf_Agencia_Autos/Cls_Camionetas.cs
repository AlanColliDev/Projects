using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_Agencia_Autos
{
    class Cls_Camionetas : Cls_carac_Auto
    {
        public Cls_Camionetas(int num, string marca, int year, decimal costo, decimal car_kg, int num_ejes, int num_rod)
        {
            num_motor = num;
            marca_h = marca;
            fecha = year;
            precio = costo;
            capac_kg = car_kg;
            cant_ejes = num_ejes;
            cant_rodad = num_rod;
        }
        public override string mostrar_datos()
        {
            return "Número del motor: " + num_motor + "\nMarca: " + marca_h + "\nFecha: " + fecha + "\nPrecio: " + precio + "\nCapacidad máxima en Kg: " + capac_kg + "\nNúmero de ejes: "+cant_ejes + "\nNúmero de rodadas: " + cant_rodad ;
        }
    }
}
