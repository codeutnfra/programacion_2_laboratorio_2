using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_17_Library;

namespace Clase_17
{
    class Program
    {
        static void Main(string[] args)
        {
            MiLista<String> miLista = new MiLista<String>();

            string item1 = "Item 1";
            string item2 = "Item 2";
            string item3 = "Item 3";
            string item4 = "Item 4";
            string item5 = "Item 5";
            string item6 = "Item 6";

            // Agregar los 6 items y mostrar
            miLista.Add(item1);
            miLista.Add(item2);
            miLista.Add(item3);
            miLista.Add(item4);
            miLista.Add(item5);
            miLista.Add(item6);

            Console.WriteLine("Mostrar Lista Completa");
            Console.WriteLine("Cantidad de items: " + miLista.Count.ToString());
            foreach (string item in miLista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("<**********************************>");
            Console.WriteLine("");
            Console.ReadKey();

            // Quitar un item y mostrar
            miLista.Remove(item4);

            Console.WriteLine("Mostrar Lista Sin 4.");
            Console.WriteLine("Cantidad de items: " + miLista.Count.ToString());
            foreach (string item in miLista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("<**********************************>");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
