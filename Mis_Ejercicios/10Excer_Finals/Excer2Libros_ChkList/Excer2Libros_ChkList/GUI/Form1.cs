using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Excer2Libros_ChkList
{
    public partial class frm_Excer2 : Form
    {
        Cls_Libros oper = new Cls_Libros();


        int cont = 0;
        int acum = 0;

        public frm_Excer2()
        {
            InitializeComponent();
            chk_Android.Checked = false;
            chk_CSharp.Checked = false;
            chk_Java.Checked = false;
            chk_Node.Checked = false;
            chk_Oracle.Checked = false;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
            if (chk_Oracle.Checked == true)
            {
                cont += 1;
                acum = oper.Oper_Oracle();
            }

            if (chk_Android.Checked == true)
            {
                cont += 1;
                acum = oper.Oper_Android();
            }
            if (chk_CSharp.Checked == true)
            {
                cont += 1;
                acum = oper.Oper_Csharp();
            }

           if (chk_Node.Checked == true)
            {
                cont += 1;
                acum = oper.Oper_Node();
            }

           if (chk_Java.Checked == true)
            {
                cont += 1;
                acum = oper.Oper_Java();
            }
                
            txt_NumLib.Text = Convert.ToString(cont + " Libros");
            txt_Costo.Text = Convert.ToString(acum);
            
          
        }
      

    }
}
