using System;
using Veterinaria;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato("Gardfield", new DateTime(1999,3,3),"Largo");

            gato.AsignarPeso(12.2);

            Console.WriteLine(gato.ObtenerDatos());
        }
    }
}
