
using System;
using Biblioteca_Ejercicio_I01;

namespace Consola_Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona(11, "Tom", "Riddle");

            //PersonaDAO.Guardar(persona);

            //PersonaDAO.Borrar(persona);

            PersonaDAO.Modificar(persona, new Persona(14, "Bruce", "Wayne"));



        }
    }
}
