using System;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Lio", "Messi");

            try
            {
                string pathVacio = string.Empty;

                // Serializar en XML
                Persona.GuardarXML(persona, pathVacio);

                // Intentar leer desde XML
                Persona personaDesdeXML = Persona.LeerXML(pathVacio);
                if (personaDesdeXML != null)
                {
                    Console.WriteLine("Persona desde XML: " + personaDesdeXML);
                }

                // Serializar en JSON
                Persona.GuardarJSON(persona, pathVacio);

                // Intentar leer desde JSON
                Persona personaDesdeJSON = Persona.LeerJSON(pathVacio);
                if (personaDesdeJSON != null)
                {
                    Console.WriteLine("Persona desde JSON: " + personaDesdeJSON);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
