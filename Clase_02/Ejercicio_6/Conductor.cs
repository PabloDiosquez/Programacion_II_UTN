using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Conductor
    {
        // Atributos 

        private int legajo;

        private string apellido;

        private string nombre;

        private int[] diasSemana;

        // Constructor 👷🏼‍

        public Conductor(int legajo, string apellido, string nombre)
        {
            this.legajo   = legajo;

            this.apellido = apellido;   

            this.nombre   = nombre;

            diasSemana    = new int[7];
        }

        // Métodos de instancia 

        // Describe el legajo de un conductor.
        public int GetLegajo()
        {
            return legajo;
        }

        // Describe el apellido de un conductor.
        public string GetApellido() 
        {
            return apellido;
        }

        // Describe el nombre de un conductor.
        public string GetNombre()
        {
            return nombre;
        }

        // Permite cargar la cantidad de kilométros recorridos por un conductor en cada día de la semana.
        public void CargarKilometrosRecorridosPorDia() 
        {
            for (int i = 0; i < diasSemana.Length; i++) 
            {
                Console.WriteLine($"Día {i+1}: ");

                diasSemana[i] = int.Parse(Console.ReadLine());
            } 
        }

        // Describe la cantidad de kilómetros recorridos por un conductor el día 'diaSemana' de la semana actual.
        // Pre: 'diaSemana' debe ser un día de la semana.
        public int GetKilometrosRecorridosEnDia(string diaSemana)
        {
            diaSemana = diaSemana.ToLower();

            int kilometrosRecorridos;

            switch (diaSemana)
            {
                case "lunes":
                    kilometrosRecorridos = diasSemana[0];
                    break;
                case "martes":
                    kilometrosRecorridos = diasSemana[0];
                    break;
                case "miercoles":
                    kilometrosRecorridos = diasSemana[0];
                    break;
                case "jueves":
                    kilometrosRecorridos = diasSemana[0];
                    break;
                case "viernes":
                    kilometrosRecorridos = diasSemana[0];
                    break;
                case "sabado":
                    kilometrosRecorridos = diasSemana[0];
                    break;
                case "domingo":
                    kilometrosRecorridos = diasSemana[0];
                    break;
                default:
                    Console.WriteLine("Día inválido");
                    kilometrosRecorridos = -1;
                    break;
            }

            return kilometrosRecorridos;
        }

        // Describe la cantidad total de kilometros recorridos por un conductor en la semana.
        public int TotalKilometrosRecorridos() 
        {
            int kilometrosTotales = 0;

            foreach (int kilometros in diasSemana)
            {
                kilometrosTotales += kilometros;
            }

            return kilometrosTotales;
        }

        // Muestra la información de un conductor de la empresa de transporte.
        public void MostrarInfoConductor()
        {
            Console.WriteLine($"Legajo: {GetLegajo()}");

            Console.WriteLine($"Apellido: {GetApellido()}");

            Console.WriteLine($"Nombre: {GetNombre()}");

            for (int i = 0; i < diasSemana.Length; i++)
            {
                Console.WriteLine($"Día {i + 1}: {diasSemana[i]} kilómetros");
            }
        }

    }
}
