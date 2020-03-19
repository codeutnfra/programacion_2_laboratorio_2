using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Library
{
    public class ErrorLecturaException : Exception
    {
        public ErrorLecturaException(Exception e)
            : base("No se pudo leer el archivo", e)
        { }
    }
}
