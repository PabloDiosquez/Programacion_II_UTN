using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona : IComparable
    {
        // Atributos 

        private int dni;

        private string nombre;

        private string apellido;

        // Constructor 

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public bool EsIgualA(Persona persona)
        {
            return this.dni == persona.dni;
        }

        public bool EsMayorQue(Persona persona)
        {
            return this.dni < persona.dni;
        }

        public bool EsMenorQue(Persona persona)
        {
            return this.dni > persona.dni;
        }
    }
}
