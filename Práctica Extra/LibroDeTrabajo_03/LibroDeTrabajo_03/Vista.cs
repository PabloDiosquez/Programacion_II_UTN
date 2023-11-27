using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    /// <summary>
    /// Clase estática que proporciona métodos para mostrar información en la consola relacionada con la Olimpíada de Matemática (OMA).
    /// </summary>
    public static class Vista
    {
        /// <summary>
        /// Muestra el menú principal de la Olimpíada de Matemática (OMA) en la consola.
        /// </summary>
        public static void MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ### Olimpíada de Matemática OMA ### ");
            sb.AppendLine("a. Inscribir un alumno.");
            sb.AppendLine("b. Borrar un alumno.");
            sb.AppendLine("c. Total alumnos inscriptos.");
            sb.AppendLine("d. Total escuelas inscriptas.");
            sb.AppendLine("e. Imprimir listado de escuelas inscriptas.");
            sb.AppendLine("Salir: X");
            sb.AppendLine("¿Qué opción desea elegir?");
            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// Obtiene la información de un alumno desde la consola.
        /// </summary>
        /// <returns>Objeto Alumno con la información ingresada por el usuario.</returns>
        public static Alumno ObtenerAlumno()
        {
            try
            {
                Console.WriteLine("\nDNI:");
                int dni = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNombre escuela:");
                string nombreEscuela = Console.ReadLine();

                return new Alumno(dni, nombreEscuela);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: El DNI debe ser un número entero.");
                return null; // O manejo adicional según tus requisitos
            }
        }

        /// <summary>
        /// Imprime en la consola el listado de escuelas inscriptas en la competencia.
        /// </summary>
        /// <param name="competencia">Competencia que contiene la información de las escuelas inscriptas.</param>
        public static void ImprimirEscuelas(Competencia competencia)
        {
            StringBuilder sb = new StringBuilder();

            List<string> escuelas = competencia.Escuelas;

            escuelas.Sort();

            sb.AppendLine(" *** Escuelas inscriptas *** ");

            foreach (string escuela in escuelas)
            {
                sb.AppendLine(escuela);
            }
            Console.WriteLine(sb.ToString());
        }

        public static char ObtenerOpcionMenu()
        {
            char opcion;
            do
            {
                Console.WriteLine("¿Qué opción desea elegir?");
                opcion = Console.ReadKey().KeyChar;
            } while (!EsOpcionValida(opcion));

            return opcion;
        }

        private static bool EsOpcionValida(char opcion)
        {
            return opcion == 'a' || opcion == 'b' || opcion == 'c' || opcion == 'd' || opcion == 'e' || opcion == 'X';
        }
    }
}
