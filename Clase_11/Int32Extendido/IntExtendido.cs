using System;

namespace Int32Extendido
{
    public static class IntExtendido
    {
        /// <summary>
        /// Realiza la operación FizzBuzz en un número entero.
        /// </summary>
        /// <param name="numero">El número entero para aplicar FizzBuzz.</param>
        /// <returns>
        /// El resultado de FizzBuzz:
        /// - "Fizz" si el número es divisible por 3.
        /// - "Buzz" si el número es divisible por 5.
        /// - "FizzBuzz" si el número es divisible por 3 y 5.
        /// - El número en formato de cadena si no es divisible por 3 ni 5.
        /// </returns>
        public static string FizzBuzz(this Int32 numero)
        {
            string resultado = numero.ToString();

            if (numero.EsDivisiblePor(3) && numero.EsDivisiblePor(5))
            {
                resultado = "FizzBuzz";
            }
            else if (numero.EsDivisiblePor(3))
            {
                resultado = "Fizz";
            }
            else if (numero.EsDivisiblePor(5))
            {
                resultado = "Buzz";
            }
            return resultado;
        }

        /// <summary>
        /// Verifica si un número entero es divisible por otro número.
        /// </summary>
        /// <param name="numero">El número entero que se verifica si es divisible.</param>
        /// <param name="divisor">El número por el cual se verifica la divisibilidad.</param>
        /// <returns>
        /// <c>true</c> si el número es divisible por el divisor; de lo contrario, <c>false</c>.
        /// </returns>
        /// <exception cref="DivideByZeroException">
        /// Se lanza si el divisor es igual a 0.
        /// </exception>
        private static bool EsDivisiblePor(this Int32 numero, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("¡No se puede dividir por 0! 🤬");
            }
            return numero % divisor == 0;
        }
    }
}
