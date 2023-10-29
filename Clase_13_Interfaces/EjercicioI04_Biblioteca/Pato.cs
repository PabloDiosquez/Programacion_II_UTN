using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04_Biblioteca
{
    public class Pato : IVolador
    {
        // Atributos

        private static int energiaMaxima = 100;

        private int energia;

        // Constructor
        public Pato() 
        {
            this.energia = energiaMaxima;
        }

        // Método de interfaz 
        public string Volador()
        {
            if (this.energia == 0) return "Ya no puedo volar como pato! Cuak!";
                
            this.energia -= 5;

            return "¡Estoy volando como pato! Cuak!";
        }
    }
}
