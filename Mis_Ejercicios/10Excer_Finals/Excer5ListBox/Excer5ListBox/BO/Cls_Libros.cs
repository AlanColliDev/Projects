using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer5ListBox.BO
{
    class Cls_Libros
    {
        public string libro1 { get; set; }
        public string libro2 { get; set; }
        public string libro3 { get; set; }
        public string libro4 { get; set; }
        public string libro5 { get; set; }
        public string libro6 { get; set; }
        public string libro7 { get; set; }
        public string libro8 { get; set; }
        public string libro9 { get; set; }
        public string libro10 { get; set; }

        public Cls_Libros()
        {
            libro1 = "SQL SERVER 2008";
            libro2 = "BASE DE DATOS AVANZADAS";
            libro3 = "ORACLE";
            libro4 = "VISUAL STUDIO 2010";
            libro5 = "OFFICE";
            libro6 = "MACROMEDIA FLASH MX";
            libro7 = "WINDOWS 2008";
            libro8 = "TIMERS";
            libro9 = "TEXTOS DE CUENTOS";
            libro10 = "HOJAS DE CALCULO";
        }
        public void Mover_Derecha(ListBox Derecha, ListBox Izquierda)
        {
            Izquierda.Items.Add(Derecha.SelectedItem);
            Derecha.Items.Remove(Derecha.SelectedItem);
        }
        public void Mover_Izquierda(ListBox Derecha, ListBox Izquierda)
        {
            Derecha.Items.Add(Izquierda.SelectedItem);
            Izquierda.Items.Remove(Izquierda.SelectedItem);
        }
    }
}
