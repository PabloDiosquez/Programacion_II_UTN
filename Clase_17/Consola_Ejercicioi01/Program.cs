using System;
using Biblioteca_Ejercicio_I01;

namespace Consola_Ejercicioi01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (Persona persona in PersonaDAO.Leer())
            {
                Console.WriteLine(persona);
            }
        }
    }
}
