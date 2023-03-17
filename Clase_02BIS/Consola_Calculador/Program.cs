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
                    Console.WriteLine("Asegúrese de ingresar un número...");
                }

                while (!double.TryParse(Console.ReadLine(), out operando2))
                {
                    Console.WriteLine("Asegúrese de ingresar un número...");
                }

                Console.WriteLine("Operación:");

                string operacion = Console.ReadLine();

                Console.WriteLine("Resultado: {0}", Calculadora.Calcular(operando1, operando2, operacion));

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
