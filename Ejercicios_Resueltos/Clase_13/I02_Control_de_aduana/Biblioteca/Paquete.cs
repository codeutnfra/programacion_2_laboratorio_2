using System.Text;

namespace Biblioteca
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return costoEnvio * 0.35M;

            }
        }

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Código de seguimiento: {codigoSeguimiento}");
            stringBuilder.AppendLine($"Costo de envío: ${costoEnvio:#.00}");
            stringBuilder.AppendLine($"Origen: {origen}");
            stringBuilder.AppendLine($"Destino: {destino}");
            stringBuilder.AppendLine($"Peso: {pesoKg:#.00} kg");

            if (TienePrioridad)
            {
                stringBuilder.AppendLine("Tiene prioridad.");
            }
            else
            {
                stringBuilder.AppendLine("No tiene prioridad.");
            }
            

            return stringBuilder.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos;
        }
    }
}
