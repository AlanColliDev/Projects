using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer7ListBoxProd.BO
{
    class Cls_DatosProd
    {
        public string codigo_1{ get; set; }
        public string codigo_2 { get; set; }
        public string codigo_3 { get; set; }
        public string codigo_4 { get; set; }
        public string codigo_5 { get; set; }
        public string codigo_6 { get; set; }
        public string codigo_7 { get; set; }
        public string codigo_8 { get; set; }
        public string codigo_9 { get; set; }
        public string codigo_10 { get; set; }
        

        public Cls_DatosProd()
        {
            codigo_1 = "A001";
            codigo_2 = "A002";
            codigo_3 = "A003";
            codigo_4 = "A004";
            codigo_5 = "A005";
            codigo_6 = "A006";
            codigo_7 = "A007";
            codigo_8 = "A008";
            codigo_9 = "A009";
            codigo_10 = "A010";
        }

        public void Cambiar_Datos(ListBox lista, TextBox cod, TextBox name, TextBox prec, TextBox cant, PictureBox pic)
        {
            if (lista.SelectedIndex == 0)
            {
                cod.Text = "";
                name.Text = "";
                prec.Text = "";
                cant.Text = "";
                pic.Image = null;
            }

            else if (lista.SelectedIndex == 1)
            {
                cod.Text = codigo_1;
                name.Text = "HP Compaq 500B E6500";
                prec.Text = "$14,000";
                cant.Text = "3";
                pic.Image = Excer7ListBoxProd.Properties.Resources.uno;
            }
            else if (lista.SelectedIndex == 2)
            {
                cod.Text = codigo_2;
                name.Text = "Apple iMac";
                prec.Text = "$15,400";
                cant.Text = "8";
                pic.Image = Excer7ListBoxProd.Properties.Resources.dos;
            }
            else if (lista.SelectedIndex == 3)
            {
                cod.Text = codigo_3;
                name.Text = "Aurora Alienware";
                prec.Text = "$8,799";
                cant.Text = "4";
                pic.Image = Excer7ListBoxProd.Properties.Resources.tres;
            }
            else if (lista.SelectedIndex == 4)
            {
                cod.Text = codigo_4;
                name.Text = "Dell Inspiron One 2320";
                prec.Text = "$3,900";
                cant.Text = "9";
                pic.Image = Excer7ListBoxProd.Properties.Resources.cuatro;
            }
            else if (lista.SelectedIndex == 5)
            {
                cod.Text = codigo_5;
                name.Text = "Gateway Compact Desktop";
                prec.Text = "$11,800";
                cant.Text = "7";
                pic.Image = Excer7ListBoxProd.Properties.Resources.cinco;
            }
            else if (lista.SelectedIndex == 6)
            {
                cod.Text = codigo_6;
                name.Text = "Gateway ZX4300-01e";
                prec.Text = "$6,000";
                cant.Text = "6";
                pic.Image = Excer7ListBoxProd.Properties.Resources.seis;
            }
            else if (lista.SelectedIndex == 7)
            {
                cod.Text = codigo_7;
                name.Text = "Sony Vaio VPCJ114FX/B C";
                prec.Text = "$9,000";
                cant.Text = "11";
                pic.Image = Excer7ListBoxProd.Properties.Resources.siete;
            }
            else if (lista.SelectedIndex == 8)
            {
                cod.Text = codigo_8;
                name.Text = "HP Omni 220 Quad";
                prec.Text = "$18,000";
                cant.Text = "5";
                pic.Image = Excer7ListBoxProd.Properties.Resources.ocho;
            }
            else if (lista.SelectedIndex == 9)
            {
                cod.Text = codigo_9;
                name.Text = "Lenovo IdeaCentre A720";
                prec.Text = "$12,000";
                cant.Text = "18";
                pic.Image = Excer7ListBoxProd.Properties.Resources.nueve;
            }
            else if (lista.SelectedIndex == 10)
            {
                cod.Text = codigo_10;
                name.Text = "Sony VAIO Serie L";
                prec.Text = "$19,000";
                cant.Text = "6";
                pic.Image = Excer7ListBoxProd.Properties.Resources.diez;
            }

        }
       
    }
}
