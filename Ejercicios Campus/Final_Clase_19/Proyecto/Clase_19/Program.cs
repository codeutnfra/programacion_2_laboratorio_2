using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_8_Library;
using Archivos;

namespace Clase_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("José", "Pérez", "000-001", Empleado.EPuestoJerarquico.Gerencia, 45000);

            Console.WriteLine("XML");
            Xml<Empleado> xml = new Xml<Empleado>();
            if (!xml.guardar("Empleado.xml", e1))
                Console.WriteLine("Error al guardar XML");

            Empleado e2;
            if (!xml.leer("Empleado.xml", out e2))
                Console.WriteLine("Error al leer XML");
            else
                Console.WriteLine(e2.ToString());

            Console.WriteLine("<----------------->");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("TXT");
            Texto txt = new Texto();
            if (!txt.guardar("Empleado.txt", e1.ToString()))
                Console.WriteLine("Error al guardar TXT");

            string datos;
            if (!txt.leer("Empleado.txt", out datos))
                Console.WriteLine("Error al leer TXT");
            else
                Console.WriteLine(datos);

            Console.WriteLine("<----------------->");
            Console.ReadKey();
        }
    }
}
