using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    internal class MiExcepcion : Exception
    {
        public static void Metodo1()
        {
            try
            {
                Console.WriteLine("Escriba el primer número");

                int i = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el segundo número");

                int j = int.Parse(Console.ReadLine());

                int k = i / j;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
