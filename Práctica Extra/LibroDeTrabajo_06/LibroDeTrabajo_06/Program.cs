using System;
using Clases;

namespace LibroDeTrabajo_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) ALUMNO: Juan Perez(26) 2998745 7.8

            Alumno alumno = new Alumno(2998745, "Juan", "Perez", new DateTime(1997, 12, 3), 7.8);

            Console.WriteLine(alumno);


        }
    }
}
