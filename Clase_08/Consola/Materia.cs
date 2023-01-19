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
            this.Nombre = nombre;

            this.Carrera = carrera;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public void ProfesorACargo(Profesor profesor) 
        {
            profesorACargo = profesor;
        }
    }
}
