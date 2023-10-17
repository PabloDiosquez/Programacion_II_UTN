using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    /// <summary>
    /// Clase estática que proporciona métodos para realizar cálculos.
    /// </summary>
    public static class Calculador
    {
        /// <summary>
        /// Calcula la división de dos números enteros.
        /// </summary>
        /// <param name="numero1">El dividendo (número superior de la división).</param>
        /// <param name="numero2">El divisor (número inferior de la división).</param>
        /// <returns>El resultado de la división como un número de punto flotante.</returns>
        /// <exception cref="DivideByZeroException">Se lanza si el divisor es igual a 0.</exception>
        public static float CalcularDivision(int numero1, int numero2)
        {
            if (numero2 == 0) throw new DivideByZeroException("¡No se puede dividir por 0! 🥴");

            return numero1 / numero2;
        }
    }
}
