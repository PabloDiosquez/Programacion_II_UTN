using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConversorBinarioRecargado.ConversorBinario;

namespace ConversorBinarioRecargado
{
    public class NumeroBinario
    {
        // Atributos 

        private string numero;

        // Constructor 

        private NumeroBinario(string numero)
        {
            // Constructor privado que toma un valor binario y lo asigna al atributo numero.
            this.numero = numero;
        }

        // Método de instancia 

        // Describe el número binario.
        public string Numero()
        {
            // Este método devuelve el valor binario almacenado en el atributo numero.
            return numero;
        }

        // Sobrecarga de operadores 

        // Convierte una cadena en un objeto NumeroBinario.
        public static explicit operator NumeroBinario(string numero)
        {
            // Este operador de conversión toma una cadena que representa un número binario
            // y crea un nuevo objeto NumeroBinario con ese valor.
            return new NumeroBinario(numero);
        }

        // Convierte un objeto NumeroDecimal en un objeto NumeroBinario.
        public static explicit operator NumeroBinario(NumeroDecimal numero)
        {
            // Este operador de conversión toma un objeto NumeroDecimal y convierte su valor
            // a binario antes de crear un nuevo objeto NumeroBinario.
            if (numero is null)
            {
                throw new Exception("Objeto nulo");
            }

            return new NumeroBinario(ConvertirDecimalABinario(numero.Numero()));
        }

        // Sobrecarga del operador de suma para sumar un NumeroDecimal a un NumeroBinario.
        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            // Este operador suma los valores convertidos de binario a decimal
            // y luego convierte el resultado de nuevo a binario antes de devolverlo.
            return ConvertirDecimalABinario(ConvertirBinarioADecimal(numeroBinario.Numero()) + numeroDecimal.Numero());
        }

        // Sobrecarga del operador de resta para restar un NumeroDecimal a un NumeroBinario.
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            // Este operador resta los valores convertidos de binario a decimal
            // y luego convierte el resultado de nuevo a binario antes de devolverlo.
            return ConvertirDecimalABinario(ConvertirBinarioADecimal(numeroBinario.Numero()) - numeroDecimal.Numero());
        }

        // Sobrecarga del operador de igualdad para comparar un NumeroBinario con un NumeroDecimal.
        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            // Este operador compara los valores convertidos de binario a decimal.
            return ConvertirBinarioADecimal(numeroBinario.Numero()) == numeroDecimal.Numero();
        }

        // Sobrecarga del operador de desigualdad para comparar un NumeroBinario con un NumeroDecimal.
        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            // Este operador invierte el resultado de la comparación de igualdad.
            return !(ConvertirBinarioADecimal(numeroBinario.Numero()) == numeroDecimal.Numero());
        }
    }
}
