using System;

namespace Pitagoras_estaria_orgulloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

            //El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

            //Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

            //Mostrar el resultado en la consola




        }

        public static double AplicarElTeoremaDePitagoras(double longitudBase, double longitudAltura)
        {
            return Math.Sqrt(Math.Pow(longitudBase,2) + Math.Pow(longitudAltura,2));
        }    
    }
}
