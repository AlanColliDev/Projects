using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_GRID.BO
{
    class Cls_Producto
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set;}
        public double total { get; set; }


        public double totalpro()
        {
            total += precio;
            return total;
        }
    }
}
