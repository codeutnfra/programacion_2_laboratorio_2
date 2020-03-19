using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Conversor
    {
        /// <summary>
        /// Método que convierte un número entero en un binario ASCII
        /// </summary>
        /// <param name="entero">Número a convertir. EJ: 9</param>
        /// <returns>Valor binario ASCII resultado de la conversión. EJ: 1001</returns>
        public static string EnteroBinario(int entero)
        {
            string binario = "";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;
        }

        /// <summary>
        /// Método que convierte un binario ASCII en un número entero
        /// </summary>
        /// <param name="binario">Binario ASCII a convertir. EJ: 1001</param>
        /// <returns>Valor entero resultado de la conversión. EJ: 9</returns>
        public static int BinarioEntero(string binario)
        {
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero;
        }
    }
}
