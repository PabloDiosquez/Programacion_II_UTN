using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04_Biblioteca
{
    public class BuzzLightyear : IVolador
    {
        // Atributos

        private int experiencia;

        // Constructor 

        public BuzzLightyear() 
        {
            this.experiencia = 0;
        }

        // Métodos de la interfaz

        public string Volador()
        {
            this.experiencia += 3;

            return "¡Al infinito y más allá!";
        }
    }
}
