using System;
using Entidades;

namespace Consola_Teorica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperaturaCelsius = 0F;    

            float temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);

            Console.WriteLine("Temperatura en grados Celsius: {0}°", temperaturaCelsius);
            
            Console.WriteLine("Temperatura en grados Kelvin: {0}K", temperaturaKelvin);

        }
    }
}
