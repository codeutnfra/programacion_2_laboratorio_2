using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        
        public short cilindradas;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindradas):base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cilindradas = cilindradas;
        }
    }
}
