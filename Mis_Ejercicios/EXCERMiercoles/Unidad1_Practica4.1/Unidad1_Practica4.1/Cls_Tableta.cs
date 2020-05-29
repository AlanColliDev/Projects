using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1_Practica4._1
{
    class Cls_Tableta : Cls_Movil
    {
        public string marca { get; set; }
        public string sistema { get; set; }
        public int cantidad { get; set; }
        public double version { get; set; }

        public double costo_table()
        {
            double cos_fin = precio * cantidad;
            return cos_fin;
        }
        public string mostrar_info()
        {
            string info = "Color:" + color + " " + "Tamaño: " + tamaño + " " + "Compañía: " + compañia + " " + "Precio:" + precio + " " + "\nMarca: " + marca + " " + "S.Operativo: " + sistema + " " + "Cantidad: " + cantidad + " " + "Versión: " + version;
            return info;
        }
    }
}
