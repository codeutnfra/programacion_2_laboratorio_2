using System;

namespace Entidades
{
    public class BomberoOcupadoException : Exception
    {
        public BomberoOcupadoException()
        {
        }

        public BomberoOcupadoException(string message) : base(message)
        {
        }

        public BomberoOcupadoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
