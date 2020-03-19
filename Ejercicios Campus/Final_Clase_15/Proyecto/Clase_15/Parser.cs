using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15
{
    class Parser
    {
        static string messageCatch;
        static Parser()
        {
            Parser.messageCatch = "El string no podrá ser convertido";
        }
        public static bool TryParse(string dato, out int salida)
        {
            try
            {
                salida = Parse(dato);
                return true;
            }
            catch (Exception e)
            {
                throw new ErrorParserException(messageCatch, e);
            }
        }
        public static int Parse(string dato)
        {
            try
            {
                return Int32.Parse(dato);
            }
            catch (FormatException e)
            {
                throw new ErrorParserException(messageCatch + " por error de formato.", e);
            }
            catch (OverflowException e)
            {
                throw new ErrorParserException(messageCatch + " por tamaño del dato.", e);
            }
            catch (Exception e)
            {
                throw new ErrorParserException(messageCatch, e);
            }
        }
    }
}
