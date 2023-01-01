using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            // Se debe validar que el número sea mayor que cero, caso contrario,
            // mostrar el mensaje: "ERROR. ¡Reingresar número!".

            while (true) 
            {
                Console.WriteLine("Ingrese un número natural:");
                    
                if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0) 
                {
                    int cuadrado = numero * numero;
                    int cubo = cuadrado * numero; 

                    Console.WriteLine($"{numero} elevado al cuadrado: {cuadrado}");
                    Console.WriteLine($"{numero} elevado al cubo: {cubo}");
                    break;
                }

                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
