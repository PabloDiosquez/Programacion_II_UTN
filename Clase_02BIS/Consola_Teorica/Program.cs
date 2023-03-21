using System;
using Entidades;

namespace Consola_Teorica
{
    internal class Program
    {
        private static float temperaturaCelsius = 0F;

        private static float temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);

        static void Main(string[] args)
        {
            //Program.MostrarTemperaturas();

            MostrarTemperaturas();
        }

        public static void MostrarTemperaturas()
        {
            Console.WriteLine("Temperatura en grados Celsius: {0}°", temperaturaCelsius);

            Console.WriteLine("Temperatura en grados Kelvin: {0}K", temperaturaKelvin);
        }
    }
}
