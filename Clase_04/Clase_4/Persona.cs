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
            if (p1 is not null && p2 is not null) 
            {
                return p1.nombre == p2.nombre && p1.dni == p2.dni;
            }

            return false;
        }

        public static bool operator !=(Persona p1, Persona p2) 
        {
            return !(p1 == p2);
        }

        // CONVERSIONES IMPLÍCITAS 💣

        public static implicit operator string(Persona p) 
        {
            if (p is not null)
            {
                return p.nombre;
            }    
            return string.Empty;
        }

        public static implicit operator int(Persona p) 
        {
            if (p.dni > 0) 
            {
                return p.dni;
            }
            return -1;
        }

        // CONVERSIÓN EXPLÍCITA

        public static explicit operator DateTime(Persona p) 
        {
            return p.fechaNacimiento;
        }
    }
}
