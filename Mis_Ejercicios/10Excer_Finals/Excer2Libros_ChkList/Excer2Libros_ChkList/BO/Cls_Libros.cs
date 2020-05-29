using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Excer2Libros_ChkList
{
    class Cls_Libros
    {
       
        public int costo { get; set; }
      
        public int oracle { get; set; }
        public int java { get; set; }
        public int CSharp { get; set; }
        public int android { get; set; }
        public int node { get; set; }
        public int tot { get; set; }

        public Cls_Libros()
        {
            oracle = 250;
            java = 150;
            CSharp = 300;
            android = 150;
            node = 160;
            tot = 0;
        }
        
        public int Oper_Oracle()
        {
            tot += oracle;
            return tot;
            
        }
        public int Oper_Java()
        {
            tot += java;
            return tot;
        }
        public int Oper_Csharp()
        {
            tot += CSharp;
            return tot;
        }
        public int Oper_Android()
        {
            tot += android;
            return tot;
        }
        public int Oper_Node()
        {
            tot += node;
            return tot;
        }
    }
}
