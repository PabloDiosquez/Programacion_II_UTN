using System;
using System.Collections.Generic;

namespace SerializacionXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje1 = new Personaje("Spiderman", 126);
            Personaje personaje2 = new Personaje("Batman", 153);
            Personaje personaje3 = new Personaje("Superman", 5000);

            //ClaseSerializadora.Escribir(personaje1);

            List<Personaje> personajes = new List<Personaje>() { personaje1, personaje2, personaje3};

            //ClaseSerializadora.Escribir(personajes);

            Console.WriteLine(ClaseSerializadora.Leer());
        }
    }
}
