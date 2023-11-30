using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona : IComparable
    {
        // Atributos 

        private int dni;

        private string nombre;

        private string apellido;

        // Constructor 

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        // Propiedades
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public bool EsIgualA(Persona persona)
        {
            return this.dni == persona.dni;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Nombre completo: {this.Apellido}, {this.Nombre}");

            return sb.ToString();
        }
    }
}
