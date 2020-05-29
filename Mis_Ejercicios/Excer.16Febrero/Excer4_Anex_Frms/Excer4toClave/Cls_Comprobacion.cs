using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer4toClave
{
    class Cls_Comprobacion
    {
        public string clave { get; set; }
        public bool flag = false;
        int cont = 1;
       

        public bool Verif_clave()
        {
            
            switch(clave)
            {
                case "csharp":
                    flag = true;
                    break;

            }
            return flag;
        }
        public int comprobar()
        {
           
                cont += 1;
            
            return cont;
        }
     
    }
}
