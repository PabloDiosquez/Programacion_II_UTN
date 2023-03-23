using System;
using System.Text;

namespace Biblioteca_EjercicioI02
{
    public class Persona
    {
        private string nombre;

        private DateTime fechaDeNacimiento;

        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni )
        {
            this.nombre = nombre;   

            this.fechaDeNacimiento = fechaDeNacimiento;

            this.dni = dni;
        }

        public string Nombre { get; }

        public DateTime FechaDeNacimiento { get; }

        public int Dni { get; }

        /// <summary>
        /// Retorna la edad de la persona calculándola a partir de la fecha de nacimiento.
        /// </summary>
        /// <returns></returns>
        private int CalcularEdad()
        {
            return DateTime.Now.Year - FechaDeNacimiento.Year;
        }

        /// <summary>
        /// Retorna una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("▪ Datos personales ▪");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Edad: {CalcularEdad()}");
            sb.AppendLine($"DNI: {dni}");

            return sb.ToString();
        }

        /// <summary>
        /// Si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
        /// </summary>
        /// <returns></returns>
        public string EsMayorDeEdad()
        {
            if (CalcularEdad() > 18)
            {
                return "Es mayor de edad";
            }
            return "NO es menor de edad";
        }
    }

    // TODO 1: Instanciar 3 objetos de tipo Persona en el método Main.
    // TODO 2: Mostrar quiénes son mayores de edad y quiénes no.
}
