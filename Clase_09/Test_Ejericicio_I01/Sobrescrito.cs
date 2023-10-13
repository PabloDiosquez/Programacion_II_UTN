using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Ejericicio_I01
{
    /// <summary>
    /// Clase base abstracta que proporciona un ejemplo de sobrescritura de métodos y propiedades.
    /// </summary>
    public abstract class Sobrescrito
    {
        // Atributos

        /// <summary>
        /// Atributo protegido utilizado para almacenar un valor.
        /// </summary>
        protected string miAtributo;

        // Constructor 👷🏼‍

        /// <summary>
        /// Constructor de la clase base que inicializa el atributo miAtributo con un valor predeterminado.
        /// </summary>
        public Sobrescrito()
        {
            this.miAtributo = "Probando abstractos";
        }

        // Propiedad abstracta de sólo lectura.

        /// <summary>
        /// Propiedad abstracta de sólo lectura que debe ser implementada en clases derivadas.
        /// </summary>
        public abstract string MiPropiedad { get; }

        // Método abstracto

        /// <summary>
        /// Método abstracto que debe ser implementado en clases derivadas.
        /// </summary>
        /// <returns>Un valor de tipo string.</returns>
        public abstract string MiMetodo();

        // Método ToString() sobrescrito.

        /// <summary>
        /// Sobrescribe el método ToString para proporcionar una representación de cadena personalizada de la instancia.
        /// </summary>
        /// <returns>Una cadena que representa la instancia.</returns>
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        // Método Equals() sobrescrito.

        /// <summary>
        /// Sobrescribe el método Equals para comparar si dos objetos son del mismo tipo.
        /// </summary>
        /// <param name="objeto">El objeto que se va a comparar.</param>
        /// <returns>True si los objetos son del mismo tipo, False en caso contrario.</returns>
        public override bool Equals(object objeto)
        {
            return this.GetType() == objeto.GetType();
        }

        // Método GetHashCode() sobrescrito.

        /// <summary>
        /// Sobrescribe el método GetHashCode para proporcionar un valor hash constante.
        /// </summary>
        /// <returns>Un valor hash constante.</returns>
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
