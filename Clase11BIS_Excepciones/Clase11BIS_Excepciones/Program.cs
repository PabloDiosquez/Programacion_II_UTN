using System;

namespace Clase11BIS_Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int aleatorio = random.Next(1, 100);

            int miNumero;

            int intentos = 0;

            Console.WriteLine("Introduce un número entre 1 y 100:");

            do
            {
                intentos++;

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex) 
                {
                    Console.WriteLine("Ha ocurrido un error. Debes introducir un número entero...Se toma como número introducido el -1");

                    miNumero = -1;
                }


                if (miNumero > aleatorio)
                {
                    Console.WriteLine("El número es menor...");
                }
                else if (miNumero < aleatorio)
                {
                    Console.WriteLine("El número es mayor...");
                }

            } while (miNumero != aleatorio);

            Console.WriteLine($"¡Correcto! Número: {aleatorio}.\nHas necesitado {intentos} intentos 🖖🏼");

            Console.WriteLine("A partir de esta línea el programa continuaría...");

        }
    }
}
