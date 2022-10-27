namespace Expendedora
{
    public class Producto
    {
        private string nombre;
        private double precio;
        private  int codigo; //Este atributo se agrega en la parte TRES
        private static int ultimoCodigo; //Este atributo se agrega en la parte TRES
        private int cantidad; //Este atributo se agrega en la parte CINCO

        static Producto()
        {
            ultimoCodigo = 1000; //Este codigo se ejecuta SOLO UNA VEZ y nos sirve de punto de partida
        }

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;     
            this.codigo = ultimoCodigo; //Esta asignacion se agrega en la parte TRES
            ultimoCodigo++; //Este comando se ejecuta en parte TRES
        }

        public Producto (string nombre,double precio,int cantidad):this(nombre,precio)
        {
            this.cantidad = cantidad; //Esta sobrecarga se crea para el punto CINCO
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Codigo { get => codigo; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}