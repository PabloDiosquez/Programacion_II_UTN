using System;

namespace Ejercicio_I01_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase miClase = new MiClase(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Estoy en el main... {ex.Message}");
            }
        }
    }
}
