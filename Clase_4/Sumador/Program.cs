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

            Sumador sumador = new Sumador();

            Console.WriteLine($"Cantidad de sumas: {sumador.CantidadSumas()}");
            Console.WriteLine(sumador.Sumar("Hola"," Mundo!!"));
            Console.WriteLine($"Cantidad de sumas: {sumador.CantidadSumas()}");

        }
    }
}
