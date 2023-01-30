using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Empleado
    {
        // Atributos

        private string nombre;

        private string apellido;

        private DateTime fecha_ingreso;

        private bool estaActivo;

        private bool esJefe;

        private Empleado jefe;

        // Properties

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public DateTime Fecha_ingreso { get => fecha_ingreso;}
        public bool EsJefe { get => esJefe; }
        public Empleado Jefe { get => jefe; set { jefe = value; } }
        public bool EstaActivo { get => estaActivo; set => estaActivo = value; }

        // Métodos
        public Empleado(string nombre, string apellido, DateTime fecha_ingreso, bool esJefe)
        {
            this.nombre = nombre;

            this.apellido = apellido;

            this.fecha_ingreso = fecha_ingreso;

            this.jefe = jefe;   

            this.esJefe = esJefe;
        }

        public int ObtenerAntiguedad()
        {
            return (int)(DateTime.Now.Year - this.fecha_ingreso.Year);
        }

        public string NombreCompleto() 
        {
            StringBuilder sb = new StringBuilder();

            return sb.Append($"{nombre} {apellido}").ToString();
        }

    }
}
