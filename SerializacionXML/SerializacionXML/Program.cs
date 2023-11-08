using System;

namespace SerializacionXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje("Spiderman", 126);

            ClaseSerializadora.Escribir(personaje);
        }
    }
}
