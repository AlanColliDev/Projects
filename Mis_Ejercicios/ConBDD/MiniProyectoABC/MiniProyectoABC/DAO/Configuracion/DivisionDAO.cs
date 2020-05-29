using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//DLL
using System.Data;//DataTable, perite trabajar con los datatable y los data set
using MiniProyectoABC.BO;

namespace MiniProyectoABC.DAO
{
    class DivisionDAO
    {
        Conexion Conex;//creo un objeto
        public DivisionDAO()
        {
            Conex = new Conexion();
        }

        public DataTable Buscar()
        {
            string ComandoSQL = "SELECT * FROM division";
            //con el objeto de la classe conexión llama al método ejecutar sentencia y envía la sentencia sql
            return Conex.EjecutarSentencia(ComandoSQL);//recordemos que ejecutar sentencia nos devuelve un datatable
        }
        public int Agregar(Division cat)//le mando mi objeto para que pueda utilizar y acceder a las propieddesde la clase ProductosB
        {
            //se sustituyen los números por los valores de las variables
            //todo sealmcaena en la variable ComandoSQL la cual contendrá la sentencia INSERT INTO y se realizará todo lo que se ve
            string ComandoSQL = string.Format("INSERT INTO division (nombre_div) VALUES ('{0}');",cat.Nombre);
            return Conex.EjecutarComando(ComandoSQL);
        }

        public int Modificar(Division cat)
        {
           //Update es palabra reservada 
            string CommandSQL = string.Format("UPDATE division SET nombre_div='{1}' WHERE id_div={0}",cat.Id_Producto, cat.Nombre);//las comillas significan que recibiré un string
            return Conex.EjecutarComando(CommandSQL);
       }

        public int Eliminar(Division cat)
        {
            string ComandoSQL = string.Format("DELETE FROM division where id_div={0}", cat.Id_Producto);
            return Conex.EjecutarComando(ComandoSQL);
        }
    }
    
}
