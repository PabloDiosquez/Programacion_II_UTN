using System;

namespace Biblioteca_Cartuchera
{
    public class EscrituraWrapper
    {
        private ConsoleColor color;

        private string texto;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color; 

            this.texto = texto; 
        }

        public ConsoleColor Color { get { return color; } }

        public string Texto { get { return texto; } }

    }
}
