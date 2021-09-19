namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        private float longitudBase;
        private float longitudAltura;

        public Rectangulo(float longitudBase, float longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }

        public override double CalcularPerimetro()
        {
            return (this.longitudBase + this.longitudAltura) * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.longitudBase * this.longitudAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }
    }
}
