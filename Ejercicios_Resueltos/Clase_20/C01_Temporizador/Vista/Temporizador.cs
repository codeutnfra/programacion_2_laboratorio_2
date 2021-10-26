using System.Threading;
using System.Threading.Tasks;

namespace Vista
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private Task hilo;
        private int intervalo;

        public bool EstaActivo
        {
            get
            {
                return hilo is not null && 
                    (hilo.Status == TaskStatus.Running ||
                    hilo.Status == TaskStatus.WaitingToRun ||
                    hilo.Status == TaskStatus.WaitingForActivation);
            }
        }

        public int Intervalo
        {
            get
            {
                return intervalo;
            }
            set
            {
                intervalo = value;
            }
        }

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        public void IniciarTemporizador()
        {
            if (hilo is null || hilo.IsCompleted)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;

                hilo = new Task(CorrerTiempo, cancellationToken);
            }

            if (!EstaActivo)
            {
                hilo.Start();
            }
        }

        public void DetenerTemporizador()
        {
            if (hilo is not null && !hilo.IsCompleted)
            {
                cancellationTokenSource.Cancel();
            }
        }

        private void CorrerTiempo()
        {
            do
            {
                if (TiempoCumplido is not null)
                {
                    TiempoCumplido.Invoke();
                }

                Thread.Sleep(intervalo);
            } while (!cancellationToken.IsCancellationRequested);
        }
    }
}
