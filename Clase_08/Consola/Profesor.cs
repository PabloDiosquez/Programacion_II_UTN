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
        public Profesor(string nombre, string apellido, int dni, string catedra) : base(nombre, apellido, dni)
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
