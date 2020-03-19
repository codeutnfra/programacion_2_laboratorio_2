using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int numero = Parser.Parse("a");
                //int numero = Parser.Parse("999999999999999999");
                int numero = Parser.Parse("9999");
                Console.WriteLine("Conversión exitosa: "+numero);
            }
            catch (ErrorParserException e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
