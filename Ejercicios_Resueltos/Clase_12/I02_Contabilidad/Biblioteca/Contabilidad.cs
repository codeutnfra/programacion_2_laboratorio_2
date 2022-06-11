using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento, new()
    {
        public List<T> egresos;
        public List<U> ingresos;
        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U>c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }
    }
}
