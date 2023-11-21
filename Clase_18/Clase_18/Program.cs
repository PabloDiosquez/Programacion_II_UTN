using System;
using System.Threading;

namespace Clase_18
{
    /// <summary>
    /// Clase principal del programa que demuestra el uso de delegados.
    /// </summary>
    public class Program
    {
        // Definición del objeto delegado
        public delegate void ObjetoDelegado(string mensaje);

        /// <summary>
        /// Método principal de la aplicación.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos.</param>
        static void Main(string[] args)
        {
            // Creación de una instancia del objeto delegado y asignación del método MensajeBienvenida.Saludar
            ObjetoDelegado saludo = new ObjetoDelegado(MensajeBienvenida.Saludar);

            // Puedes asignar otro método al objeto delegado en cualquier momento
            // ObjetoDelegado despedida = new ObjetoDelegado(MensajeDespedida.Saludar);

            // Llamada al método asociado al objeto delegado (MensajeBienvenida.Saludar)
            //saludo("Bienvenido...");

            // Asignación del método MensajeDespedida.Saludar al objeto delegado
            //saludo = MensajeDespedida.Saludar;

            // Pausa la ejecución durante 3 segundos (3000 milisegundos)
            //Thread.Sleep(3000);

            // Llamada al método asociado al objeto delegado (MensajeDespedida.Saludar)
            //saludo("Hasta luego...");

            Temporizador.EsperarYDisparar(5000, saludo);
        }
    }

    /// <summary>
    /// Clase que proporciona un mensaje de bienvenida.
    /// </summary>
    public class MensajeBienvenida
    {
        /// <summary>
        /// Método estático que imprime un mensaje de bienvenida en la consola.
        /// </summary>
        /// <param name="mensaje">Mensaje a imprimir.</param>
        public static void Saludar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

    /// <summary>
    /// Clase que proporciona un mensaje de despedida.
    /// </summary>
    public class MensajeDespedida
    {
        /// <summary>
        /// Método estático que imprime un mensaje de despedida en la consola.
        /// </summary>
        /// <param name="mensaje">Mensaje a imprimir.</param>
        public static void Saludar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
