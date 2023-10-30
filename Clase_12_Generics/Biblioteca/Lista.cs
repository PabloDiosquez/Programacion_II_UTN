using System;

namespace Biblioteca
{
    /// <summary>
    /// Clase genérica que representa una lista de elementos de tipo T.
    /// </summary>
    /// <typeparam name="T">El tipo de elementos almacenados en la lista.</typeparam>
    public class Lista<T>
        where T : class, new()
    {
        private T[] arr;

        /// <summary>
        /// Agrega un objeto de tipo T a la lista.
        /// </summary>
        /// <param name="objeto">El objeto de tipo T que se agregará a la lista.</param>
        public void Agregar(T objeto)
        {
            // Implementación del método Agregar
        }

        /// <summary>
        /// Obtiene un elemento de la lista en la posición especificada.
        /// </summary>
        /// <param name="indice">El índice del elemento que se desea obtener.</param>
        /// <returns>El elemento de tipo T en la posición indicada.</returns>
        public T ObtenerElemento(int indice)
        {
            return arr[indice];
        }

        /// <summary>
        /// Remueve un objeto de tipo T de la lista.
        /// </summary>
        /// <param name="objeto">El objeto de tipo T que se eliminará de la lista.</param>
        public void Remover(T objeto)
        {
            // Implementación del método Remover
        }

        /// <summary>
        /// Realiza una operación de búsqueda específica en la lista.
        /// </summary>
        /// <typeparam name="U">El tipo de elemento a buscar.</typeparam>
        /// <param name="item">El elemento que se desea buscar en la lista.</param>
        public void Encontrar<U>(U item)
        {
            // Implementación del método Encontrar
        }
    }
}
