using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_Sem
{
    class Cls_DiasSemana
    {
        public string inicial { get; set; }
        public string dia { get; set; }
        public string Conver_Ini()
        {
            switch (inicial)
            {
                case "l": case "L":
                    dia = "Lunes";
                    break;
                case "m":
                case "M":
                    dia = "Martes";
                    break;
                case "x":
                case "X":
                    dia = "Miercoles";
                    break;
                case "j":
                case "J":
                    dia = "Jueves";
                    break;
                case "v":
                case "V":
                    dia = "Viernes";
                    break;
            }
            return dia;
        }
    }
}
