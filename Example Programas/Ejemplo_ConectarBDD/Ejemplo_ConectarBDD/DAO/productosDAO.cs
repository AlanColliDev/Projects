using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//DLL
using System.Data;//DataTable, perite trabajar con los datatable y los data set
using Ejemplo_ConectarBDD.BO;

namespace Ejemplo_ConectarBDD.DAO
{
    class productosDAO
    {
        Conexion Conex;//creo un objeto
        public productosDAO()
        {
            Conex = new Conexion();
        }

        public DataTable Buscar()
        {
            string ComandoSQL = "SELECT * FROM productos";
            //con el objeto de la classe conexión llama al método ejecutar sentencia y envía la sentencia sql
            return Conex.EjecutarSentencia(ComandoSQL);//recordemos que ejecutar sentencia nos devuelve un datatable
        }
        public int Agregar(ProductosB prodB)//le mando mi objeto para que pueda utilizar y acceder a las propieddesde la clase ProductosB
        {
            //se sustituyen los números por los valores de las variables
            //todo sealmcaena en la variable ComandoSQL la cual contendrá la sentencia INSERT INTO y se realizará todo lo que se ve
            string ComandoSQL = string.Format("INSERT INTO productos (Clave,Nombre,Descripcion,Precio) VALUES ('{0}','{1}','{2}','{3}');",prodB.Clave, prodB.Nombre,prodB.Descripcion,prodB.Precio);
            return Conex.EjecutarComando(ComandoSQL);
        }

        public int Modificar(ProductosB prodB)
        {
           //Update es palabra reservada 
            string CommandSQL = string.Format("UPDATE productos, SET Clave='{1}',Nombre='{2}',Descripcion='{3}',Precio={4} WHERE id={0}",prodB.Id, prodB.Clave, prodB.Nombre, prodB.Descripcion, prodB.Precio);//las comillas significan que recibiré un string
            return Conex.EjecutarComando(CommandSQL);
        }
       // public int Borar
    }
    
}
