using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_06
{
    public class Alumno : Persona
    {
        // Atributos 

        private double promedio;

        // Constructores

        public Alumno(int dni, string nombre, string apellido)
            : base(dni, nombre, apellido)
        { }

        public Alumno(int dni, string nombre, string apellido, DateTime fechaNacimiento)
            : base(dni, nombre, apellido, fechaNacimiento)
        { }

        public Alumno(int dni, string nombre, string apellido, DateTime fechaNacimiento, double promedio)
            : this(dni, nombre, apellido, fechaNacimiento)
        {
            this.promedio = (promedio >= 0) ? promedio : 0;
        }

        public Alumno(Alumno alumno) : base(alumno) 
        {
            this.promedio = alumno.promedio;
        }

        // Propiedades 

        public double Promedio {
            get { return this.promedio; }
            set { this.promedio = (value >= 0) ? value : 0; }
        }

        // Métodos 

        public override string ToString()
        {
            return $"{base.ToString()} {this.Promedio}";
        }
    }
}
