using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroDeTrabajo_04
{
    /// <summary>
    /// Representa una operación matemática con dos operandos y un operador.
    /// </summary>
    public class Operacion
    {
        // Atributos o campos

        /// <summary>
        /// Primer operando de la operación.
        /// </summary>
        private int operando1;

        /// <summary>
        /// Segundo operando de la operación.
        /// </summary>
        private int operando2;

        /// <summary>
        /// Operador de la operación.
        /// </summary>
        private char operador;

        // Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase Operacion con los operandos y operador dados.
        /// </summary>
        /// <param name="operando1">Primer operando.</param>
        /// <param name="operando2">Segundo operando.</param>
        /// <param name="operador">Operador de la operación.</param>
        public Operacion(int operando1, int operando2, char operador)
        {
            this.operando1 = operando1;
            this.operando2 = operando2;
            this.operador = ValidarOperador(operador);
        }

        // Métodos de instancia 

        /// <summary>
        /// Evalúa la operación y devuelve el resultado.
        /// </summary>
        /// <returns>Resultado de la operación o un valor especial si ocurre un error.</returns>
        public int Evaluar()
        {
            switch (this.operador)
            {
                case '+':
                    return this.operando1 + this.operando2;
                case '-':
                    return this.operando2 - this.operando1;
                case '*':
                    return this.operando1 * this.operando2;
                case '/':
                    if (this.operando2 != 0) return this.operando2 / this.operando1;
                    return int.MaxValue;
                case 'p':
                    return Convert.ToInt32(Math.Pow(this.operando1, this.operando2));
                case '\0':
                    Console.WriteLine("Operador inválido.");
                    break;
            }
            return -1;
        }

        // Métodos privados

        /// <summary>
        /// Valida el operador y lo devuelve si es válido; de lo contrario, devuelve el carácter nulo '\0'.
        /// </summary>
        /// <param name="operador">Operador a validar.</param>
        /// <returns>Operador validado o carácter nulo si no es válido.</returns>
        private static char ValidarOperador(char operador)
        {
            List<char> operadoresValidos = new List<char>() { '+', '-', '*', '/', 'p' };

            if (operadoresValidos.Contains(operador)) return operador;

            return '\0';
        }
    }
}
