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

                double operando1 = 0;

                double operando2 = 0;

                ValidarOperando(ref operando1);

                ValidarOperando(ref operando2);

                Console.WriteLine("Operación:");

                string operacion = Console.ReadLine();

                Console.WriteLine("Resultado: {0}", Calculadora.Calcular(operando1, operando2, operacion));

            } while (Continuar());
        }

        public static void ValidarOperando(ref double operando)
        {
            while (!double.TryParse(Console.ReadLine(), out operando))
            {
                Console.WriteLine("Asegúrese de ingresar un número...");
            }
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
