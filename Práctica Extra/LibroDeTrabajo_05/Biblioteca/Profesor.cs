using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Profesor : Persona
    {
        // Atributos

        private int legajo;

        private List<string> materiasQueDicta;

        // Constructor 

        public Profesor(int legajo, int dni, string nombre, string apellido)
            : base(dni, nombre, apellido)
        {
            this.legajo = legajo;

            materiasQueDicta = new List<string>();
        }

        // Propiedades 
        public int Legajo { get => legajo; set => legajo = value; }
        public List<string> MateriasQueDicta { get => materiasQueDicta; set => materiasQueDicta = value; }

        // Métodos de instancia 

        public void AgregarDictadoMateria(string materia, string diaHora) 
        {
            if(string.IsNullOrEmpty(materia)) throw new ArgumentNullException(nameof(materia));

            this.materiasQueDicta.Add($"[{materia}, {diaHora}]");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del alumno: Legajo {this.Legajo}");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Materias: {this.VerMaterias()}");
            
            return sb.ToString();
        }

        private string VerMaterias() 
        {
            return string.Join(", ", materiasQueDicta);
        }
    }
}
