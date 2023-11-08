using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML
{
    public class Personaje
    {
        // Atributos 

        private string nombre;

        private int nivel;

        // Constructores

        public Personaje() { }

        public Personaje(string nombre, int nivel) 
        {
            this.Nombre = nombre;

            this.Nivel = nivel;
        }

        // Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        // Métodos de instancia 

        public override string ToString() 
        {
            return $"Nombre: {Nombre} -- Nivel: {Nivel}";
        }
    }
}
