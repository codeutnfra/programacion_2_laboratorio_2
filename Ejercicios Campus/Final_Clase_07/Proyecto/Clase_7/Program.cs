using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            bool continuar = true;

            Cajon cajon = new Cajon(10);
            do
            {
                Console.WriteLine(cajon.MostrarContenido());
                Console.WriteLine("****************************");
                // Menú
                Console.WriteLine("1 - Agregar fruta");
                Console.WriteLine("2 - Quitar fruta");
                Console.WriteLine("3 - Mostrar espacio disponible");
                Console.WriteLine("0 - Salir");
                // Fin Menú

                // Si el valor ingresa por el usuario NO es válido, fuerzo la iteración,
                // salteando el código que está por debajo
                if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out key))
                    continue;
                // Según la tecla presionada por el usuario...
                switch (key)
                {
                    case 1:
                        Fruta fruta = new Fruta();
                        cajon.AgregarFruta(fruta);
                        break;
                    case 2:
                        cajon.QuitarFruta();
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Espacio disponible: " + cajon.CalcularEspacioDisponible());
                        Console.ReadKey();
                        break;
                    case 0:
                        continuar = false;
                        break;
                }
                Console.Clear();
            } while (continuar);
        }
    }
}
