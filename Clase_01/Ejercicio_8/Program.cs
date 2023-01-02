using System;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que imprima por consola un triángulo como el siguiente:

            //*
            //***
            //*****
            //*******
            //*********

            //El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
            //Para el ejemplo anterior, la altura ingresada fue de 5.

            int altura;

            do
            {
                Console.WriteLine("Ingrese altura del triángulo:");

            } while (!int.TryParse(Console.ReadLine(), out altura));

            Triangulo.crearTriangulo(altura);

        }

    }
}
