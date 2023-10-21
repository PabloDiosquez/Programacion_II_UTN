using System;

namespace Biblioteca
{
    /// <summary>
    /// Clase que implementa la interfaz IMiInterfaz para saludar y proporcionar una propiedad.
    /// </summary>
    public class MiClase : IMiInterfaz
    {
        /// <summary>
        /// Propiedad de solo lectura que siempre devuelve 0.
        /// </summary>
        public int Propiedad { get { return 0; } }

        /// <summary>
        /// Método que permite a la clase saludar.
        /// </summary>
        /// <returns>Un saludo como una cadena de caracteres.</returns>
        public string Saludar()
        {
            return "Saludando...";
        }
    }
}
