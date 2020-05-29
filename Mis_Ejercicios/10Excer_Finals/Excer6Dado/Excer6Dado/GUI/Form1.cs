using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excer6Dado.BO;

namespace Excer6Dado
{
    public partial class frm_Excer6 : Form
    {
        //creo dos objetos de mis dados para que cada uno ejecute los metodos de la clase.
        Cls_Dados lanzD1 = new Cls_Dados(), lanzD2 = new Cls_Dados();
        int num_turno = 0;
        Random turn = new Random();

        public frm_Excer6()
        {
            InitializeComponent();
            dgv_MostarDatos.ColumnCount = 4;//establece el numero de columnas
            dgv_MostarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//el ancho de las columnas abarcará todo el anchodel grid
            dgv_MostarDatos.Columns[0].Name = "N° Lanzamiento";
            dgv_MostarDatos.Columns[1].Name = "Dado 1";
            dgv_MostarDatos.Columns[2].Name = "Dado 2";
            dgv_MostarDatos.Columns[3].Name = "Total";


            //solo lectura de mi datagrew
            dgv_MostarDatos.ReadOnly = true;

        }

        private void btn_LanzarD_Click(object sender, EventArgs e)
        {
            int suma_dados = 0;
            num_turno++;//cada ves que presione este boton, el numero de lanzamientos incrementara

            //lanzaremos los dados(gracias al metodo existente en la clase)
            //se crea un b¿objrto por dado para un mejor manejo de los eventos
            lanzD1.Lanzamiento(turn);
            lanzD2.Lanzamiento(turn);
           

            //mostrar los dados, un objeto por cada dado
            lanzD1.Mostrar(pic_Dado1);
            lanzD2.Mostrar(pic_Dado2);

            //realizo la suma de los valores arrojados por el random 
            suma_dados = lanzD1.num_lanz + lanzD2.num_lanz;

            //se mostrarán los datos en el datagridview
            dgv_MostarDatos.Rows.Add(num_turno, lanzD1.num_lanz, lanzD2.num_lanz, suma_dados );


        }
    }
}
