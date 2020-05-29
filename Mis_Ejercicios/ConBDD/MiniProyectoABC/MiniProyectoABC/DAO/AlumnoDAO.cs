using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProyectoABC.BO;
using System.Data;

namespace MiniProyectoABC.DAO
{
    class AlumnoDAO
    {
        Conexion Miconexion;
        public AlumnoDAO()
        {
            Miconexion = new Conexion();
        }

        public DataTable RecuperarDivision()//
        {
            String ComandoSQL = string.Format("SELECT * FROM division");
            //llena el datatble con la infromacionobtenida de la bdd
            DataTable datos = Miconexion.EjecutarSentencia(ComandoSQL);
            //se le creara una nueva fila al datatble para que el indicedel mismo no muestre enseguida los datos obtenidos de la bdd
            DataRow newdr = datos.NewRow();//le estoy diciendo que creará un nuevo registro de indice para que no muestre los de la bdd enseguida
            newdr["nombre_div"] = "Seleccionar";
            newdr["id_div"]= 0;
            //establezco el orden en el cual se insertará la fila
            datos.Rows.InsertAt(newdr,0);
            return datos;
       }

        public DataTable Buscar()
        {
            String ComandoSQL = string.Format("SELECT * FROM alumno");
            return Miconexion.EjecutarSentencia(ComandoSQL);
        }


    }
}
