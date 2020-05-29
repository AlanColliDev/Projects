using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heren_Editorial
{
    class Cls_AudioLibro:Cls_Date_Library
    {
        public Cls_AudioLibro(string titul, double precio)
        {
            title_h = titul;
            precio_h = precio;
        }

        public string mostrar_datos(double time_m)
        {
            string date = "Título: " + title_h + "\nPrecio: " + precio_h + "\nTiempo de duración: " + time_m;
            return date;
        }
    }
}
