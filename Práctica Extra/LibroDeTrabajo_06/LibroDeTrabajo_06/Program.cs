using System;
using Espectaculo;
using Biblioteca_Cine;

namespace LibroDeTrabajo_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el precio de la obra de teatro 'El fantasma de la ópera': ");
            double precioObra = Convert.ToDouble(Console.ReadLine());

            ObraDeTeatro elFantasmaDeLaOpera = new ObraDeTeatro("El fantasma de la ópera", 10); // 10 butacas disponibles

            int totalEntradasSolicitadas = 0;
            int totalEntradasVendidas = 0;

            while (true)
            {
                Console.Write("Ingrese el DNI del espectador (o '0' para salir): ");
                int dni = Convert.ToInt32(Console.ReadLine());

                if (dni == 0)
                {
                    break; // Salir del bucle si se ingresa 0
                }

                Console.Write("Ingrese el nombre del espectador: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el apellido del espectador: ");
                string apellido = Console.ReadLine();

                Espectador espectador = new Espectador(dni, nombre, apellido);

                if (elFantasmaDeLaOpera.VenderEntrada(espectador, precioObra))
                {
                    Console.WriteLine($"Entrada vendida. Nro de butaca: {espectador.NroButaca}");
                    totalEntradasVendidas++;
                }
                else
                {
                    Console.WriteLine("No hay butacas disponibles.");
                }

                totalEntradasSolicitadas++;
            }

            Console.WriteLine("\nResumen de la venta de entradas:");
            Console.WriteLine($"Total de entradas solicitadas: {totalEntradasSolicitadas}");
            Console.WriteLine($"Total de entradas vendidas: {totalEntradasVendidas}");
            Console.WriteLine($"Recaudación final: {elFantasmaDeLaOpera.totalRecaudado()}");

            Console.ReadLine(); // Para que la consola no se cierre inmediatamente

        }
    

        // Ejercicio 1.
        public static Alumno IngresarAlumno() 
        {
            Console.WriteLine("Ingresar datos alumno: [DNI<TAB>Nombre<TAB>Apellido<TAB><ENTER>]");

            string[] datos = Console.ReadLine().Split('\t');

            return new Alumno(Convert.ToInt32(datos[0]), datos[1], datos[2]);
        }
    }
}
