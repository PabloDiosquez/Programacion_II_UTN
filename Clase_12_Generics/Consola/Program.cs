using Biblioteca;
using System;

namespace Consola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Lista<int> listaInt = new Lista<int>();

            Lista<Persona> listaPersonas = new Lista<Persona>();

            listaPersonas.Encontrar<Persona>(new Persona());
        }
    }
}
