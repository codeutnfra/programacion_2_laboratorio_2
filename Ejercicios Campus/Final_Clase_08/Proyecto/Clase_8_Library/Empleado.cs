using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
    public class Empleado
    {
        public enum EPuestoJerarquico
        {
            Administración,
            Gerencia,
            Sistemas,
            Accionista
        }
        string _nombre;
        string _apellido;
        string _legajo;
        EPuestoJerarquico _puesto;
        int _salario;

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        /// <summary>
        /// Dos empleados son iguales si, y sólo si, comparten el mismo número de legajo.
        /// </summary>
        /// <param name="e1">Primer empleado a comparar</param>
        /// <param name="e2">Segundo empleado a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            // Controlo que ninguno de los dos empleados no haya sido instanciado, para evitar errores.
            if (!object.ReferenceEquals(e1, null) && !object.ReferenceEquals(e2, null))
            {
                if (e1._legajo == e2._legajo)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Dos empleados son distintos si, y sólo si, NO comparten el mismo número de legajo.
        /// </summary>
        /// <param name="e1">Primer empleado a comparar</param>
        /// <param name="e2">Segundo empleado a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre  : " + this._nombre);
            sb.AppendLine("Apellido: " + this._apellido);
            sb.AppendLine("Legajo  : " + this._legajo);
            sb.AppendLine("Puesto  : " + this._puesto.ToString());
            sb.AppendLine("Salario : $" + this._salario);
            sb.AppendLine("******************");

            return sb.ToString();
        }
    }
}
