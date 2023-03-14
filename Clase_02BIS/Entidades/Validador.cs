using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor > min && valor < max)
            {
                return true;
            }
            return false;
        }

        //Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

        //Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

        //El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

        public static bool ValidarRespuesta()
        {
            Console.WriteLine("¿Desea continuar? (S/N)");

            if (Console.ReadLine().ToUpper() == "S")
            {
                return true;
            }

            return false;
        }
    }
}
