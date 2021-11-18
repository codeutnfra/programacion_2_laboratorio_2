using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Cuartel2 : Form
    {
        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        public Cuartel2()
        {
            InitializeComponent();

            fuegos = new List<PictureBox>();
            fuegos.Add(fuego1);
            fuegos.Add(fuego2);
            fuegos.Add(fuego3);
            fuegos.Add(fuego4);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bomberos = new List<Bombero>();
            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += FinalDeSalida;
            bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += FinalDeSalida;
            bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += FinalDeSalida;
            bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += FinalDeSalida;
            bomberos.Add(b4);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            DespacharServicio(0);
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            DespacharServicio(1);
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            DespacharServicio(2);
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            DespacharServicio(3);
        }

        private void DespacharServicio(int index)
        {
            fuegos[index].Visible = true;
            Bombero bombero = bomberos[index];
        }

        private void OcultarBombero(int bomberoIndex)
        {
            fuegos[bomberoIndex].Visible = false;
        }

    }
}
