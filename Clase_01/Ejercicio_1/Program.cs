using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar 5 números por consola, guardándolos en una variable escalar.
            // Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            principal();
        }

        // Funciones auxiliares ☂

        // Función principal del ejercicio.
        private static void principal() 
        {
            int numero, maximo = 0, minimo = 0, acumulador = 0;

            for (int i = 0; i < 5; i++)
            {
                numero = validarNumero();

                acumulador += numero;

                calcularMaxYMin(numero, i, ref maximo, ref minimo);
            }

            mostrarResultados(maximo, minimo, acumulador);
        }

        // Subtarea utilizada dentro del ciclo for para modularizar el código. Define el máximo y el mínimo entre los 
        // números ingresados.
        private static void calcularMaxYMin(int numero, int indice, ref int maximo, ref int minimo) 
        {
            if (indice == 0)
            {
                maximo = numero;
                minimo = numero;
            }
            else
            {
                minimo = minimoEntre(numero, minimo);
                maximo = maximoEntre(numero, maximo);
            }
        }

        // Imprime por pantalla los resultados pedidos en el ejercicio.
        private static void mostrarResultados(int maximo, int minimo, int acumulador)
        {
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Promedio: {(acumulador / 5).ToString("0.00")}");
        }

        /// <summary>
        /// Describe el número más chico entre los dos números dados.
        /// </summary>
        /// <param name="numero1">Número</param>
        /// <param name="numero2">Número</param>
        /// <returns>Número</returns>
        private static int minimoEntre(int numero1, int numero2)
        {
            return numero1 <= numero2 ? numero1 : numero2;
        }

        /// <summary>
        /// Describe el número más grande entre los dos números dados.
        /// </summary>
        /// <param name="numero1">Número</param>
        /// <param name="numero2">Número</param>
        /// <returns>Número</returns>
        private static int maximoEntre(int numero1, int numero2) 
        {
            return numero1 > numero2 ? numero1 : numero2;
        }

        /// <summary>
        /// Describe un número entero leído por consola.
        /// </summary>
        /// <returns>Número</returns>
        private static int validarNumero()
        {
            int numero;

            Console.WriteLine("Ingrese un número:");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número. Intente de nuevo.");
            }

            return numero;
        }
    }
}
