using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17_Library
{
    public class MiLista<T> : IEnumerable<T>
    {
        private T[] lista;

        public MiLista()
        {
            this.lista = new T[0];
        }

        public int Count
        {
            get
            {
                return this.lista.Length;
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref lista, lista.Length + 1);
            this.lista[lista.Length - 1] = item;
        }

        public void Remove(T item)
        {
            T[] aux = new T[this.lista.Length - 1];

            for (int i = 0; i < this.lista.Length; i++)
            {
                if (this.lista[i].Equals(item))
                {
                    // Si I no es el primer elemento,
                    // copio el contenido desde el comienzo hasta I
                    if (i > 0)
                        Array.ConstrainedCopy(this.lista, 0, aux, 0, i);
                    // Si I no es el último elemento,
                    // copio el contenido desde I + 1 hasta el final
                    if (i < this.lista.Length)
                        Array.ConstrainedCopy(this.lista, i + 1, aux, i, this.lista.Length - i - 1);
                    break;
                }
            }
            // Copio el auxiliar a la lista
            Array.Resize(ref lista, lista.Length - 1);
            Array.ConstrainedCopy(aux, 0, this.lista, 0, this.lista.Length);
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.lista)
            {
                yield return item;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int index = 0; index < this.lista.Length; index++)
            {
                // Yield each day of the week.
                yield return this.lista[index];
            }
        }

        #endregion
    }
}
