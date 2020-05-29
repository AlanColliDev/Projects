using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_polimorfismo_prog2
{
    class Cls_operaciones
    {
        protected int num1 { get; set; }
        protected int num2 { get; set; }

        public virtual int hacer_operacion()
        {
            return 0;
        }
    }
}
