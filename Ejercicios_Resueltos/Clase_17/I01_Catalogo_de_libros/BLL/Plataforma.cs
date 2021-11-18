namespace BLL
{
    public class Plataforma
    {
        private int id;
        private string nombre;

        public Plataforma(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
