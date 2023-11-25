using System;
using System.Collections.Generic;
using System.Text;

namespace LibroDeTrabajo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string palabra = "eeeiiioouuffaa";

            //foreach (string par in cantidadVocales(palabra))
            //{
            //    Console.WriteLine(par);
            //}

            usarCalculadora();
        }

        // Ejercicio 1.
        //Escriba un programa de aplicación que lea una palabra y determine si es un palíndromo.
        //(Ej: “abbccd” y “dccbba” son palíndromos).

        static Predicate<string> esPalindromo = str => str.EsPalindromo();

        // Ejercicio 2.
        //Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía.
        //Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de
        //caracteres por palabra

        static Func<string, char, bool> comienzaCon = (str, caracter) => !string.IsNullOrEmpty(str) && str[0] == caracter;

        public static void LeerPalabrasYDeterminarPorcentaje()
        {
            try
            {
                int totalPalabras = 0;
                int totalPalabrasComienzanConS = 0;

                while (true)
                {
                    Console.WriteLine("Ingrese una palabra (presione Enter para finalizar):");

                    string palabra = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(palabra)) break;

                    totalPalabras++;

                    if (comienzaCon(palabra, 's')) totalPalabrasComienzanConS++;

                }

                if (totalPalabras == 0) Console.WriteLine("No se ingresaron palabras. 🥴");
                else
                {
                    double porcentaje = (double)totalPalabrasComienzanConS / totalPalabras * 100;
                    Console.WriteLine($"Porcentaje de palabras que comienzan con 's': {porcentaje.ToString("0.00")}%");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Algo salió mal... {ex.Message}");
            }

        }

        // Ejercicio 3.
        //Defina una función que reciba una palabra y retorne en un vector la cantidad de cada una de las vocales que
        //contiene.

        static Func<string, string[]> cantidadVocales = (str) => str.ContadorDeVocales();

        // Ejercicio 4.
        //Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario
        //realizar las cuatro operaciones elementales e imprimir el resultado de la operación.Para ello el programa debe
        //mostrar un menú de opciones con cada una de las operaciones, luego de seleccionar la operación el programa
        //pide ingresar dos números, realiza la operación solicitada e imprime el resultado

        public static Action usarCalculadora = UsarCalculadora;

        private static void UsarCalculadora()
        {
            while (true)
            {
                Console.WriteLine(" **** App Calculadora **** ");
                double primerNumero = Helpers.ValidarNumero();
                double segundoNumero = Helpers.ValidarNumero();
                MostrarMenuCalculadora();
                string operador = ValidarOperador();
                if (operador.ToUpper() == "ESC") break;
                Console.WriteLine($"Resultado: {Calculadora.Calcular(primerNumero, segundoNumero, operador)}");
            }
            Console.WriteLine("Gracias por usar la App!");
            
        }
        private static void MostrarMenuCalculadora()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** Menú Calculadora ***");
            sb.AppendLine("Ingresa la operación que desea realizar:");
            sb.AppendLine("Suma ➡ +");
            sb.AppendLine("Resta ➡ -");
            sb.AppendLine("Multiplicación ➡ *");
            sb.AppendLine("División ➡ /");
            sb.AppendLine("Salir ➡ ESC");

            Console.WriteLine(sb.ToString());
        }

        private static string ValidarOperador()
        {
            List<string> operadoresValidos = new List<string>() {"+", "-", "*", "/", "ESC", "esc" };

            string operador = Console.ReadLine().Trim();    

            while (true)
            {
                if (operadoresValidos.Contains(operador)) break;
                else 
                {
                    Console.WriteLine("Operación NO válida. Intente de nuevo.");

                    operador = Console.ReadLine();  
                }
            }
            return operador;
        }
    }
}
