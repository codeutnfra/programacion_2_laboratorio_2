using System;
using System.IO;

namespace IO
{
    public abstract class Archivo
    {
        protected abstract string Extension { get;  }

        protected bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new ArchivoIncorrectoException("El archivo no se encontró.");
            }
                
            if (Path.GetExtension(ruta) != Extension)
            {
                throw new ArchivoIncorrectoException($"El archivo no tiene la extensión {Extension}.");
            }

            return true;
        }
    }
}
