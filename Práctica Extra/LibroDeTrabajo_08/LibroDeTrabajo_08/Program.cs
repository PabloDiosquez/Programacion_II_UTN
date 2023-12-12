using System;
using System.Collections;
using System.Text;

namespace LibroDeTrabajo_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(esPalindromo("PEFEPA"));
        }

        // Ejercicio 1.
        //Implemente una función recursiva que calcule el factorial de un número n, el cual es
        //pasado por parámetro.

        public static int factorial(int numero) 
        {
            if (numero == 0) return 1;

            return factorial(numero - 1) * numero; 
        }

        // Ejercicio 2.
        //Implemente una función recursiva que imprima por consola la secuencia de Fibonacci hasta
        //un número pasado por parámetro.La secuencia de Fibonacci se genera sumando dos
        //números consecutivos para obtener el siguiente. La definición es la siguiente:
        //f1 = 1
        //f2 = 1
        //fn = fn - 1 + fn–2 para n >= 3
        //La serie Fibonacci hasta el número 8 → es: 1, 1, 2, 3, 5, 8, 13, 21

        public static void Fibonacci(int hasta)
        {
            _Fibonacci(0, hasta);
        }

        private static void _Fibonacci(int desde, int hasta)
        {
            if (desde <= hasta)
            {
                Console.Write($"{EnesimoFibonacci(desde)} ");
                _Fibonacci(desde + 1, hasta);
            }
        }

        private static int EnesimoFibonacci(int numero)
        {
            if (numero <= 1) return numero;

            return EnesimoFibonacci(numero - 1) + EnesimoFibonacci(numero - 2);
        }

        // Ejercicio 3. 
        //Modifique la función anterior para, que en vez de imprimir por consola, devuelva la serie
        //en un ArrayList.

        public static ArrayList arrayFibonacci(int hasta)
        {
            ArrayList arrayFibo = new ArrayList();

            return _arrayFibonacci(arrayFibo, 0, hasta);
        }

        private static ArrayList _arrayFibonacci(ArrayList arrayFibo, int desde, int hasta)
        {
            if(desde > hasta) return arrayFibo;

            arrayFibo.Add(EnesimoFibonacci(desde));

            return _arrayFibonacci(arrayFibo, desde + 1, hasta);
        }

        // Ejercicio 5.
        //Escriba una función recursiva que reciba un string y retorne la cantidad de vocales que
        //contiene.

        public static int cuentaVocales(string str)
        {
            return _cuentaVocales(str, 0, str.Length);
        }

        private static int _cuentaVocales(string str, int desde, int hasta)
        {
            if (desde >= hasta) return 0;

            return unoSiCeroSino(esVocal(str[desde])) + _cuentaVocales(str, desde + 1, hasta);
        }

        private static bool esVocal(char caracter)
        {
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U',
           'á', 'é', 'í', 'ó', 'ú', 'Á', 'É', 'Í', 'Ó', 'Ú',};

            return Array.IndexOf(vocales, caracter) >= 0;
        }

        private static int unoSiCeroSino(bool condicion)
        {
            if (condicion) return 1;
            return 0;
        }

        // Ejercicio 7.
        //Escriba una función recursiva que reciba un string como parámetro y devuelva si es o
        //no palíndromo.

        public static bool esPalindromo(string str)
        {
            return _esPalindromo(str, 0, str.Length - 1);
        }

        private static bool _esPalindromo(string str, int desde, int hasta)
        {
            if(desde >= hasta) return true;

            return str[desde] == str[hasta] && _esPalindromo(str, desde + 1, hasta - 1);
        }

    } 
}
