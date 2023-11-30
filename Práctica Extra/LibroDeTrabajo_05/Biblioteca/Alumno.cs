using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Alumno : Persona
    {
        // Atributos 

        private int legajo;

        private DateTime fechaNacimiento;

        private List<string> materias;

        // Constructores

        public Alumno(int legajo, int dni, string nombre, string apellido) : 
            base(dni, nombre, apellido)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }

        public Alumno(int legajo, int dni, string nombre, string apellido, DateTime fechaNacimiento)
            : this(legajo, dni, nombre, apellido)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        // Propiedades 
        public int Legajo { get => legajo; set => legajo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public List<string> Materias { get => materias; set => materias = value; }

        // Métodos de instancia 

        public void InscribirseAMateria(string materia, string diaHora)
        {
            if(string.IsNullOrEmpty(materia)) throw new ArgumentNullException(nameof(materia));

            this.materias.Add($"[{materia}, {diaHora}]");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del alumno: Legajo {this.Legajo}");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Fecha de nacimiento: {this.FechaNacimiento.ToString("dd/mm/yyyy")}");
            sb.AppendLine($"Materias: {this.VerMaterias()}");

            return sb.ToString();
        }

        private string VerMaterias()
        {
            //string materias = "[ ";

            //foreach (string materia in this.materias)
            //{
            //    materias += $"{materia} ";
            //}
            //return materias += "]";

            return string.Join(", ", this.materias);
        }
    }
}
