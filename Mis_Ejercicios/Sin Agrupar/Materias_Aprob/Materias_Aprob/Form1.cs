using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materias_Aprob
{
    public partial class Form1 : Form
    {
        Cls_Notas objcal = new Cls_Notas();
        int tot_notas = 0;//variable donde almacenare la cantidad de notas
        int contnot_captu = 1;//inicializo el contador que usare despues para el ciclo windows
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            btn_Iniciar.Enabled = false;
            tot_notas = Convert.ToInt32(txt_CantNotas.Text);// esta variable se declaro arriba porque despues se estara enviando caundo llamemos al metodo
            while (contnot_captu <= tot_notas)//mi contador aqui empieza a valer uno y el total de notas segunlo  que el usuario inserte
            {

                //la referencia a visual basic se repetirá n cantidad de veces segun el contadory el total de calificaciones
                double calif = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la calificación","Captura Calificación"));
                //en la variable calif guardo las calificaciones, con la ayuda de la referencia de visual basic 

                if (calif < 0 || calif > 10)
                {
                    MessageBox.Show("La calificación no puede ser menor que 0 ni mayor que 10", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //si las calificaciones cumplen con los lineamientos, se realiza este metodo
                    objcal.analizar_nota(calif);
                    contnot_captu++;
                }
            }
            btn_VerResul.Enabled = true;
        }

        private void btn_VerResul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nEl total de notas reprobadas es: " + objcal.total_reprobadas + "\nEl total de notas aprobadas es: " + objcal.total_aprobadas + "\nEl promedio de aprobadas es: " + Math.Pow(objcal.prom_aprob(), 2) + "\nEl promedio de reprobadas es: " + Math.Pow(objcal.prom_reprob(), 2) + "\nEl promedio general es: " + Math.Pow(objcal.devuelve_promgral(), 2));
        }
    }
}
