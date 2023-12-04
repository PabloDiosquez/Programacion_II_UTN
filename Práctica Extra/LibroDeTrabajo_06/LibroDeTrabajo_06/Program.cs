using System;
using Clases;

namespace LibroDeTrabajo_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno(2998745, "Juan", "Perez", new DateTime(1997, 12, 3), 7.8);

            Console.WriteLine(alumno);

            Alumno alumno1 = IngresarAlumno();

            Console.WriteLine(alumno1);
        }

        public static Alumno IngresarAlumno() 
        {
            Console.WriteLine("Ingresar datos alumno: [DNI<TAB>Nombre<TAB>Apellido<TAB><ENTER>]");
            string datosRaw = Console.ReadLine();

            string[] datos = datosRaw.Split('\t');

            return new Alumno(Convert.ToInt32(datos[0]), datos[1], datos[2]);
        }
    }
}
