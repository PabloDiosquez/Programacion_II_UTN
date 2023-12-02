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

        private List<Materia> materiasQueDicta;

        // Constructor 

        public Profesor(int legajo, int dni, string nombre, string apellido)
            : base(dni, nombre, apellido)
        {
            this.legajo = legajo;

            materiasQueDicta = new List<Materia>();
        }

        // Propiedades 
        public int Legajo { get => legajo; set => legajo = value; }
        public List<Materia> MateriasQueDicta { get => materiasQueDicta; set => materiasQueDicta = value; }

        // Métodos de instancia 

        public void AgregarDictadoMateria(Materia materia) 
        {
            if(materia is null) throw new ArgumentNullException(nameof(materia));

            this.materiasQueDicta.Add(materia);

            materia.Profesor = this;    
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
            List<string> materias = new List<string>();

            foreach (Materia materia in this.materiasQueDicta)
            {
                materias.Add(materia.ToString());
            }

            return string.Join(", ", this.materiasQueDicta);
        }
    }
}
