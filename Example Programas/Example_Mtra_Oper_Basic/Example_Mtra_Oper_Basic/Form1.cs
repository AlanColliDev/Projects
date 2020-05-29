using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Mtra_Oper_Basic
{
    public partial class Form1 : Form
    {
        Cls_Operaciones calc = new Cls_Operaciones();
        public Form1()
        {
            InitializeComponent();
            //seva a una clase de la que hereda y "pinta la imagen del formulario"
            //inicializa valores al formulario,me va a servir para lle ar el combobox
            cbo_Oper.Items.Add("Seleccionar");//le estoy diciendo que en la propiedad "cbo_ Oper" me va a agregar un item
            cbo_Oper.Items.Add("Suma");
            cbo_Oper.Items.Add("Resta");
            cbo_Oper.Items.Add("Multiplicacion");
            //Inicializamos el indice en "0" esto se feriefe al orden de la lista desplegable
            cbo_Oper.SelectedIndex = 0; //esto realiza que suma valga 1, resta 2, y multiplicacion 3 etc..
            //el selected index quiere decir cuál saldrá por default en este caso escogimos el "0"el cuál se refiere a la opción seeleccionar.
        }

        private void cambiacbo(object sender, EventArgs e)
        {
            //recupera el indice de la lisata que está selecionado
            int seleccion = cbo_Oper.SelectedIndex;//esta variable me va a almacenar el indice que tienen suma, resta, multiplicacion...
            //de acuerdo a selección llena textbox descripción
            switch (seleccion)
            {//gracias a esto la caja de texto txt_Descripcion.Text irá mostrando el texto que aparece entre comillas, acorde a el case que se utilice
                case 0:
                    txt_Descripcion.Text = "No se haseleccionado ninguna operación";
                    break;
                case 1:
                    txt_Descripcion.Text = "Realiza la suma de dos números";
                    break;
                case 2:
                    txt_Descripcion.Text = "Realiza la resta de dos números";
                        break;
                case 3:
                    txt_Descripcion.Text = "Realiza la multiplicación de dos números";
                    break;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int resul = 0;
            calc.num1 = Convert.ToInt32(txt_Num1.Text);
            calc.num2 = Convert.ToInt32(txt_Num2.Text);

            int seleccion = cbo_Oper.SelectedIndex;//aqui estoy volviendo a llamar a las opciones de la lista desplegable  
            //inicializaré un switch para que por cada opcion de la lista desplegale ocurrirá un evento distinto
            switch (seleccion)
            {
                case 0:
                    MessageBox.Show("No ha seleccinado ninguna operación");
                    break;
                case 1:
                    resul = calc.sumar();
                    MessageBox.Show("El resultado de la suma es: "+resul);
                    break;
                case 2:
                    resul = calc.restar();
                    MessageBox.Show("El resultado de la resta es: "+resul);
                    break;
                case 3:
                    resul = calc.multiplicacion();
                    MessageBox.Show("El resultado de la multiplicación es: " + resul);
                    break;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Num1.Clear();
            txt_Num2.Clear();
            cbo_Oper.SelectedIndex = 0;
            txt_Descripcion.Clear();
        }
    }
}
