using System;

namespace IO
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje)
            : base(mensaje)
        {

        }
    }
}
