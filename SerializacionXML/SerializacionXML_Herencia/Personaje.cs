using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionXML_Herencia
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
            this.nombre = nombre;

            this.nivel = nivel;
        }

        // Propiedades 

        public string Nombre { get; set; }

        public int Nivel { get; set; }

        // Métodos de instancia

        public override string ToString()
        {
            return $"Nombre: {Nombre} -- Nivel: {Nivel}";
        }
    }
}
