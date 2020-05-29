using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Mtra_Oper_Basic
{
    class Cls_Operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int res { get; set; }

        public int sumar()
        {
            res = num1 + num2;
            return res;
        }
        public int restar()
        {
            res = num1 - num2;
            return res;
        }
        public int multiplicacion()
        {
            res = num1 * num2;
            return res;
        }
    }
}
