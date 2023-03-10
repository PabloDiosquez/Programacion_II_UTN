using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;

        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;

            this.Apellido = apellido;   
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return $"Nombre: {Nombre} -- Apellido: {Apellido}";
        }



    }
}
