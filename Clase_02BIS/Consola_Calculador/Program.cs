using System;
using Biblioteca;

namespace Consola_Calculador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Operandos:");

                double operando1;

                double operando2;

                while (!double.TryParse(Console.ReadLine(), out operando1))
                {
                    Console.WriteLine("Asegúrese de ingresar UN número");
                }




                Console.WriteLine();
                Console.WriteLine();

            } while (Continuar());
        }


        public static bool Continuar()
        {
            Console.WriteLine("¿Desea continuar? (S/N)");

            if (Console.ReadLine().ToUpper() == "S")
            {
                return true;
            }
            return false;
        }
    }
}
