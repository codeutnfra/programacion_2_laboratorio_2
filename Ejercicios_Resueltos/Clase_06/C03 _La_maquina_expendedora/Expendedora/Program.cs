using System;
using System.Collections.Generic;

namespace Expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Parte UNO
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();

            maquinaExpendedora.Add(1, "Papas");
            maquinaExpendedora.Add(2, "Saladix");
            maquinaExpendedora.Add(3, "Alfajor");
            maquinaExpendedora.Add(4, "Oreo");
            maquinaExpendedora.Add(5, "Chocolate");
            maquinaExpendedora.Add(6, "7up");
            maquinaExpendedora.Add(7, "Fanta");
            maquinaExpendedora.Add(8, "Cereales");
            maquinaExpendedora.Add(9, "Mani con chocolate");
            maquinaExpendedora.Add(10, "Agua");

           Console.BackgroundColor = ConsoleColor.DarkGreen;
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("Bienvenido: \n\n");
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Gray;
           int entradaUsuario = 1;
           string entradaUsuarioString = "";

            while (entradaUsuarioString != "S" && maquinaExpendedora.Count > 0)
            {
                foreach (KeyValuePair<int, string> producto in maquinaExpendedora)
                {
                    Console.WriteLine($"Posicion: {producto.Key} - Producto: {producto.Value}");
                }
               Console.ForegroundColor = ConsoleColor.Blue;
               Console.WriteLine("Elija su producto o presione S para salir: \n");
               Console.ForegroundColor = ConsoleColor.Gray;
               entradaUsuarioString = Console.ReadLine();
                if (int.TryParse(entradaUsuarioString, out entradaUsuario) && maquinaExpendedora.ContainsKey(entradaUsuario))
                {
                    Console.WriteLine($"Eligió el producto : {maquinaExpendedora[entradaUsuario]}\n");
                    maquinaExpendedora.Remove(entradaUsuario);
                }
                else if(entradaUsuarioString != "S")
               {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Elija una opción correcta");
                   Console.ForegroundColor = ConsoleColor.Gray;
               }
            }

            Console.WriteLine("Gracias, vuelva prontos!");

            
            //---------------------------------------------------------------------------------------------------------
            //Parte DOS

            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();

           maquinaExpendedora.Add(1, new Producto("Papas",25.50));
           maquinaExpendedora.Add(2, new Producto("Saladix",90));
           maquinaExpendedora.Add(3, new Producto("Alfajor",15));
           maquinaExpendedora.Add(4, new Producto("Oreo",100));
           maquinaExpendedora.Add(5, new Producto("Chocolate",56));
           maquinaExpendedora.Add(6, new Producto("7up",80.90));
           maquinaExpendedora.Add(7, new Producto("Fanta",45));
           maquinaExpendedora.Add(8, new Producto("Cereales",78));
           maquinaExpendedora.Add(9, new Producto("Mani con chocolate",45));
           maquinaExpendedora.Add(10, new Producto("Agua",30));

           Console.BackgroundColor = ConsoleColor.DarkGreen;
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("Bienvenido: \n\n");
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Gray;
           int entradaUsuario = 1;
           string entradaUsuarioString = "";

           while (entradaUsuarioString != "S" && maquinaExpendedora.Count > 0)
           {
               foreach (KeyValuePair<int, Producto> producto in maquinaExpendedora)
               {
                   Console.WriteLine($"Posicion: {producto.Key} - Producto: {producto.Value.Nombre} - Precio: $ {producto.Value.Precio}");
               }
               Console.ForegroundColor = ConsoleColor.DarkBlue;
               Console.WriteLine("Elija su producto o presione S para salir: \n");
               Console.ForegroundColor = ConsoleColor.Gray;
               entradaUsuarioString = Console.ReadLine();
               if (int.TryParse(entradaUsuarioString, out entradaUsuario) && maquinaExpendedora.ContainsKey(entradaUsuario))
               {
                   Console.WriteLine($"Eligió el producto : {maquinaExpendedora[entradaUsuario].Nombre}, " +
                       $"que sale ${maquinaExpendedora[entradaUsuario].Precio}\n");
                   maquinaExpendedora.Remove(entradaUsuario);
               }
               else if (entradaUsuarioString != "S")
               {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Elija una opción correcta");
                   Console.ForegroundColor = ConsoleColor.Gray;
               }
           }

           Console.WriteLine("Gracias, vuelva prontos!");

            
           //---------------------------------------------------------------------------------------------------------
           //Parte TRES

           Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

           Stack<Producto> papasFritas = new Stack<Producto>();
           papasFritas.Push(new Producto("Papas Fritas", 25.50));
           papasFritas.Push(new Producto("Papas Fritas", 25.50));
           papasFritas.Push(new Producto("Papas Fritas", 25.50));
           papasFritas.Push(new Producto("Papas Fritas", 25.50));

           Stack<Producto> galletitas = new Stack<Producto>();
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));

           Stack<Producto> bebidas = new Stack<Producto>();
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));

           maquinaExpendedora.Add(1,papasFritas);
           maquinaExpendedora.Add(2, galletitas);
           maquinaExpendedora.Add(3, bebidas);

           Console.BackgroundColor = ConsoleColor.DarkGreen;
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("Bienvenido: \n\n");
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Gray;
           int entradaUsuario = 1;
           string entradaUsuarioString = "";

           while ( maquinaExpendedora.Count > 0 && entradaUsuarioString != "S")
           {

               foreach (KeyValuePair<int, Stack<Producto>> estante in maquinaExpendedora)
               {
                   Console.WriteLine($"{estante.Key} - Producto: {estante.Value.Peek().Nombre} " +
                       $"- Precio: $ {estante.Value.Peek().Precio} - Cantidad {estante.Value.Count}");
               }
               Console.ForegroundColor = ConsoleColor.Blue;
               Console.WriteLine("Elija su producto o presione S para salir: \n");
               Console.ForegroundColor = ConsoleColor.Gray;
               entradaUsuarioString = Console.ReadLine();
               if (int.TryParse(entradaUsuarioString, out entradaUsuario) && maquinaExpendedora.ContainsKey(entradaUsuario))
               {
                   Producto productoElegido = maquinaExpendedora[entradaUsuario].Pop();
                   Console.WriteLine($"Se eligió el producto : {productoElegido.Nombre}, " +
                       $"que sale ${productoElegido.Precio}. Y su codigo es {productoElegido.Codigo}\n");
                   if(maquinaExpendedora[entradaUsuario].Count==0)
                   {
                       maquinaExpendedora.Remove(entradaUsuario);
                   }
               }
               else if (entradaUsuarioString != "S")
               {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Elija una opción correcta");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
           }

           Console.WriteLine("Gracias, vuelva prontos!");
           
            
           //---------------------------------------------------------------------------------------------------------
           //Parte CUATRO
           Queue<string> filaDeClientes = new Queue<string>();

           filaDeClientes.Enqueue("Nacho");
           filaDeClientes.Enqueue("Esteban");
           filaDeClientes.Enqueue("Lucas");
           filaDeClientes.Enqueue("Ornella");
           filaDeClientes.Enqueue("Juan");

            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

           Stack<Producto> papasFritas = new Stack<Producto>();
           papasFritas.Push(new Producto("Papas Fritas", 25.50));
           papasFritas.Push(new Producto("Papas Fritas", 25.50));
           papasFritas.Push(new Producto("Papas Fritas", 25.50));
           papasFritas.Push(new Producto("Papas Fritas", 25.50));

           Stack<Producto> galletitas = new Stack<Producto>();
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));
           galletitas.Push(new Producto("Oreo", 100));

           Stack<Producto> bebidas = new Stack<Producto>();
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));
           bebidas.Push(new Producto("Agua", 50));

           maquinaExpendedora.Add(1,papasFritas);
           maquinaExpendedora.Add(2, galletitas);
           maquinaExpendedora.Add(3, bebidas);

           Console.BackgroundColor = ConsoleColor.DarkGreen;
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("Bienvenido: \n\n");
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Gray;
           int entradaUsuario = 1;
           string entradaUsuarioString = "";

           while (filaDeClientes.Count > 0 && maquinaExpendedora.Count > 0 && entradaUsuarioString != "S")
           {
               string clienteAtendido = filaDeClientes.Peek();

               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Console.WriteLine($"El cliente atendido es: {clienteAtendido} - Quedan {filaDeClientes.Count} en fila");
               Console.ForegroundColor = ConsoleColor.Gray;
               foreach (KeyValuePair<int, Stack<Producto>> estante in maquinaExpendedora)
               {
                   Console.WriteLine($"{estante.Key} - Producto: {estante.Value.Peek().Nombre} " +
                       $"- Precio: $ {estante.Value.Peek().Precio} - Cantidad {estante.Value.Count}");
               }
               Console.ForegroundColor = ConsoleColor.Blue;
               Console.WriteLine("Elija su producto o presione S para salir: \n");
               Console.ForegroundColor = ConsoleColor.Gray;
               entradaUsuarioString = Console.ReadLine();
               if (int.TryParse(entradaUsuarioString, out entradaUsuario) && maquinaExpendedora.ContainsKey(entradaUsuario))
               {
                   Producto productoElegido = maquinaExpendedora[entradaUsuario].Pop();
                   Console.WriteLine($"{clienteAtendido} eligió el producto : {productoElegido.Nombre}, " +
                       $"que sale ${productoElegido.Precio}. Y su codigo es {productoElegido.Codigo}\n");
                   if(maquinaExpendedora[entradaUsuario].Count==0)
                   {
                       maquinaExpendedora.Remove(entradaUsuario);
                   }
                   filaDeClientes.Dequeue();
               }
               else if (entradaUsuarioString != "S")
               {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Elija una opción correcta");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

               if(filaDeClientes.Count==0)
               {
                   Console.WriteLine("Llegamos al final de la lista. Desea agregar mas clientes? S (si) o N (no)");
                   string entradaUsuarioConfirmacion = Console.ReadLine();
                   if(entradaUsuarioConfirmacion.ToLower()=="s")
                   {
                       Console.WriteLine("Cuantos clientes desea agregar: ");
                       if(int.TryParse(Console.ReadLine(), out entradaUsuario))
                       {
                           Console.WriteLine($"Se agregarán {entradaUsuario} clientes");
                           for (int i = 0; i < entradaUsuario; i++)
                           {
                               Console.WriteLine("Ingrese el nombre del cliente: ");
                               filaDeClientes.Enqueue(Console.ReadLine());
                           }
                       }
                   }
               }
           }

           Console.WriteLine("Gracias, vuelva prontos!");
            
           //---------------------------------------------------------------------------------------------------------
           //Parte CINCO
           Queue<string> filaDeClientes = new Queue<string>();

           filaDeClientes.Enqueue("Nacho");
           filaDeClientes.Enqueue("Esteban");
           filaDeClientes.Enqueue("Lucas");
           filaDeClientes.Enqueue("Juanse");
           filaDeClientes.Enqueue("Ornella");

           List<Producto> mesaBuffet = new List<Producto>();
           List<Producto> pedido = new List<Producto>();

           mesaBuffet.Add(new Producto("Ensalada", 60, 10));
           mesaBuffet.Add(new Producto("Hamburguesa", 80, 5));
           mesaBuffet.Add(new Producto("Yogur", 16, 3));
           mesaBuffet.Add(new Producto("Bebida", 50, 10));
           mesaBuffet.Add(new Producto("Milanesa", 110, 4));
           mesaBuffet.Add(new Producto("Papas", 150, 4));
           mesaBuffet.Add(new Producto("Flan", 99, 10));
           mesaBuffet.Add(new Producto("Ensalada de Frutas",45, 3));
           mesaBuffet.Add(new Producto("Torta", 115, 10));

           Console.WriteLine("Bienvenido: ");
           int entradaUsuario = 1;


           while (filaDeClientes.Count > 0 && mesaBuffet.Count > 0)
           {
               string entradaUsuarioString = "";
               string clienteAtendido = filaDeClientes.Peek();
                double acumulador = 0;
                

               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Console.WriteLine($"El cliente atendido es: {clienteAtendido} - Quedan {filaDeClientes.Count} en fila");
               Console.ForegroundColor = ConsoleColor.Gray;

               while (entradaUsuarioString != "S")
               {
                    
                    int indice = 1;
                   foreach (Producto producto in mesaBuffet)
                   {
                       Console.WriteLine($"{indice} - {producto.Nombre} " +
                           $"- Precio: $ {producto.Precio} - Cantidad {producto.Cantidad}");
                       indice++;
                   }
                   Console.WriteLine("Elija su producto o presione S para terminar su compra: \n");
                   entradaUsuarioString = Console.ReadLine();
                   if (int.TryParse(entradaUsuarioString, out entradaUsuario) && entradaUsuario <= mesaBuffet.Count)
                   {
                       pedido.Add(mesaBuffet[entradaUsuario-1]);
                       mesaBuffet[entradaUsuario-1].Cantidad--;
                       Console.WriteLine($"{clienteAtendido} eligió los siguientes productos: \n");
                       acumulador = 0;
                       foreach (Producto item in pedido)
                       {
                           acumulador += item.Precio;
                           Console.WriteLine($"- {item.Nombre} - ${item.Precio}");
                       }
                       Console.WriteLine($"Total: ${acumulador}\n\n");
                   }else if(entradaUsuarioString != "S")
                   {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("Ingrese una opción valida:\n");
                       Console.ForegroundColor = ConsoleColor.Gray;
                   }                   
               }
               Console.WriteLine($"Terminó el turno de {clienteAtendido} y su total es de ${acumulador}");
               pedido.Clear();
               filaDeClientes.Dequeue();

               if (filaDeClientes.Count == 0)
               {
                   Console.WriteLine("Llegamos al final de la lista. Desea agregar mas clientes? S (si) o N (no)");
                   string entradaUsuarioConfirmacion = Console.ReadLine();
                   if (entradaUsuarioConfirmacion.ToLower() == "s")
                   {
                       Console.WriteLine("Cuantos clientes desea agregar: ");
                       if (int.TryParse(Console.ReadLine(), out entradaUsuario))
                       {
                           Console.WriteLine($"Se agregarán {entradaUsuario} clientes");
                           for (int i = 0; i < entradaUsuario; i++)
                           {
                               Console.WriteLine("Ingrese el nombre del cliente: ");
                               filaDeClientes.Enqueue(Console.ReadLine());
                           }
                       }
                   }
               }
           }

           Console.WriteLine("Gracias, vuelva prontos!");
         */  
        }
    }
   
}
