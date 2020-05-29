using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerFormulario
{
    class Cls_Operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        //método 1 usando atributos de la clase
        public int sumar()
        {
            int res = num1 + num2;
            return res;
        }
        public int divid()
        {
            int resu = num1 / num2;
            return resu;
        }

        public int multip()
        {
            int resu = num1 * num2;
            return resu;
        }

        //método 2 con parámetros
        public int restar(int n1, int n2)
        {
            int res = n1 - n2;
            return res;
        }
    }
}
