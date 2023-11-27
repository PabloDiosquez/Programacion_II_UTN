using System;
using System.Collections.Generic;

namespace LibroDeTrabajo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Helpers.EsPalindromo("anita lava la tina"));
        }

        // Ejercicio 1.
        // Escriba un programa de aplicación que reciba una lista de palabras e informe cuáles son palíndromos usando una 
        // función.

        public static List<string> FiltrarPalindromos(List<string> palabras) 
        {
            List<string> palindromos = new List<string>();

            foreach (string palabra in palabras) 
            {
                if(palabra.EsPalindromo()) palabras.Add(palabra);   
            }
            return palindromos;
        }
    }
}
