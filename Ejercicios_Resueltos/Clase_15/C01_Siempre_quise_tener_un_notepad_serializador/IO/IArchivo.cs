namespace IO
{
    public interface IArchivo<T>
    {
        void Guardar(string ruta, T contenido);
        void GuardarComo(string ruta, T contenido);
        T Leer(string ruta);
    }
}
