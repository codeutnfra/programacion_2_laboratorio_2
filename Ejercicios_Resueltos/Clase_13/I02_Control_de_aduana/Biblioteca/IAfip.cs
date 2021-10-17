namespace Biblioteca
{
    public interface IAfip
    {
        decimal Impuestos { get; }
        decimal AplicarImpuestos();
    }
}
