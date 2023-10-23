using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01_Biblioteca
{
    public class EscrituraWrapper
    {
        // Atributos 

        private ConsoleColor color;

        private string texto;

        // Constructor
        public EscrituraWrapper(string texto, ConsoleColor color) 
        {
            this.texto = texto;

            this.color = color;
        }

        // Propiedades 

        public ConsoleColor Color { get; set; }

        public string Texto { get; set; }
    }
}
