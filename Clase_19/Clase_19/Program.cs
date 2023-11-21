using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Clase_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task hilo = Task.Run(EjecutarTareasSincronico);

            EjecutarTareasEnParalelo();

            hilo.Wait();

            Console.WriteLine("Se ejecutaron todas las tareas...");
        }

        public static void EjecutarTareasEnParalelo()
        {
            Queue<Action> tareas = new Queue<Action>();

            tareas.Enqueue(() => EjecutarTarea("Tarea A en paralelo"));
            tareas.Enqueue(() => EjecutarTarea("Tarea B en paralelo"));
            tareas.Enqueue(() => EjecutarTarea("Tarea C en paralelo"));
            tareas.Enqueue(() => EjecutarTarea("Tarea D en paralelo"));

            foreach (Action tarea in tareas)
            {
                Task.Run(tarea);
            }
        }

        public static void EjecutarTareasSincronico()
        {
            Queue<Action> tareas = new Queue<Action>();

            tareas.Enqueue(() => EjecutarTarea("A"));
            tareas.Enqueue(() => EjecutarTarea("B"));
            tareas.Enqueue(() => EjecutarTarea("C"));
            tareas.Enqueue(() => EjecutarTarea("D"));

            foreach (Action tarea in tareas)
            {
                tarea();
            }
        }

        public static void EjecutarTarea(string codigo) 
        {
            int tiempoEjecucion = new Random().Next(1000, 5000);

            Thread.Sleep(tiempoEjecucion);

            Console.WriteLine($"{DateTime.Now:T} - 'Tarea {codigo}' completada en {tiempoEjecucion}ms");
        }
    }
}
