using System;

namespace EjercicioI02_Biblioteca
{
    public abstract class Documento
    {
        // Atributos

        private int numero;

        // Constructor 

        public Documento(int numero)
        {
            this.numero = numero;
        }

        // Propiedades 

        public int Numero { get; }
    }
}
