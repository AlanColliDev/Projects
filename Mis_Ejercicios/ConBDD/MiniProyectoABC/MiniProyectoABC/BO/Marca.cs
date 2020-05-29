using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyectoABC.BO
{
    class Marca
    {
        private int id_marca;
        private string nombre_marca;

        public int Id_marca { get => id_marca; set => id_marca = value; }
        public string Nombre_marca { get => nombre_marca; set => nombre_marca = value; }
    }
}
