using System;

namespace Ejercicio_I03___El_ejemplo_universal
{
    public class Estudiante
    {
        private string apellido;

        private string legajo;

        private string nombre;

        private int notaPrimerParcial;

        private int notaSegundoParcial;

        private static Random random;

        static Estudiante()
        {
            random = new Random();  
        }

        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;

            this.legajo = nombre;   

            this.nombre = legajo;   
        }
    }
}
