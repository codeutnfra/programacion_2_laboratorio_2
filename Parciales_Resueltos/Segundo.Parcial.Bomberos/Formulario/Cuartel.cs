using Entidades;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Cuartel : Form
    {
        private List<Bombero> bomberos;
        private List<PictureBox> fuegos;
        private CancellationTokenSource cancellationTokenSource;

        public Cuartel()
        {
            InitializeComponent();

            fuegos = new List<PictureBox>();
            fuegos.Add(fuego1);
            fuegos.Add(fuego2);
            fuegos.Add(fuego3);
            fuegos.Add(fuego4);

            cancellationTokenSource = new CancellationTokenSource();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bomberos = new List<Bombero>();
            Bombero b1 = new Bombero("M. Palermo");
            b1.MarcarFin += OcultarBombero;
            bomberos.Add(b1);
            Bombero b2 = new Bombero("G. Schelotto");
            b2.MarcarFin += OcultarBombero;
            bomberos.Add(b2);
            Bombero b3 = new Bombero("C. Tevez");
            b3.MarcarFin += OcultarBombero;
            bomberos.Add(b3);
            Bombero b4 = new Bombero("F. Gago");
            b4.MarcarFin += OcultarBombero;
            bomberos.Add(b4);
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(0);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensajeSalidaNoConcretada(0);
            }
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(1);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensajeSalidaNoConcretada(1);
            }
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(2);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensajeSalidaNoConcretada(2);
            }
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            try
            {
                DespacharServicio(3);
            }
            catch (BomberoOcupadoException)
            {
                MostrarMensajeSalidaNoConcretada(3);
            }
        }

        private void MostrarMensajeSalidaNoConcretada(int index)
        {
            MessageBox.Show($"Salida de bombero {index} no concretada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DespacharServicio(int index)
        {
            VerificarSiBomberoEstaEnSalida(index);
            fuegos[index].Visible = true;
            Bombero bombero = bomberos[index];
            Task hilo = new Task(() => bombero.AtenderSalida(index), cancellationTokenSource.Token);
            hilo.Start();
        }

        private void VerificarSiBomberoEstaEnSalida(int index)
        {
            foreach (Salida salida in bomberos[index].Salidas)
            {
                if (salida.FechaFin == default)
                {
                    throw new BomberoOcupadoException();
                }
            }
        }

        private void OcultarBombero(int bomberoIndex)
        {
            if (InvokeRequired)
            {
                Action<int> ocultarBombero = OcultarBombero;
                Invoke(ocultarBombero, bomberoIndex);
            }
            else
            {
                fuegos[bomberoIndex].Visible = false;
            }
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            bomberos[0].Guardar(bomberos[0]);
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            bomberos[1].Guardar(bomberos[1]);
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            bomberos[2].Guardar(bomberos[2]);
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            bomberos[3].Guardar(bomberos[3]);
        }

        private void Cuartel_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
