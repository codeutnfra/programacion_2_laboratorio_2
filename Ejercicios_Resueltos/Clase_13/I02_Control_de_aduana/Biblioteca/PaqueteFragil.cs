using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PaqueteFragil : Paquete
    {
        public override bool TienePrioridad
        {
            get 
            {
                return true;
            }
        }

        public PaqueteFragil(string codigoSeguimiento, decimal costoEnvio, 
            string destino, string origen, double pesoKg) 
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }
    }
}
