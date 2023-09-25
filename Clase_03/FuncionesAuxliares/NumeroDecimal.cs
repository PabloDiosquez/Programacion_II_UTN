using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConversorBinarioRecargado.ConversorBinario;

namespace ConversorBinarioRecargado
{
    public class NumeroDecimal
    {
        // Atributos

        private int numero;

        // Constructor 

        private NumeroDecimal(int numero) 
        {
            this.numero = numero;
        }
        // Método de instancia

        // Describe el número decimal.
        public int Numero() 
        {
            return numero;
        }

        // Sobrecarga de operadores 

        public static explicit operator NumeroDecimal(int numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario numero)
        {
            if (numero is null) throw new Exception("Objeto nulo");

            return new NumeroDecimal(ConvertirBinarioADecimal(numero.Numero()));
        }

        public static int operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return ConvertirBinarioADecimal(numeroBinario.Numero()) + numeroDecimal.Numero();   
        }

        public static int operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return ConvertirBinarioADecimal(numeroBinario.Numero()) - numeroDecimal.Numero();
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return ConvertirBinarioADecimal(numeroBinario.Numero()) == numeroDecimal.Numero();
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return ConvertirBinarioADecimal(numeroBinario.Numero()) == numeroDecimal.Numero();
        }
    }
}
