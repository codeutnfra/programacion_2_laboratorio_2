
using System;
using System.Threading;
using System.Threading.Tasks;

class EjemploHilos
{
    static void Main()
    {
        Action accion = () =>
        {
            Thread.Sleep(new Random().Next(1000, 5000));
            Console.WriteLine($"{DateTime.Now}: Task ID={Task.CurrentId}, Hilo secundario={Thread.CurrentThread.ManagedThreadId}");
        };

        // Instancia e inicia una tarea. Utilizando expresiones lambda.
        Task tarea = Task.Run(accion);
        Task otraTarea = Task.Run(accion);

        Console.WriteLine($"{DateTime.Now}: Las tareas comenzaron a ejecutarse. Hilo principal={Thread.CurrentThread.ManagedThreadId}");

        // Bloquea el hilo hasta que finaliza la tarea.
        Task.WaitAll(tarea, otraTarea);

        Console.WriteLine($"{DateTime.Now}: Las tareas finalizaron. Hilo principal={Thread.CurrentThread.ManagedThreadId}");
    }
}
