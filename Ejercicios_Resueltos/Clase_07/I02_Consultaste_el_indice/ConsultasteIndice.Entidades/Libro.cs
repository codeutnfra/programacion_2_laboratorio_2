using System;
using System.Collections.Generic;

namespace ConsultasteIndice.Entidades
{
    public class Libro
    {
        private List<string> paginas;
        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < this.paginas.Count)
                {
                    return paginas[i];
                }
                return "Pagina no valida";
            }

            set
            {
                if (i > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if (i >= 0)
                {
                    this.paginas.Insert(i, value);
                }
            }
        }
    }
}
