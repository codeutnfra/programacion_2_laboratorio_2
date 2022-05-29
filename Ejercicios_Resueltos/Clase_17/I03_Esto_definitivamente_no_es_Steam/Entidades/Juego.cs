using System;

namespace Entidades
{
    public class Juego
    {
        string nombre;
        double precio;
        string genero;
        int codigoJuego;
        int codigoUsuario;

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }

        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario) : this(nombre, precio, genero, codigoUsuario)
        {
            this.codigoJuego = codigoJuego;
        }

        public string Nombre { get => nombre; }
        public double Precio { get => precio; }
        public string Genero { get => genero; }
        public int CodigoJuego { get => codigoJuego; }
        public int CodigoUsuario { get => codigoUsuario; }
    }
}
