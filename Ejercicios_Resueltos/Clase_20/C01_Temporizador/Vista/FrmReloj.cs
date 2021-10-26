using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmReloj : Form
    {
        private Temporizador temporizador;

        public FrmReloj()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.TiempoCumplido += AsignarHora;
        }

        private void FrmReloj_Load(object sender, EventArgs e)
        {
            //ActualizarHoraConEstructurasIterativas();
            //ActualizarHoraConHilos();
            ActualizarHoraConClaseTemporizador();
        }

        #region Punto i (con estructuras iterativas)
        private void ActualizarHoraConEstructurasIterativas()
        {
            do
            {
                AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }
        #endregion

        #region Punto ii (con Timer)
        private void timer_Tick(object sender, EventArgs e)
        {
            //AsignarHora();
        }
        #endregion

        #region Punto iii (con hilos)
        private void ActualizarHoraConHilos()
        {
            Task task = Task.Run(() =>
            {
                do
                {
                    AsignarHora();
                    Thread.Sleep(1000);
                } while (true);
            });
        }
        #endregion

        #region EjercicioTemporizador
        public void ActualizarHoraConClaseTemporizador()
        {
            temporizador.IniciarTemporizador();
        }
        #endregion

        private void AsignarHora()
        {
            if (lblHora.InvokeRequired)
            {
                Action delegadoAsignarHora = AsignarHora;
                lblHora.Invoke(delegadoAsignarHora);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        private void btnDetenerReloj_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }

        private void btnIniciarReloj_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }
    }
}
