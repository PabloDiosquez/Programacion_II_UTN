using System;

namespace Indexadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje1 = new Personaje(1,"Zelda","Hechizo 123");

            Personaje personaje2 = new Personaje(2,"Arthur Weasley","Hechizo 321");

            Batalla superBatalla = new Batalla();

            superBatalla.AgregarPersonaje(personaje1);

            superBatalla.AgregarPersonaje(personaje2);

            // Se necesita una propiedad indexada

            // Lo utilizo como un GET

            Personaje personajePos0 = superBatalla[0]; 

            Personaje personajeBIS = superBatalla["Arthur Weasley"];

            Console.WriteLine(personajePos0.Nombre);

            Console.WriteLine(personajeBIS.Nombre);

            Console.WriteLine();

            // Lo utilizo como un SET

            superBatalla[1] = personajePos0;

            superBatalla[0] = personajeBIS;

            Console.WriteLine(superBatalla[0].Nombre);

            Console.WriteLine(superBatalla[1].Nombre);

        }
    }
}
