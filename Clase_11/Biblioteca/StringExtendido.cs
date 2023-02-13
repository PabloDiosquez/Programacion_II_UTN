using System;

namespace Biblioteca
{
    public static class StringExtendido
    {
        public static int ContarPalabras(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException();
            }
            return str.Split(new char[] { ' ', '-'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
