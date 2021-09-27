namespace Biblioteca
{
    public class Biografia : Publicacion
    {
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna true si hay stock. 
        /// </summary>
        public override bool HayStock
        {
            get
            {
                return stock > 0;
            }
        }

        public Biografia(string nombre)
            : base(nombre)
        {
        }

        public Biografia(string nombre, int stock)
            : base(nombre, stock)
        {
        }

        public Biografia(string nombre, int stock, float valor)
            : base(nombre, stock, valor)
        {
        }

        /// <summary>
        /// Genera un objeto Biografia a partir del nombre.
        /// </summary>
        /// <param name="nombre"></param>
        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
