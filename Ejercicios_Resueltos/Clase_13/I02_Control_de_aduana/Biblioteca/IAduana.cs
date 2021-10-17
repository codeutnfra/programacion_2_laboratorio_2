namespace Biblioteca
{
    public interface IAduana
    {
        decimal Impuestos { get; }
        decimal AplicarImpuestos();
    }
}
