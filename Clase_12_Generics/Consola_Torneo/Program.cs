using System;
using Biblioteca_Torneo;

namespace Consola_Torneo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneo = new Torneo<EquipoFutbol>("Torneo A");

            _ = torneo + new EquipoFutbol("River", new DateTime(1990, 08, 24));

            _ = torneo + new EquipoFutbol("Boca", new DateTime(1990, 09, 10));

            _ = torneo + new EquipoFutbol("Independiente", new DateTime(1990, 10, 12));

            Console.WriteLine(torneo.Mostrar());

            Console.WriteLine();

            string resultado1 = torneo.JugarPartido;

            string resultado2 = torneo.JugarPartido;

            string resultado3 = torneo.JugarPartido;

            Console.WriteLine(resultado1);

            Console.WriteLine(resultado2);

            Console.WriteLine(resultado3);
        }
    }
}
