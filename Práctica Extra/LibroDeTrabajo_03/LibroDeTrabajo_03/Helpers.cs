using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    public static class Helpers
    {
        public static bool EsPalindromo(string str) 
        {
            return string.Join(string.Empty, str.Split(' ', StringSplitOptions.RemoveEmptyEntries)) == InvertirTexto(str);
        }

        private static string InvertirTexto(string str)
        {
            string[] palabras = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return InvertirCaracteres(string.Join(string.Empty, palabras));
        }

        private static string InvertirCaracteres(string str) 
        {
            if (str is null) throw new ArgumentNullException(nameof(str));

            string strInvertido = string.Empty;

            foreach (char caracter in str)
            {
                strInvertido = caracter + strInvertido; 
            }
            return strInvertido;
        }
    }
}
