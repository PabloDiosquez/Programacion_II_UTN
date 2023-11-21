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
            Task hilo = new Task(() => EjecutarTareasSincronico());

            hilo.Start();

            EjecutarEnParalelo();

            hilo.Wait();

            Console.WriteLine("Se ejecutaron todas las tareas...");
        }

        public static void EjecutarEnParalelo()
        {
            Task hilo1 = new Task(() => EjecutarTarea("A en paralelo"));
            hilo1.Start();

            Task hilo2 = new Task(() => EjecutarTarea("B en paralelo"));
            hilo2.Start();
        }

        public static void EjecutarTareasSincronico()
        {
            Queue<Action> tareas = new Queue<Action>();

            tareas.Enqueue(() => EjecutarTarea("A"));
            tareas.Enqueue(() => EjecutarTarea("B"));
            tareas.Enqueue(() => EjecutarTarea("C"));
            tareas.Enqueue(() => EjecutarTarea("D"));
            tareas.Enqueue(() => EjecutarTarea("E"));
            tareas.Enqueue(() => EjecutarTarea("F"));
            tareas.Enqueue(() => EjecutarTarea("G"));
            tareas.Enqueue(() => EjecutarTarea("H"));

            foreach (Action tarea in tareas)
            {
                tarea();
            }
        }

        public static void EjecutarTarea(string codigo) 
        {
            int tiempoEjecucion = new Random().Next(1000, 5000);

            Thread.Sleep(tiempoEjecucion);

            Console.WriteLine($"'Tarea {codigo}' ejecutada en {tiempoEjecucion}ms");
        }
    }
}
