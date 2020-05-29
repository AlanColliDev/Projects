using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Example_NCapas.BO;//hago referencia a la carpeta y así las clases existentes en la carpeta "BO" podrán ser utilizadas por nuestro program 

namespace Example_NCapas
{
    public partial class Form1 : Form
    {
        Cls_AudioLibro audi = new Cls_AudioLibro();
        Cls_PrintLibro print = new Cls_PrintLibro();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            print.Titulo = txt_Title.Text;
            print.Precio = Convert.ToDouble(txt_Precio.Text);
            print.num_pag = Convert.ToInt32(mtxt_NumPaginas.Text);
            print.editorial = txt_Editorial.Text;
            txt_Title.Clear();
            txt_Precio.Clear();
            txt_Editorial.Clear();
            mtxt_NumPaginas.Clear();

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Título:" + print.Titulo + ", Precio: " + print.Precio + ", Num. de Páginas: " + print.num_pag);
        }
    }
}
