using System;
using System.Collections.Generic;

namespace LibroDeTrabajo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia olimpiada = new Competencia();

            while (true)
            {
                Vista.MostrarMenu();

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "a":
                        Console.WriteLine("DNI:");
                        int dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre escuela:");
                        string nombreEscuela = Console.ReadLine();
                        olimpiada.InscribirAlumno(new Alumno(dni, nombreEscuela));
                        break;
                    case "b":
                        Console.WriteLine("DNI:");
                        int dniDrop = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre escuela:");
                        string nombreEscuelaDrop = Console.ReadLine();
                        olimpiada.BorrarAlumno(new Alumno(dniDrop, nombreEscuelaDrop));
                        break;
                    case "c":
                        olimpiada.ObtenerTotalAlumnosInscriptos();
                        break;
                    case "d":
                        olimpiada.ObtenerTotalEscuelas();
                        break;
                    case "e":
                        olimpiada.ImprimirEscuelas();
                        break;
                    case "ESC":
                        Console.WriteLine("Gracias por usar la App!");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }

        // Ejercicio 1.
        // Escriba un programa de aplicación que reciba una lista de palabras e informe cuáles son palíndromos usando una 
        // función.

        public static List<string> FiltrarPalindromos(List<string> palabras) 
        {
            List<string> palindromos = new List<string>();

            foreach (string palabra in palabras) 
            {
                if(palabra.EsPalindromo()) palabras.Add(palabra);   
            }
            return palindromos;
        }

        // Ejercicio 2
        //Desarrolle un programa de aplicación que simule la inscripción de participantes de distintas escuelas a una
        //competencia de matemática.De cada alumno se conoce su Dni y el nombre de la escuela a la que representa.
        //Pueden inscribirse(en forma desordenada) varios alumnos de la misma escuela.Arme un menú que permita:
        //a.Inscribir un alumno (armar una lista de alumnos inscriptos)
        //b.Borrar un alumno(eliminarlo de la lista de alumnos inscriptos)
        //c.Indicar total de alumnos inscriptos
        //d.Indicar total de escuelas que al menos tienen un alumno inscripto (armar una lista de escuelas)
        //e.Imprimir el listado de las escuelas, ordenado alfabéticamente, sin repeticiones.

    }
}
