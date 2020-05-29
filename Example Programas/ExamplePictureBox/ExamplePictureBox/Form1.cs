using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;//si no está tendría que agregar system.drawning.bitmap img = nombredel metodo(); y lego normal, todo esto en RECURSO
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamplePictureBox.BO;

namespace ExamplePictureBox
    
{
    public partial class Form1 : Form  
    {
        Cls_Imagenes img = new Cls_Imagenes();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btn_DdesdeProyecto_Click(object sender, EventArgs e)
        {
            string ruta = img.carga_imagen_proyecto();
            pic_Proyecto.Load(ruta);//gracias a el load va a buscar la ruta recivida por el método.
            //ruta relativa
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string ruta = img.Cargar_Carpeta(pic_Carpeta);//poco eficiente, ruta absoluta.
            pic_Carpeta.Load(ruta);
        }

        private void btn_Recurso_Click(object sender, EventArgs e)
        {
            
            pic_Recurso.Image = (img.Carga_Recurso());//ESTE ES EL MÁS IDÓNEO

        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            //para arbir un cuadro de dialogo
            OpenFileDialog fileDialog = new OpenFileDialog();
            //tipo de archivos que deseo caragr, los filtro
            fileDialog.Filter = "Seleccione | *.jpg;*.png";

            //si se seleccionó algo
            if (fileDialog.ShowDialog() == DialogResult.OK)//el dialog result indica si seleccioné algo, al hacer esto el if se vuelve true y carga la imagen
            {
                //carga la imagen
                pic_Seleccionar.Image = Image.FromFile(fileDialog.FileName);
            }
        }
    }
}
