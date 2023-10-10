using System;

namespace Biblioteca
{
    // Declaración de un enumerado llamado "Posicion"
    public enum Posicion
    {
        Arquero,
        Defensor,
        Mediocampista,
        Delantero
    }

    /// <summary>
    /// Representa un objeto Jugador en un equipo deportivo.
    /// </summary>
    public class Jugador
    {
        /// <summary>
        /// Esta es una propiedad estática que representa el ID del jugador.
        /// </summary>
        private static int id;
        // Atributos

        private int id_jugador;
        private string apellido;
        private string nombre;
        private Posicion posicion;
        private short numeroCamiseta;
        private string equipo;

        // Constructores

        /// <summary>
        /// Este es el constructor estático de la clase Jugador.
        /// Se llama automáticamente una vez cuando se carga la clase o se crea una instancia de la clase por primera vez.
        /// Establece el valor inicial del id del jugador en 1.
        /// </summary>
        static Jugador() 
        {
            id = 1;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Jugador con un apellido y un nombre.
        /// </summary>
        /// <param name="apellido">El apellido del jugador.</param>
        /// <param name="nombre">El nombre del jugador.</param>
        public Jugador(string apellido, string nombre)
        {
            this.id_jugador = id;
            this.apellido = apellido;
            this.nombre = nombre;
            numeroCamiseta = 0;
            equipo = string.Empty;

            id++;
        }

        // Properties

        /// <summary>
        /// Obtiene o establece el apellido del jugador.
        /// </summary>
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del jugador.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece la posición del jugador en el equipo.
        /// </summary>
        public Posicion Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        /// <summary>
        /// Obtiene o establece el número de camiseta del jugador.
        /// </summary>
        public short Camiseta
        {
            get { return numeroCamiseta; }
            set { numeroCamiseta = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del equipo al que pertenece el jugador.
        /// </summary>
        public string Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }

        // Sobrecarga del método ToString()

        /// <summary>
        /// Devuelve una representación en cadena del objeto Jugador.
        /// </summary>
        /// <returns>Una cadena que contiene el apellido, el nombre, el equipo y la posición del jugador.</returns>
        public override string ToString()
        {
            return $"ID: {id_jugador} -- Nombre completo: {apellido}, {nombre} -- Equipo: {equipo} -- Posición: {posicion.ToString()}";
        }
    }
}
