using System.Collections.Generic;

namespace BLL
{
    public interface ICrud<T>
    {
        public List<T> Listar();        
        public void Insertar(T objeto);        
        public void Modificar(T objeto);        
        public void Eliminar(T objeto);
    }
}