using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Clase_19
{
    /// <summary>
    /// Clase principal que contiene el método de entrada Main y otros métodos relacionados con la ejecución de tareas.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Método de entrada principal del programa.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos.</param>
        static void Main(string[] args)
        {
            // Inicia dos tareas en paralelo y espera a que ambas terminen.
            Task hiloSincronico = Task.Run(EjecutarTareasSincronico);
            Task hiloParalelo = Task.Run(EjecutarTareasEnParalelo);
            Task.WaitAll(hiloSincronico, hiloParalelo);

            // Imprime un mensaje indicando que todas las tareas se han ejecutado.
            Console.WriteLine("Se ejecutaron todas las tareas...");
        }

        /// <summary>
        /// Ejecuta varias tareas en paralelo utilizando la clase Task.
        /// </summary>
        public static void EjecutarTareasEnParalelo()
        {
            // Cola de acciones que representan las tareas a ejecutar en paralelo.
            Queue<Action> tareas = new Queue<Action>();
            tareas.Enqueue(() => EjecutarTarea("Tarea A en paralelo"));
            tareas.Enqueue(() => EjecutarTarea("Tarea B en paralelo"));
            tareas.Enqueue(() => EjecutarTarea("Tarea C en paralelo"));
            tareas.Enqueue(() => EjecutarTarea("Tarea D en paralelo"));

            // Ejecuta cada tarea en un hilo separado utilizando Task.Run.
            foreach (Action tarea in tareas)
            {
                Task.Run(tarea);
            }
        }

        /// <summary>
        /// Ejecuta varias tareas de forma sincrónica (una tras otra).
        /// </summary>
        public static void EjecutarTareasSincronico()
        {
            // Cola de acciones que representan las tareas a ejecutar de forma sincrónica.
            Queue<Action> tareas = new Queue<Action>();
            tareas.Enqueue(() => EjecutarTarea("A"));
            tareas.Enqueue(() => EjecutarTarea("B"));
            tareas.Enqueue(() => EjecutarTarea("C"));
            tareas.Enqueue(() => EjecutarTarea("D"));

            // Ejecuta cada tarea de forma sincrónica.
            foreach (Action tarea in tareas)
            {
                tarea();
            }
        }

        /// <summary>
        /// Ejecuta una tarea simulada que toma un tiempo aleatorio para completarse.
        /// </summary>
        /// <param name="codigo">Código identificador de la tarea.</param>
        public static void EjecutarTarea(string codigo)
        {
            // Genera un tiempo de ejecución aleatorio entre 1000 y 5000 milisegundos.
            int tiempoEjecucion = new Random().Next(1000, 5000);

            // Simula la ejecución de la tarea mediante un retraso.
            Thread.Sleep(tiempoEjecucion);

            // Imprime información sobre la tarea completada.
            Console.WriteLine($"{DateTime.Now:T} - 'Tarea {codigo}' completada en {tiempoEjecucion}ms -- Hilo: {Task.CurrentId}");
        }
    }
}
