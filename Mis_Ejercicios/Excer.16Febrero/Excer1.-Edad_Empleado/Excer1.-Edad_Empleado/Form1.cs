using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer1._Edad_Empleado
{
    public partial class Form1 : Form
    {
        Cls_AgeEmpresa objo = new Cls_AgeEmpresa();
        int cont = 1;
        int cant_empleados = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            btn_Mostrar.Enabled = false;

            cant_empleados = Convert.ToInt32(txt_CantEmple.Text);
            for (cont =1;cont <=cant_empleados;cont++)
            {
                int edad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la edad", "Captura edad"));
                if (edad < 0 || edad < 18 || edad > 65)
                {
                    MessageBox.Show("Edad no valida, introduzca una edad mayor a 18 pero menor a 65", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(edad !=0)
                {
                    objo.comprobar_edades(edad);
                }
                
            }
            btn_Enviar.Enabled = true;
            btn_Mostrar.Enabled = true;
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nEl total de empleados jovenes es: " + objo.cant_jovenes + "\nEl total de empleados maduros es: " + objo.cant_maduros + "\nEl total de empleados mayores es: " + objo.cant_mayores);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_CantEmple.Clear();
            objo.nuevos_datos();
        }
    }
}
