using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Universidad
    {
        public const string Nombre = "UTN - Facultad Regional Avellaneda";
        private static IEnumerable<Profesor> profesores;
        private static IEnumerable<Materia> materias;
        private static string rutaRegistroProfesores;

        static Universidad()
        {
            profesores = new List<Profesor>();
            materias = new List<Materia>();
        }




    }
}
