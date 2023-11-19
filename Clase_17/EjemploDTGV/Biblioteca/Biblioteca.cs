using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Representa un juego en la biblioteca de un usuario.
    /// </summary>
    public class Biblioteca
    {
        // Atributos 

        /// <summary>
        /// Código único del juego en la biblioteca.
        /// </summary>
        private int codigoJuego;

        /// <summary>
        /// Género del juego en la biblioteca.
        /// </summary>
        private string genero;

        /// <summary>
        /// Nombre del juego en la biblioteca.
        /// </summary>
        private string juego;

        /// <summary>
        /// Nombre de usuario asociado a la biblioteca.
        /// </summary>
        private string usuario;

        // Constructor 

        /// <summary>
        /// Inicializa una nueva instancia de la clase Biblioteca.
        /// </summary>
        /// <param name="usuario">Nombre de usuario asociado a la biblioteca.</param>
        /// <param name="genero">Género del juego en la biblioteca.</param>
        /// <param name="juego">Nombre del juego en la biblioteca.</param>
        /// <param name="codigoJuego">Código único del juego en la biblioteca.</param>
        public Biblioteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.usuario = usuario;
            this.genero = genero;
            this.juego = juego;
            this.codigoJuego = codigoJuego;
        }

        // Propiedades 
        /// <summary>
        /// Obtiene el código único del juego en la biblioteca.
        /// </summary>
        public int CodigoJuego { get => codigoJuego; }

        /// <summary>
        /// Obtiene el género del juego en la biblioteca.
        /// </summary>
        public string Genero { get => genero; }

        /// <summary>
        /// Obtiene el nombre del juego en la biblioteca.
        /// </summary>
        public string Juego { get => juego; }

        /// <summary>
        /// Obtiene el nombre de usuario asociado a la biblioteca.
        /// </summary>
        public string Usuario { get => usuario; }
    }
}
