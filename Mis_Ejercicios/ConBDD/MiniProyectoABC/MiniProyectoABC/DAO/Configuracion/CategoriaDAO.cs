using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MiniProyectoABC.BO;

namespace MiniProyectoABC.DAO
{
    class CategoriaDAO
    {
        Conexion Conex;//creo un objeto
        public CategoriaDAO()
        {
            Conex = new Conexion();
        }

        public DataTable Buscar()
        {
            string ComandoSQL = "SELECT * FROM categoria";
            //con el objeto de la classe conexión llama al método ejecutar sentencia y envía la sentencia sql
            return Conex.EjecutarSentencia(ComandoSQL);//recordemos que ejecutar sentencia nos devuelve un datatable
        }
        public int Agregar(Categoria cat)//le mando mi objeto para que pueda utilizar y acceder a las propieddesde la clase ProductosB
        {
            //se sustituyen los números por los valores de las variables
            //todo sealmcaena en la variable ComandoSQL la cual contendrá la sentencia INSERT INTO y se realizará todo lo que se ve
            string ComandoSQL = string.Format("INSERT INTO categoria (nombre_cat) VALUES ('{0}');", cat.Nombre_cat);
            return Conex.EjecutarComando(ComandoSQL);
        }

        public int Modificar(Categoria cat)
        {
            //Update es palabra reservada 
            string CommandSQL = string.Format("UPDATE categoria SET nombre_cat='{1}' WHERE id_cat={0}", cat.Id_cat, cat.Nombre_cat);//las comillas significan que recibiré un string
            return Conex.EjecutarComando(CommandSQL);
        }

        public int Eliminar(Categoria cat)
        {
            string ComandoSQL = string.Format("DELETE FROM categoria where id_cat={0}", cat.Id_cat);
            return Conex.EjecutarComando(ComandoSQL);
        }
    }
}
