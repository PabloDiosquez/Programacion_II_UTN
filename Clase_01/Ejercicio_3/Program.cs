using System;

namespace Ejercicio_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Mostrar por pantalla todos los números primos que haya hasta el número que ingrese
            // el usuario por consola.

            //Validar que el dato ingresado por el usuario sea un número.

            //Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            //Si ingresa "salir", cerrar la consola.

            //Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa,
            //iterar.De lo contrario, cerrar la consola.

            string inputUsuario;
            int numero;

            do
            {
                Console.WriteLine("Ingrese un número:");
                inputUsuario = Console.ReadLine();

            } while (!int.TryParse(inputUsuario, out numero) || inputUsuario.ToLower() == "salir");

            Console.WriteLine($"Primos hasta el {numero}:");
            primosHasta(numero);

        }

        public static bool tieneDivisoresPropios(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool esPrimo(int numero)
        {
            return (numero > 1) && !(tieneDivisoresPropios(numero));
        }

        public static void primosHasta(int hasta)
        {
            for (int i = 2; i <= hasta; i++)
            {
                if (esPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
