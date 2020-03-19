using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    class Cajon
    {
        private List<Fruta> _frutas;
        private int _volumen;

        private Cajon()
        {
            this._frutas = new List<Fruta>();
        }
        public Cajon(int volumen)
            : this()
        {
            this._volumen = volumen;
        }

        public int CalcularEspacioDisponible()
        {
            int volumenOcupado = 0;
            foreach (Fruta f in this._frutas)
            {
                volumenOcupado += f._volumen;
            }
            return this._volumen - volumenOcupado;
        }

        public string MostrarContenido()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El cajón dispone de un volumen de: " + this._volumen);
            sb.AppendLine("Ocupado por las frutas:");
            foreach (Fruta f in this._frutas)
            {
                sb.AppendLine("<------------------->");
                sb.AppendLine("PESO: " + f._peso);
                sb.AppendLine("VOLUMEN: " + f._volumen);
            }

            return sb.ToString();
        }

        public void AgregarFruta(Fruta fruta)
        {
            if (this.CalcularEspacioDisponible() > fruta._volumen)
            {
                this._frutas.Add(fruta);
            }
        }

        public void QuitarFruta()
        {
            if (this._frutas.Count > 0)
            {
                Random r = new Random();
                this._frutas.RemoveAt(r.Next(0, this._frutas.Count));
            }
        }
    }
}
