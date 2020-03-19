using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_8_Library;
using Clase_18_Library;

namespace Clase_18_Console
{
    class Vista : IGrafica
    {
        public void Main(string[] args)
        {
            Empleado empleado = new Empleado("Jorge", "Martínez", "123-456", Empleado.EPuestoJerarquico.Sistemas, 15000);
            empleado.Mostrar(this);

            Console.ReadKey();
        }

        #region IGrafica Members

        public void MostrarEnGUI(string datos)
        {
            Console.WriteLine(datos);
        }

        #endregion
    }
}
