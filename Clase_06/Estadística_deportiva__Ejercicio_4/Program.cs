using System;

namespace Estadística_deportiva__Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void AgregarJugador(Equipo equipo, Jugador jugador) 
        {
            if (equipo + jugador)
            {
                Console.WriteLine($"Jugador agregado\n{jugador.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el jugador");
            }
        }
    }
}
