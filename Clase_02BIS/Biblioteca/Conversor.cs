using System;

namespace Biblioteca
{
    public class Conversor
    {
        //Desarollar una clase llamada Conversor que posea dos métodos de clase(estáticos) :

        //El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

        //public string ConvertirDecimalABinario(int numeroEntero) { }

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string res = "";

            while (numeroEntero > 0)
            {
                res += $"{numeroEntero % 2}";

                numeroEntero = numeroEntero / 2;
            }

            return res;
        }

        //El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

        //public int ConvertirBinarioADecimal(int numeroEntero) { }








    }
}
