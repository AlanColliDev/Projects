using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer10Prom_Peso
{
    public partial class frm_Ejercicio10 : Form
    {
        Cls_CalcularProm objo = new Cls_CalcularProm();
        
        public frm_Ejercicio10()
        {
            InitializeComponent();
            btn_Mostrar.Enabled = false;
            
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            objo.cant_per = Convert.ToInt32(txt_CantidadP.Text);
            //crearé mi ciclo for donde pedire los demas datos
            for (int cont = 1; cont <= objo.cant_per; cont++)
            {
                objo.edad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Introduzca la edad: ", "Datos"));
                objo.peso = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Introduzca el peso: ", "Datos"));

                objo.Calc_Cont_y_Acum();
                if (cont == objo.cant_per)
                {
                    MessageBox.Show("Se ha terminado de calcular los promedios, regrese al menú y presione en el botón <<Mostrar>>.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Mostrar.Enabled = true;
                }
                
            }

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El promedio de peso de los niños es de: " + objo.prom_niños() + "\nEl promedio de peso de los jovenes es de: " + objo.prom_jovenes() + "\nEl promedio de peso de los adultos es de: " + objo.prom_adultos() + "\nEl promedio de peso de viejos es de: " + objo.prom_viejos());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
