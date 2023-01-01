using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar 5 números por consola, guardándolos en una variable escalar.
            // Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            int numero, maximo = 0, minimo = 0, acumulador = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número:");
                while (!int.TryParse(Console.ReadLine(), out numero)) 
                {
                    Console.WriteLine("Asegúrese de ingresar un número entero. Intente de nuevo:");

                }

                acumulador += numero;

                if (i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else 
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }
            }

            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Promedio: {(acumulador / 5).ToString("0.00")}");

        }
    }
}
