using System;
using System.Text;

namespace Logica
{
    public class Usuario
    {
        private string nombre;

        private int edad;

        public Usuario(string nombre, int edad)
        {
            this.nombre = nombre;

            this.edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("### Datos del usuario ###");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Edad: {edad}");

            return sb.ToString();
        }
    }
}
