using System;

namespace Entidades
{
    public class Biblioteca
    {
        string usuario;
        string genero;
        string juego;
        int codigoJuego;

        public Biblioteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.usuario = usuario;
            this.genero = genero;
            this.juego = juego;
            this.codigoJuego = codigoJuego;
        }

        public string Usuario { get => usuario; }
        public string Genero { get => genero; }
        public string Juego { get => juego; }
        public int CodigoJuego { get => codigoJuego; }
    }
}
