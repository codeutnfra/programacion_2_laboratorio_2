using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        protected abstract bool EsColor { get; }

        /// <summary>
        /// Retorna true si hay sotck y el importe es mayor a cero.
        /// </summary>
        public virtual bool HayStock
        {
            get
            {
                return stock > 0 && importe > 0;
            }
        }

        /// <summary>
        /// Retorna el importe de la publicación.
        /// </summary>
        public float Importe
        {
            get
            {
                return importe;
            }
        }

        /// <summary>
        /// Retorna el stock de la publicación. El valor asignado debe ser mayor a cero.
        /// </summary>
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
            }
        }

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock)
            : this(nombre)
        {
            Stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe)
            : this(nombre, stock)
        {
            this.importe = importe;
        }

        /// <summary>
        /// Retorna los datos de la Publicacion.
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacion()
        {
            string esColor = EsColor ? "SI" : "NO";            

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Nombre: {0}{1}", nombre, Environment.NewLine);
            stringBuilder.Append($"Stock: {Stock}{Environment.NewLine}");
            stringBuilder.AppendLine($"Es color: {esColor}");
            stringBuilder.AppendLine($"Valor: ${importe}");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Retorna el nombre de la publicación.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nombre;
        }
    }
}
