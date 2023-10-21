using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Esta interfaz define una serie de miembros para saludar y obtener una propiedad.
    /// </summary>
    public interface IMiInterfaz
    {
        /// <summary>
        /// Propiedad de solo lectura que proporciona un valor entero.
        /// </summary>
        int Propiedad { get; }

        /// <summary>
        /// Método que permite a las clases implementar un saludo.
        /// </summary>
        /// <returns>Un saludo como una cadena de caracteres.</returns>
        string Saludar();
    }
}
