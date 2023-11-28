using System;
using System.Collections.Generic;

namespace LibroDeTrabajo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            //Hora h1 = new Hora(23, 30, 15);
            //Hora h2 = new Hora("14:25:47");
            //h1.Imprimir();
            //h2.Imprimir();
            //Console.ReadKey(true);

            // Ejercicio 2

            //Persona rapero1 = new Persona("Tupac Shakur", 25, 98765432);
            //Persona rapero2 = new Persona("The Notorious B.I.G.", 24, 87654321);
            //Persona rapero3 = new Persona("Queen Latifah", 30, 76543210);

            //List<Persona> raperos = new List<Persona>() { rapero1, rapero2, rapero3};

            //// Ordenar y recorrer la lista de raperos 

            //Console.WriteLine($"Rapero de mayor edad: {PersonaMayor(raperos)}");

            // Ejercicio 3

            Operacion op = new Operacion(5, 4,'p');
            int res = op.Evaluar();
            Console.WriteLine(res);

        }

        // Ejercicio 2

        /// <summary>
        /// Encuentra y devuelve la persona de mayor edad en una lista de personas.
        /// </summary>
        /// <param name="personas">Lista de personas entre las cuales se buscará la de mayor edad.</param>
        /// <returns>La persona de mayor edad o null si la lista está vacía o si ocurre un error.</returns>
        private static Persona PersonaMayor(List<Persona> personas)
        {
            try
            {
                // Verificar si la lista de personas no es nula ni vacía
                if (personas is null || personas.Count == 0)
                {
                    Console.WriteLine("La lista dada no debe ser vacía.");
                    return null;
                }

                // Inicializar la persona mayor como la primera persona en la lista
                Persona personaMayor = personas[0];

                // Iterar a través de la lista para encontrar la persona de mayor edad
                foreach (Persona persona in personas)
                {
                    if (persona.EsMayorQue(personaMayor))
                    {
                        personaMayor = persona;
                    }
                }

                // Devolver la persona de mayor edad encontrada
                return personaMayor;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("La lista dada no debe ser vacía.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Algo salió mal... \n{ex.Message}");
            }

            // Devolver null si hay algún error
            return null;
        }
    }
}
