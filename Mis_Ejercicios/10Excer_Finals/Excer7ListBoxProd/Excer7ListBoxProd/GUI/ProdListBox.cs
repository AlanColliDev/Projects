using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excer7ListBoxProd.BO;

namespace Excer7ListBoxProd
{
    public partial class frm_Excer7 : Form
    {
        Cls_DatosProd prod = new Cls_DatosProd();
        
        public frm_Excer7()
        {
            InitializeComponent();
            pic_ImageProd.Image = null;
            ltb_Codigos.Items.Add(prod.codigo_1);
           
            ltb_Codigos.Items.Add(prod.codigo_2);
          
            ltb_Codigos.Items.Add(prod.codigo_3);
           
            ltb_Codigos.Items.Add(prod.codigo_4);
         
            ltb_Codigos.Items.Add(prod.codigo_5);
            
            ltb_Codigos.Items.Add(prod.codigo_6);
            
            ltb_Codigos.Items.Add(prod.codigo_7);
           
            ltb_Codigos.Items.Add(prod.codigo_8);
           
            ltb_Codigos.Items.Add(prod.codigo_9);
        
            ltb_Codigos.Items.Add(prod.codigo_10);
           

        }

        private void ltb_Codigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            prod.Cambiar_Datos(ltb_Codigos, txt_Codigo, txt_NomProd, txt_Precio, txt_Cantidad, pic_ImageProd);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Cantidad.Visible = false;
        }
    }
}
