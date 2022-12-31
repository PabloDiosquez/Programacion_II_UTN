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
            Persona persona1 = new Persona("Pablo",30123456, new DateTime(1988,03,12));

            Console.WriteLine(persona.MostrarDatos());

            Console.WriteLine($"¿Son iguales? {persona == persona1}");

            string nombre = persona;
            Console.WriteLine("El nombre de la persona es " + nombre); // Uso de la conversión implícita: Persona 👉🏼 string

            int dni = persona;
            Console.WriteLine(dni*2); // Uso de la conversión implícita: Persona 👉🏼 int

            DateTime fechaNacimiento = (DateTime)persona; // Uso de la conversión explícita: Persona 👉🏼 DateTime

        }
    }
}
