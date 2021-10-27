using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cliente);

        private static Random random;
        private Queue<string> clientesALaEspera;
        private DelegadoClienteAtendido delegadoClienteAtendido;
        private string nombreCaja;

        public int CantidadDeClientesALaEspera
        {
            get
            {
                return clientesALaEspera.Count;
            }
        }

        public string NombreCaja
        {
            get
            {
                return nombreCaja;
            }
        }

        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            this.nombreCaja = nombreCaja;
            clientesALaEspera = new Queue<string>();
            this.delegadoClienteAtendido = delegadoClienteAtendido;

        }

        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }

        private void AtenderClientes()
        {
            do
            {
                if (clientesALaEspera.Any())
                {
                    string cliente = clientesALaEspera.Dequeue();
                    delegadoClienteAtendido.Invoke(this, cliente);
                    Thread.Sleep(random.Next(1000, 5000));
                }
            } while (true);
        }
    }
}
