using System;
using Biblioteca;

namespace Calculo_de_Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase(estáticos) que realicen el cálculo del área que corresponda:

            //public double CalcularAreaCuadrado(double longitudLado) { }

            //public double CalcularAreaTriangulo(double base, double altura) { }

            //public double CalcularAreaCirculo(double radio) { }

            //El ingreso de los datos como la visualización se deberán realizar desde el método Main().

            Console.WriteLine("▪ Cálculo del área de un círculo ▪");

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Radio: ");

            double radio;

            while (!double.TryParse(Console.ReadLine(), out radio))
            {
                Console.WriteLine("Asegúrese de ingresar un número...");
            }

            Console.WriteLine($"Área: {CalculadoraDeArea.CalcularAreaCirculo(radio).ToString("0.00")}");
        }
    }
}
