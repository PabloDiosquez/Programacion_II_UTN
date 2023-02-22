using System;

namespace Biblioteca
{
    public class Lista<T>
        where T : class, new()
    {
        private T[] lista;
        public void Agregar(T objeto)
        {
            // ...
        }

        public T ObtenerElemento(int indice)
        {
            return lista[indice];
        }

        public void Remover(T objeto)
        {
            // ...
        }

        // Métodos genéricos

        public void Encontrar<U>(U item)
        {
            // ...
        }
    }
}
