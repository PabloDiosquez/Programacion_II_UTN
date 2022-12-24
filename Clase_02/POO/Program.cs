using System;
using Veterinaria;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato("Gardfield", new DateTime(1999,3,3),"Largo");

            Gato gato2 = new Gato("Félix", new DateTime(2020,2,21),null);

            gato.AsignarPeso(5.2);

            gato2.AsignarPeso(3.4);

            Console.WriteLine($"El peso de {gato.ObtenerNombre()} es {gato.ObtenerPeso()} kg");

            Console.WriteLine($"El peso de {gato2.ObtenerNombre()} es {gato2.ObtenerPeso()} kg");

            Console.WriteLine(gato.ObtenerDatos());

            Console.WriteLine(gato2.ObtenerDatos());

            Console.WriteLine("¿Son iguales? {0}", gato == gato2);
            Console.WriteLine("¿Son iguales? {0}", gato.Equals(gato2));
            Console.WriteLine("¿Son iguales? {0}",ReferenceEquals(gato,gato2));

            Console.WriteLine($"{gato.ObtenerNombre()}: {gato.GetHashCode()}");
            Console.WriteLine($"{gato2.ObtenerNombre()}: {gato2.GetHashCode()}");
            
        }
    }
}
