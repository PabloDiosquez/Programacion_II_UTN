using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    public static class Vista
    {
        public static void MostrarMenu()
        {
            Console.WriteLine(" ### Olimpíadad de Matemática OMA ### ");
            Console.WriteLine("a. Inscribir un alumno.");
            Console.WriteLine("b. Borrar un alumno.");
            Console.WriteLine("c. Total alumnos inscriptos.");
            Console.WriteLine("d. Total escuelas inscriptas.");
            Console.WriteLine("e. Imprimir listado de escuelas inscriptas.");
            Console.WriteLine("Salir: ESC\n");
        }
    }
}
