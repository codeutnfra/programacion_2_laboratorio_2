using System;
using System.Collections.Generic;
using System.Text;
namespace Biblioteca
{
    public class Torneo<T> where T: Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if (item == equipo )
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if ((torneo is not null && equipo is not null)&& torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {nombre}");
            foreach (T item in equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T e1, T e2)
        {
            Random rd = new Random();
            return $"{e1.nombre}{rd.Next(0, 10)} - {e2.nombre}{rd.Next(0, 10)}";
        }
        public string JugarPartido
        {
            get
            {
                Random rd = new Random();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[rd.Next(0, equipos.Count)];
                    equipo2 = equipos[rd.Next(0, equipos.Count)];
                } while (equipo1 == equipo2);
                return CalcularPartido(equipo1, equipo2);
            }
        }
    }
    
}
