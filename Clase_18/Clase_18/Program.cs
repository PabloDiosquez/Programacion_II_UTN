using System;
using System.Collections.Generic;
using System.Threading;

namespace Clase_18
{
    /// <summary>
    /// Clase principal del programa que demuestra el uso de delegados.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Definición del objeto delegado.
        /// </summary>
        public delegate void ObjetoDelegado(string mensaje);

        /// <summary>
        /// Método principal de la aplicación.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos.</param>
        static void Main(string[] args)
        {
            // ... (comentarios para el código restante)

            // ####################################  🎀  #################################### //

            // Instancio dos receptores...

            //Receptor receptorA = new Receptor("Receptor A");

            //Receptor receptorB = new Receptor("Receptor B");

            //// Instancio una emisor...

            //Emisor emisor = new Emisor();

            //// Agrego los receptores a la lista del emisor...

            //emisor.AgregarDestinatario(receptorA.RecibirNotificacion);

            //emisor.AgregarDestinatario(receptorB.RecibirNotificacion);

            //emisor.AgregarDestinatario(CambiarColorConsola);

            //emisor.AgregarDestinatario(Notificar);

            //// Invoco al método EmitirNotificacion() del emisor...

            //emisor.EmitirNotificacion();

            // ####################################  🎀  #################################### //

            List<int> numeros = new List<int>() { 1, 43, -12, 6, -87, 101 };

            ImprimirLista<int>(numeros.Filtar<int>(numero => numero % 2 == 0));

            Console.WriteLine();

            ImprimirLista<int>(numeros.Filtar<int>(numero => numero >= 0));

        }

        /// <summary>
        /// Imprime los elementos de una lista.
        /// </summary>
        /// <typeparam name="T">Tipo de elementos en la lista.</typeparam>
        /// <param name="lista">Lista a imprimir.</param>
        public static void ImprimirLista<T>(List<T> lista)
        {
            foreach (T elemento in lista)
            {
                Console.WriteLine(elemento.ToString());
            }
        }

        /// <summary>
        /// Envia una notificación.
        /// </summary>
        public static void Notificar()
        {
            Console.WriteLine("Enviado notificación a Lio Messi...");
        }

        /// <summary>
        /// Cambia el color de la consola a rojo.
        /// </summary>
        public static void CambiarColorConsola()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
