using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Estudiante: Persona
    {
        private int legajo;

        private List<Materia> materias;

        public Estudiante(int legajo, string nombre, string apellido, int dni)
        : this(legajo, new Persona(nombre,apellido,dni))
        {
            this.legajo = legajo;

            materias = new List<Materia>();
        }

        public Estudiante(int legajo,Persona persona) : base(persona.Nombre,persona.Apellido,persona.Dni)
        {
            this.legajo = legajo;

            materias = new List<Materia>();  
        }

        public string Estudiar()
        {
            return "Estudiando... ";
        }

        public void AgregarMateria(Materia materia)
        {
            materias.Add(materia);
        }

        public void MateriasQueCursa() 
        {
            if (materias.Count > 0)
            {
                foreach (Materia materia in materias)
                {
                    Console.WriteLine(materia.Nombre);
                }
            }
            else 
            {
                Console.WriteLine("El alumno NO cursa materias este cuatrimestre.");
            }
        }
    }
}
