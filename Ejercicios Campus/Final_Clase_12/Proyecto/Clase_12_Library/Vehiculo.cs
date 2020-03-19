using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public abstract class Vehiculo
    {
        public enum EMarca //quitar public
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }
        EMarca _marca;
        string _patente;
        ConsoleColor _color;

        public Vehiculo(string patente, EMarca marca, ConsoleColor color) //quitar constructor
        {
            this._patente = patente;
            this._marca = marca;
            this._color = color;
        }

        /// <summary>
        /// Retornará la cantidad de ruedas del vehículo
        /// </summary>
        protected abstract short CantidadRuedas { get; /*set;*/ } //quitar protected

        public virtual string Mostrar() //quitar virtual y poner sealed  // quitar protected
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente); // Modificar FORMAT por LINE
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString()); // Modificar FORMAT por LINE
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString()); // Modificar FORMAT por LINE
            sb.AppendLine("---------------------");

            return sb.ToString(); //quitar tostring
        }

        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1._patente == v2._patente);
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1._patente == v2._patente);
        }
    }
}
