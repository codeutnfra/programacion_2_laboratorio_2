using System;
using System.Text;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1() : this(0, string.Empty)
        {

        }
        private AutoF1(short cantidadCombustible, bool enCompetencia, short vueltasRestantes)
        {
            this.cantidadCombustible = cantidadCombustible;
            this.enCompetencia = enCompetencia;
            this.vueltasRestantes = vueltasRestantes;
        }
        public AutoF1(short numero, string escuderia) : this(0, false, 0)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto" + this.numero);
            sb.AppendLine("Escuderia" + this.escuderia);
            sb.AppendLine("Vueltas restantes" + this.vueltasRestantes);
            return sb.ToString();

        }
        public short SetCantidadCombustible
        {
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool SetEnCompetencia
        {
            set
            {
                this.enCompetencia = value;
            }
        }
        public short SetVueltasRestantes
        {
            set
            {
                this.vueltasRestantes = value;
            }
        }


        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
    }
}
