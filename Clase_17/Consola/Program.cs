using System;
using System.Collections.Generic;
using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Persona> personas = PersonaAccesoDatos.Leer();

            //foreach (Persona persona in personas)
            //{
            //    Console.WriteLine(persona.ToString());
            //}

            //PersonaAccesoDatos.Eliminar(2);

            try
            {
                PersonaAccesoDatos.ModificarNombre(4, "Lara");

                Persona persona = PersonaAccesoDatos.Leer(4);

                Console.WriteLine(persona);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
