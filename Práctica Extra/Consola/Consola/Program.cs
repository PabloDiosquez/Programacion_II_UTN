using System;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {

            

            
            








        }

        // Ejercicio 1.
        //Escriba un programa de aplicación que solicite al usuario ingresar su nombre y apellido,
        //e imprima en la consola un saludo personalizado utilizando ese nombre e informe entre()
        //la cantidad de letras que conforman la oración
        //impresa.
        //Ejemplo: Hola Juan Perez, bienvenido a la materia (34)

        public static Action<string> saludar = nombreCompleto => 
        {
            string mensaje = $"Hola {nombreCompleto}, bienvenido a la materia";

            Console.WriteLine($"{mensaje} ({Helpers.ContarLetras(mensaje)})");
        };

        // Ejercicio 2.
        //Escriba un programa de aplicación que calcule la suma de dos números reales introducidos por
        //teclado y muestre el resultado en la consola.

        public static Func<double, double, double> suma = ((x, y) => x + y);

        public static void PedirDosNumerosYMostrarSuSuma()
        {
            double primerNumero = Helpers.ValidarNumero();

            double segundoNumero = Helpers.ValidarNumero();

            Console.WriteLine($"Suma: {suma(primerNumero, segundoNumero)}");
        }

        // Ejercicio 3.
        //Escriba un programa de aplicación que lea por teclado una secuencia de números y que imprima
        //el valor máximo, el valor mínimo de dicho conjunto y el valor promedio.

        public static Func<int[], int> minimo = numeros => Helpers.Minimo(numeros);

        public static Func<int[], int> maximo = numeros => Helpers.Maximo(numeros);

        public static Func<int[], double> promedio = numeros => Helpers.CalcularPromedio(numeros);

        public static Action<int> leerYMostrar = cantidad => MostrarDatosEnArray(LeerPorTeclado(cantidad));

        public static int[] LeerPorTeclado(int cantidad)
        {
            int[] numeros = new int[cantidad];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Helpers.ValidarNumeroEntero();
            }
            return numeros;
        }

        public static void MostrarDatosEnArray(int[] numeros)
        {
            Console.WriteLine($"Mínimo: {minimo(numeros)}");

            Console.WriteLine($"Máximo: {maximo(numeros)}");

            Console.WriteLine($"Promedio: {promedio(numeros)}");
        }

    }
}
