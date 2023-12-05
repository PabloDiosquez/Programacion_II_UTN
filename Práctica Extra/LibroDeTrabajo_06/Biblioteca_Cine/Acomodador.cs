using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cine
{
    public class Acomodador : Persona
    {
        // Atributos 

        private short antiguedad;

        private Sala sala;

        // Constructores 

        public Acomodador(string nombre, string apellido)
            : base(nombre, apellido)
        {
        }

        public Acomodador(Persona persona, short antiguedad)
            : this(persona.Nombre, persona.Apellido)
        {
            this.antiguedad = antiguedad;
        }

        public Acomodador(string nombre, string apellido, string direccion, string telefono, short edad, short antiguedad) 
            : base(nombre, apellido, direccion, telefono, edad)
        {
            this.antiguedad=antiguedad;
        }

        // Propiedades 
        public Sala Sala { get => sala; set => sala = value; }
        public short Antiguedad { get => antiguedad; set => antiguedad = value; }
    }
}
