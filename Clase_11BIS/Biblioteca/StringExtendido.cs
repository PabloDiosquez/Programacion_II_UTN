using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class StringExtendido
    {
        public static int ContadorDeVocales(this string texto)
        {
            return ContarCaracteres(texto, new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'});
        }


        public static int ContarCaracter(this string texto, char caracter)
        {
            return ContarCaracteres(texto, new char[] {caracter});
        }

        private static int ContarCaracteres(string texto, char[] caracteres)
        {
            int cont = 0;

            if (!string.IsNullOrEmpty(texto))
            {
                foreach (char caracter in texto)
                {
                    if (caracteres.Contains(caracter))
                    {
                        cont++;
                    }
                }
            }

            return cont;
        }
    }
}
