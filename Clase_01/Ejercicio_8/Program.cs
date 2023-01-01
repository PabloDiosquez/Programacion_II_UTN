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

            for (int i = 1; i <= 5; i++) 
            {
                for (int j = 0; j < i; j++)
                {
                    string valor = $"*{2 * i - 1}";
                    Console.Write(valor);
                }

                Console.WriteLine();
            }

        }
    }
}
