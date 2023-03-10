using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = PersonaAccesoDatos.Leer();

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.ToString());
            }    

        }
    }
}
