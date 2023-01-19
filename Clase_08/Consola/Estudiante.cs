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

        public Estudiante(int legajo,string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.legajo = legajo;

            materias = new List<Materia>();
        }
    }
}
