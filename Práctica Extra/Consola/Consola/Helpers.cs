using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class Helpers
    {
        public static int ContarLetras(string texto)
        {
            int cantidadLetrasAlMomento = 0;

            foreach (string palabra in texto.Split(' ', options: StringSplitOptions.RemoveEmptyEntries))
            {
                cantidadLetrasAlMomento += palabra.Length;
            }
            return cantidadLetrasAlMomento;
        }

        public static int ValidarNumeroEntero()
        {
            int numero;

            Console.WriteLine("Ingrese un número entero:");

            while (!int.TryParse(Console.ReadLine(), out numero)) Console.WriteLine("Asegúrese de ingresar un número entero...");

            return numero;
        }

        public static double ValidarNumero()
        {
            double numero;

            Console.WriteLine("Ingrese un número real:");

            while (!double.TryParse(Console.ReadLine(), out numero)) Console.WriteLine("Asegúrese de ingresar un número...");
            
            return numero;
        }

        public static double CalcularPromedio(int[] numeros)
        {
            double total = 0;

            foreach (int numero in numeros)
            {
                total += numero;
            }
            return total / numeros.Length; 
        }

        public static int Maximo(int[] numeros)
        {
            int maximoAlMomento = numeros[0];

            foreach (int numero in numeros)
            {
                maximoAlMomento = MaximoEntre(maximoAlMomento, numero);
            }
            return maximoAlMomento;
        }

        public static int Minimo(int[] numeros)
        {
            int minimoAlMomento = numeros[0];

            foreach (int numero in numeros)
            {
                minimoAlMomento = MinimoEntre(minimoAlMomento, numero);
            }
            return minimoAlMomento;
        }

        public static int MaximoEntre(int primerNumero, int segundoNumero)
        {
            if (primerNumero >= segundoNumero) return primerNumero;
            
            return segundoNumero;
        }

        public static int MinimoEntre(int primerNumero, int segundoNumero) 
        {
            if (primerNumero <= segundoNumero) return primerNumero;

            return segundoNumero;
        }
    }
}
