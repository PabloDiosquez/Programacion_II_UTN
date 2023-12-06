using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public abstract class Persona
    {
        private int legajo;

        private string nombre;

        private Turno turno;

        // Constructores 

        public Persona(int legajo, string nombre)
        {
            this.legajo = legajo;

            this.nombre = nombre;
        }

        public Persona(int legajo, string nombre, Turno turno) : this(legajo, nombre)
        {
            this.turno = turno;
        }

        public Persona(Persona persona) : this(persona.legajo, persona.nombre)
        { }

        // Propiedades 

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Turno Turno { get => turno; set => turno = value; }

        // Métodos 

        public override string ToString()
        {
            return $"[Legajo: {this.Legajo}, Nombre: {this.Nombre}]";
        }
    }
}
