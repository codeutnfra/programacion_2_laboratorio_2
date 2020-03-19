using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Calculador
    {
        private int acumulador;

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        public Calculador()
        {
            this.acumulador = 0;
        }

        /// <summary>
        /// Sumo valores en el acumulador
        /// </summary>
        /// <param name="valor">Binario ASCII a acumular</param>
        public void acumular(string valor)
        {
            this.acumulador += Conversor.BinarioEntero(valor);
        }
        /// <summary>
        /// Retorno el valor del acumulador en formato Binario ASCII
        /// </summary>
        /// <returns>Valor en binario ASCII del acumulador</returns>
        public string getResultadoBinario()
        {
            return Conversor.EnteroBinario(this.acumulador);
        }
        /// <summary>
        /// Retorno el valor del acumulador en formato entero
        /// </summary>
        /// <returns>Valor en entero del acumulador</returns>
        public int getResultadoEntero()
        {
            return this.acumulador;
        }
    }
}
