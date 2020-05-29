using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProyectoABC.BO;
using MiniProyectoABC.DAO;




namespace MiniProyectoABC.GUI
{
    public partial class frm_configuracion : Form
    {
        Division cat;
        DivisionDAO CatDAO;

        Categoria cate;
        CategoriaDAO cateDAO;   //aqui estan los objetos de las clases

        Marca objmarc;
        MarcaDAO objmarcDAO;
        
        
        public frm_configuracion()
        {
            CatDAO = new DivisionDAO();
            cateDAO = new CategoriaDAO();
            objmarcDAO = new MarcaDAO();

            InitializeComponent();
              //para evitar que el usuario agruegue filas desde el control
            dgv_Mostrar.AllowUserToAddRows = false;
            //evitar que edite 
            dgv_Mostrar.ReadOnly = true;
            //evitar que ocupe toda la grilla
            dgv_Mostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //sirve para LLENAR LOS DATOS DEL GRIDVIEW
            dgv_Mostrar.DataSource = CatDAO.Buscar();
            //que no muestre la columna ID
            dgv_Mostrar.Columns[0].Visible = false;//DATAGRIDVIEW DIVISION
            
            
            //para evitar que el usuario agruegue filas desde el control
            dgv_MostrarCat.AllowUserToAddRows = false;
            //evitar que edite 
            dgv_MostrarCat.ReadOnly = true;
            //evitar que ocupe toda la grilla
            dgv_MostrarCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //sirve para LLENAR LOS DATOS DEL GRIDVIEW
            dgv_MostrarCat.DataSource = cateDAO.Buscar();
            //que no muestre la columna ID
            dgv_MostrarCat.Columns[0].Visible = false;//DATAGRIDVIEW CATEGORIA

            //DATAGRIDVIEW MARCA
            #region dgvMarca 
            //para evitar que el usuario agruegue filas desde el control
            dgv_Marca.AllowUserToAddRows = false;
            //evitar que edite 
            dgv_Marca.ReadOnly = true;
            //evitar que ocupe toda la grilla
            dgv_Marca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //sirve para LLENAR LOS DATOS DEL GRIDVIEW
            dgv_Marca.DataSource = objmarcDAO.Buscar();
            //que no muestre la columna ID
            dgv_Marca.Columns[0].Visible = false;//DATAGRIDVIEW MARCA
            #endregion


        }

        //region Load
        #region
        private void Configuración_Load(object sender, EventArgs e)
        {

        }

        private void frm_configuracion_FormClosed(object sender, FormClosedEventArgs e)
        {

            frm_menu V1 = new frm_menu();
            V1.Show();
            this.Hide();
        }
        #endregion

        //en esta region esta la codificacion de la pestaña Division
        #region TabDivision
        private Division Recuperar_Datos()
        {
            int id = 0; int.TryParse(txt_Clave.Text, out id);//esta onda evalua sila caja de textoestá vacía, en caso de que si envía el id que vale 0 y si no envialo que tenga almacenado
            cat = new Division();//se crea en este bloque porque despues del corchete que cierra este bojeto ya no exixstirá.

            cat.Id_Producto = id;
            cat.Nombre = txt_Division.Text;
            return cat;
        }

        private void Limpiar_Controles()
        {
            txt_Clave.Clear();
            txt_Division.Clear();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar_Controles();
            btn_Actualizar.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = false;

        }

        private void SeleccionarRegistro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;
            cat = new Division();
            //agrego los valores a un objeto de la clase BO
            cat.Id_Producto = int.Parse(dgv_Mostrar.Rows[filaSeleccionada].Cells[0].Value.ToString());//evalua la fila seleccionada y en la fila 0 queda almacenada de string se convierte a entero

            cat.Nombre = dgv_Mostrar.Rows[filaSeleccionada].Cells["nombre_div"].Value.ToString();
            //muestro los valores en los textbox
            txt_Clave.Text = Convert.ToString(cat.Id_Producto);
            txt_Division.Text = cat.Nombre;


            //Activamos los botones para que el usuario pueda agregar
            btn_Nuevo.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Actualizar.Enabled = true;
            btn_Guardar.Enabled = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //recuperamos la información de los textbox con el método recuperarinformación que devuelve un objetoBO  los enviamos a la función agregar de la capa DAO, si retorna un 1 se agregó el registro
            if (CatDAO.Agregar(Recuperar_Datos()) == 1)
            {
                MessageBox.Show("Registro agregado exitosamente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_Controles();
            }
            else
            {
                MessageBox.Show("No es posible agregar el registro.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //actualiza el grid
            dgv_Mostrar.DataSource = CatDAO.Buscar();
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (CatDAO.Modificar(Recuperar_Datos()) == 1)
            {
                MessageBox.Show("Registro Modificado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_Controles();
                btn_Nuevo.Enabled = true;
                btn_Eliminar.Enabled = false;
                btn_Guardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Limpiar_Controles();
            dgv_Mostrar.DataSource = CatDAO.Buscar();
            btn_Nuevo.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Actualizar.Enabled = false;
            btn_Guardar.Enabled = true;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (CatDAO.Eliminar(Recuperar_Datos()) == 1)
            {
                MessageBox.Show("Registro borrado exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_Controles();
                btn_Nuevo.Enabled = true;
                btn_Eliminar.Enabled = false;
                btn_Guardar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Limpiar_Controles();
            dgv_Mostrar.DataSource = CatDAO.Buscar();
            btn_Nuevo.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Actualizar.Enabled = false;
            btn_Guardar.Enabled = true;
        }
        #endregion


        //en esta region esta toda la codificacion de la pestaña Categoria
        #region TabCategoria
        private Categoria Recuperar_DatosCat()
        {
            int id = 0; int.TryParse(txt_IdCat.Text, out id);//esta onda evalua sila caja de textoestá vacía, en caso de que si envía el id que vale 0 y si no envialo que tenga almacenado
            cate = new Categoria();//se crea en este bloque porque despues del corchete que cierra este bojeto ya no exixstirá.

            cate.Id_cat = id;
            cate.Nombre_cat = txt_Cat.Text;
            return cate;
        }
        private void Limpiar_ControlesCat()
        {
            txt_IdCat.Clear();
            txt_Cat.Clear();
        }

        private void btn_NuevoCat_Click(object sender, EventArgs e)
        {
            Limpiar_ControlesCat();
            btn_ActualizarCat.Enabled = false;
            btn_GuardarCat.Enabled = true;
            btn_EliminarCat.Enabled = false;
        }

        private void SeleccionarRegistroCat(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaseleccion = e.RowIndex;

            cate = new Categoria();
            //agrego los valores a un objeto de la clase BO
            cate.Id_cat = int.Parse(dgv_MostrarCat.Rows[filaseleccion].Cells[0].Value.ToString());//evalua la fila seleccionada y en la fila 0 queda almacenada de string se convierte a entero

            cate.Nombre_cat = dgv_MostrarCat.Rows[filaseleccion].Cells["nombre_cat"].Value.ToString();
            //muestro los valores en los textbox
            txt_IdCat.Text = Convert.ToString(cate.Id_cat);
            txt_Cat.Text = cate.Nombre_cat;

            //Activamos los botones para que el usuario pueda agregar
            btn_NuevoCat.Enabled = true;
            btn_EliminarCat.Enabled = true;
            btn_ActualizarCat.Enabled = true;
            btn_GuardarCat.Enabled = false;
        }

        private void btn_GuardarCat_Click(object sender, EventArgs e)
        {
            //recuperamos la información de los textbox con el método recuperarinformación que devuelve un objetoBO  los enviamos a la función agregar de la capa DAO, si retorna un 1 se agregó el registro
            if (cateDAO.Agregar(Recuperar_DatosCat()) == 1)
            {
                MessageBox.Show("Registro agregado exitosamente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_ControlesCat();
            }
            else
            {
                MessageBox.Show("No es posible agregar el registro.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //actualiza el grid
            dgv_MostrarCat.DataSource = cateDAO.Buscar();
        }

        private void btn_ActualizarCat_Click(object sender, EventArgs e)
        {
            if (cateDAO.Modificar(Recuperar_DatosCat()) == 1)
            {
                MessageBox.Show("Registro Modificado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_ControlesCat();
                btn_NuevoCat.Enabled = true;
                btn_EliminarCat.Enabled = false;
                btn_GuardarCat.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Limpiar_ControlesCat();
            dgv_MostrarCat.DataSource = cateDAO.Buscar();
            btn_NuevoCat.Enabled = true;
            btn_EliminarCat.Enabled = false;
            btn_ActualizarCat.Enabled = false;
            btn_GuardarCat.Enabled = true;
        }

        private void btn_EliminarCat_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Estás seguro? El cambio será permanente", "Se requiere aprobación",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                if (cateDAO.Eliminar(Recuperar_DatosCat()) == 1)
                {
                    MessageBox.Show("Registro borrado exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Limpiar_ControlesCat();
                    btn_NuevoCat.Enabled = true;
                    btn_EliminarCat.Enabled = false;
                    btn_GuardarCat.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                Limpiar_ControlesCat();
                dgv_MostrarCat.DataSource = cateDAO.Buscar();
            }
           
            btn_NuevoCat.Enabled = true;
            btn_EliminarCat.Enabled = false;
            btn_ActualizarCat.Enabled = false;
            btn_GuardarCat.Enabled = true;
        }
        #endregion//aquí está toda la codificación de la pestaña 

        //en esta region esta toda la codificacion de la pestaña Marca
        #region TabMarca
        private Marca Recuperar_DatosMarca()
        {
            int id = 0; int.TryParse(txt_IdMarca.Text, out id);//esta onda evalua sila caja de textoestá vacía, en caso de que si envía el id que vale 0 y si no envialo que tenga almacenado
            objmarc = new Marca();//se crea en este bloque porque despues del corchete que cierra este bojeto ya no exixstirá.

            objmarc.Id_marca = id;
            objmarc.Nombre_marca = txt_Marca.Text;
            return objmarc;
        }

        private void Limpiar_ControlesMarca()
        {
            txt_IdMarca.Clear();
            txt_Marca.Clear();
        }

        private void SeleccionarRegistroMarca(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaseleccion = e.RowIndex;

            objmarc = new Marca();
            //agrego los valores a un objeto de la clase BO
            objmarc.Id_marca = int.Parse(dgv_Marca.Rows[filaseleccion].Cells[0].Value.ToString());//evalua la fila seleccionada y en la fila 0 queda almacenada de string se convierte a entero

            objmarc.Nombre_marca = dgv_Marca.Rows[filaseleccion].Cells["nombre_marca"].Value.ToString();
            //muestro los valores en los textbox
            txt_IdMarca.Text = Convert.ToString(objmarc.Id_marca);
            txt_Marca.Text = objmarc.Nombre_marca;

            //Activamos los botones para que el usuario pueda agregar
            btn_NuevoM.Enabled = true;
            btn_EliminarM.Enabled = true;
            btn_ActualizarM.Enabled = true;
            btn_GuardarM.Enabled = false;
        }

        private void btn_NuevoM_Click(object sender, EventArgs e)
        {
            Limpiar_ControlesMarca();
            btn_ActualizarM.Enabled = false;
            btn_EliminarM.Enabled = false;
            btn_GuardarM.Enabled = true;
        }

        private void btn_GuardarM_Click(object sender, EventArgs e)
        {
            if (objmarcDAO.Agregar(Recuperar_DatosMarca()) == 1)
            {
                MessageBox.Show("Registro agregado exitosamente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_ControlesMarca();
            }
            else
            {
                MessageBox.Show("No es posible agregar el registro.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //actualiza el grid
            dgv_Marca.DataSource = objmarcDAO.Buscar();
        }

        private void btn_ActualizarM_Click(object sender, EventArgs e)
        {
            if (objmarcDAO.Modificar(Recuperar_DatosMarca()) == 1)
            {
                MessageBox.Show("Registro Modificado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_ControlesMarca();
                btn_NuevoM.Enabled = true;
                btn_EliminarM.Enabled = false;
                btn_GuardarM.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Limpiar_ControlesMarca();
            dgv_Marca.DataSource = objmarcDAO.Buscar();
            btn_NuevoM.Enabled = true;
            btn_EliminarM.Enabled = false;
            btn_ActualizarM.Enabled = false;
            btn_GuardarM.Enabled = true;
        }

        private void btn_EliminarM_Click(object sender, EventArgs e)
        {
            if (objmarcDAO.Eliminar(Recuperar_DatosMarca()) == 1)
            {
                MessageBox.Show("Registro borrado exitosamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Limpiar_ControlesMarca();
                btn_NuevoM.Enabled = true;
                btn_EliminarM.Enabled = false;
                btn_GuardarM.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            Limpiar_ControlesMarca();
            dgv_Marca.DataSource = objmarcDAO.Buscar();
            btn_NuevoM.Enabled = true;
            btn_EliminarM.Enabled = false;
            btn_ActualizarM.Enabled = false;
            btn_GuardarM.Enabled = true;
        }


        #endregion

       
    }
}
