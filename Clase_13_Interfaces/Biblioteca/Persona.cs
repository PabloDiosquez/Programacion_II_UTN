using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string nombre;

        protected string apellido;

        protected int dni;

        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;

            this.apellido = apellido;

            this.dni = dni;
        }

        public string Caminar()
        {
            return "Estoy caminando...";
        }        
    }
}
