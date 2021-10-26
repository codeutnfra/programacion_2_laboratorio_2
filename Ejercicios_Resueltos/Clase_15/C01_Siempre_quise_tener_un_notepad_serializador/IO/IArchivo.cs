namespace IO
{
    public interface IArchivo<T>
    {
        bool Guardar(string ruta, T objeto);
        bool GuardarComo(string ruta, T objeto);
        T Leer(string ruta);
    }
}
