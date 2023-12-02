using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Interfaz genérica que define la capacidad de comparar objetos de un tipo específico implementando un método para verificar si es igual a otro objeto del mismo tipo.
    /// </summary>
    /// <typeparam name="T">El tipo de objeto que se va a comparar.</typeparam>
    public interface IComparable<T>
    {
        /// <summary>
        /// Compara el objeto actual con otro objeto del mismo tipo para determinar si son iguales.
        /// </summary>
        /// <param name="objetoComparable">El objeto del mismo tipo con el que se va a comparar.</param>
        /// <returns>
        /// true si el objeto actual es igual al objeto especificado; de lo contrario, false.
        /// </returns>
        bool EsIgualA(T objetoComparable);
    }
}
