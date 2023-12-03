using System;
using Biblioteca_Expedientes;
using Biblioteca_Colecciones;


namespace LibroDeTrabajo_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 5

            Cola<Expediente> expedientes = new Cola<Expediente>();

            // Agregar 5 expedientes a la cola
            expedientes.Encolar(new Expediente(1, "Gabriela Turco", new DateTime(2004, 2, 3)));
            expedientes.Encolar(new Expediente(2, "Lio Messi", new DateTime(2007, 3, 12)));
            expedientes.Encolar(new Expediente(3, "Gabriela Turco", new DateTime(2010, 2, 21)));
            expedientes.Encolar(new Expediente(4, "Sergio Clein", new DateTime(2022, 12, 4)));
            expedientes.Encolar(new Expediente(5, "Jack Nepper", new DateTime(1999, 11, 11)));

            //Console.WriteLine(expedientes.VerTope());

            Cola<Expediente> colaExpedientes_Turco_Febrero = HelpersExpedientes.EncolarTramitesRealizadosPorEnMes(expedientes, "Gabriela Turco", 2);

            //Verificar si la cola no está vacía antes de intentar acceder al tope
            if (!colaExpedientes_Turco_Febrero.EstaVacia)
            {
                Console.WriteLine(colaExpedientes_Turco_Febrero.VerTope());
            }
            else
            {
                Console.WriteLine("La cola está vacía. No hay expedientes que cumplan con los criterios.");
            }
        }
    }
}
