using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Estudiante
    {
        // Atributos 
        private string apellido;

        private string legajo;

        private string nombre;

        private int notaPrimerParcial;

        private int notaSegundoParcial;

        private static Random random = new Random();

        // Constructores 👷🏼‍'s 

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;

            this.legajo = legajo;   

            this.apellido = apellido;   

        }


        // Métodos de instancia 

        /// <summary>
        /// Permita cambiar el valor del atributo 'notaPrimerParcial' de un estudiante.
        /// Pre: La nota dada deber ser un número entero entre 1 y 10 inclusive.
        /// </summary>
        /// <param name="notaPrimerParcial">Nota del primer parcial a cambiar</param>
        public void SetNotaPrimerParcial(int notaPrimerParcial) 
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        /// <summary>
        /// Permite cambiar el valor del atributo 'notaSegundoParcial' de un estudiante.
        /// Pre: La nota dada deber ser un número entero entre 1 y 10 inclusive.
        /// </summary>
        /// <param name="notaSegundoParcial">Nota del segundo parcial a cambiar</param>
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        /// <summary>
        /// Describe el promedio de las dos notas de un estudiante.
        /// </summary>
        /// <returns>El promedio de las dos notas (float)</returns>
        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        /// <summary>
        /// Describe la nota final de un estudiante si las notas del primer y del segundo parcial 
        /// son >= a 4. En caso contrario, describe -1.
        /// </summary>
        /// <returns></returns>
        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return Estudiante.random.Next(6, 10);
            }

            return -1;
        }

        /// <summary>
        /// Describe una cadena de texto con los datos del alumno.
        /// </summary>
        /// <returns>String</returns>
        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"▪▪▪ Datos del alumno: ▪▪▪");
            sb.AppendLine($"Nombre, Apellido y Legajo: {nombre}, {apellido} - {legajo}");
            sb.AppendLine($"Notas del primer y del segundo parcial: {notaPrimerParcial} - {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            double notaFinal = CalcularNotaFinal();
            if (notaFinal!= -1)
                sb.AppendLine($"Nota final: {notaFinal}");
            else
                sb.AppendLine($"Alumno desaprobado");

            return sb.ToString();
        }
    }
}
