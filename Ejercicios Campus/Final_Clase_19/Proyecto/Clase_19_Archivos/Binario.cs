using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Binario : IArchivo<string>
    {
        public bool guardar(string archivo, string datos)
        {
            throw new NotImplementedException("Método no implementado");
        }
        public bool leer(string archivo, out string datos)
        {
            throw new NotImplementedException("Método no implementado");
        }
    }
}
