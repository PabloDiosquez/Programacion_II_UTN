using System;
using System.Threading;

namespace Consola
{
    public static class Program
    {
        public static void Main() {}

        /// <summary>
        /// Ejercicio 1:
        /// Escriba un programa que solicite al usuario ingresar su nombre y apellido,
        /// e imprima en la consola un saludo personalizado y la cantidad de letras de la oración.
        /// </summary>
        public static Action<string> saludar = nombreCompleto =>
        {
            string mensaje = $"Hola {nombreCompleto}, bienvenido a la materia";

            Console.WriteLine($"{mensaje} ({Helpers.ContarLetras(mensaje)})");
        };

        /// <summary>
        /// Ejercicio 2:
        /// Calcula la suma de dos números reales introducidos por teclado y muestra el resultado en la consola.
        /// </summary>
        public static Func<double, double, double> suma = ((x, y) => x + y);

        /// <summary>
        /// Ejercicio 2:
        /// Pide dos números al usuario y muestra su suma en la consola.
        /// </summary>
        public static void PedirDosNumerosYMostrarSuSuma()
        {
            double primerNumero = Helpers.ValidarNumero();

            double segundoNumero = Helpers.ValidarNumero();

            Console.WriteLine($"Suma: {suma(primerNumero, segundoNumero)}");
        }

        /// <summary>
        /// Ejercicio 3:
        /// Lee por teclado una secuencia de números, muestra el valor máximo, mínimo y el promedio de la secuencia.
        /// </summary>
        public static Action<int> leerYMostrar = cantidad => MostrarDatosEnArray(LeerPorTeclado(cantidad));

        private static int[] LeerPorTeclado(int cantidad)
        {
            int[] numeros = new int[cantidad];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Helpers.ValidarNumeroEntero();
            }
            return numeros;
        }

        private static void MostrarDatosEnArray(int[] numeros)
        {
            Console.WriteLine($"Mínimo: {Helpers.Minimo(numeros)}");

            Console.WriteLine($"Máximo: {Helpers.Maximo(numeros)}");

            Console.WriteLine($"Promedio: {Helpers.CalcularPromedio(numeros)}");
        }

        /// <summary>
        /// Ejercicio 4:
        /// Imprime en la consola todos los números pares, múltiplos de 5 y comprendidos entre 250 y 900.
        /// </summary>
        public static Action imprimirNumerosParesYMultiplosDe5 = () => ImprimirNumerosParesYMultiplosDe5(250, 900);
        private static void ImprimirNumerosParesYMultiplosDe5(int desde, int hasta)
        {
            for (int numero = desde; numero <= hasta; numero++)
            {
                Thread.Sleep(10);
                if (Helpers.esPar(numero) && Helpers.esMultiploDe(numero, 5))
                    Console.WriteLine(numero);
            }
        }

        /// <summary>
        /// Ejercicio 5:
        /// Permite al usuario ingresar números por la consola y muestra la suma acumulada.
        /// Informa la cantidad total de números ingresados y sumados cuando se ingresa un 0.
        /// </summary>
        public static Action leerEImprimirNumerosHastaIngresarCero = () => LeerEImprimirNumeros();
        private static void LeerEImprimirNumeros()
        {
            int sumaAcumuladaAlMomento = 0;

            int totalNumerosAlMomento = 0;

            while (true)
            {
                int numero = Helpers.ValidarNumeroEntero();

                if (numero == 0) break;

                totalNumerosAlMomento++;

                Console.WriteLine($"Número: {numero}");

                Console.WriteLine($"Suma acumulada al momento: {sumaAcumuladaAlMomento += numero}");
            }

            Console.WriteLine($"Números ingresados en total: {totalNumerosAlMomento}");

            Console.WriteLine($"Suma total: {sumaAcumuladaAlMomento}");
        }
    }
}
