using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[20];
            Random rdn = new Random();

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = rdn.Next(-100, 100);
            }
            Console.WriteLine("Array original");
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, arrayNumeros[i]);

            }
            Console.WriteLine("positivos ordenados en forma decreciente.");
            Array.Sort(arrayNumeros, Program.OrdenDescendente);
            for (int i = 0; i < arrayNumeros.Length; i++)
            {

                if (arrayNumeros[i] > 0)
                    Console.WriteLine("{0} : {1}", i, arrayNumeros[i]);
            }
            Console.WriteLine("negativos ordenados en forma creciente.");
            Array.Sort(arrayNumeros);
            for (int i = 0; i < arrayNumeros.Length; i++)
            {

                if (arrayNumeros[i] < 0)
                    Console.WriteLine("{0} : {1}", i, arrayNumeros[i]);
            }

        }
        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
       
    }
}
