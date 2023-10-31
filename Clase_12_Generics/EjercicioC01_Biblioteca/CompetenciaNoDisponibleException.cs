using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01_Biblioteca
{
    public class CompetenciaNoDisponibleException : Exception
    {
        // Atributos 

        private string nombreClase;

        private string nombreMetodo;

        // Constructor 

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null) { }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception inner) : base(mensaje, inner)
        {
            this.nombreClase = clase;

            this.nombreMetodo = metodo;
        }

        // Propiedades 

        public string NombreClase { get; }

        public string NombreMetodo { get; }

        // Sobrescritura del método ToString()

        public override string ToString()
        {
            return $"Excepción en el método {NombreMetodo} de la clase {NombreClase}";
        }
    }
}
