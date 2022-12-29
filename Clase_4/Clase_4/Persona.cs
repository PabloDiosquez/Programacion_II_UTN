using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    internal class Persona
    {
        // SOBRECARGA DE CONSTRUCTORES

        private string nombre;

        private int dni;

        private DateTime fechaNacimiento;

        public Persona() { }

        public Persona(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, int dni) : this(nombre) 
        {
            this.dni = dni;
        }

        public Persona(string nombre, int dni, DateTime fechaNacimiento) : this(nombre, dni) 
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("### Datos de la persona ###");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        
        }

        // SOBRECARGA DE OPERADORES

        public static bool operator == (Persona p1, Persona p2)
        {
            return p1.dni == p2.dni; 
        }

        public static bool operator !=(Persona p1, Persona p2) 
        {
            return !(p1 == p2);
        }
    }
}
