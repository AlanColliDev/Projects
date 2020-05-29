using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerFormulario
{
    public partial class Frm_Operaciones : Form
    {
        public Frm_Operaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            Cls_Operaciones summ = new Cls_Operaciones();

            //método 1 usando atributos de la clase 
            //pormedio del objeto accedo al atributo  le asigno lo que tenga los textbox
            summ.num1 = Convert.ToInt16(txt_Num1.Text);
            summ.num2 = Convert.ToInt16(txt_Num2.Text);

            //llamo al método suma y guardo el valor retornado
            int res = summ.sumar();

            //muestro el resultado en el textbox de resultado, hay que convertirlo a string
            txt_Resultado.Text = Convert.ToString(res);


        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            Cls_Operaciones restan = new Cls_Operaciones();
            //método 2 creo variables
            int n1 = Convert.ToInt16(txt_Num1.Text);
            int n2 = Convert.ToInt16(txt_Num2.Text);

            //envío parámetros al método por medio del objeto 
            int res = restan.restar(n1, n2);

            //muestro el resultado en el textbox de resultado, hay que convertirlo a string 
            txt_Resultado.Text = Convert.ToString(res);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            Cls_Operaciones objdiv = new Cls_Operaciones();

            objdiv.num1 = Convert.ToInt16(txt_Num1.Text);
            objdiv.num2 = Convert.ToInt16(txt_Num2.Text);

            int resul = objdiv.divid();

            txt_Resultado.Text = Convert.ToString(resul);
        }

        private void btn_Multip_Click(object sender, EventArgs e)
        {
            Cls_Operaciones objmult = new Cls_Operaciones();

            objmult.num1 = Convert.ToInt16(txt_Num1.Text);
            objmult.num2 = Convert.ToInt16(txt_Num2.Text);

            int mul = objmult.multip();

            txt_Resultado.Text = Convert.ToString(mul);
        }
    }
}
