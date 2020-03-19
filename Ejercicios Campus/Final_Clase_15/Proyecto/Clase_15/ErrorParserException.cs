using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15
{
    class ErrorParserException : Exception
    {
        public ErrorParserException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
