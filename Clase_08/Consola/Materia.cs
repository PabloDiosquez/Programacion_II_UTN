using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Materia
    {
        private string nombre;

        private string carrera;

        private Profesor profesorACargo;

        public Materia(string nombre, string carrera)
        {
            this.nombre = nombre;

            this.carrera = carrera;
        }

        public void ProfesorACargo(Profesor profesor) 
        {
            profesorACargo = profesor;
        }
    }
}
