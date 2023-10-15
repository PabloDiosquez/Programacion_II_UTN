using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de una instancia de la clase 'Persona' llamada 'persona1' con valores iniciales.
            Persona persona1 = new Persona("Lio", "Messi", 12345678);

            // Creación de una instancia de la clase 'Estudiante' llamada 'estudiante1' con un número de estudiante y la instancia 'persona1'.
            Estudiante estudiante1 = new Estudiante(123, persona1);

            // Creación de una instancia de la clase 'Estudiante' llamada 'estudiante2' con un número de estudiante y valores iniciales para nombre, apellido y número de documento.
            Estudiante estudiante2 = new Estudiante(321, "Julián", "Álvarez", 12345679);

            // Creación de una instancia de la clase 'Profesor' llamada 'profesor1' con una instancia de 'Persona' como argumento y un nombre de asignatura.
            Profesor profesor1 = new Profesor(new Persona("Lionel", "Scaloni", 87654321), "Programación II");

            // Principio de sustitución de Liskov
            // Creación de una instancia de 'Persona' llamada 'persona2' a la que se le asigna una instancia de 'Estudiante'.
            Persona persona2 = new Estudiante(456, "Enzo", "Fernández", 123456777);

            // Creación de una instancia de 'Persona' llamada 'persona3' a la que se le asigna la instancia 'profesor1'.
            Persona persona3 = profesor1; // 'persona3' es de tipo 'Persona', pero en memoria sigue siendo un profesor.

            // Creación de una lista de objetos de tipo 'Persona' llamada 'personas'.
            List<Persona> personas = new List<Persona>();

            // Agregar las instancias 'persona1', 'persona2' y 'persona3' a la lista 'personas'.
            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);

            // Iterar a través de la lista 'personas'.
            foreach (Persona persona in personas)
            {
                // Imprimir los datos de la persona llamando al método 'MostrarDatos()' de la clase base 'Persona'.
                Console.WriteLine(persona.MostrarDatos());

                // Verificar si la instancia actual es un objeto de tipo 'Estudiante'.
                if (persona is Estudiante estudiante)
                {
                    // Si es un estudiante, imprimir el resultado del método 'Estudiar()' de la clase 'Estudiante'.
                    Console.WriteLine(estudiante.Estudiar());
                }
                // Verificar si la instancia actual es un objeto de tipo 'Profesor'.
                else if (persona is Profesor profesor)
                {
                    // Si es un profesor, imprimir el resultado del método 'Corregir()' de la clase 'Profesor'.
                    Console.WriteLine(profesor.Corregir());
                }
            }
        }
    }
}
