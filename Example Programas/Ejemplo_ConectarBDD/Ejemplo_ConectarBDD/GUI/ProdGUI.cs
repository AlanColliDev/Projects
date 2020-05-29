using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo_ConectarBDD.BO;
using Ejemplo_ConectarBDD.DAO;

namespace Ejemplo_ConectarBDD.GUI
{
    public partial class ProdGUI : Form
    {
        //ProductosB oProductosBO;
        productosDAO OprodDAO;
        ProductosB prodB;
        public ProdGUI()
        {
            OprodDAO = new productosDAO();
            InitializeComponent();
            //para evitar que el usuario agruegue filas desde el control
            dgv_Mostrar.AllowUserToAddRows = false;
            //evitar que edite 
            dgv_Mostrar.ReadOnly = true;
            //evitar que ocupe toda la grilla
            dgv_Mostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //sirve para LLENAR LOS DATOS DEL GRIDVIEW
            dgv_Mostrar.DataSource = OprodDAO.Buscar();
            //que no muestre la columna ID
            dgv_Mostrar.Columns[0].Visible = false; 

        }
        private ProductosB Recuperar_Info()
        {
            //este método recuperará toda la información del formulario

            //sim está vacío eltextbo devuelve cero de lo contrario devuelve el texto del textbox
            int id = 0; int.TryParse(txt_ID.Text, out id);//esta onda evalua sila caja de textoestá vacía, en caso de que si envía el id que vale 0 y si no envialo que tenga almacenado
            //crea un bojeto de la clase productos B
            prodB = new ProductosB();
            prodB.Id = id;
            prodB.Clave = txt_Clave.Text;
            prodB.Nombre = txt_Nombre.Text;
            prodB.Descripcion = txt_Descripcion.Text;
            prodB.Precio = Convert.ToDouble(txt_Precio.Text);
            return prodB;// se retorna el objeto porque todos los datos antes capturados se retornan en el objeto "como un arreglo".
        }
        private void Limpiar_Controles()
        {
            txt_ID.Clear();
            txt_Clave.Clear();
            txt_Nombre.Clear();
            txt_Descripcion.Clear();
            txt_Precio.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //recuperamos la información de los textbox con el método recuperarinformación que devuelve un objetoBO  los enviamos a la función agregar de la capa DAO, si retorna un 1 se agregó el registro
            if (OprodDAO.Agregar(Recuperar_Info()) == 1)
            {
                MessageBox.Show("Registro agregado exitosamente.");
                Limpiar_Controles();
            }
            else
            {
                MessageBox.Show("No es posible agregar el registro.", "Mensaje del sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //actualiza el grid
            dgv_Mostrar.DataSource = OprodDAO.Buscar();
        }

        private void SeleccionarRegistro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)//evento para recuperar el item seleccionado
        {
            int filaSeleccionada = e.RowIndex;
            prodB = new ProductosB();
            //agrego los valores a un objeto de la clase BO
            prodB.Id = int.Parse(dgv_Mostrar.Rows[filaSeleccionada].Cells[0].Value.ToString());//evalua la fila seleccionada y en la fila 0 queda almacenada de string se convierte a entero
            prodB.Clave = dgv_Mostrar.Rows[filaSeleccionada].Cells["Clave"].Value.ToString();
            prodB.Nombre = dgv_Mostrar.Rows[filaSeleccionada].Cells["Nombre"].Value.ToString();
            prodB.Descripcion = dgv_Mostrar.Rows[filaSeleccionada].Cells["Descripcion"].Value.ToString();
            prodB.Precio = Convert.ToDouble(dgv_Mostrar.Rows[filaSeleccionada].Cells["Precio"].Value.ToString());

            //muestro los valores en los textbox
            txt_ID.Text = Convert.ToString(prodB.Id);
            txt_Clave.Text = prodB.Clave;
            txt_Nombre.Text = prodB.Nombre;
            txt_Descripcion.Text = prodB.Descripcion;
            txt_Precio.Text = Convert.ToString(prodB.Precio);

            //Activamos los botones para que el usuario pueda agregar
            btn_Agregar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modif.Enabled = true;
            btn_Cancelar.Enabled = true;
        }

        private void btn_Modif_Click(object sender, EventArgs e)
        {
            if (OprodDAO.Modificar(Recuperar_Info()) == 1)
            {
                MessageBox.Show("Registro Modificado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_Controles();
                btn_Agregar.Enabled = true;
                btn_Eliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error", "Mensaje del sistema",MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Limpiar_Controles();
            dgv_Mostrar.DataSource = OprodDAO.Buscar();
            btn_Agregar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Modif.Enabled = false;
            btn_Cancelar.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar_Controles();
            btn_Agregar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Modif.Enabled = false;
            btn_Cancelar.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
