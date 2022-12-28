using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicación de consola y que contenga la clase Persona.

            //Deberá tener los atributos:

            //nombre
            //fechaDeNacimiento
            //dni
            //Deberá tener un constructor que inicialice todos los atributos.

            //Construir los siguientes métodos para la clase:

            //Setter y getter para cada uno de los atributos.
            //CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
            //Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
            //EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
            //Instanciar 3 objetos de tipo Persona en el método Main.
            //Mostrar quiénes son mayores de edad y quiénes no.

            Persona persona1 = new Persona("Pablo", new DateTime(1990, 08, 24), 35402027);

            Console.WriteLine(persona1.MostrarDatos());

            Console.WriteLine($"¿Es mayor de edad? {persona1.EsMayorDeEdad()}");

        }
    }
}
