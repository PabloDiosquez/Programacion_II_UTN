using System;

namespace LibroDeTrabajo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
        }

        // Ejercicio 1.
        //Escriba un programa de aplicación que lea una palabra y determine si es un palíndromo.
        //(Ej: “abbccd” y “dccbba” son palíndromos).

        static Predicate<string> esPalindromo = str => str.EsPalindromo();

    }
}
