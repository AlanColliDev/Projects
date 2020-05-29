using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excer4Password
{
    class Cls_LoginPass
    {
        public string password { get; set; }

        public bool Verif_Pass()
        {
            bool flag = false;
            switch(password)
            {
                case "Csharp":
                    flag = true;
                    break;
            }
            return flag;
        }
    }
}
