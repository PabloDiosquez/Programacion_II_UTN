using System;

namespace Aplicacion_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 100; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine(Funciones.NombreApp());

            //Console.WriteLine(Funciones.CantidadUsuarios("0.1A"));

            int usuarios;
            Console.WriteLine("Ingrese cantidad de usuarios:");
            //string cantidad = Console.ReadLine();

            //while (!int.TryParse(cantidad, out usuarios))
            //{
            //    Console.WriteLine("No se pudo leer correctamente la información.");
            //    Console.WriteLine("Ingrese nuevamente la cantidad de usuarios:");

            //    cantidad = Console.ReadLine();

            //}

            //Console.Clear();
            //Console.WriteLine($"La cantidad de usuarios ingresada es {usuarios}");

            while (!int.TryParse(Console.ReadLine(), out usuarios))
                Console.WriteLine("No se pudo leer correctamente la información.Ingrese nuevamente la cantidad de usuarios:");

            Console.Clear();
            Console.WriteLine($"Cantidad de usuarios de la App: {usuarios}");
        }
    }
}
