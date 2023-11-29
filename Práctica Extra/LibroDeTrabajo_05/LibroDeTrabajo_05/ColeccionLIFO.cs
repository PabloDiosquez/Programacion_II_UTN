using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_05
{
    /// <summary>
    /// Representa una colección LIFO (Last In, First Out) genérica.
    /// </summary>
    /// <typeparam name="T">Tipo de elementos almacenados en la colección.</typeparam>
    public class ColeccionLIFO<T>
    {
        private List<T> elementos;

        public ColeccionLIFO()
        {
            this.elementos = new List<T>();
        }

        public void Apilar(T elemento)
        {
            if (elemento == null)
            {
                // Manejar el caso de elemento nulo según tus necesidades.
                throw new ArgumentNullException(nameof(elemento), "El elemento no puede ser nulo.");
            }
            this.elementos.Add(elemento);
        }

        public T Desapilar()
        {
            if (this.EstaVacia)
            {
                throw new InvalidOperationException("La colección no debe estar vacía para desapilar.");
            }

            T desapilado = this.elementos[this.elementos.Count - 1];
            this.elementos.Remove(desapilado);
            return desapilado;
        }
        public T VerTope()
        {
            if (this.EstaVacia)
            {
                throw new InvalidOperationException("La colección no debe estar vacía para ver el tope.");
            }

            return this.elementos[elementos.Count - 1];
        }

        public bool EstaVacia => this.elementos.Count == 0;

        public void Limpiar()
        {
            this.elementos.Clear();
        }
    }
}
