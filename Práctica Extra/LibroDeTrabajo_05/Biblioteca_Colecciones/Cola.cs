using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Colecciones
{
    /// <summary>
    /// Representa una cola genérica (FIFO - First In, First Out).
    /// </summary>
    /// <typeparam name="T">Tipo de elementos almacenados en la cola.</typeparam>
    public class Cola<T>
    {
        // Atributos

        /// <summary>
        /// Lista que almacena los elementos encolados.
        /// </summary>
        private List<T> encolados;

        public List<T> Encolados { get { return this.encolados; } }

        // Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Cola{T}"/>.
        /// </summary>
        public Cola()
        {
            // Inicializa la lista de elementos encolados.
            encolados = new List<T>();
        }

        // Métodos de instancia

        /// <summary>
        /// Encola un elemento al final de la cola.
        /// </summary>
        /// <param name="elemento">Elemento a encolar.</param>
        /// <exception cref="ArgumentNullException">Se lanza si el elemento es nulo.</exception>
        public void Encolar(T elemento)
        {
            // Verifica si el elemento es nulo.
            if (elemento is null) throw new ArgumentNullException(nameof(elemento), "El elemento no puede ser nulo.");

            // Agrega el elemento al final de la lista.
            this.encolados.Add(elemento);
        }

        /// <summary>
        /// Desencola y devuelve el elemento al frente de la cola.
        /// </summary>
        /// <returns>Elemento desencolado.</returns>
        /// <exception cref="InvalidOperationException">Se lanza si la cola está vacía.</exception>
        /// <remarks>Precondición: La cola no debe estar vacía.</remarks>
        public T Desencolar()
        {
            // Verifica si la cola está vacía antes de desencolar.
            if (this.EstaVacia)
            {
                throw new InvalidOperationException("La cola no debe estar vacía para desencolar.");
            }

            // Obtiene el elemento al frente de la lista.
            T desencolado = this.encolados[0];

            // Elimina el elemento de la lista.
            this.encolados.Remove(desencolado);

            // Devuelve el elemento desencolado.
            return desencolado;
        }

        /// <summary>
        /// Devuelve el elemento al frente de la cola sin desencolarlo.
        /// </summary>
        /// <returns>Elemento al frente de la cola.</returns>
        /// <exception cref="InvalidOperationException">Se lanza si la cola está vacía.</exception>
        /// <remarks>Precondición: La cola no debe estar vacía.</remarks>
        public T VerTope()
        {
            // Verifica si la cola está vacía antes de obtener el tope.
            if (this.EstaVacia)
            {
                throw new InvalidOperationException("La cola no debe estar vacía para ver el tope.");
            }

            // Devuelve el elemento al frente de la lista.
            return encolados[0];
        }

        /// <summary>
        /// Indica si la cola está vacía.
        /// </summary>
        public bool EstaVacia => this.encolados.Count == 0;

        /// <summary>
        /// Elimina todos los elementos de la cola.
        /// </summary>
        public void Limpiar()
        {
            // Limpia la lista de elementos encolados.
            this.encolados.Clear();
        }
    }
}
