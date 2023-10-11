using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Lio", "Messi", 12345678);

            Estudiante estudiante1 = new Estudiante(123, persona1);

            Estudiante estudiante2 = new Estudiante(321, "Julián", "Álvarez", 12345679);

            Profesor profesor1 = new Profesor(new Persona("Lionel", "Scaloni", 87654321), "Programación II");

            // Principio de sustitución de Liskov

            Persona persona2 = new Estudiante(456, "Enzo", "Fernández", 123456777);

            Persona persona3 = profesor1; // 👉🏼 sigue siendo un profesor en memoria. Pero es una variable de tipo Persona ⚠

            List<Persona> personas = new List<Persona>();

            personas.Add(persona1);

            personas.Add(persona2);

            personas.Add(persona3);

            // ⚠ todos los objetos agregados a la lista anterior son Personas 🙊!

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.MostrarDatos());

                if (persona is Estudiante estudiante)
                {
                    Console.WriteLine(estudiante.Estudiar());
                }
                else if (persona is Profesor profesor)
                {
                    Console.WriteLine(profesor.Corregir());
                }
            }
        }
    }
}
