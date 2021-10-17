using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class Materia
    {
        private string nombre;
        private Cuatrimestre cuatrimestre;
        private IEnumerable<Materia> materiasCorrelativas;

        /// <summary>
        /// Nombre de la materia.
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        /// <summary>
        /// Cuatrimestre de la materia.
        /// </summary>
        public Cuatrimestre Cuatrimestre
        {
            get
            {
                return cuatrimestre;
            }
        }

        /// <summary>
        /// Retorna la materia correlativa correspondiente al índice pasado como argumento.
        /// Si no hay materias en el índice retorna null. 
        /// </summary>
        /// <param name="indice">Índice de la materia correlativa.</param>
        /// <returns>Materia correlativa correspondiente al índice proporcionado.</returns>
        public Materia this[int indice]
        {
            get
            {
                if (indice >= materiasCorrelativas.Count())
                {
                    return null;
                }

                return materiasCorrelativas.ElementAt(indice);
            }
        }

        /// <summary>
        /// Constructor de materia.
        /// </summary>
        /// <param name="nombre">Nombre de la materia.</param>
        /// <param name="cuatrimestre">Cuatrimestre de la materia.</param>
        /// <param name="materiasCorrelativas">Enumerable correspondiente a las asignaturas correlativas a la materia.</param>
        public Materia(string nombre, Cuatrimestre cuatrimestre, 
            IEnumerable<Materia> materiasCorrelativas)
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            if (materiasCorrelativas is null)
            {
                this.materiasCorrelativas = new List<Materia>();
            }
            else
            {
                this.materiasCorrelativas = materiasCorrelativas;
            }
        }
    }
}
