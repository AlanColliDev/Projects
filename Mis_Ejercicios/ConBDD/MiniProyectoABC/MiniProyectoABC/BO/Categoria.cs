using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyectoABC.BO
{
    class Categoria
    {
        private int id_cat;
        private string nombre_cat;

        public int Id_cat { get => id_cat; set => id_cat = value; }
        public string Nombre_cat { get => nombre_cat; set => nombre_cat = value; }
    }
}
