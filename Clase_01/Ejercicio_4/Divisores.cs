using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal static class Divisores
    {
        public static int sumaDivisores(int n)
        {
            int sumaDivisores = 0;

            for (int i = 1; i <= n / 2; i++) 
            {
                if (n % i == 0) 
                {
                    sumaDivisores += i;
                }
            }

            return sumaDivisores;
        }


        public static bool esNumeroPerfecto(int n)
        {
            return sumaDivisores(n) == n;
        }
    }
}
