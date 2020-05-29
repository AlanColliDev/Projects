using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Practica4._1
{
    public partial class frm_OBByHerencia : Form
    {
        Cls_Tableta table = new Cls_Tableta();
        Cls_Celular cel = new Cls_Celular();
        public frm_OBByHerencia()
        {
            InitializeComponent();
        }

        private void rbt_InfoTablet_CheckedChanged(object sender, EventArgs e)
        {
         
            if (rbt_InfoTablet.Checked == true)
            {
                table.color = (txt_Color.Text);
                table.tamaño = (txt_Tamaño.Text);
                table.compañia = (txt_Compañia.Text);
                table.precio = Convert.ToDouble(txt_Precio.Text);
                table.marca = (txt_Marca.Text);
                table.sistema = (txt_SO.Text);
                table.version = Convert.ToDouble(txt_Version.Text);
                table.cantidad = Convert.ToInt32(txt_Cantidad.Text);

                txt_Costo.Text = Convert.ToString(table.costo_table());
                txt_Info.Text = table.mostrar_info();
            }
            else
            {
     
            }
        }

        private void rbt_InfoCelu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_InfoCelu.Checked == true)
            {
                cel.color = (txt_Color.Text);
                cel.tamaño = (txt_Tamaño.Text);
                cel.compañia = (txt_Compañia.Text);
                cel.precio = Convert.ToDouble(txt_Precio.Text);
                cel.marca = (txt_MarcaC.Text);
                cel.sistema = (txt_SOC.Text);
                cel.cantidad = Convert.ToInt32(txt_CantidadC.Text);
                cel.modelo = (txt_Modelo.Text);
               

                txt_Costo.Text = Convert.ToString(cel.costo_cel());
                txt_Info.Text = cel.mostrar_info();
                
            }
            else
            {
                
            }
        }
    }
}
