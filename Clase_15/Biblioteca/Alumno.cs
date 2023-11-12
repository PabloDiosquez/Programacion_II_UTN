using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumno
    {
        private string nombreCompleto;

        private int legajo;

        private short edad;

        public Alumno() { }

        public Alumno(string nombreCompleto, int legajo, short edad)
        {
            this.NombreCompleto = nombreCompleto;

            this.Legajo = legajo;

            this.Edad = edad;
        }

        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public short Edad { get => edad; set => edad = value; }
    }
}
