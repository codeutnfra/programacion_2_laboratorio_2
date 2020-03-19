using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Library
{
    public class ErrorEscrituraException : Exception
    {
        public ErrorEscrituraException(Exception e)
            : base("No se pudo escribir el archivo", e)
        { }
    }
}
