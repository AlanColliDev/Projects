using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamplePictureBox.BO
{
    class Cls_Imagenes
    {
        public string carga_imagen_proyecto()
        {
            string ruta = @"..\..\Img\Daredevil.jpg";
            return ruta;
        }

        public string Cargar_Carpeta(PictureBox pic)
        {
            string ruta = @"C:\Users\Portatil\Pictures\DareDevil\Dare.jpg";
            return ruta;
        }
        public System.Drawing.Bitmap Carga_Recurso()
        {
            System.Drawing.Bitmap ruta = ExamplePictureBox.Properties.Resources.MCR;
            return ruta;
        }

        
    }
}
