using System;

namespace Biblioteca
{
    public class Conversor
    {
        //Desarollar una clase llamada Conversor que posea dos métodos de clase(estáticos) :

        //El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

        //public string ConvertirDecimalABinario(int numeroEntero) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns></returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string res = "";

            while (numeroEntero > 0)
            {
                res = $"{numeroEntero % 2}" + res;

                numeroEntero = numeroEntero / 2;
            }

            return res;
        }

        //El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int res = 0;

            int i = 0;

            while (numeroEntero > 0)
            {
                int digito = numeroEntero % 10;

                res += digito * Convert.ToInt32(Math.Pow(2,i));

                numeroEntero = numeroEntero / 10;

                i++;
            }
            
            return res;
        }

    }
}
