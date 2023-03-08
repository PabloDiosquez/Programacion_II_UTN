using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;

        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;

            this.apellido = apellido;   
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} -- Apellido: {apellido}";
        }



    }
}
