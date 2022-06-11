using System;
using Biblioteca;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("tBasquet");
            EquipoBasquet e1 = new EquipoBasquet("e1", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("e2", DateTime.Now);

            _ = torneoBasquet + e1;
            _ = torneoBasquet + e2;

            Console.WriteLine(torneoBasquet.Mostrar());

        }
    }
}
