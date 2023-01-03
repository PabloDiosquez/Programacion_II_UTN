using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    internal class Usuario
    {
        private string nombre;

        private string apellido;

        private int dni;

        private string telefono;

        private string direccion;

        public Usuario(string nombre, string apellido, int dni)
        {
            AsignarNombreYApellido(nombre, apellido);

            this.dni = dni;
        }

        public Usuario(string nombre, string apellido, int dni, string telefono, string direccion):
            this(nombre, apellido, dni) 
        {
            this.telefono = telefono;

            this.direccion = direccion;     
        }

        public void AsignarNombreYApellido(string nombre, string apellido) 
        {
            if (nombre is not null && apellido is not null) 
            {
                this.nombre = nombre.Trim();

                this.apellido = apellido.Trim();
            }

            this.nombre = "NN";
            this.apellido = "NN";
        }
        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#### Datos del usuario ####");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Teléfono: {telefono}");
            sb.AppendLine($"Dirección: {direccion}");

            return sb.ToString();
        }
    }
}
