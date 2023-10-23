using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_Biblioteca
{
    /// <summary>
    /// Define un conjunto de acciones (contrato) que pueden realizar objetos relacionados con la escritura.
    /// </summary>
    public interface IAcciones
    {
        // Propiedades 

        /// <summary>
        /// Obtiene o establece el color a utilizar para la escritura.
        /// </summary>
        ConsoleColor Color { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad de unidades disponibles para la escritura.
        /// </summary>
        float UnidadesDeEscritura { get; set; }

        // Métodos 

        /// <summary>
        /// Escribe un texto en la salida utilizando el color especificado.
        /// </summary>
        /// <param name="texto">El texto que se va a escribir.</param>
        /// <returns>Un objeto <see cref="EscrituraWrapper"/> que encapsula el texto y el color de escritura.</returns>
        EscrituraWrapper Escribir(string texto);

        /// <summary>
        /// Recarga las unidades de escritura con la cantidad especificada.
        /// </summary>
        /// <param name="unidades">La cantidad de unidades a recargar.</param>
        /// <returns><c>true</c> si la recarga fue exitosa, <c>false</c> si falló.</returns>
        bool Recargar(int unidades);
    }
}
