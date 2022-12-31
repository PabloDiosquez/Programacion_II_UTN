using System;

namespace Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //          Crear dos constructores:

        //Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
        //Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
        //El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

        //En el caso de Sumar(long, long) sumará los valores numéricos
        //En el de Sumar(string, string) concatenará las cadenas de texto.
        //Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

        //Seguido:

        //Generar una conversión explícita que retorne cantidadSumas.

        //Sobrecargar el operador + (suma) con dos operadores de tipo Sumador.El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

        //Sobrecargar el operador | (pipe)con dos operadores de tipo Sumador.Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

        //Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.

            Sumador sumador = new Sumador();
            Sumador sumador1 = new Sumador();

            //Console.WriteLine($"Cantidad de sumas: {sumador.CantidadSumas()}");
            Console.WriteLine($"Cantidad de sumas: {(int)sumador}");
            Console.WriteLine($"Resultado string: {sumador.Sumar("Hola", " Mundo!!")}");
            //Console.WriteLine($"Cantidad de sumas: {sumador.CantidadSumas()}");
            Console.WriteLine($"Cantidad de sumas: {(int)sumador}");
            Console.WriteLine($"Resultado long: {sumador.Sumar(21, 34)}");
            //Console.WriteLine($"Cantidad de sumas: {sumador.CantidadSumas()}");
            Console.WriteLine($"Cantidad de sumas: {(int)sumador}");

            Console.WriteLine($"Resultado long: {sumador1.Sumar(12,4)}");
            Console.WriteLine($"Cantidad de sumas: {(int)sumador1}");

            Console.WriteLine($"Suma de los sumadores: {sumador + sumador1}");
            Console.WriteLine($"¿Tienen igual cantidad de sumas?: {sumador | sumador1}");

        }
    }
}
