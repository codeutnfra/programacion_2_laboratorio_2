using System;

namespace Biblioteca
{
    public class PaquetePesado : Paquete, IAfip
    {
        public override bool TienePrioridad
        {
            get
            {
                return false;
            }
        }

        decimal IAfip.Impuestos
        {
            get
            {
                return costoEnvio * 0.25M;
            }
        }

        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio,
            string destino, string origen, double pesoKg)
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos + ((IAfip)this).Impuestos;
        }
    }
}
