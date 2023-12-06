using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class Enfermero : Persona
    {
        public Enfermero(int legajo, string nombre) : base(legajo, nombre) 
        {
        }

        public Enfermero(Persona persona) : base(persona)
        { }
    }
}
