using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_03
{
    public class Alumno
    {
        // Atributos 

        private int dni;

        private string nombreEscuela;

        // Constructores 

        public Alumno() 
        { }

        public Alumno(int dni, string nombreEscuela)
        {
            this.dni = dni;

            this.nombreEscuela = nombreEscuela;
        }

        // Propiedades 
        public int Dni { get => dni; set => dni = value; }
        public string NombreEscuela { get => nombreEscuela; set => nombreEscuela = value; }

        // Sobrecarga del método ToString()

        public override string ToString()
        {
            return $"[DNI: {this.Dni}, Escuela: {this.NombreEscuela}]";
        }
    }
}
