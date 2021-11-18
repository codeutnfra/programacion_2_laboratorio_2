using System;

namespace Entidades
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public DateTime FechaFin
        {
            get
            {
                return fechaFin;
            }
            set
            {
                fechaFin = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                fechaInicio = value;
            }
        }

        public double TiempoTotal
        {
            get
            {
                return fechaInicio.CalcularDiferenciaEnSegundos(fechaFin);
            }
        }
               
        public Salida()
        {
            fechaInicio = DateTime.Now;
        }

        public void FinalizarSalida()
        {
            fechaFin = DateTime.Now;
        }
    }
}
