using System;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Lio","Messi",12345678);

            Estudiante estudiante1 = new Estudiante(123,persona1);

            Estudiante estudiante2 = new Estudiante(321, new Persona("Julián", "Álvarez", 12345679));

            Profesor profesor1 = new Profesor(new Persona("Lionel", "Scaloni", 87654321),"Programación II");
        }
    }
}
