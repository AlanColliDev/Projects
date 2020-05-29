using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo_GRID.BO;

namespace Ejemplo_GRID
{
    public partial class Form1 : Form
    {
        Cls_Producto prod = new Cls_Producto();
        public Form1()
        {
            InitializeComponent();
            //agrego el número de columnas que se desea
            dgv_Table.ColumnCount = 3;//establece el numero de las columnas
            dgv_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//estas tres columnas van a ocupar toda la grilla

            //Agregare titulos a las columnas
            dgv_Table.Columns[0].Name = "Código";
            dgv_Table.Columns[1].Name = "Descripción";
            dgv_Table.Columns[2].Name = "Precio";

            //no se puede editar las filas
            dgv_Table.ReadOnly = true; //quiere decir que son solo de lectura y deshabilita el modod de edición
        }

        private void brn_Agregar_Click(object sender, EventArgs e)
        {
            prod.codigo = txt_Codigo.Text;
            prod.descripcion = txt_Descripcion.Text;
            prod.precio = Convert.ToDouble(txt_Precio.Text);

            //agrega una fila con los valores
            dgv_Table.Rows.Add(prod.codigo, prod.descripcion, prod.precio);//hay que fijarse ene el orden en el cual se agrega la fila 
            //muestra las sumatorias de los precios
            txt_Total.Text = prod.totalpro().ToString();
            limpiar();
            
        }

        public void limpiar()
        {
            txt_Codigo.Clear();
            txt_Descripcion.Clear();
            txt_Precio.Clear();
        }
    }
}
