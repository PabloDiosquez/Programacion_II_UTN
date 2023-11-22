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
    }
}
