namespace Biblioteca
{
    public class AppJuegos : Aplicacion
    {
        protected override int Tamanio
        {
            get
            {
                return tamanioMb;
            }
        }

        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanio)
            :base(nombre, sistemaOperativo, tamanio)
        {
        }
    }
}
