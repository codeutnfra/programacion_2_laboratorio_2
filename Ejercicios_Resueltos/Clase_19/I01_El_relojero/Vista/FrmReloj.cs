using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmReloj : Form
    {
        public FrmReloj()
        {
            InitializeComponent();
        }

        private void FrmReloj_Load(object sender, EventArgs e)
        {
            //ActualizarHoraConEstructurasIterativas();
            ActualizarHoraConHilos();
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
            AsignarHora();
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
    }
}
