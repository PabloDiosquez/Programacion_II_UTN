using System;

namespace Biblioteca_EjercicioI01
{
    public class Cliente
    {
        // Atributos

        private string nombre; // Nombre del cliente
        private int numero;    // Número de identificación del cliente

        // Constructor

        /// <summary>
        /// Crea un objeto Cliente con el número de identificación especificado.
        /// </summary>
        /// <param name="numero">El número de identificación del cliente.</param>
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Crea un objeto Cliente con el número de identificación y el nombre especificados.
        /// </summary>
        /// <param name="numero">El número de identificación del cliente.</param>
        /// <param name="nombre">El nombre del cliente.</param>
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero
        {
            get { return numero; }
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
