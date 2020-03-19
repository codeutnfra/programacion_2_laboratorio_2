using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Calculador calculador = new Calculador();

            int key;
            bool continuar = true;
            string valor;
            do
            {
                // Menú
                Console.WriteLine("1 - Convertir de Binario a Decimal");
                Console.WriteLine("2 - Convertir de Decimal a Binario");
                Console.WriteLine("3 - Mostrar acumulador en Binario");
                Console.WriteLine("4 - Mostrar acumulador en Decimal");
                Console.WriteLine("0 - Salir");
                // Fin Menú

                // Si el valor ingresa por el usuario NO es válido, fuerzo la iteración,
                // salteando el código que está por debajo
                if(!int.TryParse(Console.ReadKey().KeyChar.ToString(), out key))
                    continue;
                Console.WriteLine("");
                // Según la tecla presionada por el usuario...
                switch(key)
                {
                    case 1:
                        Console.WriteLine("Ingrese un valor Binario ASCII a convertir a entero: ");
                        string aux = Console.ReadLine();
                        Console.WriteLine(Conversor.BinarioEntero(aux));
                        // Acumulo en el calculador
                        calculador.acumular(aux);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un valor entero a convertir a Binario ASCII: ");
                        int converso;
                        if (int.TryParse(Console.ReadLine(), out converso))
                        {
                            Console.WriteLine(Conversor.EnteroBinario(converso));
                            // Acumulo en el calculador
                            calculador.acumular(converso);
                        }
                        else
                            Console.WriteLine("¡Valor inválido!");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Valor del acumulador en Binario ASCII: ");
                        // Imprimo el resultado en binario ASCII
                        Console.WriteLine(calculador.getResultadoBinario());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Valor del acumulador en entero: ");
                        // Imprimo el resultado en entero
                        Console.WriteLine(calculador.getResultadoEntero());
                        Console.ReadKey();
                        break;
                    case 0:
                        continuar = false;
                        break;
                }
                Console.Clear();
            } while(continuar);
        }
    }
}
