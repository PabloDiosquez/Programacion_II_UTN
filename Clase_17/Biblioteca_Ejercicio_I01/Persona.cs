using System;

namespace Biblioteca_Ejercicio_I01
{
    public class Persona
    {
        // Atributos 

        private int id;

        private string nombre;

        private string apellido;

        // Constructores 

        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this.id = id;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;

            this.apellido = apellido;
        }

        // Propiedades 
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

    }
}
