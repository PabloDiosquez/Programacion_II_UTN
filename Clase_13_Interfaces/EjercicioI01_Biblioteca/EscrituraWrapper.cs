using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_Biblioteca
{
    /// <summary>
    /// Clase que envuelve un texto y su color de consola para su escritura.
    /// </summary>
    public class EscrituraWrapper
    {
        // Atributos 

        /// <summary>
        /// Obtiene o establece el color de la consola para el texto.
        /// </summary>
        private ConsoleColor color;

        /// <summary>
        /// Obtiene o establece el texto que se va a escribir en la consola.
        /// </summary>
        private string texto;

        // Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase EscrituraWrapper con el texto y el color especificados.
        /// </summary>
        /// <param name="texto">El texto que se va a escribir en la consola.</param>
        /// <param name="color">El color de la consola para el texto.</param>
        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.texto = texto;
            this.color = color;
        }

        // Propiedades 

        /// <summary>
        /// Obtiene o establece el color de la consola para el texto.
        /// </summary>
        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Obtiene o establece el texto que se va a escribir en la consola.
        /// </summary>
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
    }
}
