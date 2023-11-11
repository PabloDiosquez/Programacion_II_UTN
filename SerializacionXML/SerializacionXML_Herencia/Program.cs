using System;
using System.Collections.Generic;

namespace SerializacionXML_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personaje> personajes = new List<Personaje>();

            personajes.Add(new Personaje("Aragorn", 200));
            personajes.Add(new Arquero("Legolas", 123, true));
            personajes.Add(new Mago("Gandalf", 542, false));

            ClaseSerializadora<List<Personaje>>.Escribir(personajes, "personajes.xml");
        }
    }
}
