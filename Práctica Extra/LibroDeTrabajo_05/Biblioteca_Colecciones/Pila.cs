using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Colecciones
{
    /// <summary>
    /// Representa una pila genérica.
    /// </summary>
    /// <typeparam name="T">Tipo de elementos almacenados en la pila.</typeparam>
    public class Pila<T>
    {
        private List<T> apilados;

        /// <summary>
        /// Constructor de la clase <see cref="Pila{T}"/>.
        /// </summary>
        public Pila()
        {
            // Inicializa la lista de elementos apilados.
            this.apilados = new List<T>();
        }

        /// <summary>
        /// Apila un elemento en la pila.
        /// </summary>
        /// <param name="elemento">Elemento a apilar.</param>
        public void apilar(T elemento)
        {
            // Agrega el elemento al final de la lista.
            this.apilados.Add(elemento);
        }

        /// <summary>
        /// Desapila un elemento de la pila.
        /// </summary>
        /// <returns>Elemento desapilado.</returns>
        /// <exception cref="System.Exception">Se lanza si la pila está vacía.</exception>
        /// <remarks>Precondición: La pila no debe estar vacía.</remarks>
        public T desapilar()
        {
            // Verifica si la pila está vacía antes de desapilar.
            if (this.estaVacía()) throw new Exception("La pila no debe estar vacía.");

            // Obtiene el último elemento de la lista.
            T desapilado = this.apilados[this.apilados.Count - 1];

            // Elimina el elemento de la lista.
            this.apilados.Remove(desapilado);

            // Devuelve el elemento desapilado.
            return desapilado;
        }

        /// <summary>
        /// Verifica si la pila está vacía.
        /// </summary>
        /// <returns>True si la pila está vacía, False en caso contrario.</returns>
        public bool estaVacía()
        {
            // Comprueba si la lista de elementos apilados está vacía.
            return apilados.Count == 0;
        }

        /// <summary>
        /// Obtiene el elemento en la cima de la pila sin desapilarlo.
        /// </summary>
        /// <returns>Elemento en la cima de la pila.</returns>
        /// <exception cref="System.Exception">Se lanza si la pila está vacía.</exception>
        /// <remarks>Precondición: La pila no debe estar vacía.</remarks>
        public T verTope()
        {
            // Verifica si la pila está vacía antes de obtener el tope.
            if (this.estaVacía()) throw new Exception("La pila no debe estar vacía.");

            // Devuelve el elemento en la cima de la pila.
            return this.apilados[apilados.Count - 1];
        }
    }
}
