﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class StringExtension
    {
        public static int ContadorDeVocales(string texto)
        {
            char[] vocales = {'a', 'e', 'i', 'o', 'u'};

            int cont = 0;

            if (!string.IsNullOrEmpty(texto))
            {
                foreach (char caracter in texto.ToLower())
                {
                    if (vocales.Contains(caracter))
                    {
                        cont++;
                    }
                }
            }

            return cont;
        }
    }
}
