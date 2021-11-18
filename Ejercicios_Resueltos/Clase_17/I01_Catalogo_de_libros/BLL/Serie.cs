using System;

namespace BLL
{
    public class Serie
    {
        private int id;
        private string titulo;
        private Plataforma plataforma;
        private DateTime fechaEstreno;
        private int cantidadCapitulos;
        private bool finalizada;

        public Serie(int id, string titulo, Plataforma plataforma, DateTime fechaEstreno, int cantidadCapitulos, bool finalizada)
        {
            this.id = id;
            this.titulo = titulo;
            this.plataforma = plataforma;
            this.fechaEstreno = fechaEstreno;
            this.cantidadCapitulos = cantidadCapitulos;
            this.finalizada = finalizada;
        }

        public int Id { get { return id; } }
        public string Titulo { get { return titulo; } }
        public Plataforma Plataforma { get { return plataforma; } }
        public DateTime FechaEstreno { get { return fechaEstreno; } }
        public int CantidadCapitulos { get { return cantidadCapitulos; } }
        public bool Finalizada { get { return finalizada; } }
    }
}
