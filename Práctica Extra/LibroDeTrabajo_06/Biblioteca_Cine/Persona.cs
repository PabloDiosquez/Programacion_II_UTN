using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cine
{
    public abstract class Persona
    {
        // Atributos 

        private string nombre;

        private string apellido;

        private string direccion;

        private string telefono;

        private short edad;

        // Constructores 

        protected Persona(string nombre, string apellido)
        {
            this.nombre = nombre;

            this.apellido = apellido;
        }

        protected Persona(string nombre, string apellido, short edad) 
            : this(nombre, apellido)
        {
            this.edad = edad;
        }

        protected Persona(Persona otraPersona)
            : this(otraPersona.nombre, otraPersona.apellido, otraPersona.edad)
        { }

        protected Persona(string nombre, string apellido, string direccion, string telefono, short edad)
            : this(nombre, apellido, edad)
        {
            this.direccion = direccion;

            this.telefono = telefono;
        }

        // Propiedades 

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public short Edad { get => edad; set => edad = value; }

        // Sobrescritura: método ToString()

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre completo: {this.Nombre}, {this.Apellido}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Teléfono: {this.Telefono}");
            sb.AppendLine($"Dirección: {this.Direccion}");

            return sb.ToString();
        }
    }
}
