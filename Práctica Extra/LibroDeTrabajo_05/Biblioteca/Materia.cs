using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Materia
    {
        // Atributos 

        private string nombre;

        private string diaYHora;

        private Profesor profesor;

        private List<Alumno> alumnosInscriptos;

        // Constructor

        public Materia(string nombre, string diaYHora)
        {
            this.nombre = nombre;

            this.diaYHora = diaYHora;

            alumnosInscriptos = new List<Alumno>();
        }

        // Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public string DiaYHora { get => diaYHora; set => diaYHora = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }
        public List<Alumno> AlumnosInscriptos { get => alumnosInscriptos; set => alumnosInscriptos = value; }

        // Métodos 

        public override string ToString()
        {
            return $"[Materia: {this.Nombre}, Día y hora: {this.DiaYHora}, Profesor a cargo: {this.Profesor.Apellido}]";
        }
    }
}
