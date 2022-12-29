using System;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sobrecarga.Sumar(2, 3));

            //Console.WriteLine(Sobrecarga.Sumar(2,3,14));

            //Console.WriteLine(Sobrecarga.Sumar(2,3.2F));

            //Console.WriteLine(Sobrecarga.Sumar("Hola"," Mundo"));

            Persona persona = new Persona("Lio",30123456, new DateTime(1985,02,21));

            Console.WriteLine(persona.MostrarDatos());

        }
    }
}
