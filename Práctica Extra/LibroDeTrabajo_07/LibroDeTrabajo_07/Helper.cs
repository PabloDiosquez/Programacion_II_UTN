using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_07
{
    public static class Helper
    {
        // Ejercicio 5.

        //Implemente una función que reciba dos parámetros: un arreglo de enteros a y un valor
        //entero v.Esta función debe devolver la posición dentro del arreglo donde se encuentra
        //el valor v. Si el valor buscado no se encuentra en el arreglo entonces debe disparar una
        //excepción definida por usted.

        public static int index(int[] numeros, int numeroBuscado)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado) return i;
            }
            throw new ValorNoEncontradoException("El elemento buscado no está en el arreglo.");
        }
    }
}
