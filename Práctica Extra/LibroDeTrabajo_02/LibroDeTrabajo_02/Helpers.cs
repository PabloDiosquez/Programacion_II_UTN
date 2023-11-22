using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_02
{
    public static class Helpers
    {
        public static bool EsPalindromo(this string str)
        {
            if (str is null) throw new ArgumentNullException("str");

            return str.Replace(" ", "").ToLower() == str.Replace(" ", "").ToLower().RevertirStr();
        }

        public static string RevertirStr(this string str)
        {
            if (str is null) throw new ArgumentNullException("str");

            string invertido = string.Empty;

            for (int indice = str.Length - 1; indice >= 0; indice--)
            {
                invertido += str[indice];
            }
            return invertido;
        }

        public static string RevertirStrRecursivo(this string str)
        {
            // Manejo de cadena vacía
            if (string.IsNullOrEmpty(str)) return str;

            int ultimaPosicion = str.Length - 1;

            // Utilizar StringBuilder para mejorar rendimiento
            StringBuilder reversedString = new StringBuilder();
            reversedString.Append(str[ultimaPosicion]);

            // Llamada recursiva
            reversedString.Append(RevertirStrRecursivo(str.Remove(ultimaPosicion)));

            return reversedString.ToString();
        }

        public static int ValidarNumeroEntero() 
        {
            int numeroEntero;

            while (!int.TryParse(Console.ReadLine(), out numeroEntero))
            {
                Console.WriteLine("Asegúrese de ingresar un número entero...\nIntente de nuevo.");
            }
            return numeroEntero;
        }


    }
}
