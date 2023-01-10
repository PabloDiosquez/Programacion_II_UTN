using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que determine si un año es bisiesto.

            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos,
            //salvo si ellos también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.

            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

            int anho1 = 0, anho2 = 0;

            Console.WriteLine("Ingrese el primer año:");

            anho1 = ValidarAnho();

            Console.WriteLine("Ingrese el segundo año:");

            anho2 = ValidarAnho();

            OrdenarAnhos(ref anho1, ref anho2);

            Console.WriteLine($"Años bisiestos entre {anho1} y {anho2}:");

            for (int anho = anho1; anho <= anho2; anho++)
            {
                if (esBisiesto(anho))
                {
                    Console.WriteLine($"Año: {anho}");
                }
            }
        }

        // MÉTODOS UTILIZADOS

        public static bool esBisiesto(int anho)
        {
            return anho % 4 == 0 || (anho % 400 == 0 && anho % 100 != 0);
        }

        public static int ValidarAnho()
        {
            int anho;

            while (!int.TryParse(Console.ReadLine(), out anho))
            {
                Console.WriteLine("Algo salió mal. Intente de nuevo:");
            }

            Console.WriteLine("Ingreso correcto!");

            return anho;    
        }

        public static void OrdenarAnhos(ref int anho1, ref int anho2) 
        {
            int anhoAux = 0; 

            if (anho2 < anho1)
            {
                anhoAux = anho1;

                anho1 = anho2;

                anho2 = anhoAux;
            }
        }
    }
}
