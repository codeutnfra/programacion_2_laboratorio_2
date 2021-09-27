namespace Biblioteca
{
    public class Comic : Publicacion
    {
        private bool esColor;

        /// <summary>
        /// Retorna true si el comic es a color.
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }

        public Comic(string nombre, bool esColor, int stock, float valor)
            : base(nombre, stock, valor)
        {
            this.esColor = esColor;
        }
    }
}
