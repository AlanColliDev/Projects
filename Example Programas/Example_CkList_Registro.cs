using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Resgistro : Form
    {
        Cls_Persona objper = new Cls_Persona();

        public Frm_Resgistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //guardaré el nombre en la clase y puedo acceder porque es público
            objper.nombre = txt_Nombre.Text;
            //guardo la edad
            objper.edad = Convert.ToInt32(txt_Edad.Text);
            //pregunto si esta selecciona un genero masculino
            if (rbt_Genero.Checked)//aqui está evaluando la propiedad donde evaluo el género
            {
                //guardo el género masculino
                objper.genero = 'M';
            }
            else
            {
                //de lo contrario almaceno femenino
                objper.genero = 'F';
            }

            //limpio los controles
            txt_Nombre.Clear();
            txt_Edad.Clear();
            rbt_Genero.Checked = false;
            rbt_GeneroF.Checked = false;

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text = objper.nombre;
            txt_Edad.Text = Convert.ToString(objper.edad);
            if (objper.genero != ' ')
            {
                if (objper.genero == 'M')
                {
                    rbt_Genero.Checked = true;
                }
                else
                {
                    rbt_GeneroF.Checked = true;
                }
            }

        }
    }
}
