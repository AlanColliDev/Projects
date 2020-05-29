using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Mtra_DateTimePick
{
    public partial class frm_ejemplo : Form
    {
        Cls_persona objper = new Cls_persona();
        public frm_ejemplo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string datos;
            string texto_recursador = "";
            if (objper.recur == true)
            {
                texto_recursador = "\nEl alumno es recursador";
            }
            datos = "\nNombre: " + objper.nombre + "\nApellido Paterno: " + objper.ap_pat + "\nApellido Materno: " + objper.ap_mat + "\nFecha Nacimiento: " + objper.fecha_nac + texto_recursador;
            //configurando el mensaje
            //mensaje, titulo, botones, icono
            MessageBox.Show(datos, "Datos Guardados",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //estas son varias configuraciones del tipo MessageBox(está en libreta)

            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            objper.nombre = txt_Nombre.Text;
            objper.ap_mat = txt_ApPat.Text;
            objper.ap_pat = txt_ApMat.Text;
            //ahora igualaremos la opcion del DateTime pero convirtiendolo a su tipo de dato
            //ya que el programa primero me lo lee como tipo string
            objper.fecha_nac = Convert.ToDateTime(dtp_Fecha.Text);//aqui se realiza lo antes mencionado
            //llamo a mi propiedad recursador y la iniciializo como falso
            objper.recur = false;
            //pregunto si está seleccionado el checkbox, si está, cambio el bvalor del atributo recursador a verdadero
            if (chk_Recursador.Checked == true)
            {
                objper.recur = true;
            }
            else
            {
                objper.recur = false;
            }


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_ApPat.Clear();
            txt_ApMat.Clear();

           chk_Recursador.Checked = false;
        }

        private void dtp_Fecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
