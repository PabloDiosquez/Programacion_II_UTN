using System;
using EjercicioI01_Biblioteca;
namespace EjercicioI01_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("tBasquet");
            EquipoBasquet e1 = new EquipoBasquet("e1");
            EquipoBasquet e2 = new EquipoBasquet("e2");

            e1.FechaDeCreacion = new DateTime(1990, 12, 21);
            e2.FechaDeCreacion = new DateTime(1993, 6, 12);

            _ = torneoBasquet + e1;
            _ = torneoBasquet + e2;

            Console.WriteLine(torneoBasquet.Mostrar());
        }
    }
}
