using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicación de consola que contenga la clase Cuenta.

            //Deberá tener los atributos:

            //titular que contendrá la razón social del titular de la cuenta.
            //cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.

            //Construir los siguientes métodos para la clase:

            //Un constructor que permita inicializar todos los atributos.
            //Un método getter para cada atributo.
            //mostrar retornará una cadena de texto con todos los datos de la cuenta.
            //ingresar recibirá un monto para acreditar a la cuenta.Si el monto ingresado es negativo, no se hará nada.
            //retirar recibirá un monto para debitar de la cuenta.La cuenta puede quedar en negativo.
            //En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo

            Cuenta cuenta = new Cuenta("ABC 123",100000M);

            Console.WriteLine($"Titular: {cuenta.ObtenerTitular()}");
            Console.WriteLine($"Cantidad: ARS {cuenta.ObtenerCantidad()}");

            Console.WriteLine(cuenta.MostrarDatos());

            cuenta.Ingresar(1200M);
            Console.WriteLine($"Cantidad: {cuenta.ObtenerCantidad()}");

            cuenta.Retirar(1200M);
            Console.WriteLine($"Cantidad: {cuenta.ObtenerCantidad()}");

        }
    }
}
