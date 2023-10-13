using System;
using System.Collections.Generic;
using Biblioteca_Ejercicio_I02;

namespace Test_Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista de figuras.

            Circulo circulo = new Circulo(2.45);

            Cuadrado cuadrado = new Cuadrado(3);

            Rectangulo rectangulo = new Rectangulo(4, 8);

            //Agregar a la lista una figura de cada tipo.

            List<Figura> figuras = new List<Figura>();

            figuras.Add(circulo);

            figuras.Add(cuadrado);

            figuras.Add(rectangulo);

            //Recorrer la lista mostrando:

            //El resultado del método Dibujar.

            //El área y el perímetro de cada figura con una precisión de 2 decimales.

            //El tipo del objeto(método GetType).

            int numero = 1;

            foreach (Figura figura in figuras)
            {
                Console.WriteLine($"========== Figura {numero++} ==========");
                Console.WriteLine($"Tipo: {figura.GetType()}");
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine($"Área: {figura.CalcularSuperficie().ToString("0.00")}");
                Console.WriteLine($"Perímetro: {figura.CalcularPerimetro().ToString("0.00")}");
                Console.WriteLine("=======================================");
                Console.WriteLine();
            }
        }
    }
}
