using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProyectoABC.DAO;
using MiniProyectoABC.BO;

namespace MiniProyectoABC.GUI
{   
    public partial class frm_Alumno : Form
    {
        AlumnoBO objalum = new AlumnoBO();
        AlumnoDAO objdao = new AlumnoDAO();
        public frm_Alumno()
        {
            InitializeComponent();
            //lleno el combobox

            cmb_Division.DataSource = objdao.RecuperarDivision();

            //dato que v amostrar al ususario
            cmb_Division.DisplayMember = "nombre_div";//nombre del campo en bdd
            //dato que va a enviar al seleccionar un dato
            cmb_Division.ValueMember = "id_div";//nombre del campo en bdd
            //valor seleccionado por default lo que se muestre por defecto
            cmb_Division.SelectedIndex = 0;

            //mostrar registros con el metodo buscar en ALUMNODAO
            dgv_Vista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//ocupa todo el datagrid automaticamnet
            dgv_Vista.ReadOnly = true;
            dgv_Vista.AllowUserToAddRows = false;
            dgv_Vista.DataSource = objdao.Buscar();//pongo estos datos en el datagrid gracias al daatsource

        }

        private void Cerrar(object sender, FormClosedEventArgs e)
        {
            frm_menu abre = new frm_menu();
            abre.Show();
            
        }
    }
}
