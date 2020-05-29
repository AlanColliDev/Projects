using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer7ConvaPosit
{
    class Cls_Conversion
    {
        public int num { get; set; }
        public int num_pos { get; set; }

        public Cls_Conversion()
        {
            num = 0;
            num_pos = 0;
        }
        public int Conver_Positivo()
        {
            num_pos = num - (num * 2);
            return num_pos;
        }
    }
}
