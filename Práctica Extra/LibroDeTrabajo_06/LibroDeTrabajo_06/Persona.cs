using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_06
{
    public abstract class Persona
    {
        // Atributos 

        private int dni;

        private string nombre;

        private string apellido;

        private DateTime fechaNacimiento;

        // Constructores 

        public Persona() { }

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;

            this.nombre = nombre;

            this.apellido = apellido;
        }

        public Persona(int dni, string nombre, string apellido, DateTime fechaNacimiento) 
            : this(dni, nombre, apellido)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public Persona(Persona persona)
        {
            if (persona is null) throw new ArgumentNullException(nameof(persona));

            this.dni = persona.dni;

            this.nombre = persona.nombre;

            this.apellido = persona.apellido;

            this.fechaNacimiento = persona.fechaNacimiento;
        }

        // Propiedades 
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => CalcularEdad(); }

        // Métodos 

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} ({this.Edad}) {this.Dni}";
        }

        private int CalcularEdad()
        {
            if (fechaNacimiento == DateTime.MinValue)
            {
                throw new Exception("Fecha de nacimiento sin actualizar.");
            }
            return DateTime.Now.Year - this.fechaNacimiento.Year;
        }
    }
}
