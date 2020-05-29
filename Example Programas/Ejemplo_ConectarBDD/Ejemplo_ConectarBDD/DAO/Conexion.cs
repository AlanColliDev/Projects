using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//DLL
using System.Data;//DataTable, perite trabajar con los datatable y los data set

namespace Ejemplo_ConectarBDD
{
    class Conexion//esta calse contendra elementos o instancias SQL la cual ejecutara estas sentencais para conectar nuestra base de datos
    {
        MySqlConnection conex; MySqlCommand comando;//el command ejecuta las sentencias, 
        public Conexion()
        {
            //e crean variables que posteriormente se usaran en la cadena conexion
            string servidor = "159.89.85.223";
            string userid = "utm";
            string pass = "utm1234#12345";
            string bd = "_utmpractica";

            //para nosotros la IP es localhost
            conex = new MySqlConnection("Server =" + servidor +"; User ID = " +userid +"; Persist Security info = true; password = " +pass+ "; Database=" + bd );
            comando = new MySqlCommand();
        }//se cambian el servidor, el usuario, el password y la bdd a la cual se conectara
        public void AbrirConexion() { this.conex.Open(); }// se relaciona con conex y abre la base de datos con los parametros que le envie
        public void CerrarConexion() { this.conex.Close(); }//aqui cierra la conexion

        public int EjecutarComando(string comandoSQL) //INSERT , UPDATE, DELETE,  estoy reciviendo un valor de tripo string que contendra las sentencias
        {
            //el try trata de ejecutar un bloque si falla el catch lo recibe y resaliza las funciones establecidas
            try
            {//representa una sentenci o procedimiento sql
                this.comando.CommandText = comandoSQL;
                //representa una cadena de conexion lo utiliza el commandtext
                this.comando.Connection = this.conex;
                //abre la conexion
                this.AbrirConexion();
                //ejecuta una instruccion de transtact-SQL en la conexión y devuelve el numero de filas afectadas
                this.comando.ExecuteNonQuery();
                //cierra la conexion 
                this.CerrarConexion();
                //si se realizó con éxito retorna 1
                return 1;
            }
            catch (MySqlException)//si no realiza retorna 0 
            {
                return 0;
            }
            finally//y al final de todo tiene que cerrar la conexion
            {
                this.CerrarConexion();
            }
        }
        public DataTable EjecutarSentencia(string comandoSQL)//la variable trae todas las acciones que tenga
        {
            //el conex es el objeto que almcaena la conexion, representa una sentencia SQL y una conexión que se utiliza para rellenar un Dataset
            MySqlDataAdapter adapter = new MySqlDataAdapter(comandoSQL, this.conex);//el adapter permite rabajar con datagrid, listbox entre otros
            DataTable tabla = new DataTable();
            
            adapter.Fill(tabla);//actualiza el dataset o el datatable 
            return tabla;//me regresa la tabla pero ya con los datos que solicite
        }
    }
}
