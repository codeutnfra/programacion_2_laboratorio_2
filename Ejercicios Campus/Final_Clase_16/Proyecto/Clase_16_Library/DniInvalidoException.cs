using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16_Library
{
    public class DniInvalidoException : Exception
    {
        static string mensajeBase = "El DNI ingresado no es un número válido.";
        public DniInvalidoException()
            : base (mensajeBase)
        {

        }
        public DniInvalidoException(string message)
            : this(message, null)
        {

        }
        public DniInvalidoException(Exception e)
            : base(mensajeBase, e)
        {

        }
        public DniInvalidoException(string message, Exception e)
            : base(mensajeBase + message, e)
        {

        }
    }
}
