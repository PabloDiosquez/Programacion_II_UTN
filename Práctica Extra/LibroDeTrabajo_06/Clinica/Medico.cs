using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class Medico : Persona
    {
        private string especialidad;

        // Constructores 

        public Medico(int legajo, string nombre) : base(legajo, nombre)
        { }

        public Medico(int legajo, string nombre, Turno turno) : base(legajo, nombre, turno)
        { }

        public Medico(Medico medico) : this(medico.Legajo, medico.Nombre)
        { }

        public Medico(Persona persona) : base(persona)
        { }

        public Medico(int legajo, string nombre, string especialidad) : this(legajo, nombre)
        {
            this.especialidad = especialidad;
        }

        // Propiedades 

        public string Especialidad { get => especialidad; set => especialidad = value; }


        // Métodos 

        public override string ToString()
        {
            return $"{base.ToString()}\nEspecialidad: {this.Especialidad}";
        }
    }
}
