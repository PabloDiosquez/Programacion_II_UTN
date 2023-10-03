using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02_Registrate
{
    public class Ingresante
    {
        // Atributos 

        private string nombre;         // Almacena el nombre del ingresante
        private string apellido;       // Almacena el apellido del ingresante
        private int edad;             // Almacena la edad del ingresante
        private string genero;         // Almacena el género del ingresante
        private string pais;           // Almacena el país de origen del ingresante
        private string direccion;      // Almacena la dirección del ingresante
        private List<string> cursos;       // Almacena los cursos en los que está inscrito el ingresante

        // Constructor

        public Ingresante(string nombre, string apellido, int edad, string genero, string pais, string direccion, List<string> cursos)
        {
            // Inicializa los atributos con los valores proporcionados al crear una instancia de la clase
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.direccion = direccion;
            this.cursos = cursos;
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();  // Crea un objeto StringBuilder para construir una cadena de texto

            sb.AppendLine("▪▪▪ Datos del ingresante ▪▪▪");   // Agrega una línea de encabezado a la cadena
            sb.AppendLine($"Nombre: {nombre}");           // Agrega el nombre del ingresante a la cadena
            sb.AppendLine($"Apellido: {apellido}");       // Agrega el apellido del ingresante a la cadena
            sb.AppendLine($"Edad: {edad}");               // Agrega la edad del ingresante a la cadena
            sb.AppendLine($"Género: {genero}");           // Agrega el género del ingresante a la cadena
            sb.AppendLine($"País: {pais}");               // Agrega el país de origen del ingresante a la cadena
            sb.AppendLine($"Dirección: {direccion}");     // Agrega la dirección del ingresante a la cadena
            sb.AppendLine("Curso/s:");
            foreach (string curso in cursos)              // Agrega los cursos del ingresante en la cadena.
            {
                sb.AppendLine($"{curso}");
            }
            return sb.ToString();  // Convierte el StringBuilder a una cadena y la devuelve
        }
    }
}
