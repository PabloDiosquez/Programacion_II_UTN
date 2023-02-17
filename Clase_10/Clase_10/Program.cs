using System;

namespace Clase_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 4, 5, 6, 7 };

            //arr[7] = -1; System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            //int num1 = 5;

            //int num2 = 0;

            //int div = num1 / num2; System.DivideByZeroException: 'Attempted to divide by zero.'

            // 1.

            try
            {
                arr[arr.Length] = 8;
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió una excepción 😕");
            }
            finally 
            {
                Console.WriteLine("Programa terminado.");
            }

            Console.WriteLine();

            // Mútiples bloques catch

            //Un bloque de código en una instancia try puede contener muchas instrucciones, cada una de las cuales puede
            // producir una o más clases diferentes de excepción.
            //Al haber muchas clases de excepciones distintas, es posible que haya muchos bloques catch y que cada uno de
            //ellos capture un tipo específico de excepción.
            //El runtime captura automáticamente objetos excepción de un tipo concreto en un bloque catch para ese tipo.

            // 2.

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Ocurrió una excepción: {e.Message} ");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Ocurrió una excepción: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Ocurrió una excepción: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocurrió una excepción: {e.Message}");
            }
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"{arr[i]}");
                }
            }


            // 3. 

            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void Metodo1()
        {
            try
            {
                Console.WriteLine("Escriba el primer número");

                int i = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el segundo número");

                int j = int.Parse(Console.ReadLine());

                int k = i / j;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Metodo2()
        {
            try
            {
                int dividendo = 2;

                int divisor = 0;

                int res = dividendo / divisor;
            }
            catch (DivideByZeroException ex)
            {
                throw new MiExcepcion("BOOM!! No se puede dividir por cero.", ex);
            }
        }
    }
}
