using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;
        
        /// <summary>
        /// Retorna el tamaño de la app + tamaño ocupado por las canciones.
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                int tamanioCanciones = listaCanciones.Count * 2;

                return tamanioMb + tamanioCanciones;
            }
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial)
            :this(nombre, sistemaOperativo, tamanioInicial, new List<string>())    
        {
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            : base(nombre, sistemaOperativo, tamanioInicial)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ObtenerInformacionApp());
            stringBuilder.AppendLine($"{Environment.NewLine}Lista de canciones");

            foreach (string cancion in listaCanciones)
            {
                stringBuilder.AppendLine(cancion);
            }

            return stringBuilder.ToString();
        }
    }
}
