﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C03
{
    public abstract class Helper
    {
        /// <summary>
        /// El propósito del método DeDecimalABinario es tomar un número decimal como entrada y 
        /// convertirlo en su equivalente binario. El método realiza esta conversión mediante el
        /// cálculo de los dígitos binarios del número decimal y construyendo una cadena que 
        /// representa la representación binaria del número.
        /// </summary>
        /// <param name="numeroDecimal">Este es el número decimal que se desea convertir en binario. 
        /// Es el único parámetro de entrada del método.</param>
        /// <returns>El método devuelve una cadena de caracteres (string) que resulta la representación
        /// binaria del número decimal proporcionado como entrada. Esta cadena contiene los dígitos binarios
        /// en orden correcto.</returns>
        public static string DeDecimalABinario(int numeroDecimal)
        {
            // Caso especial 
            if (numeroDecimal == 0) 
            {
                return "0";
            }

            // Inicializar una cadena de caracteres para almacenar el resultado binario.
            string resBinario = string.Empty;

            // Mientras el número decimal sea mayor que 0, continuamos dividiendo y obteniendo los dígitos binarios.
            while (numeroDecimal > 0)
            {
                // Calculamos el residuo de la división del número decimal por 2.
                string digito = Convert.ToString(numeroDecimal % 2);

                // Agregamos el dígito obtenido al principio de la cadena de resultado.
                resBinario = digito + resBinario;

                // Dividimos el número decimal por 2 para continuar el proceso.
                numeroDecimal = numeroDecimal / 2;
            }

            // Una vez que el número decimal se ha convertido completamente en binario, retornamos la cadena resultante.
            return resBinario;
        }

        /// <summary>
        /// El propósito del método DeBinarioADecimal es tomar una cadena de caracteres que representa un número
        /// binario y convertirla en su equivalente decimal. El método realiza esta conversión calculando el
        /// valor decimal del número binario y lo devuelve como un entero.
        /// </summary>
        /// <param name="numeroBinario">Esta es la cadena de caracteres que representa el número binario que se desea
        /// convertir en decimal.</param>
        /// <returns>un número entero (int) que representa el valor decimal equivalente al número binario proporcionado
        /// como entrada.</returns>
        public static int DeBinarioADecimal(string numeroBinario)
        {
            int orden = numeroBinario.Length;

            int numeroDecimal = 0;

            for (int index = orden-1; index >= 0; index--)
            {
                // Debes restar '0' para convertir un carácter numérico en su valor entero.
                int digito = Convert.ToInt32(numeroBinario[index]) - '0';

                numeroDecimal += digito * (int)Math.Pow(2,orden - 1 - index);
            }

            return numeroDecimal;
        }

        /// <summary>
        /// Indica si la cadena de caracteres dada es una cadena binaria, es decir, si sólo esta formada por 0's 
        /// y 1's.
        /// </summary>
        /// <param name="cadena">La cadena según la cual se describe true o false</param>
        /// <returns>Boolean</returns>
        public static bool esBinario(string cadena) 
        {
            char[] ceroYUno = new char[] { '0', '1' };
 
            foreach (char caracter in cadena)
            {
                if (!ceroYUno.Contains(caracter)) return false;
            }

            return true;
        }
    }
}
