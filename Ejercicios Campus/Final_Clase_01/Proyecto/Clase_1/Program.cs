using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    class Program
    {
        /// <summary>
        /// NOTA: Recordar agregar Console.ReadKey(); para detener el curso del programa y ver lo impreso por pantalla
        /// NOTA: Utilizar estructuras repetitivas, selectivas y la función módulo (%). 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // EJERCICIO Nº1
            //--------------------------------------------------------------
            // Declaro las 5 variables escalares
            int variable1;
            int variable2;
            int variable3;
            int variable4;
            int variable5;
            // Variables para mostrar máximo, mínimo y promedio
            int max;
            int min;
            int acumPromedio = 0;

            // VERSION 1
            // Pido el primer valor
            Console.WriteLine("Ingrese el primer valor: ");
            while (!int.TryParse(Console.ReadLine(), out variable1))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }
            // Inicializo máximo y mínimo con la primer variable
            max = variable1;
            min = variable1;

            // Limpio pantalla y pido el segundo valor
            Console.Clear();
            Console.WriteLine("Ingrese el segundo valor: ");
            while (!int.TryParse(Console.ReadLine(), out variable2))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }
            // Limpio pantalla y pido el tercer valor
            Console.Clear();
            Console.WriteLine("Ingrese el tercer valor: ");
            while (!int.TryParse(Console.ReadLine(), out variable3))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }
            // Limpio pantalla y pido el cuarto valor
            Console.Clear();
            Console.WriteLine("Ingrese el cuarto valor: ");
            while (!int.TryParse(Console.ReadLine(), out variable4))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }
            // Limpio pantalla y pido el quinto valor
            Console.Clear();
            Console.WriteLine("Ingrese el quinto valor: ");
            while (!int.TryParse(Console.ReadLine(), out variable5))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }
            // Calculo máximo, mínimo y promedio
            if (max < variable2)
                max = variable2;
            if (min > variable2)
                min = variable2;
            if (max < variable3)
                max = variable3;
            if (min > variable3)
                min = variable3;
            if (max < variable4)
                max = variable4;
            if (min > variable4)
                min = variable4;
            if (max < variable5)
                max = variable5;
            if (min > variable5)
                min = variable5;
            acumPromedio = variable1 + variable2 + variable3 + variable4 + variable5;
            Console.WriteLine("El valor máximo es {0}, el mínimo {1} y el promedio {2}", max, min, acumPromedio / 5);

            Console.ReadKey();
            Console.Clear();

            // VERSION 2
            acumPromedio = 0;
            int cont = 1;
            int auxI;
            while (cont < 6)
            {
                // Limpio pantalla y pido un valor, indicando con cont que valor es
                Console.WriteLine("Ingrese el " + cont + " valor: ");
                if (int.TryParse(Console.ReadLine(), out auxI))
                {
                    // Si pudo convertir el valor a int, me fijo que valor es
                    switch (cont)
                    {
                        case 1:
                            variable1 = auxI;
                            // Inicializo máximo y mínimo con la primer variable
                            max = variable1;
                            min = variable1;
                            break;
                        case 2:
                            variable2 = auxI;
                            break;
                        case 3:
                            variable3 = auxI;
                            break;
                        case 4:
                            variable4 = auxI;
                            break;
                        case 5:
                            variable5 = auxI;
                            break;
                    }
                    // Compruebo máximo, mínimo y acumulador de promedio
                    if (max < auxI)
                        max = auxI;
                    if (min > auxI)
                        min = auxI;
                    acumPromedio += auxI;
                    // Incremento el contador
                    cont++;

                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un valor entero y numérico.");
                }
            }
            Console.WriteLine("El valor máximo es {0}, el mínimo {1} y el promedio {2}", max, min, acumPromedio / 5);

            //--------------------------------------------------------------
            // FIN EJERCICIO Nº1
            Console.ReadKey();
            Console.Clear();

            // EJERCICIO Nº2
            //-------------------------------------------------------------
            // Valor tope de la iteración
            int maximo;
            // Ingreso el número hasat el cual calcularé los números primos hasta que sea numérico
            Console.WriteLine("Ingrese un número hasta el cual se calcularan todos los números primos: ");
            while (!int.TryParse(Console.ReadLine(), out maximo))
            {
                Console.WriteLine("Error. Ingrese un valor entero y numérico.");
            }

            bool esPrimo;
            // Un número primo es un número natural mayor que 1, por eso arranco el contador desde 2 hasta el número ingresado
            for (int i = 2; i <= maximo; i++)
            {
                esPrimo = true;
                // Busco divisores entre 2 y el número actual, dando por hecho que el número se dividirá por 1 y por si mismo,
                // ya que un número primo tiene únicamente dos divisores distintos: él mismo y el 1.
                for (int divisor = 2; divisor < i; divisor++)
                {
                    if ((i % divisor) == 0)
                    {
                        // Si encuentro otro divisor, marco como no primo y rompo la iteración del FOR
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                    Console.WriteLine("El número {0} es un número primo menor a {1}", i, maximo);
            }
            //--------------------------------------------------------------
            // FIN EJERCICIO Nº2
            Console.ReadKey();
        }
    }
}
