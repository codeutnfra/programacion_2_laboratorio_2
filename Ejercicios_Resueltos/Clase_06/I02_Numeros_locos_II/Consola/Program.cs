using System;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> colaPos = new Queue<int>();
            Stack<int> pilaPos = new Stack<int>();
            Queue<int> colaNeg = new Queue<int>();
            Stack<int> pilaNeg = new Stack<int>();
            
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(r.Next(-100, 100));
            }


            Console.WriteLine("Lista Original");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista Ordenada decreciente");
            lista.Sort(Program.OrdenDescendente);
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista Positivos");
            foreach (int i in lista)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    colaPos.Enqueue(i);//agrego positivo a la cola de positivos
                }
                else if (i != 0)//evito el cero
                {
                    pilaNeg.Push(i);//agrego negativos a la lista de negativos
                }
            }
            Console.WriteLine("Lista Negativos");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] > 0)
                {
                    pilaPos.Push(lista[i]);//agrego positivo a la pila de positivos
                }
                else if (i != 0)//evito el cero
                {
                    Console.WriteLine(lista[i]);
                    colaNeg.Enqueue(lista[i]);//agrego negativos a la lista de negativos
                }
            }
            Console.WriteLine(" Cola Positivos");
            foreach (int i in colaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Positivos");
            foreach (int i in pilaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Cola Negativos");
            foreach (int i in colaNeg)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Negativos");
            foreach (int i in pilaNeg)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }
    }
}
