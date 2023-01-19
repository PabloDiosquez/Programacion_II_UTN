using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Persona
    {
        protected string nombre;

        protected string apellido;

        protected int dni;

        protected int edad;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;

            this.apellido = apellido;

            this.dni = dni;
        }

        protected string Nombre { get => nombre; set => nombre = value; }
        protected string Apellido { get => apellido; set => apellido = value; }
        protected int Dni { get => dni; set => dni = value; }

        public string MostrarDatos(Persona persona)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Edad: {edad}");

            return sb.ToString();
        }



    }
}
