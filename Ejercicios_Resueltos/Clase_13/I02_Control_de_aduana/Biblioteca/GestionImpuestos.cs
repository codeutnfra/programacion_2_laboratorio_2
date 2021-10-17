using System.Collections.Generic;

namespace Biblioteca
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal totalImpuestos = 0;

            foreach (IAduana impuestoAduana in impuestosAduana)
            {
                totalImpuestos += impuestoAduana.Impuestos;  
            }

            return totalImpuestos;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal totalImpuestos = 0;

            foreach (IAfip impuestoAfip in impuestosAfip)
            {
                totalImpuestos += impuestoAfip.Impuestos;
            }

            return totalImpuestos;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete paquete in paquetes)
            {
                RegistrarImpuestos(paquete);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            impuestosAduana.Add(paquete);

            if (paquete is IAfip)
            {
                IAfip paqueteAfip = (IAfip)paquete;
                impuestosAfip.Add(paqueteAfip);
            }
        }
    }
}
