using System.Drawing;
using System.Text.Json.Serialization;

namespace Vista
{
    public class Cartel
    {
        private int colorARGB;

        public int ColorARGB
        {
            get { return colorARGB; }
            set { colorARGB = value; }
        }

        private Texto titulo;

        public Texto Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private Texto mensaje;

        public Texto Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        
        public Cartel(int colorARGB, Texto titulo, Texto mensaje)
        {
            ColorARGB = colorARGB;
            Titulo = titulo;
            Mensaje = mensaje;
        }
    }
}
