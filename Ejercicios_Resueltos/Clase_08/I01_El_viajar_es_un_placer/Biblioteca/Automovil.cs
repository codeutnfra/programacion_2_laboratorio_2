using System;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, int cantidadPasajeros)
            : base(cantidadRuedas,cantidadPuertas, color)
        {
           
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
