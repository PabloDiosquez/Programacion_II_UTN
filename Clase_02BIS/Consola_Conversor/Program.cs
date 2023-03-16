using System;
using Biblioteca;

namespace Consola_Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.ConvertirDecimalABinario(52));

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(0));
        }
    }
}
