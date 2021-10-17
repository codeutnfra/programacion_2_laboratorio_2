using System;

namespace Entidades
{
    public class Profesor
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private DateTime fechaInicioActividad;
        private bool enActividad;


        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Legajo
        {
            get
            {
                return legajo;
            }
        }

        public DateTime FechaInicioActividad
        {
            get
            {
                return fechaInicioActividad;
            }
        }

        public bool EnActividad
        {
            get
            {
                return enActividad;
            }
            set
            {
                enActividad = value;
            }
        }

        public Profesor(string nombre, string apellido, int legajo, DateTime fechaInicioActividad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.fechaInicioActividad = fechaInicioActividad;
        }
    }
}
