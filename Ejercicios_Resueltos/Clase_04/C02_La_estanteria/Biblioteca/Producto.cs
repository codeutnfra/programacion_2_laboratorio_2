using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {

            return String.Format("MARCA {0} CODIGO {1} PRECIO {2} ", p.marca, (string)p, p.precio);
        }
        //conversion

        //devuelve el valor del atributo codigoDeBarra

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        //operadores
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string auxStr)
        {
            if (p.codigoDeBarra == auxStr)
            {
                return true;
            }
            return p.codigoDeBarra == auxStr;
        }
        public static bool operator !=(Producto p, string auxStr)
        {
            return !(p == auxStr);
        }
    }
}
