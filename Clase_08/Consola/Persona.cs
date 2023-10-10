using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Persona
    {
        // Campos protegidos que almacenan la información personal de la persona.
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected int edad;

        // Constructor de la clase Persona.
        public Persona(string nombre, string apellido, int dni)
        {
            // Propósito: Inicializa una instancia de la clase Persona con información básica.
            // Precondiciones: 
            // - El nombre no debe ser nulo ni vacío.
            // - El apellido no debe ser nulo ni vacío.
            // - El DNI debe ser un número entero válido.

            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        // Propiedades públicas para acceder y modificar los campos protegidos.

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public int Dni
        {
            get => dni;
            set => dni = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        // Método para mostrar los datos de la persona en formato legible.

        public string MostrarDatos()
        {
            // Propósito: Genera una representación de cadena que contiene los datos de la persona.
            // Precondiciones: Ninguna.

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Edad: {Edad}");

            return sb.ToString();
        }
    }
}
