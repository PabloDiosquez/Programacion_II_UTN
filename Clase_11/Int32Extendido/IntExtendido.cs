using System;

namespace Int32Extendido
{
    public static class IntExtendido
    {
        public static string FizzBuzz(this int numero)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (numero % 3 == 0)
            {
                return "Fizz";
            }
            else if (numero % 5 == 0)
            {
                return "Buzz";
            }
            
            return numero.ToString();
        }
    }
}
