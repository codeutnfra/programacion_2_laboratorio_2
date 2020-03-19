using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface ISerializable<T>
    {
        bool guardar(string archivo);
        bool modificar(string archivo);
        bool leer(string archivo, out T datos);
        bool eliminar(string archivo);
    }
}
