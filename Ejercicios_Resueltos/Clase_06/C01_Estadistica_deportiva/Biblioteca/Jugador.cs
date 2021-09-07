using System;
using System.Text;
namespace Biblioteca
{
    public class Jugador
    {
        //atributos

        private int dni;
        private string nombre;
        private int partidosJugados;
        private int promedioGoles;
        private int totalGoles;

        //inicializo datos estadisticos en ctor privado
        private Jugador()
        {
            this.promedioGoles = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            : this() //llamo al ctor privado sin parametros
        {
            this.dni = dni;
            this.nombre = nombre;

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre) //llamo al ctor publico que recibe dos parametros
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            Jugador j = new Jugador();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dni: " + this.dni.ToString());
            sb.AppendLine("partidos jugador: " + this.partidosJugados.ToString());
            sb.AppendLine("total goles: " + this.totalGoles.ToString());
            sb.AppendLine("Promedio goles: " + this.GetPromedioGoles().ToString());

            return sb.ToString();

        }

        //sobrecarga de operadores
        //dos jugadores seran iguales si tienen mismo dni
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
