using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04_Biblioteca
{
    public class Boing747 : IVolador
    {
        // Atributos 

        private int horasDeVuelo;

        // Constructor 

        public Boing747() 
        {
            this.horasDeVuelo = 0;
        }

        // Métodos de la interfaz

        public string Volador() 
        {
            this.horasDeVuelo += 13;

            return "¡Estoy volando como un avión!";
        }
    }
}
