using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            // Se debe validar que el número sea mayor que cero, caso contrario,
            // mostrar el mensaje: "ERROR. ¡Reingresar número!".

            mostrarNumeroAlCuadYAlCubo(validarNumero());
           
        }

        // Describe un número entero que cumple con las condiciones pedidas en el ejercicio.
        private static int validarNumero()
        {
            int numero;

            Console.WriteLine("Ingrese un número natural:");
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            return numero;
        }

        // Muestra los resultados en consola.
        private static void mostrarNumeroAlCuadYAlCubo(int numero)
        {
            Console.WriteLine($"{numero} elevado al cuadrado: {cuadradoDe_(numero)}");
            Console.WriteLine($"{numero} elevado al cubo: {cuboDe_(numero)}");
        }

        /// <summary>
        /// Describe el cuadrado del número dado.
        /// </summary>
        /// <param name="numero">Número</param>
        /// <returns>Número</returns>
        private static int cuadradoDe_(int numero) 
        {
            return numero * numero;
        }

        /// <summary>
        /// Describe el cubo del número dado.
        /// </summary>
        /// <param name="numero">Número</param>
        /// <returns>Número</returns>
        private static int cuboDe_(int numero)
        {
            return numero * cuadradoDe_(numero);
        }
    }
}
