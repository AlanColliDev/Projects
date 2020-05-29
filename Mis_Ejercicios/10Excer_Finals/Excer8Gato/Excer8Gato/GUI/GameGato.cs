using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excer8Gato
{
    public partial class frm_Excer8 : Form
    {
        public frm_Excer8()
        {
            InitializeComponent();
            rbt_CPU.Checked = true;
            botones = Controls.OfType<Button>().ToList(); //estoy pidiendo todos los obtones apenas se cargue el formulario
            int posicion = 0;

            for (int orden = 8; orden >= 0; orden--)//se ordenan los botones segun la posicion en el tablero
            {

                AllBotones[posicion] = botones.ElementAt(orden);

                posicion++;
            }
        }
        Button[] AllBotones = new Button[9];//se crea un objeto para hacer referencia a los botones posteriomente
        List<Button> botones; //seccrea una lista de objetos para poder manipularlos.

        //Enumeración pata saber quien juega en todo momento
        public enum Jugando
        {
            JUGADOR_1,  
            JUGADOR_2,
        }

        //Declaramos e inicializamos algunas variables
        Jugando quienJuega = Jugando.JUGADOR_1;
        char[] posiciones = new char[9];
        int[] turnos = new int[9];
        bool maquin_agame = false;

        //Metodo de la Maquina
        private void InteligenciaArtificial()
        {
            Button boton;
            bool moviento_maquina = false;

            for (int cont = 0; moviento_maquina == false; cont++)
            {
                if (posiciones[cont] != 'x' && posiciones[cont] != 'o')
                {
                    boton = AllBotones[cont];

                    boton.PerformClick();
                    moviento_maquina = true;
                }
            }
        }
        //Evento para reiniciar el tablero
        private void ReiniciarTablero()
        {

            quienJuega = Jugando.JUGADOR_1;
            botones.ForEach(x => x.BackColor = Color.White);
            botones.ForEach(x => x.Enabled = true);
            for (int i = 0; i < 9; i++)
            {
                posiciones[i] = '0';
                turnos[i] = 0;
            }
        }
        private bool Empate()//metodo para verificar si hay empate despues de que se hayan realizado todos los movimientos y no haya ganador
        {
            bool flag = false;
            int suma = 0;
            for (int cont = 0; cont < 9; cont++)
            {
                suma += turnos[cont];
            }

            if (suma == 9)
            {
                MessageBox.Show("Empate, no hay ganador.", "AVISO DEL JUEGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReiniciarTablero();
                return true;
            }

            return flag;
        }

        //Metodo para verficar si hay ganador
        #region Metodo que verifica si hay ganador
        private bool HayGanador()
        {
            bool ganador = false;

            //Horizontales con x
            if (posiciones[0] == 'x' && posiciones[1] == 'x' && posiciones[2] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[3] == 'x' && posiciones[4] == 'x' && posiciones[5] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[6] == 'x' && posiciones[7] == 'x' && posiciones[8] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }


            //Verticales con x
            if (posiciones[2] == 'x' && posiciones[5] == 'x' && posiciones[8] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[1] == 'x' && posiciones[4] == 'x' && posiciones[7] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[0] == 'x' && posiciones[3] == 'x' && posiciones[6] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }


            //Diagonales con x
            if (posiciones[2] == 'x' && posiciones[4] == 'x' && posiciones[6] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[0] == 'x' && posiciones[4] == 'x' && posiciones[8] == 'x')
            {
                MessageBox.Show("Has ganado!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }


            //Horizontales con o
            if (posiciones[0] == 'o' && posiciones[1] == 'o' && posiciones[2] == 'o')
            {
                MessageBox.Show("Ha ganado CPU!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[3] == 'o' && posiciones[4] == 'o' && posiciones[5] == 'o')
            {
                MessageBox.Show("Ha ganado CPU!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[6] == 'o' && posiciones[7] == 'o' && posiciones[8] == 'o')
            {
                MessageBox.Show("Ha ganado CPU!", "GATO.exe",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }


            //Verticales con o
            if (posiciones[2] == 'o' && posiciones[5] == 'o' && posiciones[8] == 'o')
            {
                MessageBox.Show("Ha ganado CPU!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[1] == 'o' && posiciones[4] == 'o' && posiciones[7] == 'o')
            {
                MessageBox.Show("Ha ganado CPU!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[0] == 'o' && posiciones[3] == 'o' && posiciones[6] == 'o')
            {
                MessageBox.Show("Ha ganado P2!", "Apps Easy");
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }


            //Diagonales con o
            if (posiciones[2] == 'o' && posiciones[4] == 'o' && posiciones[6] == 'o')
            {
                MessageBox.Show("Ha ganado CPU!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;
            }
            if (posiciones[0] == 'o' && posiciones[4] == 'o' && posiciones[8] == 'o')
            {
                MessageBox.Show("Ha ganado CPU!", "GATO.exe", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ReiniciarTablero();
                ganador = true;
                return ganador;

            }
            else return false;
        }

        #endregion
        //lo que pasa cada que se presiona una tecla
        private void EvtMarcarTablero(object sender, EventArgs e)
        {
            bool ganaron = false;
            bool empate = false;

            Button b = (Button)sender;

            if (b.Name == btn_Uno.Name)
            {
                turnos[0] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[0] = 'x';
                        btn_Uno.Text = "O";
                        btn_Uno.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[0] = 'o';
                        btn_Uno.Text = "X";
                        btn_Uno.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;

                }

            }

            if (b.Name == btn_Dos.Name)
            {
                turnos[1] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[1] = 'x';
                        btn_Dos.Text = "O";
                        btn_Dos.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[1] = 'o';
                        btn_Dos.Text = "X";
                        btn_Dos.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;

                }

            }

            if (b.Name == btn_Tres.Name)
            {
                turnos[2] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[2] = 'x';
                        btn_Tres.Text = "O";
                        btn_Tres.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[2] = 'o';
                        btn_Tres.Text = "X";
                        btn_Tres.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;

                }

            }

            if (b.Name == btn_Cuatro.Name)
            {
                turnos[3] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[3] = 'x';
                        btn_Cuatro.Text = "O";
                        btn_Cuatro.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[3] = 'o';
                        btn_Cuatro.Text = "X";
                        btn_Cuatro.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;

                }

            }

            if (b.Name == btn_Cinco.Name)
            {
                turnos[4] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[4] = 'x';
                        btn_Cinco.Text = "O";
                        btn_Cinco.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[4] = 'o';
                        btn_Cinco.Text = "X";
                        btn_Cinco.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;
                }

            }

            if (b.Name == btn_Seis.Name)
            {
                turnos[5] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[5] = 'x';
                        btn_Seis.Text = "O";
                        btn_Seis.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[5] = 'o';
                        btn_Seis.Text = "X";
                        btn_Seis.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;
                }

            }

            if (b.Name == btn_Siete.Name)
            {
                turnos[6] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[6] = 'x';
                        btn_Siete.Text = "O";
                        btn_Siete.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[6] = 'o';
                        btn_Siete.Text = "X";
                        btn_Siete.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;

                }

            }

            if (b.Name == btn_Ocho.Name)
            {
                turnos[7] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[7] = 'x';
                        btn_Ocho.Text = "O";
                        btn_Ocho.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[7] = 'o';
                        btn_Ocho.Text = "X";
                        btn_Ocho.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;

                }

            }

            if (b.Name == btn_Nueve.Name)
            {
                turnos[8] = 1;
                switch (quienJuega)
                {
                    case Jugando.JUGADOR_1:
                        posiciones[8] = 'x';
                        btn_Nueve.Text = "O";
                        btn_Nueve.Enabled = false;
                        quienJuega = Jugando.JUGADOR_2;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            empate = Empate();
                        }
                        if (maquin_agame == true && ganaron == false && empate == false)
                        {

                            InteligenciaArtificial();
                        }
                        break;
                    case Jugando.JUGADOR_2:
                        posiciones[8] = 'o';
                        btn_Nueve.Text = "X";
                        btn_Nueve.Enabled = false;
                        quienJuega = Jugando.JUGADOR_1;
                        ganaron = HayGanador();
                        if (ganaron == false)
                        {
                            Empate();
                        }
                        break;

                }

            }
            if (quienJuega == Jugando.JUGADOR_1)
            {
                btn_Turno.Text = "O";
            }
            else if (quienJuega == Jugando.JUGADOR_2)
            {
                btn_Turno.Text = "X";
            }
        }


        private void EvtLaMaquinaEstaJugando(object sender, EventArgs e)
        {
            if (rbt_CPU.Checked == true)
            {
                maquin_agame = true;
                //Para que si la máquina entra en un juego ya empezado sepa que le tica jugar a ella
                if (quienJuega == Jugando.JUGADOR_2)
                {
                    InteligenciaArtificial();
                }
            }
               
            

           
        }



    }
}
