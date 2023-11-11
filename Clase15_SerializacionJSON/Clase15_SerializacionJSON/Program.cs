using System;
using System.Collections.Generic;

namespace Clase15_SerializacionJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota("Coco", 11, "Callejero", 5.2, true);
            Mascota mascota2 = new Mascota("Luchi", 6, "Boxer", 11.1, true);

            //ClaseSerializadora<Mascota>.Escribir(mascota1, "mascota.json");

            List<Mascota> mascotas = new List<Mascota>() { mascota1, mascota2 };

            //ClaseSerializadora<List<Mascota>>.Escribir(mascotas, "mascotas.json");

            List<Mascota> mascotasRecuperadas = ClaseSerializadora<List<Mascota>>.Leer("mascotas.json");

            foreach (Mascota mascota in mascotasRecuperadas)
            {
                Console.WriteLine(mascota);
            }
        }
    }
}
