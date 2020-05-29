using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heren_Editorial
{
    class Cls_PrintLibro:Cls_Date_Library
    {
        public Cls_PrintLibro(string titul, double precio)
        {
            title_h = titul;
            precio_h = precio;
        }
        public string mostrar_datos(int pag_num)
        {
            string date = "Título: "+title_h + "\nPrecio: "+precio_h + "\nNúmero de paginas: "+pag_num;
            return date;
        }
    }
}
