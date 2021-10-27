using NameGenerator.Generators;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();
            hilos.AddRange(AbrirCajas());
                        

            hilos.Add(Task.Run(GenerarClientes));
            hilos.Add(Task.Run(AsignarCajas));

            return hilos;
        }

        private List<Task> AbrirCajas()
        {
            List<Task> hilos = new List<Task>();

            foreach (Caja caja in cajas)
            {
                hilos.Add(caja.IniciarAtencion());
            }

            return hilos;
        }

        private void GenerarClientes()
        {
            do
            {
                clientes.Enqueue(realNameGenerator.Generate());
                Thread.Sleep(1000);
            } while (true);
        }

        private void AsignarCajas()
        {
            do
            {
                Caja caja = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    caja.AgregarCliente(cliente);
                }
            } while (true);
        }
    }
}
