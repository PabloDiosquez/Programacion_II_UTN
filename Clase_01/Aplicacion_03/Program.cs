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

            Console.WriteLine("Ingrese cantidad de usuarios:");
            if (int.TryParse(Console.ReadLine(), out int usuarios))
                Console.WriteLine($"Cantidad de usuarios de la App: {usuarios}");
            else
            {
                Console.WriteLine("No se pudo obtener la cantidad de usuarios");
                Console.WriteLine($"Cantidad de usuarios: {usuarios=-1}");
            }

        }
    }
}
