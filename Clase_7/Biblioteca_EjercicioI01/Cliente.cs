using System;

namespace Biblioteca_EjercicioI01
{
    public class Cliente
    {
        // Atributos

        public string Nombre { get; set; } // Nombre del cliente
        public int Numero { get; }         // Número de identificación del cliente

        // Constructor

        /// <summary>
        /// Crea un objeto Cliente con el número de identificación especificado.
        /// </summary>
        /// <param name="numero">El número de identificación del cliente.</param>
        public Cliente(int numero)
        {
            this.Numero = numero;
        }

        /// <summary>
        /// Crea un objeto Cliente con el número de identificación y el nombre especificados.
        /// </summary>
        /// <param name="numero">El número de identificación del cliente.</param>
        /// <param name="nombre">El nombre del cliente.</param>
        public Cliente(int numero, string nombre) : this(numero)
        {
            Nombre = nombre;
        }

        // Sobrecarga de operadores 

        // Sobrecarga del operador de igualdad (==) para comparar dos objetos Cliente
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1 is not null && cliente2 is not null)
            {
                return cliente1.Numero == cliente2.Numero;
            }

            return false;
        }

        // Sobrecarga del operador de desigualdad (!=) para comparar dos objetos Cliente
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
    }
}
