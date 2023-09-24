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

        public int GetLegajo()
        {
            return legajo;
        }

        public string GetApellido() 
        {
            return apellido;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void CargarKilometrosRecorridosPorDia() 
        {
            for (int i = 0; i < diasSemana.Length; i++) 
            {
                Console.WriteLine($"Día {i+1}: ");

                diasSemana[i] = int.Parse(Console.ReadLine());
            } 
        }

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

        public void MostrarInfoConductor()
        {
            Console.WriteLine($"Legajo: {GetLegajo()}");

            Console.WriteLine($"Apellido: {GetApellido()}");

            for (int i = 0; i < diasSemana.Length; i++)
            {
                Console.WriteLine($"Día {i+1}: {diasSemana[i]}");
            }
        }

    }
}
