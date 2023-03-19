using System;
using System.Text;

namespace Aprende_las_tablas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicación de consola que permita al usuario ingresar un número entero.

            //Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

            //Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

            //Mostrar en la consola el resultado.

            //Por ejemplo, si se ingresa el número 2 la salida deberá ser:

            //Tabla de multiplicar del número 2:
            //2 x 1 = 2
            //2 x 2 = 4
            //2 x 3 = 6
            //2 x 4 = 8
            //2 x 5 = 10
            //2 x 6 = 12
            //2 x 7 = 14
            //2 x 8 = 16
            //2 x 9 = 18

            Console.WriteLine("Ingrese un número y presione la tecla Enter:");

            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingrsar un número. Intente de nuevo...");
            }

            Console.WriteLine($"\n{ObtenerLaTablaDe(numero)}");
        }

        public static string ObtenerLaTablaDe(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tabla de multiplicar del número {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero*i}");
            }

            return sb.ToString();
        }
    }
}
