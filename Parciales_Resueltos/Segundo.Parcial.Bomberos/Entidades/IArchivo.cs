namespace Entidades
{
    interface IArchivo<X>
    {
        void Guardar(X info);
        X Leer();
    }
}
