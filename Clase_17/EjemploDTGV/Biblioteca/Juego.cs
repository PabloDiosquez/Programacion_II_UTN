using System;

namespace Biblioteca
{
    /// <summary>
    /// Representa un juego en el sistema.
    /// </summary>
    public class Juego
    {
        /// <summary>
        /// Obtiene el código único del juego.
        /// </summary>
        public int CodigoJuego { get; }

        /// <summary>
        /// Obtiene el código único del usuario asociado al juego.
        /// </summary>
        public int CodigoUsuario { get; }

        /// <summary>
        /// Obtiene el género del juego.
        /// </summary>
        public string Genero { get; }

        /// <summary>
        /// Obtiene el nombre del juego.
        /// </summary>
        public string Nombre { get; }

        /// <summary>
        /// Obtiene el precio del juego.
        /// </summary>
        public double Precio { get; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Juego.
        /// </summary>
        /// <param name="nombre">El nombre del juego.</param>
        /// <param name="precio">El precio del juego.</param>
        /// <param name="genero">El género del juego.</param>
        /// <param name="codigoJuego">El código único del juego.</param>
        /// <param name="codigoUsuario">El código único del usuario asociado al juego.</param>
        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario)
            : this(nombre, precio, genero, codigoUsuario)
        {
            this.CodigoJuego = codigoJuego;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Juego.
        /// </summary>
        /// <param name="nombre">El nombre del juego.</param>
        /// <param name="precio">El precio del juego.</param>
        /// <param name="genero">El género del juego.</param>
        /// <param name="codigoUsuario">El código único del usuario asociado al juego.</param>
        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Genero = genero;
            this.CodigoUsuario = codigoUsuario;
        }
    }
}
