using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    /// <summary>
    /// Delegado para funciones de comparación de textos.
    /// </summary>
    /// <param name="primerTexto">Primer texto a comparar.</param>
    /// <param name="segundoTexto">Segundo texto a comparar.</param>
    /// <returns>Resultado de la comparación.</returns>
    public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

    class Program
    {
        /// <summary>
        /// Entrada principal del programa.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos.</param>
        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola.
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/

            Console.WriteLine($"{Environment.NewLine}1era Comparación - Texto con más caracteres:");
            Comparar(primerTexto, segundoTexto, (p, s) => p.Length - s.Length);

            Console.WriteLine($"{Environment.NewLine}2da Comparación - Texto con más palabras:");
            Comparar(primerTexto, segundoTexto, (p, s) => (p.Split(' ', StringSplitOptions.RemoveEmptyEntries)).Length - (s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length));

            Console.WriteLine($"{Environment.NewLine}3era Comparación - Texto con más vocales:");
            Comparar(primerTexto, segundoTexto, (p, s) => ContarVocales(p) - ContarVocales(s));

            Console.WriteLine($"{Environment.NewLine}4ta Comparación - Texto con más signos de puntuación:");
            Comparar(primerTexto, segundoTexto, (p, s) => ContarSignosPuntuacion(p) - ContarSignosPuntuacion(s));
        }

        /// <summary>
        /// Realiza la comparación de dos textos utilizando un delegado de comparación.
        /// </summary>
        /// <param name="primerTexto">Primer texto a comparar.</param>
        /// <param name="segundoTexto">Segundo texto a comparar.</param>
        /// <param name="comparacion">Delegado de comparación.</param>
        public static void Comparar(string primerTexto, string segundoTexto, DelegadoComparacion comparacion)
        {
            switch (comparacion(primerTexto, segundoTexto))
            {
                case > 0:
                    Console.WriteLine("El primer texto es MAYOR que el segundo.");
                    break;
                case < 0:
                    Console.WriteLine("El segundo texto es MAYOR que el primero.");
                    break;
                default:
                    Console.WriteLine("El primer texto es IGUAL al segundo.");
                    break;
            }
        }

        /// <summary>
        /// Cuenta la cantidad de vocales en un texto.
        /// </summary>
        /// <param name="texto">Texto en el que contar las vocales.</param>
        /// <returns>Número de vocales en el texto.</returns>
        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
        {
            'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
            'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
            'u', 'ú', 'U', 'Ú'
        };

            return ContarCaracteres(texto, vocales);
        }

        /// <summary>
        /// Cuenta la cantidad de signos de puntuación en un texto.
        /// </summary>
        /// <param name="texto">Texto en el que contar los signos de puntuación.</param>
        /// <returns>Número de signos de puntuación en el texto.</returns>
        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
        {
            '.', ';', ','
        };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        /// <summary>
        /// Cuenta la cantidad de caracteres específicos en un texto.
        /// </summary>
        /// <param name="texto">Texto en el que contar los caracteres.</param>
        /// <param name="caracteres">Lista de caracteres a contar.</param>
        /// <returns>Número de caracteres en el texto.</returns>
        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }
    }
}
