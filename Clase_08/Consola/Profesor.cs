using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Profesor : Persona
    {
        private string catedra;

        public Profesor(string nombre, string apellido, int dni, string catedra)
        : this(new Persona(nombre,apellido,dni), catedra)
        {
            this.catedra = catedra;
        }

        public Profesor(Persona persona, string catedra):base(persona.Nombre,persona.Apellido,persona.Dni)
        {
            this.catedra = catedra;
        }

        public string Catedra { get => catedra; set => catedra = value; }

        //public string Catedra 
        //{
        //    get { return catedra; }
        //    set { catedra = value; }
        //}

        public string Corregir() 
        {
            return "Corrigiendo...";
        }

    }
}
