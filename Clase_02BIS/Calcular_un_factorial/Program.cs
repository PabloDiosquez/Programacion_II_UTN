using System;

namespace Calcular_un_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros

            //positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

            //En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.

            Console.WriteLine("Número: ");

            int numero = 0;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Algo malió sal...");
            }

            Console.WriteLine("\nFactorial: {0}", CalcularFactorial(numero));

            Console.WriteLine("\nFactorial: {0}", CalcularFactorialV2(numero));
        }

        public static Int32 CalcularFactorial(int numero)
        {
            if (numero == 0) 
            {
                return 1;
            }

            return CalcularFactorial(numero - 1) * numero;
        }

        public static Int32 CalcularFactorialV2(Int32 numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
