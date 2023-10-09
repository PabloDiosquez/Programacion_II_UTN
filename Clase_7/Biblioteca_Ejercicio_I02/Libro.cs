using System;
using System.Collections.Generic;

namespace Biblioteca_Ejercicio_I02
{
    public class Libro
    {
        // Atributos 

        private List<string> paginas;

        // Propiedad indexada 
        //En C#, los indexadores son miembros especiales de una clase que permiten acceder a los elementos de una instancia de la clase
        //utilizando una sintaxis similar a la de un arreglo o una colección. Los indexadores son especialmente útiles cuando deeas tratar 
        //una clase como si fuera una colección de datos, como una matriz o una lista.

        //Un indexador se define en una clase utilizando la palabra clave this, seguida de un parámetro o una lista de parámetros entre 
        //corchetes.Estos parámetros actúan como claves para acceder a los elementos de la instancia de la clase.

        /// <summary>
        /// Indexador que permite acceder y manipular el contenido de las páginas del libro
        /// mediante un número de página.
        /// </summary>
        /// <param name="numeroPagina">El número de página que se desea acceder o modificar.
        /// Precondición: Debe ser un número entero no negativo.</param>
        /// <returns>El contenido de la página especificada si existe; de lo contrario, una cadena vacía.</returns>
        /// <exception cref="IndexOutOfRangeException">Se lanza cuando el número de página está fuera del rango
        /// de páginas existentes en el libro.</exception>
        public string this[int indice]
        {
            get 
            {
                if (indice >= 0 && indice < this.paginas.Count) return this.paginas[indice];

                return string.Empty;
            }
            set 
            {
                if (indice >= 0 && indice < this.paginas.Count)
                {
                    this.paginas[indice] = value;
                }
                else if (indice == this.paginas.Count)
                {
                    paginas.Add(value);
                }
                else throw new IndexOutOfRangeException("Índice inaccesible");
            }
        }
    }
}
