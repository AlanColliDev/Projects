using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyectoABC.BO
{
    class AlumnoBO
    {
        private int matricula;
        private string nombre;
        private string apellido;
        private int id_div;
        private DateTime fechanac;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id_div { get => id_div; set => id_div = value; }
        public DateTime Fechanac { get => fechanac; set => fechanac = value; }
    }
}
