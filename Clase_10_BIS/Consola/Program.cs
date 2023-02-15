using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[4] { " perro  ", "Magia", null, "Acertijo" };

            try
            {
                string resultado = DevolverPalabra(palabras, "acertijo");

                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error controlado: {ex.Message}");
            }

            Console.WriteLine("\n\nApp finalizada.");
            
        }

        private static string DevolverPalabra(string[] palabras, string palabra)
        {
            for (int i = 0; i < palabras.Length; i++)
            {
                try
                {
                    // Búsqueda exacta
                    if (palabras[i].Trim().ToLower() == palabra.Trim().ToLower())
                    {
                        return palabras[i].Trim();
                    }
                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("Falló porque enconrtró algo null. Revisar datos.");
                }
            }

            return "La palabra buscada NO se encuentra en el array";
        }
    }
}
