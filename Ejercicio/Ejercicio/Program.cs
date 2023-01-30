using System;
using System.Collections.Generic;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();


        }
        public static int diasVacaciones(Empleado empleado)
        {
            int antiguedad = empleado.ObtenerAntiguedad();

            if (antiguedad <= 5)
            {
                return 15;
            }
            else
            {
                int aniosExtra = antiguedad - 5;

                if (empleado.EsJefe)
                {
                    return 15 + aniosExtra * 4;
                }
                else
                {
                    return 15 + aniosExtra * 3;
                }
            }
        }

        public static void EmpleadosDeVacaciones(List<Empleado> empleados)
        {

            foreach (Empleado empleado in empleados) 
            {
                if (empleado.Jefe.EstaActivo)
                {
                    Console.WriteLine($"{empleado.NombreCompleto()} puede irse {diasVacaciones(empleado)} días.");
                }

                Console.WriteLine($"El empleado {empleado.NombreCompleto()} NO puede irse de vacaciones.");
         
            }    
        }
    }
}
