using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10.BO
{
    class Cls_Conversion
    {
        public int AnTecladoNegras;
        public int AlTecladoNegras;

        public int AnTecladoBlancas;
        public int AlTecladoBlancas;

        public Cls_Conversion()
        {
            this.AnTecladoNegras = 40;
            this.AlTecladoNegras = 250;
            this.AnTecladoBlancas = 50;
            this.AlTecladoBlancas = 300;
        }
        public void CrearTeclasNegras(String[] NotasTeclasNegras, Panel panel)
        {
            for (int i = 0; i < NotasTeclasNegras.Length; i++)
            {
                if (NotasTeclasNegras[i] != "_")
                {
                    Button Negra = new Button();
                    Negra.BackColor = Color.Black;
                    Negra.ForeColor = Color.White;

                    Negra.Size = new Size(AnTecladoNegras, this.AlTecladoNegras);
                    Negra.Name = NotasTeclasNegras[i].ToString();
                    Negra.Location = new Point(Negra.Location.X + (i * this.AnTecladoBlancas) + 30, Negra.Location.Y);
                    Negra.Text = NotasTeclasNegras[i];
                    Negra.Click += ReproducirSonidos;
                    panel.Controls.Add(Negra);
                }
            }
        }

        public void CrearTeclasBlancas(String[] NotasTeclasBlancas, Panel panel)
        {
            for (int i = 0; i < NotasTeclasBlancas.Length; i++)
            {
                Button Blancas = new Button();
                Blancas.Name = NotasTeclasBlancas[i].ToString();
                Blancas.TextAlign = ContentAlignment.BottomCenter;
                Blancas.Text = NotasTeclasBlancas[i];
                Blancas.Size = new Size (this.AnTecladoBlancas, this.AlTecladoBlancas);
                Blancas.ForeColor = Color.Black;
                int TheX = Blancas.Location.X + (i * this.AnTecladoBlancas);
                Blancas.Location = new Point (TheX, Blancas.Location.Y);
                Blancas.Click += ReproducirSonidos;
                panel.Controls.Add(Blancas);
            }
        }
        public void ReproducirSonidos(object sender, EventArgs e)
        {
            var BtnSonido = (Button)sender;

            Stream str = (Stream)Properties.Resources.ResourceManager.GetObject(BtnSonido.Name.ToString().Replace("#", "S"));
            SoundPlayer Sonido = new SoundPlayer(str);
            Sonido.Play();
        }
    }
}
