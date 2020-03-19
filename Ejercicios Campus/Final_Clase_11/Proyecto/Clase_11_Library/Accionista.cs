using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_8_Library;

namespace Clase_10_Library
{
    public class Accionista : Persona
    {
        private int _porcionAccionaria;

        public Accionista(string nombre, string apellido, int porcionAccionaria)
            : base (nombre, apellido)
        {
            this.PorcionAccionaria = porcionAccionaria;
        }

        public int PorcionAccionaria
        {
            get
            {
                return this._porcionAccionaria;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this._porcionAccionaria = value;
                }
            }
        }

        public override string PosicionSocietaria()
        {
            return "Accionista con el " + this.PorcionAccionaria + "% de la porción accionaria.";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Persona.Mostrar(this));
            sb.AppendLine(this.PosicionSocietaria());
            sb.AppendLine("******************");

            return sb.ToString();
        }
    }
}
