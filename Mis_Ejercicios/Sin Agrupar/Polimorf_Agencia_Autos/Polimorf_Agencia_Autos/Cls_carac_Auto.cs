using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf_Agencia_Autos
{
    class Cls_carac_Auto
    {
        protected int num_motor { get; set; }
        protected string marca_h { get; set; }
        protected int fecha { get; set; }
        protected decimal precio { get; set; }
        //***PARA AUTOS Y BAGONETAS
        protected int cant_pasaj { get; set; }
        //***PARA CAMIONETAS
        protected decimal capac_kg { get; set; }
        protected int cant_ejes { get; set; }
        protected int cant_rodad { get; set; }

        //***MÉTODO POR EL CUALSEAPLICARÁ EL POLIMORFISMO
        public virtual string mostrar_datos()
        {
            return "";
        }
    }
}
