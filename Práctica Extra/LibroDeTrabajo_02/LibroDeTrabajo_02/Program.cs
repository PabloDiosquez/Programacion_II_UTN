using System;

namespace LibroDeTrabajo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra = "eeeiiioouuffaa";

            foreach (string par in cantidadVocales(palabra))
            {
                Console.WriteLine(par);
            }
        }

        // Ejercicio 1.
        //Escriba un programa de aplicación que lea una palabra y determine si es un palíndromo.
        //(Ej: “abbccd” y “dccbba” son palíndromos).

        static Predicate<string> esPalindromo = str => str.EsPalindromo();

        // Ejercicio 2.
        //Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía.
        //Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de
        //caracteres por palabra

        static Func<string, char, bool> comienzaCon = (str, caracter) => !string.IsNullOrEmpty(str) && str[0] == caracter;

        public static void LeerPalabrasYDeterminarPorcentaje()
        {
            try
            {
                int totalPalabras = 0;
                int totalPalabrasComienzanConS = 0;

                while (true)
                {
                    Console.WriteLine("Ingrese una palabra (presione Enter para finalizar):");

                    string palabra = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(palabra)) break;

                    totalPalabras++;

                    if (comienzaCon(palabra, 's')) totalPalabrasComienzanConS++;

                }

                if (totalPalabras == 0) Console.WriteLine("No se ingresaron palabras. 🥴");
                else
                {
                    double porcentaje = (double)totalPalabrasComienzanConS / totalPalabras * 100;
                    Console.WriteLine($"Porcentaje de palabras que comienzan con 's': {porcentaje.ToString("0.00")}%");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Algo salió mal... {ex.Message}");
            }

        }

        // Ejercicio 3.
        //Defina una función que reciba una palabra y retorne en un vector la cantidad de cada una de las vocales que
        //contiene.

        static Func<string, string[]> cantidadVocales = (str) => str.ContadorDeVocales();  
    }
}
