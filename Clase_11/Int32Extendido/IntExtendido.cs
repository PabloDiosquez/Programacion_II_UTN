using System;

namespace Int32Extendido
{
    public static class IntExtendido
    {
        public static string FizzBuzz(this int numero)
        {
            string resultado = numero.ToString();

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                resultado = "FizzBuzz";
            }
            else if (numero % 3 == 0)
            {
                resultado = "Fizz";
            }
            else if (numero % 5 == 0)
            {
                resultado =  "Buzz";
            }
            
            return resultado;
        }
    }
}
