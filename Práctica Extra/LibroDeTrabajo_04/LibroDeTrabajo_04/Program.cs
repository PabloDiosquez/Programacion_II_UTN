using System;

namespace LibroDeTrabajo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hora h1 = new Hora(23, 30, 15);
            Hora h2 = new Hora("14:25:47");
            h1.imprimir();
            h2.imprimir();
            Console.ReadKey(true);
        }
    }
}
