using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MiniProyectoABC.BO;

namespace MiniProyectoABC.DAO
{
    class MarcaDAO
    {
        Conexion Conex;//creo un objeto
        public MarcaDAO()
        {
            Conex = new Conexion();
        }

        public DataTable Buscar()
        {
            string ComandoSQL = "SELECT * FROM marca";
            //con el objeto de la classe conexión llama al método ejecutar sentencia y envía la sentencia sql
            return Conex.EjecutarSentencia(ComandoSQL);//recordemos que ejecutar sentencia nos devuelve un datatable
        }
        public int Agregar(Marca objmarca)//le mando mi objeto para que pueda utilizar y acceder a las propieddesde la clase ProductosB
        {
            //se sustituyen los números por los valores de las variables
            //todo sealmcaena en la variable ComandoSQL la cual contendrá la sentencia INSERT INTO y se realizará todo lo que se ve
            string ComandoSQL = string.Format("INSERT INTO marca (nombre_marca) VALUES ('{0}');", objmarca.Nombre_marca);
            return Conex.EjecutarComando(ComandoSQL);
        }

        public int Modificar(Marca objmarca)
        {
            //Update es palabra reservada 
            string CommandSQL = string.Format("UPDATE marca SET nombre_marca='{1}' WHERE id_marca={0}", objmarca.Id_marca, objmarca.Nombre_marca);//las comillas significan que recibiré un string
            return Conex.EjecutarComando(CommandSQL);
        }
        
        public int Eliminar(Marca objmarca)
        {
            string ComandoSQL = string.Format("DELETE FROM marca where id_marca={0}", objmarca.Id_marca);
            return Conex.EjecutarComando(ComandoSQL);
        }
    }
}
