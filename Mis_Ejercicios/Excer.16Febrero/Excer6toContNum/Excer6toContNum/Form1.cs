using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer6toContNum
{
    public partial class frm_Excer6 : Form
    {
        Cls_Verificacion verif = new Cls_Verificacion();
        int cont = 1;
        public frm_Excer6()
        {
            InitializeComponent();
            btn_Mostrar.Enabled = false;
            btn_Salir.Enabled = false;
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            
            int cant_num = Convert.ToInt32(txt_CantNum.Text);

            for (cont = 1; cont <= cant_num; cont++)
            {
                int num = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor", "Capturación de valores"));
                verif.evaluacion_num(num);
            }
            btn_Mostrar.Enabled = true;
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nLa cantidad de números positivos es: "+ verif.positivos + "\nLa cantidad de números negativos es: "+verif.negativos + "\nLa cantidad de números neutros es: "+ verif.neutros);
            btn_Salir.Enabled = true;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
