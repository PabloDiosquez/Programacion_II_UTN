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
            expedientes.Encolar(new Expediente(1, "Gabriela Turco", new DateTime(2004, 2, 21)));
            expedientes.Encolar(new Expediente(2, "Lio Messi", new DateTime(2007, 3, 12)));
            expedientes.Encolar(new Expediente(3, "Gabriela Turco", DateTime.Now));
            expedientes.Encolar(new Expediente(4, "Sergio Clein", new DateTime(2022, 12, 4)));
            expedientes.Encolar(new Expediente(5, "Jack Nepper", new DateTime(1999, 11, 11)));

            Cola<Expediente> colaExpedientes_Turco_Febrero = HelpersExpedientes.EncolarTramitesRealizadosPor_EnMes_(expedientes, "Gabriela Turco", 2);


        }
    }
}
