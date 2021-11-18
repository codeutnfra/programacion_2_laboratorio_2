using System;

namespace Entidades
{
    public static class Extension
    {
        public static double CalcularDiferenciaEnSegundos(this DateTime inicio, DateTime fin)
        {
            return (fin - inicio).TotalSeconds;
        }
    }
}
