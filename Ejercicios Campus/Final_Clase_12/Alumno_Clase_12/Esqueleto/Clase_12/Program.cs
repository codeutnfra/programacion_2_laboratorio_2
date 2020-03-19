using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_12_Library; //quitar Reference

namespace Clase_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Concecionaria concecionaria = new Concecionaria(5);

            Camion c1 = new Camion(Vehiculo.EMarca.Scania, "ASD012", ConsoleColor.Black);
            Camion c2 = new Camion(Vehiculo.EMarca.Iveco, "ASD913", ConsoleColor.Red);
            Moto m1 = new Moto(Vehiculo.EMarca.BMW, "HJK789", ConsoleColor.White);
            Moto m2 = new Moto(Vehiculo.EMarca.Yamaha, "IOP852", ConsoleColor.Blue);
            Automovil a1 = new Automovil(Vehiculo.EMarca.Chevrolet, "QWE968", ConsoleColor.Gray);
            Automovil a2 = new Automovil(Vehiculo.EMarca.Ford, "TYU426", ConsoleColor.DarkBlue);
            Automovil a3 = new Automovil(Vehiculo.EMarca.Scania, "IOP852", ConsoleColor.Green);

            // Agrego 6 ítems (los últimos 2 no deberían poder agregarse) y muestro
            concecionaria += c1;
            concecionaria += c2;
            concecionaria += m1;
            concecionaria += m2;
            concecionaria += a1;
            concecionaria += a2;
            concecionaria += a3;

            Console.WriteLine(concecionaria.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Quito un item y muestro
            concecionaria -= c1;

            Console.WriteLine(concecionaria.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Motos
            Console.WriteLine(Concecionaria.Mostrar(concecionaria, Concecionaria.ETipo.Moto));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Camiones
            Console.WriteLine(Concecionaria.Mostrar(concecionaria, Concecionaria.ETipo.Camion));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Automoviles
            Console.WriteLine(Concecionaria.Mostrar(concecionaria,Concecionaria.ETipo.Automovil));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
        }
    }
}
